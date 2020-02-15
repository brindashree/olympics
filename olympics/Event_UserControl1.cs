using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace olympics
{
    public partial class Event_UserControl1 : UserControl
    {

        private static Event_UserControl1 _instance;
        public static Event_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Event_UserControl1();
                }
                return _instance;
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        public Event_UserControl1()
        {
            InitializeComponent();
        }

        private void Event_UserControl1_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllEvent_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("      <<INVALID SQL OPERATION>> \n" + ex);
                }
                con.Close();
                dataGridView1.DataSource = ds.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Add_Event_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("EventAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EventID", EtID_txtbox.Text);
            cmd.Parameters.AddWithValue("@EventName", EtName_txtbox.Text);
            

            con.Open();
            if (!string.IsNullOrEmpty(EtID_txtbox.Text) && !string.IsNullOrEmpty(EtName_txtbox.Text))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("            <<INVALID SQL OPERATION>> \n" + ex);
                }
            }
            else
            {
                MessageBox.Show("Textbox contains null values");
            }
            con.Close();
            refresh_DataGridView();
        }

        private void Delete_Event_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("EventDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EventID", EtID_txtbox.Text);


                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("            <<INVALID SQL OPERATION>> \n" + ex);
                }
                con.Close();
                refresh_DataGridView();


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Clear_Event_Click(object sender, EventArgs e)
        {
            refresh_DataGridView();
            EtIDsearch_txtbox.Text = " ";
            EtID_txtbox.Text = " ";
            EtName_txtbox.Text = " ";
        }

        private void Search_Event_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchEvent_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EventID", EtIDsearch_txtbox.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("      <<INVALID SQL OPERATION>> \n" + ex);
                }
                con.Close();
                dataGridView1.DataSource = ds.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Update_Event_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("up_event_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EID",EtID_txtbox.Text);
            cmd.Parameters.AddWithValue("@etname", EtName_txtbox.Text);
            


            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("            <<INVALID SQL OPERATION>> \n" + ex);
            }
            con.Close();
            refresh_DataGridView();
        }
    }
}
