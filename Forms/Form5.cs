using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace CoffeeShop
{
    public partial class Form5_main_menu : Form
    {
        public Form5_main_menu()
        {
            InitializeComponent();
        }

        private void button_log_out_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Session Expired");
            this.Close();
            Form1 openform = new Form1();
            openform.Show();
        }

        private void button_pdf_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show("Report has been Generated");
        }

        private void button_report_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sold In Current Session:" + (Form2.hot_count+Form2.coco_count)+
                "\n 1. Hot Coffee x "+Form2.hot_count+
                "\n 2. Hot Coco x "+Form2.coco_count+
                "\n Total Cash : "+Form2.total_cash);
        }

        private void button_cash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Cash :" + Form2.total_cash);
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 openform = new Form2();
            this.Close();
            openform.Show();
        }

        private void Form5_main_menu_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;        //Hide The Taskbar
            //this.FormBorderStyle = FormBorderStyle.None;
            // this.WindowState = FormWindowState.Maximized;
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            Program.printPDFWithAcrobat();
        }

        private void button_exit_5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to Quit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("See you soon!");
                // File.Delete("bill.txt");
                Application.Exit();
            }
        }

        private void saveFile_report_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button_save_as_Click(object sender, EventArgs e)
        {
            //
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";      
            saveFileDialog1.Title = "Save text Files";
           // saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(@"bill.txt", Encoding.UTF8);
                // text = saveFileDialog1.FileName;

                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                sw.WriteLine(text);
                
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "Saved";
                popup.ContentText = "Please Check your saved file";
                popup.Popup();// show  
            }
        }

        private void button_temp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 openform = new Form7();
            this.Close();
            openform.ShowDialog();
        }

    }
}
