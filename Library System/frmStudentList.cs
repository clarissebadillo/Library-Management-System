using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_System
{
    public partial class frmStudentList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string stitle = "Library Management System";

        public frmStudentList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecords();
        }

        public void LoadRecords()
        {
            int i = 0;
            gunaDataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblStudent WHERE stNumber LIKE '" + txtSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                gunaDataGridView1.Rows.Add(i, dr["studID"].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frmStudent frm = new frmStudent(this);
            frm.Show();
        }

        private void GunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = gunaDataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmStudent frm = new frmStudent(this);
                frm.btnSave.Enabled = false;
                frm.lblID.Text = gunaDataGridView1[1, e.RowIndex].Value.ToString();
                frm.txtStudentNo.Text = gunaDataGridView1[2, e.RowIndex].Value.ToString();
                frm.txtLname.Text = gunaDataGridView1[3, e.RowIndex].Value.ToString();
                frm.txtFname.Text = gunaDataGridView1[4, e.RowIndex].Value.ToString();
                frm.txtMi.Text = gunaDataGridView1[5, e.RowIndex].Value.ToString();
                frm.cboCourse.Text = gunaDataGridView1[6, e.RowIndex].Value.ToString();
                frm.cboYear.Text = gunaDataGridView1[7, e.RowIndex].Value.ToString();
                frm.cboGender.Text = gunaDataGridView1[8, e.RowIndex].Value.ToString();
                frm.txtContact.Text = gunaDataGridView1[9, e.RowIndex].Value.ToString();
                frm.txtEmail.Text = gunaDataGridView1[10, e.RowIndex].Value.ToString();
                frm.txtAddress.Text = gunaDataGridView1[11, e.RowIndex].Value.ToString();
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblStudent WHERE stNumber like '" + gunaDataGridView1[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted!", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
