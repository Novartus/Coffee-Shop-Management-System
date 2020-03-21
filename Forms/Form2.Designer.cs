namespace CoffeeShop
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label_title_form2 = new System.Windows.Forms.Label();
            this.label_menu = new System.Windows.Forms.Label();
            this.textBox_quantity_hot_coffee = new System.Windows.Forms.TextBox();
            this.button_cofirm_menu = new System.Windows.Forms.Button();
            this.groupBox_menu = new System.Windows.Forms.GroupBox();
            this.textBox_quantity_coco = new System.Windows.Forms.TextBox();
            this.label_coco = new System.Windows.Forms.Label();
            this.TEMP = new System.Windows.Forms.TextBox();
            this.button_log_out_2 = new System.Windows.Forms.Button();
            this.button_report_2 = new System.Windows.Forms.Button();
            this.groupBox_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title_form2
            // 
            this.label_title_form2.AutoSize = true;
            this.label_title_form2.BackColor = System.Drawing.Color.Transparent;
            this.label_title_form2.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_form2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_title_form2.Location = new System.Drawing.Point(28, 60);
            this.label_title_form2.Name = "label_title_form2";
            this.label_title_form2.Size = new System.Drawing.Size(422, 47);
            this.label_title_form2.TabIndex = 1;
            this.label_title_form2.Text = "The Simple-Coffee-Shop";
            this.label_title_form2.Click += new System.EventHandler(this.label_title_form2_Click);
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_menu.Location = new System.Drawing.Point(33, 37);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(135, 26);
            this.label_menu.TabIndex = 2;
            this.label_menu.Text = "1. Hot Coffee";
            this.label_menu.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_quantity_hot_coffee
            // 
            this.textBox_quantity_hot_coffee.Location = new System.Drawing.Point(328, 35);
            this.textBox_quantity_hot_coffee.Multiline = true;
            this.textBox_quantity_hot_coffee.Name = "textBox_quantity_hot_coffee";
            this.textBox_quantity_hot_coffee.Size = new System.Drawing.Size(30, 28);
            this.textBox_quantity_hot_coffee.TabIndex = 3;
            this.textBox_quantity_hot_coffee.TextChanged += new System.EventHandler(this.textBox_quantity_hot_coffee_TextChanged);
            // 
            // button_cofirm_menu
            // 
            this.button_cofirm_menu.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.button_cofirm_menu.Location = new System.Drawing.Point(609, 377);
            this.button_cofirm_menu.Name = "button_cofirm_menu";
            this.button_cofirm_menu.Size = new System.Drawing.Size(134, 52);
            this.button_cofirm_menu.TabIndex = 4;
            this.button_cofirm_menu.Text = "Confirm";
            this.button_cofirm_menu.UseVisualStyleBackColor = true;
            this.button_cofirm_menu.Click += new System.EventHandler(this.button_cofirm_menu_Click);
            // 
            // groupBox_menu
            // 
            this.groupBox_menu.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_menu.Controls.Add(this.textBox_quantity_coco);
            this.groupBox_menu.Controls.Add(this.label_coco);
            this.groupBox_menu.Controls.Add(this.label_menu);
            this.groupBox_menu.Controls.Add(this.textBox_quantity_hot_coffee);
            this.groupBox_menu.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_menu.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox_menu.Location = new System.Drawing.Point(470, 44);
            this.groupBox_menu.Name = "groupBox_menu";
            this.groupBox_menu.Size = new System.Drawing.Size(397, 286);
            this.groupBox_menu.TabIndex = 5;
            this.groupBox_menu.TabStop = false;
            this.groupBox_menu.Text = "Menu Of The Day";
            // 
            // textBox_quantity_coco
            // 
            this.textBox_quantity_coco.Location = new System.Drawing.Point(328, 78);
            this.textBox_quantity_coco.Multiline = true;
            this.textBox_quantity_coco.Name = "textBox_quantity_coco";
            this.textBox_quantity_coco.Size = new System.Drawing.Size(30, 28);
            this.textBox_quantity_coco.TabIndex = 5;
            this.textBox_quantity_coco.TextChanged += new System.EventHandler(this.textBox_quantity_coco_TextChanged);
            // 
            // label_coco
            // 
            this.label_coco.AutoSize = true;
            this.label_coco.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.label_coco.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_coco.Location = new System.Drawing.Point(33, 80);
            this.label_coco.Name = "label_coco";
            this.label_coco.Size = new System.Drawing.Size(121, 26);
            this.label_coco.TabIndex = 4;
            this.label_coco.Text = "2. Hot Coco";
            this.label_coco.Click += new System.EventHandler(this.label_coco_Click);
            // 
            // TEMP
            // 
            this.TEMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEMP.Location = new System.Drawing.Point(89, 352);
            this.TEMP.Name = "TEMP";
            this.TEMP.ReadOnly = true;
            this.TEMP.Size = new System.Drawing.Size(145, 20);
            this.TEMP.TabIndex = 6;
            this.TEMP.Text = "Under Development";
            this.TEMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TEMP.TextChanged += new System.EventHandler(this.TEMP_TextChanged);
            // 
            // button_log_out_2
            // 
            this.button_log_out_2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.button_log_out_2.Location = new System.Drawing.Point(225, 151);
            this.button_log_out_2.Name = "button_log_out_2";
            this.button_log_out_2.Size = new System.Drawing.Size(158, 67);
            this.button_log_out_2.TabIndex = 7;
            this.button_log_out_2.Text = "Log Out";
            this.button_log_out_2.UseVisualStyleBackColor = true;
            this.button_log_out_2.Click += new System.EventHandler(this.button_log_out_2_Click);
            // 
            // button_report_2
            // 
            this.button_report_2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_report_2.Location = new System.Drawing.Point(24, 151);
            this.button_report_2.Name = "button_report_2";
            this.button_report_2.Size = new System.Drawing.Size(153, 67);
            this.button_report_2.TabIndex = 8;
            this.button_report_2.Text = "Report";
            this.button_report_2.UseVisualStyleBackColor = true;
            this.button_report_2.Click += new System.EventHandler(this.button_report_2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 475);
            this.Controls.Add(this.button_report_2);
            this.Controls.Add(this.button_log_out_2);
            this.Controls.Add(this.TEMP);
            this.Controls.Add(this.groupBox_menu);
            this.Controls.Add(this.button_cofirm_menu);
            this.Controls.Add(this.label_title_form2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple-Coffee-Shop: Menu ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox_menu.ResumeLayout(false);
            this.groupBox_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title_form2;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.TextBox textBox_quantity_hot_coffee;
        private System.Windows.Forms.Button button_cofirm_menu;
        private System.Windows.Forms.GroupBox groupBox_menu;
        private System.Windows.Forms.TextBox textBox_quantity_coco;
        private System.Windows.Forms.Label label_coco;
        private System.Windows.Forms.TextBox TEMP;
        private System.Windows.Forms.Button button_log_out_2;
        private System.Windows.Forms.Button button_report_2;
    }
}