using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingDiary
{
    public partial class InsertWorkout : Form
    {
        public InsertWorkout()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDistance_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection string, otvaranje konekcije, sql query i izvrsavanje querya
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NE61V6A;Initial Catalog=stock;Integrated Security=True");
            con.Open();
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Convert.ToString(cmb1.SelectedItem) == "Running") 
            if (cmb1.SelectedItem.ToString() == "Running")
            {
                cmb2.Enabled = false;
                cmb3.Enabled = false;
            }
            else
            {
                cmb2.Enabled = true;
                cmb3.Enabled = true;
            }
        }
    }
}

