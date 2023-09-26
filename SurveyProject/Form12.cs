using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyProject
{
    public partial class Form12 : Form
    {
        
        public Form12()
        {
            InitializeComponent();
        }
        private void Form12_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connect = new MySqlConnection("Server=localhost;Port=3306;Database=book_survey;Uid=root;Password="))
            {


                try
                {
                    connect.Open();
                    MySqlCommand cmd = connect.CreateCommand();
                    cmd.CommandText = "SELECT * FROM age, job, gender";
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            using (MySqlConnection connect = new MySqlConnection("Server=localhost;Port=3306;Database=book_survey;Uid=root;Password="))
            {


                try
                {
                    connect.Open();
                    MySqlCommand cmd = connect.CreateCommand();
                    cmd.CommandText = "SELECT * FROM quantity, time, kind";
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView5.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            using (MySqlConnection connect = new MySqlConnection("Server=localhost;Port=3306;Database=book_survey;Uid=root;Password="))
            {


                try
                {
                    connect.Open();
                    MySqlCommand cmd = connect.CreateCommand();
                    cmd.CommandText = "SELECT * FROM never_read";
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            using (MySqlConnection connect = new MySqlConnection("Server=localhost;Port=3306;Database=book_survey;Uid=root;Password="))
            {


                try
                {
                    connect.Open();
                    MySqlCommand cmd = connect.CreateCommand();
                    cmd.CommandText = "SELECT * FROM genre";
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView3.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            using (MySqlConnection connect = new MySqlConnection("Server=localhost;Port=3306;Database=book_survey;Uid=root;Password="))
            {


                try
                {
                    connect.Open();
                    MySqlCommand cmd = connect.CreateCommand();
                    cmd.CommandText = "SELECT * FROM environ";
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView4.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    

        
        
    

