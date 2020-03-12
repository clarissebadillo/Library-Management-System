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
    public partial class frmStudent : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmStudentList frmlist;

        public frmStudent(frmStudentList flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlist = flist;
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void Clear()
        {
            txtStudentNo.Text = "";
            txtLname.Text = "";
            txtFname.Text = "";
            txtMi.Text = "";
            cboCourse.Items.Clear();
            cboYear.Items.Clear();
            cboGender.Items.Clear();
            txtContact.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtStudentNo.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this record?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //open connection to the database
                    cn.Open();
                    //command to be executed on the database
                    cm = new SqlCommand("INSERT INTO tblStudent VALUES (@stNumber, @stLname, @stFname, @stInitial, @stCourse, @stYear, @stGender, @stContact, @stEmail, @stAddress)", cn);
                    //set parameters value
                    cm.Parameters.AddWithValue("@stNumber", txtStudentNo.Text);
                    cm.Parameters.AddWithValue("@stLname", txtLname.Text);
                    cm.Parameters.AddWithValue("@stFname", txtFname.Text);
                    cm.Parameters.AddWithValue("@stInitial", txtMi.Text);
                    cm.Parameters.AddWithValue("@stCourse", cboCourse.Text);
                    cm.Parameters.AddWithValue("@stYear", cboYear.Text);
                    cm.Parameters.AddWithValue("@stGender", cboGender.Text);
                    cm.Parameters.AddWithValue("@stContact", txtContact.Text);
                    cm.Parameters.AddWithValue("@stEmail", txtEmail.Text);
                    cm.Parameters.AddWithValue("@stAddress", txtAddress.Text);
                    //ask db to execute query
                    cm.ExecuteNonQuery();
                    //close connection
                    cn.Close();
                    MessageBox.Show("Record has been sucessfully saved!");
                    Clear();
                    frmlist.LoadRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
