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

namespace StudentRegistrstion
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=AFFIN\\MSSQLSERVER01;Initial Catalog=Library;Integrated Security=True;Pooling=False");

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.id.Text = "";
            this.fname.Clear();
            this.mobileno.Text = "";
            this.emailid.Clear();
            this.user.Text = "";
            this.passwor.Clear();
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void reg_Click(object sender, EventArgs e)
        {
            try
            {
                String regno = id.Text;
                String name = fname.Text;
                long mobile = Int64.Parse(mobileno.Text);

                String email = emailid.Text;
                String username = user.Text;
                String password = passwor.Text;

                con.Open();
                String qry = "insert into reguser(regno,name,mobile,email,username,password) values ('"+ regno + "','" + name + "','" + mobile + "','" + email + "','" + username + "','" + password + "')";
                SqlCommand cmd = new SqlCommand(qry,con);
                int i = cmd.ExecuteNonQuery();
                if(i>= 1)
                    MessageBox.Show(i+ " Number of user registered with user name"+username);
                else
                    MessageBox.Show(" User registration failed with username: " + username);

                con.Close();
                clear_Click(sender, e);

            }
            catch(System.Exception exp)
            {
                MessageBox.Show("Some error occured at user registration : " + exp.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
