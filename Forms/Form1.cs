/* Copyright (c) 2020 All Rights Reserved
 *  Author: Abhee Hudani
 *  Title: Coffee Shop Management
 */

using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);

        double count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox_login_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = button_login;
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }  //Check if CAPS is ON or OFF
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label_username_Click(object sender, EventArgs e)
        {
          
        }

        private void label_password_Click(object sender, EventArgs e)
        {

        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {


            // Login Code
            string username, password;
            username = "admin";
            password = "admin";
            if((textBox_password.Text == username ) && (textBox_username.Text == password))
            {
                MessageBox.Show("Welcome Admin !");
               this.Hide();
               Form5_main_menu openform = new Form5_main_menu();
                this.Close();
              // openform.Show();
               openform.ShowDialog();

            }
            else
            {
                MessageBox.Show("Access Denied !");
                count = count + 1;
                double maxcount = 3;
                double remain;
                remain = maxcount - count;
                MessageBox.Show("Wrong user name or password" + "\n" + remain + " " + "tries left");
                textBox_password.Clear();
                textBox_username.Clear();
                textBox_username.Focus();
                if (count == maxcount)
                {
                    MessageBox.Show("Max try exceeded.");
                    Application.Exit();
                }
            } //Wrong Password
            
        } //Login Credentails

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //EXIT BUTTON

        private void richTextBox_quote_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] allLines = File.ReadAllLines(@"Quotes.txt");
                Random rnd1 = new Random();
                richTextBox_quote.Text = allLines[rnd1.Next(allLines.Length)];
            }
            catch
            {
                richTextBox_quote.Text = "Random Quote file not found";
            }
            
        }

        private void button_internet_Click(object sender, EventArgs e)
        {
            int Out;
            if (InternetGetConnectedState(out Out, 0) == true)
            {
                MessageBox.Show("Internet Connection is Available");
            }
            else
            {
                MessageBox.Show("Internet Connection is not Available");
            }
        }
    }
}
