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
            addIntArrayCmb2(10, this.cmb2);
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
            private void addIntArrayCmb2(int max2, ComboBox c)
            {
                for (int i = 1; i <= max2; i++)
                {
                    c.Items.Add(i);
                }
            }


        private void button1_Click(object sender, EventArgs e)
        {
            //connection string, otvaranje konekcije, sql query i izvrsavanje querya
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NE61V6A;Initial Catalog=Training;Integrated Security=True");
            con.Open();

            //insert into table exercises
            var sqlQuery = "";
            sqlQuery = @"INSERT INTO[dbo].[Exercises] ([Date],[ExerciseType],[Series],[Repetitions],[Duration],[Distance])
             VALUES ('" + dateTimePicker1.Value.Date + "','" + cmb1.SelectedItem + "','" + cmb2.SelectedItem + "','" + cmb3.SelectedItem + "', '" + tbLenght.Text + "','" + tbDistance.Text + "')";

            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();


            //Nakon update-a ocisti textboxe
            Clear();
            InsertWorkout.ActiveForm.Close();
        }
        //Clear fields
        private void Clear()
        {
            //dateTimePicker1.Clear();
            cmb1.SelectedValue = -1;
            cmb2.SelectedIndex = -1;
            cmb3.SelectedIndex = -1;
            tbLenght.Clear();
            tbDistance.Clear();

        }
        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If selected item is Running there is no need for series and repetition 
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
            //If selected value is different than running then disable lenght and distance.
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

        
    }
}

