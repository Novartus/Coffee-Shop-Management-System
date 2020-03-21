namespace CoffeeShop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_title = new System.Windows.Forms.Label();
            this.groupBox_login = new System.Windows.Forms.GroupBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox_login = new System.Windows.Forms.PictureBox();
            this.richTextBox_quote = new System.Windows.Forms.RichTextBox();
            this.label_quote = new System.Windows.Forms.Label();
            this.button_internet = new System.Windows.Forms.Button();
            this.pictureBox_lock = new System.Windows.Forms.PictureBox();
            this.groupBox_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lock)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(268, 26);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(422, 47);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "The Simple-Coffee-Shop";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // groupBox_login
            // 
            this.groupBox_login.Controls.Add(this.textBox_password);
            this.groupBox_login.Controls.Add(this.textBox_username);
            this.groupBox_login.Controls.Add(this.label_password);
            this.groupBox_login.Controls.Add(this.label_username);
            this.groupBox_login.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_login.Location = new System.Drawing.Point(238, 97);
            this.groupBox_login.Name = "groupBox_login";
            this.groupBox_login.Size = new System.Drawing.Size(532, 189);
            this.groupBox_login.TabIndex = 1;
            this.groupBox_login.TabStop = false;
            this.groupBox_login.Text = "Login Details:";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(274, 129);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.Size = new System.Drawing.Size(208, 38);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(274, 50);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(208, 34);
            this.textBox_username.TabIndex = 2;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(31, 129);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(151, 37);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password :";
            this.label_password.Click += new System.EventHandler(this.label_password_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(31, 48);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(159, 37);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username :";
            this.label_username.Click += new System.EventHandler(this.label_username_Click);
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(520, 332);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(130, 49);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(737, 332);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(130, 49);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // pictureBox_login
            // 
            this.pictureBox_login.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_login.Image")));
            this.pictureBox_login.Location = new System.Drawing.Point(66, 12);
            this.pictureBox_login.Name = "pictureBox_login";
            this.pictureBox_login.Size = new System.Drawing.Size(94, 74);
            this.pictureBox_login.TabIndex = 4;
            this.pictureBox_login.TabStop = false;
            // 
            // richTextBox_quote
            // 
            this.richTextBox_quote.Location = new System.Drawing.Point(57, 332);
            this.richTextBox_quote.Name = "richTextBox_quote";
            this.richTextBox_quote.ReadOnly = true;
            this.richTextBox_quote.Size = new System.Drawing.Size(377, 47);
            this.richTextBox_quote.TabIndex = 5;
            this.richTextBox_quote.Text = "";
            this.richTextBox_quote.TextChanged += new System.EventHandler(this.richTextBox_quote_TextChanged);
            // 
            // label_quote
            // 
            this.label_quote.AutoSize = true;
            this.label_quote.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quote.Location = new System.Drawing.Point(53, 308);
            this.label_quote.Name = "label_quote";
            this.label_quote.Size = new System.Drawing.Size(190, 21);
            this.label_quote.TabIndex = 6;
            this.label_quote.Text = "Quote Of The Moment:";
            // 
            // button_internet
            // 
            this.button_internet.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_internet.Location = new System.Drawing.Point(729, 44);
            this.button_internet.Name = "button_internet";
            this.button_internet.Size = new System.Drawing.Size(138, 56);
            this.button_internet.TabIndex = 7;
            this.button_internet.Text = "Internet \r\n?";
            this.button_internet.UseVisualStyleBackColor = true;
            this.button_internet.Click += new System.EventHandler(this.button_internet_Click);
            // 
            // pictureBox_lock
            // 
            this.pictureBox_lock.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_lock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_lock.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_lock.Image")));
            this.pictureBox_lock.Location = new System.Drawing.Point(16, 92);
            this.pictureBox_lock.Name = "pictureBox_lock";
            this.pictureBox_lock.Size = new System.Drawing.Size(200, 194);
            this.pictureBox_lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_lock.TabIndex = 8;
            this.pictureBox_lock.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(879, 475);
            this.Controls.Add(this.button_internet);
            this.Controls.Add(this.label_quote);
            this.Controls.Add(this.richTextBox_quote);
            this.Controls.Add(this.pictureBox_login);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.groupBox_login);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.pictureBox_lock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple-Coffee-Shop: Login ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.groupBox_login_Enter);
            this.groupBox_login.ResumeLayout(false);
            this.groupBox_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.GroupBox groupBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox pictureBox_login;
        private System.Windows.Forms.RichTextBox richTextBox_quote;
        private System.Windows.Forms.Label label_quote;
        private System.Windows.Forms.Button button_internet;
        private System.Windows.Forms.PictureBox pictureBox_lock;
    }
}

