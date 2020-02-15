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
    public partial class Res_update_UserControl1 : UserControl
    {

        private static Res_update_UserControl1 _instance;
        public static Res_update_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Res_update_UserControl1();
                }
                return _instance;
            }
        }
        public Res_update_UserControl1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");

        private void Res_update_UserControl1_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllResult_SP", con);
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
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        

        private void res_search_id_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Result_search_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AthleteID",res_athid_txtbox.Text);
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
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                



            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void res_clear_btn_Click(object sender, EventArgs e)
        {
            refresh_DataGridView();
            res_athid_txtbox.Text = " ";
           res_year_txtbox.Text = " ";
            res_medal_txtbox.Text = " ";
            res_rec_txtbox.Text = " ";
            athid_sel_res_txtbox.Text = " ";
            year_sel_res_txtbox.Text = " ";


        }

        private void sel_res_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("res_sel_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@AthID", athid_sel_res_txtbox.Text);
            cmd.Parameters.AddWithValue("@Year", year_sel_res_txtbox.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                res_athid_txtbox.Text = (dr["Athleteid"].ToString());
                res_year_txtbox.Text = (dr["Year"].ToString());
                res_medal_txtbox.Text = (dr["Medal"].ToString());
                res_rec_txtbox.Text = (dr["Record"].ToString());
                


            }
            con.Close();
        }

        private void res_update_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("up_first_res_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Athid", res_athid_txtbox.Text);
            cmd.Parameters.AddWithValue("@Year", res_year_txtbox.Text);
            cmd.Parameters.AddWithValue("@Medal", res_medal_txtbox.Text);
            cmd.Parameters.AddWithValue("@Record", res_rec_txtbox.Text);



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
