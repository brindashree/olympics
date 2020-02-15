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

namespace olympics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

       

       private String getUserName()
       {
            con.Open();
            String syn = "SELECT Value FROM system where Property='UserName'";
            cmd = new SqlCommand(syn, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp =  dr[0].ToString();
            con.Close();
            return temp;
       }
        private String getPassword()
        {
            con.Open();
            String syn = "SELECT Value FROM system where Property='Password'";
            cmd = new SqlCommand(syn, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String Uname = getUserName(), Upass= getPassword(), name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            
            if (name.Equals(Uname) && pass.Equals(Upass))
            {
                //login
                label3.Hide();
                
                AppBody obj = new AppBody();
                this.Hide();
                obj.Show();

            }
            else
            {
                //dont login
                label3.Show();
            }
        }
    }
}
