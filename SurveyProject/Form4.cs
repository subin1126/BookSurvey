﻿using MySql.Data.MySqlClient;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=book_survey;Uid=root;Password="))
                {
                    string updateQuery = "UPDATE  `gender` SET `female` = female+1, `male` = male+0";
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
            }
            if (radioButton2.Checked == true)
            {
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=book_survey;Uid=root;Password="))
                {
                    string updateQuery = "UPDATE  `gender` SET `female` = female+0, `male` = male+1";
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
            }
            this.Visible = false;             // 추가

            Form5 showForm5 = new Form5();

            showForm5.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
