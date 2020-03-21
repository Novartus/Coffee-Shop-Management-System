/* Copyright (c) 2020 All Rights Reserved
 *  Author: Abhee Hudani
 *  Title: Coffee Shop Management
 */
using System;
using System.Windows.Forms;
using System.IO;
using MyPDF;

namespace CoffeeShop
{
    public partial class Form4 : Form
    {
        Timer T = new Timer();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;        //Hide The Taskbar
           // this.FormBorderStyle = FormBorderStyle.None;
            // this.WindowState = FormWindowState.Maximized;

            T.Interval = 10;
            T.Tick += new EventHandler(t_tick);
            T.Start();
            this.AcceptButton = button_new_registration;

        }

        private void button_new_registration_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Order Confirmed");
            this.Hide();
            Form2 openform = new Form2();
            this.Close();
            openform.Show();
        }

        private void button_log_out_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Session Expired");
            this.Close();
            Form1 openform = new Form1();
            openform.ShowDialog();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to Quit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                using (StreamWriter Writer = File.AppendText("bill.txt"))
                {
                    Writer.WriteLine("Total Cash is :{0} \n\n", Form2.total_cash);
                }

                string fileName = @"bill.txt";
                string filePath = @"E:\CSharp_Project\CSharp_GUI\CoffeeShop\bin\Debug\bill.txt";

                // Create a new PdfWriter
                MyPDF.PdfWriter pdfWriter =
                   new MyPDF.PdfWriter(842.0f, 1190.0f, 10.0f, 10.0f);

                if (filePath.Length > 0)
                {
                    //Write to a PDF file
                    pdfWriter.Write(fileName);
                }

                MessageBox.Show("See you soon !");
                Application.Exit();
            }

            else

            {
                //do something if NO
                //It won't close current window
            }
           
        } //exit button

        private void richTextBox_exit_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_tick(object Sender, EventArgs args)
        {
            int h, m, s;
            h = DateTime.Now.Hour;
            m = DateTime.Now.Minute;
            s = DateTime.Now.Second;

            label_time.Text = h.ToString() + ":" + m.ToString() + ":" + s.ToString();
        }

        private void label_time_Click(object sender, EventArgs e)
        {
        }
    }
}
