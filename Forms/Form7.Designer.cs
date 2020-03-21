namespace CoffeeShop
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.button_email = new System.Windows.Forms.Button();
            this.button_qr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_email
            // 
            this.button_email.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_email.Location = new System.Drawing.Point(148, 197);
            this.button_email.Name = "button_email";
            this.button_email.Size = new System.Drawing.Size(241, 131);
            this.button_email.TabIndex = 0;
            this.button_email.Text = "Send sample mail";
            this.button_email.UseVisualStyleBackColor = true;
            this.button_email.Click += new System.EventHandler(this.button_email_Click);
            // 
            // button_qr
            // 
            this.button_qr.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_qr.Location = new System.Drawing.Point(504, 197);
            this.button_qr.Name = "button_qr";
            this.button_qr.Size = new System.Drawing.Size(255, 131);
            this.button_qr.TabIndex = 1;
            this.button_qr.Text = "Generate QR CODE";
            this.button_qr.UseVisualStyleBackColor = true;
            this.button_qr.Click += new System.EventHandler(this.button_qr_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 475);
            this.Controls.Add(this.button_qr);
            this.Controls.Add(this.button_email);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Under Development";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_email;
        private System.Windows.Forms.Button button_qr;
    }
}