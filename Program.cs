using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace CoffeeShop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }

        public static void printPDFWithAcrobat()
        {
            string Filepath = @"C:\Coffee Shop-Record\txtPdf.pdf";
            try
            {
                using (PrintDialog Dialog = new PrintDialog())
                {
                    Dialog.ShowDialog();

                    ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                    {
                        Verb = "print",
                        CreateNoWindow = true,
                        FileName = Filepath,
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    Process printProcess = new Process();
                    printProcess.StartInfo = printProcessInfo;
                    printProcess.Start();

                    printProcess.WaitForInputIdle();

                    Thread.Sleep(1000);

                    if (false == printProcess.CloseMainWindow())
                    {
                        printProcess.Kill();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Can't fulfill your request.");
            }
        } //Print to a file

    }
}
