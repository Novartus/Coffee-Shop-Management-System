using QRCoder;
using System;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void button_qr_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("The text which should be encoded.", QRCodeGenerator.ECCLevel.Q);

            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

             PictureBox imageControl = new PictureBox();
             imageControl.Image = qrCodeImage;
             imageControl.Width = qrCodeImage.Width;
             imageControl.Height = qrCodeImage.Height;
             imageControl.SizeMode = PictureBoxSizeMode.CenterImage;
             Controls.Add(imageControl);

            //  qr_code = qrCodeImage;
            //   MessageBox.Show(qrCodeImage);


        }

        private void button_email_Click(object sender, EventArgs e) //Send mail through SMTP
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com"); // Gmail SMTP
                mail.From = new MailAddress("CoffeeShopMail@email.com"); // Coffeeshop Mail Address
                mail.To.Add("example@email.com"); // Client Email Address
                mail.Subject = "Test Mail - 4.... Please Collect your bill & QR";
                mail.Body = "mail with attachment \n"+"" +""; //Maybe Send QR CODE

               System.Net.Mail.Attachment attachment;
               attachment = new System.Net.Mail.Attachment(@"bill.txt");
               mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;      //Password AND ID
                SmtpServer.Credentials = new System.Net.NetworkCredential("email_id", @"Email_Password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ep)
            {
                //MessageBox.Show("failed to send email with the following error:");
                MessageBox.Show(ep.Message);
                Application.Exit();
            }
           
        }

        private void Form7_Load(object sender, EventArgs e)
        {
           // this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
