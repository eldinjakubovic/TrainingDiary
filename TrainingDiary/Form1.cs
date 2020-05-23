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
        private int RowIndex;

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

        public void DeleteTraining()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NE61V6A;Initial Catalog=Training;Integrated Security=True");
            var sqlQuery = "";
            {
                con.Open();
                foreach (DataGridViewRow item in this.dataGridViewTraining.SelectedRows)
                {
                    int id = Convert.ToInt32(dataGridViewTraining.SelectedRows[0].Cells[0].Value);
                    sqlQuery = "Delete from exercises where id='" + id + "'";

                    dataGridViewTraining.Rows.RemoveAt(this.dataGridViewTraining.SelectedRows[0].Index);
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteTraining();
        }
    }


}








