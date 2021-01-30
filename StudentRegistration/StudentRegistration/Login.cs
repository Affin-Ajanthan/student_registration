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
using WindowsFormsApplication;

namespace StudentRegistrstion
{
    
    public partial class Login : Form
    {

        SqlConnection con = new SqlConnection("Data Source=AFFIN\\MSSQLSERVER01;Initial Catalog=Library;Integrated Security=True;Pooling=False");


        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.textBox1.Text == "")
            //{
            //    MessageBox.Show("Please Enter The User Name");
            //}
            if (this.textBox2.Text.Length==0)
            {
                MessageBox.Show("Please Enter Password");
            }
            if (this.textBox1.Text.Length == 0 || this.textBox2.Text.Length == 0)
            {
                MessageBox.Show("All fields are comulsory");
            }

            String uname = textBox1.Text.ToString();
            String pass = textBox2.Text.ToString();
            con.Open();
            String qry = "select username, password from reguser where username = '" +uname+ "' and password = '"+pass+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(qry,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                MessageBox.Show("Valid user : " +uname);
                this.Hide();
                Form1 obj = new Form1();
                obj.Show();
            }
            else
            {
                MessageBox.Show("In Valid user");
                con.Close();
                button2_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Clear() ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.Show();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
