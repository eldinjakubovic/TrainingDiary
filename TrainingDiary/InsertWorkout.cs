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
            //Add Array range to 140
            addIntArrayCmb2(10, this.cmb3);
            addIntArrayCmb3(140, this.cmb3);
        }
        //addIntArray call and filling 
        private void addIntArrayCmb3(int max, ComboBox c)
        {
            for (int i = 1; i <= max; i++)
            {
                c.Items.Add(i);
            }
        }
            private void addIntArrayCmb2(int max, ComboBox c)
            {
                for (int i = 1; i <= max; i++)
                {
                    c.Items.Add(i);
                }
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
            if (cmb1.SelectedItem.ToString() != "Running")
            {
                tbLenght.Enabled = false;
                tbDistance.Enabled = false;
            }
            else
            {
                tbLenght.Enabled = true;
                tbDistance.Enabled = true;
            }
        }

        private void cmb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cmb3.Items.AddRange(Enumerable.Range(1, 100).Select(i => (object)i).ToArray());
            this.cmb3.Items.Add(Enumerable.Range(1, 100).Select(i => (object)i).ToArray());
        }
    }
}

