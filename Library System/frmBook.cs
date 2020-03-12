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
    public partial class frmBook : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmBookList frmlist;

        public frmBook(frmBookList flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlist = flist;
        }

        private void FrmBook_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void Clear()
        {
            txtBookTitle.Text = "";
            txtAuthor.Text = "";
            txtEdition.Text = "";
            txtGenre.Text = "";
            txtISBN.Text = "";
            txtPublisher.Text = "";
            txtYear.Text = "";
            txtCopies.Text = "";
            txtBookTitle.Focus();
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
                    cm = new SqlCommand("INSERT INTO tblBook VALUES (@bktitle, @bkedition, @bkgenre, @bkauthor, @bkpublisher, @bkyear, @bkISBN, @bkcopies)", cn);
                    //set parameters value
                    cm.Parameters.AddWithValue("@bktitle", txtBookTitle.Text);
                    cm.Parameters.AddWithValue("@bkedition", txtEdition.Text);
                    cm.Parameters.AddWithValue("@bkgenre", txtGenre.Text);
                    cm.Parameters.AddWithValue("@bkauthor", txtAuthor.Text);
                    cm.Parameters.AddWithValue("@bkpublisher", txtPublisher.Text);
                    cm.Parameters.AddWithValue("@bkyear", int.Parse(txtYear.Text));
                    cm.Parameters.AddWithValue("@bkisbn", txtISBN.Text);
                    cm.Parameters.AddWithValue("@bkcopies", txtCopies.Text);
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblBook SET bkTitle = @booktitle, bkEdition = @edition, bkGenre = @genre, bkAuthor = @author, bkPublisher = @publisher, bkYear = @year, bkISBN = @ISBN, bkCopies = @copies WHERE bookID LIKE '" + lblID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@booktitle", txtBookTitle.Text);
                    cm.Parameters.AddWithValue("@edition", txtEdition.Text);
                    cm.Parameters.AddWithValue("@genre", txtGenre.Text);
                    cm.Parameters.AddWithValue("@author", txtAuthor.Text);
                    cm.Parameters.AddWithValue("@publisher", txtPublisher.Text);
                    cm.Parameters.AddWithValue("@year", txtYear.Text);
                    cm.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    cm.Parameters.AddWithValue("@copies", txtCopies.Text);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Record has been successfully updated!");
                    Clear();
                    frmlist.LoadRecords();
                    this.Close();
                }
            }
            catch (Exception)
            {
            }
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
