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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            tbPassword.Text = "";
            // The password character 
            tbPassword.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            tbPassword.MaxLength = 14;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {

            //Provjera kroz bazu da li je korisnik validan
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NE61V6A;Initial Catalog=Training;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from Users where Username = '" + tbUserName.Text + "' and Password = '" + tbPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Form1 main = new Form1();
                main.Show();
            }
            //Ispisivanje errora u koliko se user ne nalazi u bazi
            else
            {
                MessageBox.Show("Invalid user! Please enter valid user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLoginReset_Click(sender, e);
            }

        }

        private void btnLoginReset_Click(object sender, EventArgs e)
        {
            //Kada kliknemo dugme reset textboxevi se isprazne
            tbUserName.Clear();
            tbPassword.Clear();
            tbUserName.Focus();
        }
    }
}
