/* Copyright (c) 2020 All Rights Reserved
 *  Author: Abhee Hudani
 *  Title: Coffee Shop Management
 */

using System;
using System.Windows.Forms;
using System.IO;

namespace CoffeeShop
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           // this.TopMost = true;        //Hide The Taskbar
            //this.FormBorderStyle = FormBorderStyle.None;
            // this.WindowState = FormWindowState.Maximized;

            this.AcceptButton = button_final_order;
            richTextBox_Bill.Text=(@"+------------------------------+" +
"1. HOT COFFEE x " + Form2.hot_count + "= " + (Form2.hot_count * 50) +
"\n2. HOT COCO x " + Form2.coco_count + "= " + (Form2.coco_count * 90)+
"\n\n Total Rs. = " + ( (Form2.hot_count * 50) + (Form2.coco_count * 90) ) +
"\n+------------------------------+");
            Form2.hot_count = 0;
            Form2.coco_count = 0;
            

            // richTextBox_Bill.Text = ("Second Line"); // Follows only last line
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label_review_msg_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_Bill_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_final_order_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You For Shopping With Us");
            this.Hide();
            Form4 openform = new Form4();
            this.Close();
            openform.ShowDialog();
        }

        private void button_final_change_order_Click(object sender, EventArgs e) //Button is not working
        {

        }
    }
}
