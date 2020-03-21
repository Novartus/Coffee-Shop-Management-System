namespace CoffeeShop
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_loading = new System.Windows.Forms.Label();
            this.progressBarEx1 = new CoffeeShop.ProgressBarEx();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_loading
            // 
            this.label_loading.AutoSize = true;
            this.label_loading.BackColor = System.Drawing.Color.Transparent;
            this.label_loading.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loading.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_loading.Location = new System.Drawing.Point(254, 19);
            this.label_loading.Name = "label_loading";
            this.label_loading.Size = new System.Drawing.Size(400, 47);
            this.label_loading.TabIndex = 1;
            this.label_loading.Text = "The Simple-Coffee-Shop";
            this.label_loading.Click += new System.EventHandler(this.label_loading_Click);
            // 
            // progressBarEx1
            // 
            this.progressBarEx1.ForeColor = System.Drawing.Color.Peru;
            this.progressBarEx1.Location = new System.Drawing.Point(224, 364);
            this.progressBarEx1.Name = "progressBarEx1";
            this.progressBarEx1.Size = new System.Drawing.Size(430, 31);
            this.progressBarEx1.TabIndex = 3;
            this.progressBarEx1.Click += new System.EventHandler(this.progressBarEx1_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(895, 514);
            this.Controls.Add(this.label_loading);
            this.Controls.Add(this.progressBarEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_loading;
        private ProgressBarEx progressBarEx1;
    }
}