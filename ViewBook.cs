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
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        //Database fetch on start
        private void ViewBook_Load(object sender, EventArgs e)
        {
            updatePanel.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI-ISAAC; database = Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from newBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            viewBookGrid.DataSource = ds.Tables[0];
        }

        //Updater table
        int bid;
        Int64 rowid;
        private void viewBookGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(viewBookGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                bid = int.Parse(viewBookGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(viewBookGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            updatePanel.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI-ISAAC; database = Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from newBook where bid= "+bid+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtBNameUP.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthorUP.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPublicationUP.Text = ds.Tables[0].Rows[0][3].ToString();
            txtPDateUP.Text = ds.Tables[0].Rows[0][4].ToString();
            txtPriceUP.Text = ds.Tables[0].Rows[0][5].ToString();
            txtQuantityUP.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        //Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            updatePanel.Visible = false;
        }

        //Name search box
        private void txtBNameSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtBNameSearch.Text !="")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MSI-ISAAC; database = Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from newBook where bName LIKE '"+txtBNameSearch.Text+ "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                viewBookGrid.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MSI-ISAAC; database = Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from newBook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                viewBookGrid.DataSource = ds.Tables[0];
            }
        }
        //Refresh button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBNameSearch.Clear();
            ViewBook_Load(this, null);
        }


        //Update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated", "Succes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string bname = txtBNameUP.Text;
                string bauthor = txtAuthorUP.Text;
                string bpublication = txtPublicationUP.Text;
                string pdate = txtPDateUP.Text;
                Int64 price = Int64.Parse(txtPriceUP.Text);
                Int64 quantity = Int64.Parse(txtQuantityUP.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MSI-ISAAC; database = Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update newBook set bName = '" + bname + "',bAuthor = '" + bauthor + "',bPublication = '" + bpublication + "',bPDate = '" + pdate + "',bPrice = '" + price + "',bQuantity ='" + quantity + "' where bid=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ViewBook_Load(this, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted", "Succes", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MSI-ISAAC; database = Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from newBook where bid="+rowid+"";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ViewBook_Load(this, null);
            }
        }
    }
}
