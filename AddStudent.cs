using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibarySystem
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)== DialogResult.OK)
            { 
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEnrollment.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEnrollment.Text != "" && txtDepartment.Text != "" && txtSemester.Text != "" && txtContact.Text != "" && txtEmail.Text != "")
            {
                string name = txtName.Text;
                string enroll = txtEnrollment.Text;
                string dep = txtDepartment.Text;
                string sem = txtSemester.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                string email = txtEmail.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MSI-ISAAC; database = Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into newStudent (sName,enroll,dep,sem,contact,email) values('" + name + "','" + enroll + "','" + dep + "','" + sem + "','" + mobile + "','" + email + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data saved!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill empty fields", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
