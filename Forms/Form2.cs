/* Copyright (c) 2020 All Rights Reserved
 *  Author: Abhee Hudani
 *  Title: Coffee Shop Management
 */

using System;
using System.Windows.Forms;
using System.IO;

namespace CoffeeShop
{
    public partial class Form2 : Form
    {
        
        int hot_coffee = 0; //Default Value
        int coco = 0;       //Default Value
        public static int hot_count = 0;
        public static int total_hot = 0;
        public static int total_coco = 0;
        public static int coco_count = 0;
        public static int total_cash = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void label_title_form2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           // this.TopMost = true;        //Hide The Taskbar
          //this.FormBorderStyle = FormBorderStyle.None;
            // this.WindowState = FormWindowState.Maximized;
            TEMP.Text = "Under Development"; //It will work here
        }

        private void textBox_quantity_hot_coffee_TextChanged(object sender, EventArgs e)
        {
            string quantity_1 = textBox_quantity_hot_coffee.Text.Trim();
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox_quantity_hot_coffee.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    textBox_quantity_hot_coffee.Text = textBox_quantity_hot_coffee.Text.Remove(textBox_quantity_hot_coffee.Text.Length - 1);
                }
                else
                {
                    hot_coffee = int.Parse(quantity_1);
                    hot_count = hot_coffee;
                }
                this.AcceptButton = button_cofirm_menu;
            }
            catch (Exception)
            {
                MessageBox.Show("Please try again !");
            }
        } //HOT COFFEE

        private void button_cofirm_menu_Click(object sender, EventArgs e)
        {
            using (StreamWriter Writer = File.AppendText("bill.txt"))
            {
                Writer.WriteLine(@"+-------------------------------------+");
                Writer.WriteLine("Simple Coffee: Rs.50 x {0} = Rs.{1}", hot_count, (50 * hot_count));
            }  //HOT COFFEE
            total_cash = total_cash + (hot_count * 50);
            total_hot += hot_count;
            
            using (StreamWriter Writer = File.AppendText("bill.txt"))
            {
                Writer.WriteLine("Hot Coco: Rs.90 x {0} = Rs.{1}", coco_count, (50 * coco_count));
                Writer.WriteLine("Total Cash for this Bill: {0} ",total_cash);
                Writer.WriteLine(@"+-------------------------------------+" +"\n\n");
            } //HOT COCO
            total_cash = total_cash + (coco_count * 50);
            total_coco += coco_count;

            MessageBox.Show("Great Choice! \nPlease Review Your Order");
            this.Hide();
            Form3 openform = new Form3();
            this.Close();
            openform.ShowDialog();
        }

        private void textBox_quantity_coco_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string quantity_2 = textBox_quantity_coco.Text.Trim();
                if (System.Text.RegularExpressions.Regex.IsMatch(quantity_2, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    textBox_quantity_coco.Text = quantity_2.Remove(quantity_2.Length - 1);
                }
                else
                {
                    coco = int.Parse(quantity_2);
                    coco_count = coco;
                   
                }
                this.AcceptButton = button_cofirm_menu;
            }
            catch (Exception)
            {
                MessageBox.Show("Please try again !");
            }
        } //COCO

        private void TEMP_TextChanged(object sender, EventArgs e)
        {
       //     TEMP.Text = "DEFAULT";        It won't work Here
        }

        private void label_coco_Click(object sender, EventArgs e)
        {

        }

        private void button_log_out_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Session Expired");
            this.Hide();
            Form1 openform = new Form1();
            this.Close();
            openform.Show();
        }

        private void button_report_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Cash is :" + Form2.total_cash);
        }
    }
}
