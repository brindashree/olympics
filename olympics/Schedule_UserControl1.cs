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
    public partial class Schedule_UserControl1 : UserControl
    {

        private static Schedule_UserControl1 _instance;
        public static Schedule_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Schedule_UserControl1();
                }
                return _instance;
            }
        }
        public Schedule_UserControl1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Schedule_UserControl1_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllSchedules_SP", con);
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
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("ScheduleAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Date", Date_schd_txtbox.Text);
            cmd.Parameters.AddWithValue("@Venue", Venue_schd_txtbox.Text);
            cmd.Parameters.AddWithValue("@Sport", spor_schd_txtbox.Text);
            cmd.Parameters.AddWithValue("@Eventid", evntid_schd_txtbox.Text);
            cmd.Parameters.AddWithValue("@Year", year_schd_txtbox.Text);
            cmd.Parameters.AddWithValue("@Season", seas_schd_txtbox.Text);

            con.Open();
            if (!string.IsNullOrEmpty(Date_schd_txtbox.Text) && !string.IsNullOrEmpty(Venue_schd_txtbox.Text) && !string.IsNullOrEmpty(spor_schd_txtbox.Text) && !string.IsNullOrEmpty(evntid_schd_txtbox.Text) && !string.IsNullOrEmpty(year_schd_txtbox.Text) && !string.IsNullOrEmpty(seas_schd_txtbox.Text))
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

        private void Delete_schd_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("scheduleDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Sport", spor_search_schd_txtbox.Text);
                cmd.Parameters.AddWithValue("@Year", year_search_schd_txtbox.Text);


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

        private void clear_schd_button_Click(object sender, EventArgs e)
        {
            refresh_DataGridView();
            year_schd_txtbox.Text = " ";
            year_search_schd_txtbox.Text = " ";
           Date_schd_txtbox.Text = " ";
            Venue_schd_txtbox.Text = " ";
            spor_schd_txtbox.Text = " ";
            spor_search_schd_txtbox.Text = " ";
            evntid_schd_txtbox.Text = " ";
            seas_schd_txtbox.Text = " ";
        }

        private void Search_schd_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Search_Schedule_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Year", year_schd_txtbox.Text);
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
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;



            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void sch_sel_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sel_schd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Sport", spor_search_schd_txtbox.Text);
            cmd.Parameters.AddWithValue("@Year", year_search_schd_txtbox.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                year_schd_txtbox.Text = (dr["Year"].ToString());
                Venue_schd_txtbox.Text = (dr["Venue"].ToString());
                spor_schd_txtbox.Text = (dr["Sport"].ToString());
                evntid_schd_txtbox.Text = (dr["Eventid"].ToString());
                Date_schd_txtbox.Text = (dr["Date"].ToString());
                seas_schd_txtbox.Text = (dr["Season"].ToString());


            }
            con.Close();
        }

        private void Update_schd_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("upSchd_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Year", year_schd_txtbox.Text);
            cmd.Parameters.AddWithValue("@Sport", spor_schd_txtbox.Text);
            cmd.Parameters.AddWithValue("@Date", Date_schd_txtbox.Text);
            cmd.Parameters.AddWithValue("@Venue", Venue_schd_txtbox.Text);
            cmd.Parameters.AddWithValue("@Eventid", evntid_schd_txtbox.Text);
            cmd.Parameters.AddWithValue("@Season", seas_schd_txtbox.Text);


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
