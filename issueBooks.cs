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
    public partial class issueBooks : Form
    {
        public issueBooks()
        {
            InitializeComponent();
        }

        private void issueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI-ISAAC; database = Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select bName from newBook", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while(Sdr.Read())
            {
                for(int i=0;i<Sdr.FieldCount;i++)
                {
                    comboBoxBooks.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();
        }

        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtEnrollment.Text !="")
            {
                String eid = txtEnrollment.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MSI-ISAAC; database = Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from newStudent where enroll= '" + eid + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //Counter of issued books to a student
                cmd.CommandText = "select coun(stdEnroll) from irBook where stdEnroll= '" + eid + "' and bookReturnDate is null";
                SqlDataAdapter DA2 = new SqlDataAdapter(cmd);
                DataSet DS2 = new DataSet();
                DA.Fill(DS2);

                count = int.Parse(DS2.Tables[0].Rows[0][0].ToString());


                if (DS.Tables[0].Rows.Count !=0)
                {
                    txtName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtDepartment.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtSemester.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtName.Clear();
                    txtDepartment.Clear();
                    txtSemester.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Invalid enrollment NO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if(txtName.Text !="")
            {
                if(comboBoxBooks.SelectedIndex!= -1 && count<=2)
                {
                    String enroll = txtEnrollment.Text;
                    String sname = txtName.Text;
                    String sdep = txtDepartment.Text;
                    String sem = txtSemester.Text;
                    Int64 contact = Int64.Parse(txtSemester.Text);
                    string email = txtEmail.Text;
                    String bookname = comboBoxBooks.Text;
                    String bookIssueDate = dateTimePicker.Text;

                    String eid = txtEnrollment.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = MSI-ISAAC; database = Library;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandText = cmd.CommandText = "insert into irBook (stdEnroll,stdName,stdDep,stdSem,stdContact,stdEmail,bookName,bookIssueDate) values ('"+enroll+ "','"+sname+ "','"+sem+ "','"+contact+ "','"+email+ "','"+bookname+ "','"+bookIssueDate+"')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book issued", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select book. Or maximum number of books has ben issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter valid enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnrollment_TextChanged(object sender, EventArgs e)
        {
            if(txtEnrollment.Text == "")
            {
                txtName.Clear();
                txtDepartment.Clear();
                txtSemester.Clear();
                txtContact.Clear();
                txtEmail.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollment.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
