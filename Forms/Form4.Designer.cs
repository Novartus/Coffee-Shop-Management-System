namespace CoffeeShop
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button_new_registration = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_log_out = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.richTextBox_exit = new System.Windows.Forms.RichTextBox();
            this.label_time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_new_registration
            // 
            this.button_new_registration.BackColor = System.Drawing.Color.Transparent;
            this.button_new_registration.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new_registration.Location = new System.Drawing.Point(610, 15);
            this.button_new_registration.Name = "button_new_registration";
            this.button_new_registration.Size = new System.Drawing.Size(254, 84);
            this.button_new_registration.TabIndex = 2;
            this.button_new_registration.Text = "Continue Registration";
            this.button_new_registration.UseVisualStyleBackColor = false;
            this.button_new_registration.Click += new System.EventHandler(this.button_new_registration_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button_log_out
            // 
            this.button_log_out.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_log_out.Location = new System.Drawing.Point(279, 393);
            this.button_log_out.Name = "button_log_out";
            this.button_log_out.Size = new System.Drawing.Size(190, 55);
            this.button_log_out.TabIndex = 4;
            this.button_log_out.Text = "Log Out";
            this.button_log_out.UseVisualStyleBackColor = true;
            this.button_log_out.Click += new System.EventHandler(this.button_log_out_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(29, 393);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(190, 55);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // richTextBox_exit
            // 
            this.richTextBox_exit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_exit.Location = new System.Drawing.Point(57, 272);
            this.richTextBox_exit.Name = "richTextBox_exit";
            this.richTextBox_exit.ReadOnly = true;
            this.richTextBox_exit.Size = new System.Drawing.Size(312, 38);
            this.richTextBox_exit.TabIndex = 6;
            this.richTextBox_exit.Text = "If you select exit then it will generate the final report. Of Current Session and" +
    " delete the history.";
            this.richTextBox_exit.TextChanged += new System.EventHandler(this.richTextBox_exit_TextChanged);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.BackColor = System.Drawing.Color.Transparent;
            this.label_time.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_time.Location = new System.Drawing.Point(546, 250);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(311, 81);
            this.label_time.TabIndex = 7;
            this.label_time.Text = "00:00:00";
            this.label_time.Click += new System.EventHandler(this.label_time_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(879, 475);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.richTextBox_exit);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_log_out);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_new_registration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple-Coffee-Shop: Done";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_new_registration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_log_out;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.RichTextBox richTextBox_exit;
        private System.Windows.Forms.Label label_time;
    }
}