using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class SplashScreen : Form
    {
      //  int a = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            if (progressBarEx1.Value < progressBarEx1.Maximum)
            {
                progressBarEx1.Value++;
            }
            else
            {
                progressBarEx1.Value = 0;
            }
            if (progressBarEx1.Value == 100)
            {
                this.Hide();
                timer1.Enabled = false;
                Form1 openform = new Form1();
                openform.ShowDialog();
            }
        }

        private void label_loading_Click(object sender, EventArgs e)
        {

        }
       
        private void progressBarEx1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}