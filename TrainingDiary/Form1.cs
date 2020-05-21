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

namespace TrainingDiary
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NE61V6A;Initial Catalog=Training;Integrated Security=True");
        SqlCommand comm;
        SqlDataAdapter sda;
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form2 = new InsertWorkout();
            form2.Show();
        }

        public void searchData()//string valueToSearch
        {
            string query = @"SELECT * FROM Exercises where [Date] = '" + dateTimePickerSearch.Value.Date + "'";
            //"  [Product] = '" + tbStckProduct.Text + "'";
            comm = new SqlCommand(query, conn);
            sda = new SqlDataAdapter(comm);
            table = new DataTable();
            //Punjenje tabele
            sda.Fill(table);
            //koristenje datasourcea 
            dataGridViewTraining.DataSource = table;

        }

        private void btnTrainingSearch_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-NE61V6A;Initial Catalog=stock;Integrated Security=True");
            //var sqlQuery = "";
            //{
            //    con.Open();
            //    //   sqlQuery2 = @"INSERT INTO[dbo].[Deleted_items] ([Code],[Product])
            //    //VALUES ('" + tbCode.Text + "','" + tbProduct.Text + "')";
            //    sqlQuery = @"DELETE FROM [Products] WHERE [Code] = '" + tbCode.Text + "'";
            //    //Brisanje iz tabele Products
            //    SqlCommand cmd = new SqlCommand(sqlQuery, con);
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            foreach (DataGridViewRow item in this.dataGridViewTraining.SelectedRows)
            {
                dataGridViewTraining.Rows.RemoveAt(item.Index);

            }
        }
    }
}
            

            
    

