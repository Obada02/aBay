﻿using aBay.screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SQLite;

namespace aBay
{
    public partial class login : Form
    {
        SqlConnection conn;
        public login()
        {
            InitializeComponent();

        }



        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            int enteredUserID = Int32.Parse(userID.Text);
            string sql = "select * from [user] where userID = " + userID.Text ;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();


            //while (sqlDataReader.Read())
            //    MessageBox.Show(sqlDataReader.ToString());
            sqlDataReader.Read();

            string enteredPassword = password.Text;
            string userPassword = sqlDataReader["password"].ToString();
            bool seller =  (sqlDataReader["seller"].ToString() == "1"),
                buyer = (sqlDataReader["buyer"].ToString() == "1"),
                delivery = (sqlDataReader["delivery"].ToString() == "1");
            conn.Close();

            if (enteredPassword == userPassword){
                if (seller)
                {
                    seller seller1 = new seller(enteredUserID);
                    this.Hide();
                    seller1.Show();
                }else if (buyer)
                {
                    all_Items all_Items1 = new all_Items();
                    this.Hide();
                    all_Items1.Show();
                }else
                {

                }
            }else
            {
                MessageBox.Show("Wrong ID or Password!");
            }
            //SQLiteCommand command = new SQLiteCommand(sql, conn);
            //SQLiteDataReader reader = command.ExecuteReader();
        }

        private void login_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbProject.mdf;Integrated Security=True;Connect Timeout=30");

        }
    }
}
