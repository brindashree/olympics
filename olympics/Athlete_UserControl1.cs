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
    public partial class Athlete_UserControl1 : UserControl
    {
        private static Athlete_UserControl1 _instance;
        public static Athlete_UserControl1 Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Athlete_UserControl1();
                }
                return _instance;
            }
        }

        public Athlete_UserControl1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");


        private void Athlete_UserControl1_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllAthletes_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
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
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;


            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AthleteAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@AthleteID", atid_textbox.Text);
            cmd.Parameters.AddWithValue("@AthleteName", athName_txtbox.Text);
            cmd.Parameters.AddWithValue("@DOB", dob_txtbox.Text);
            cmd.Parameters.AddWithValue("@Country", country_txtbox.Text);
            cmd.Parameters.AddWithValue("@Gender", gender_txtbox.Text);
            cmd.Parameters.AddWithValue("@Sport", sport_txtbox.Text);

            con.Open();
            if (!string.IsNullOrEmpty(atid_textbox.Text) && !string.IsNullOrEmpty(athName_txtbox.Text) && !string.IsNullOrEmpty(dob_txtbox.Text) && !string.IsNullOrEmpty(country_txtbox.Text) && !string.IsNullOrEmpty(gender_txtbox.Text) && !string.IsNullOrEmpty(sport_txtbox.Text))
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

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AthleteDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AthleteID", atid_textbox.Text);


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
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void search_AthId_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchAthlete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AthleteID", athid_search_textBox.Text);
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



            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            refresh_DataGridView();
            athid_search_textBox.Text = " ";
            atid_textbox.Text = " ";
            athName_txtbox.Text = " ";
            dob_txtbox.Text = " ";
            country_txtbox.Text = " ";
            gender_txtbox.Text = " ";
            sport_txtbox.Text = " ";
        }

        private void gender_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_button_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("upname_sp", con);
             cmd.CommandType = CommandType.StoredProcedure;

             cmd.Parameters.AddWithValue("@AthleteID", atid_textbox.Text);
             cmd.Parameters.AddWithValue("@AthName", athName_txtbox.Text);
            cmd.Parameters.AddWithValue("@dob", dob_txtbox.Text);
            cmd.Parameters.AddWithValue("@coun", country_txtbox.Text);
            cmd.Parameters.AddWithValue("@gen", gender_txtbox.Text);
            cmd.Parameters.AddWithValue("@sport", sport_txtbox.Text);


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
            /*if(!string.IsNullOrEmpty(atid_textbox.Text) && !string.IsNullOrEmpty(athName_txtbox.Text))
            {
                SqlCommand cmd = new SqlCommand("upname_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AthleteID", atid_textbox.Text);
                cmd.Parameters.AddWithValue("@AthName", athName_txtbox.Text);


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
            
                if (!string.IsNullOrEmpty(atid_textbox.Text) && !string.IsNullOrEmpty(dob_txtbox.Text))
                {
                    SqlCommand cmd = new SqlCommand("upDob_sp", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AthleteID", atid_textbox.Text);
                    cmd.Parameters.AddWithValue("@dob", dob_txtbox.Text);


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
                else
            {
                MessageBox.Show("Cannot be empty");
            }*/

           
            
        }

        private void atid_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ath_sel_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM athlete WHERE AthleteID = " + int.Parse(atid_textbox.Text);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                athName_txtbox.Text = (dr["AthleteName"].ToString());
                dob_txtbox.Text = (dr["DOB"].ToString());
                country_txtbox.Text = (dr["Country"].ToString());
                gender_txtbox.Text = (dr["Gender"].ToString());
                sport_txtbox.Text = (dr["Sport"].ToString());

            }
            con.Close();
        }
    }
}
