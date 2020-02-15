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
    public partial class Site_UserControl1 : UserControl
    {
        private static Site_UserControl1 _instance;
        public static Site_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Site_UserControl1();
                }
                return _instance;
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        public Site_UserControl1()
        {
            InitializeComponent();
        }

        private void Yearsearch_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Site_UserControl1_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllSite_SP", con);
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
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Site_Button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SiteAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Year", year_txtbox.Text);
            cmd.Parameters.AddWithValue("@Country", Cntry_txtbox.Text);
            cmd.Parameters.AddWithValue("@City", city_txtbox.Text);
            cmd.Parameters.AddWithValue("@Event_ID", EventID_txtbox.Text);


            con.Open();
            if (!string.IsNullOrEmpty(year_txtbox.Text) && !string.IsNullOrEmpty(Cntry_txtbox.Text) && !string.IsNullOrEmpty(city_txtbox.Text) && !string.IsNullOrEmpty(EventID_txtbox.Text))
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

        private void Update_Site_Button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("upSite_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Year", year_txtbox.Text);
            cmd.Parameters.AddWithValue("@Cntry", Cntry_txtbox.Text);
            cmd.Parameters.AddWithValue("@City", city_txtbox.Text);
            cmd.Parameters.AddWithValue("@EID", EventID_txtbox.Text);


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

        private void Delete_Site_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SiteDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Year", year_txtbox.Text);


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

        private void Clear_Site_Button_Click(object sender, EventArgs e)
        {
            refresh_DataGridView();
            Yearsearch_textbox.Text = " ";
            year_txtbox.Text = " ";
            Cntry_txtbox.Text = " ";
            city_txtbox.Text = " ";
            EventID_txtbox.Text = " ";
        }

        private void Search_Site_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchSite_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Year", Yearsearch_textbox.Text);
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



            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void site_sel_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM site WHERE Year = " + int.Parse(year_txtbox.Text);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Cntry_txtbox.Text = (dr["Country"].ToString());
                city_txtbox.Text = (dr["City"].ToString());
                EventID_txtbox.Text = (dr["Event_ID"].ToString());
               

            }
            con.Close();
        }
    }
}
