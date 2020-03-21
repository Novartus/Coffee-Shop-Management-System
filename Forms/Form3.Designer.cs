namespace CoffeeShop
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label_review_msg = new System.Windows.Forms.Label();
            this.button_final_order = new System.Windows.Forms.Button();
            this.button_final_change_order = new System.Windows.Forms.Button();
            this.richTextBox_Bill = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_review_msg
            // 
            this.label_review_msg.AutoSize = true;
            this.label_review_msg.BackColor = System.Drawing.Color.Transparent;
            this.label_review_msg.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F);
            this.label_review_msg.ForeColor = System.Drawing.Color.Sienna;
            this.label_review_msg.Location = new System.Drawing.Point(217, 8);
            this.label_review_msg.Name = "label_review_msg";
            this.label_review_msg.Size = new System.Drawing.Size(438, 47);
            this.label_review_msg.TabIndex = 2;
            this.label_review_msg.Text = "Please Review Your Order";
            this.label_review_msg.Click += new System.EventHandler(this.label_review_msg_Click);
            // 
            // button_final_order
            // 
            this.button_final_order.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_final_order.Location = new System.Drawing.Point(649, 348);
            this.button_final_order.Name = "button_final_order";
            this.button_final_order.Size = new System.Drawing.Size(183, 63);
            this.button_final_order.TabIndex = 3;
            this.button_final_order.Text = "Confrim";
            this.button_final_order.UseVisualStyleBackColor = true;
            this.button_final_order.Click += new System.EventHandler(this.button_final_order_Click);
            // 
            // button_final_change_order
            // 
            this.button_final_change_order.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_final_change_order.Location = new System.Drawing.Point(73, 348);
            this.button_final_change_order.Name = "button_final_change_order";
            this.button_final_change_order.Size = new System.Drawing.Size(179, 63);
            this.button_final_change_order.TabIndex = 4;
            this.button_final_change_order.Text = "Add In Order";
            this.button_final_change_order.UseVisualStyleBackColor = true;
            this.button_final_change_order.Click += new System.EventHandler(this.button_final_change_order_Click);
            // 
            // richTextBox_Bill
            // 
            this.richTextBox_Bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(213)))), ((int)(((byte)(196)))));
            this.richTextBox_Bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Bill.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Bill.Location = new System.Drawing.Point(588, 91);
            this.richTextBox_Bill.Name = "richTextBox_Bill";
            this.richTextBox_Bill.ReadOnly = true;
            this.richTextBox_Bill.Size = new System.Drawing.Size(279, 251);
            this.richTextBox_Bill.TabIndex = 5;
            this.richTextBox_Bill.Text = "";
            this.richTextBox_Bill.TextChanged += new System.EventHandler(this.richTextBox_Bill_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 475);
            this.Controls.Add(this.richTextBox_Bill);
            this.Controls.Add(this.button_final_change_order);
            this.Controls.Add(this.button_final_order);
            this.Controls.Add(this.label_review_msg);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(142, 36);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple-Coffee-Shop: Order Review";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_review_msg;
        private System.Windows.Forms.Button button_final_order;
        private System.Windows.Forms.Button button_final_change_order;
        private System.Windows.Forms.RichTextBox richTextBox_Bill;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}