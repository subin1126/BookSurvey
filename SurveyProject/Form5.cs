using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=book_survey;Uid=root;Password="))
                {
                    string updateQuery = "UPDATE  `quantity` SET `book_1` = book_1+1, `book_2` = book_2+0,`book_4` = book_4+0,`book_5` = book_5+0,`book_0` = book_0+0";
                    try//예외 처리
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(updateQuery, connection);

                        // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                        if (command.ExecuteNonQuery() == 1)
                        {
                            Console.WriteLine("인서트 성공");
                        }
                        else
                        {
                            Console.WriteLine("인서트 실패");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("실패");
                        Console.WriteLine(ex.ToString());
                    }
                }
                this.Visible = false;             // 추가

                Form6 showForm6 = new Form6();

                showForm6.ShowDialog();
            }
            if (radioButton2.Checked == true)
            {
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=book_survey;Uid=root;Password="))
                {
                    string updateQuery = "UPDATE  `quantity` SET `book_1` = book_1+0, `book_2` = book_2+1,`book_4` = book_4+0,`book_0` = book_0+0";
                    try//예외 처리
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(updateQuery, connection);

                        // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                        if (command.ExecuteNonQuery() == 1)
                        {
                            Console.WriteLine("인서트 성공");
                        }
                        else
                        {
                            Console.WriteLine("인서트 실패");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("실패");
                        Console.WriteLine(ex.ToString());
                    }
                }
                this.Visible = false;             // 추가

                Form6 showForm6 = new Form6();

                showForm6.ShowDialog();
            }
            if (radioButton3.Checked == true)
            {
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=book_survey;Uid=root;Password="))
                {
                    string updateQuery = "UPDATE  `quantity` SET `book_1` = book_1+0, `book_2` = book_2+0,`book_4` = book_4+1,`book_0` = book_0+0";
                    try//예외 처리
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(updateQuery, connection);

                        // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                        if (command.ExecuteNonQuery() == 1)
                        {
                            Console.WriteLine("인서트 성공");
                        }
                        else
                        {
                            Console.WriteLine("인서트 실패");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("실패");
                        Console.WriteLine(ex.ToString());
                    }
                }
                this.Visible = false;             // 추가

                Form6 showForm6 = new Form6();

                showForm6.ShowDialog();
            }
            
            if (radioButton5.Checked == true)
            {
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=book_survey;Uid=root;Password="))
                {
                    string updateQuery = "UPDATE  `quantity` SET `book_1` = book_1+0, `book_2` = book_2+0,`book_4` = book_4+0,`book_0` = book_0+1";
                    try//예외 처리
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(updateQuery, connection);

                        // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                        if (command.ExecuteNonQuery() == 1)
                        {
                            Console.WriteLine("인서트 성공");
                        }
                        else
                        {
                            Console.WriteLine("인서트 실패");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("실패");
                        Console.WriteLine(ex.ToString());
                    }
                }
                this.Visible = false;             // 추가

                Form10 showForm10 = new Form10();

                showForm10.ShowDialog();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
