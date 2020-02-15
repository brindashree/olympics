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
    public partial class Add_Res_UserControl1 : UserControl
    {
        private static Add_Res_UserControl1 _instance;
        public static Add_Res_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Add_Res_UserControl1();
                }
                return _instance;
            }
        }
        public Add_Res_UserControl1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");

        private void Add_Res_UserControl1_Load(object sender, EventArgs e)
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
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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

        private void res_del_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ResultDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AthleteID", atid_del_txtbox.Text);
                cmd.Parameters.AddWithValue("@Year", year_del_txtbox.Text);


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

        private void Add_res_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("ResultAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@AthleteID", athid_add_txtbox.Text);
            cmd.Parameters.AddWithValue("@Year", year_add_res_txtbox.Text);
            cmd.Parameters.AddWithValue("@Medal", med_res_add_txtbox.Text);
            cmd.Parameters.AddWithValue("@Record", rec_res_add_txtbox.Text);
            cmd.Parameters.AddWithValue("@AthName", atn_add_txtbx.Text);
            cmd.Parameters.AddWithValue("@Cntry", cntry_add_txtbx.Text);
            cmd.Parameters.AddWithValue("@spor", spor_add_txtbx.Text);


            con.Open();
            if (!string.IsNullOrEmpty(athid_add_txtbox.Text) && !string.IsNullOrEmpty(year_add_res_txtbox.Text) && !string.IsNullOrEmpty(med_res_add_txtbox.Text))
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

        private void res_clear_btn_Click(object sender, EventArgs e)
        {
            refresh_DataGridView();

            athid_add_txtbox.Text = " ";
            year_add_res_txtbox.Text = " ";
            med_res_add_txtbox.Text = " ";
            rec_res_add_txtbox.Text = " ";
            atid_del_txtbox.Text = " ";
            year_del_txtbox.Text = " ";
            atn_add_txtbx.Text = " ";
            cntry_add_txtbx.Text = " ";
            spor_add_txtbx.Text = " ";
        }

        private void sel_add_res_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM athlete WHERE AthleteID = " + int.Parse(athid_add_txtbox.Text);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                atn_add_txtbx.Text = (dr["AthleteName"].ToString());
                cntry_add_txtbx.Text = (dr["Country"].ToString());
                
                spor_add_txtbx.Text = (dr["Sport"].ToString());

            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
