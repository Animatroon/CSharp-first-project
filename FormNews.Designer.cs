namespace FinalPorject
{
    partial class FormNews
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltext = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddNewsImage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.NavFirstName = new System.Windows.Forms.Label();
            this.profileIcon = new System.Windows.Forms.PictureBox();
            this.txtExit = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.ProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(23, 308);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1142, 559);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.ProfilePanel);
            this.panel1.Controls.Add(this.txtExit);
            this.panel1.Controls.Add(this.lbltext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 104);
            this.panel1.TabIndex = 2;
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbltext.ForeColor = System.Drawing.Color.White;
            this.lbltext.Location = new System.Drawing.Point(98, 27);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(276, 38);
            this.lbltext.TabIndex = 1;
            this.lbltext.Text = "Добавить носовость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текст:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(137, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(739, 34);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Загаловок:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddNewsImage
            // 
            this.btnAddNewsImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnAddNewsImage.FlatAppearance.BorderSize = 0;
            this.btnAddNewsImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewsImage.ForeColor = System.Drawing.Color.White;
            this.btnAddNewsImage.Location = new System.Drawing.Point(978, 124);
            this.btnAddNewsImage.Name = "btnAddNewsImage";
            this.btnAddNewsImage.Size = new System.Drawing.Size(160, 43);
            this.btnAddNewsImage.TabIndex = 11;
            this.btnAddNewsImage.Text = "Добавить картинку";
            this.btnAddNewsImage.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(994, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.BackColor = System.Drawing.Color.Transparent;
            this.ProfilePanel.Controls.Add(this.NavFirstName);
            this.ProfilePanel.Controls.Add(this.profileIcon);
            this.ProfilePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfilePanel.Location = new System.Drawing.Point(998, 11);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(184, 60);
            this.ProfilePanel.TabIndex = 29;
            // 
            // NavFirstName
            // 
            this.NavFirstName.AutoSize = true;
            this.NavFirstName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NavFirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NavFirstName.ForeColor = System.Drawing.Color.White;
            this.NavFirstName.Location = new System.Drawing.Point(35, 16);
            this.NavFirstName.MaximumSize = new System.Drawing.Size(180, 32);
            this.NavFirstName.Name = "NavFirstName";
            this.NavFirstName.Size = new System.Drawing.Size(82, 23);
            this.NavFirstName.TabIndex = 23;
            this.NavFirstName.Text = "FullName";
            // 
            // profileIcon
            // 
            this.profileIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileIcon.Image = global::FinalPorject.Properties.Resources.icons8_user_50;
            this.profileIcon.Location = new System.Drawing.Point(139, 0);
            this.profileIcon.Name = "profileIcon";
            this.profileIcon.Size = new System.Drawing.Size(45, 58);
            this.profileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileIcon.TabIndex = 24;
            this.profileIcon.TabStop = false;
            // 
            // txtExit
            // 
            this.txtExit.AutoSize = true;
            this.txtExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtExit.ForeColor = System.Drawing.Color.White;
            this.txtExit.Location = new System.Drawing.Point(1123, 74);
            this.txtExit.Margin = new System.Windows.Forms.Padding(0);
            this.txtExit.MaximumSize = new System.Drawing.Size(200, 32);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(59, 23);
            this.txtExit.TabIndex = 30;
            this.txtExit.Text = "Выйти";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::FinalPorject.Properties.Resources.icons8_назад_50__1_;
            this.btnBack.Location = new System.Drawing.Point(12, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 47);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 31;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 902);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddNewsImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormNews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNews";
            this.Load += new System.EventHandler(this.FormNews_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddNewsImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Label NavFirstName;
        private System.Windows.Forms.PictureBox profileIcon;
        private System.Windows.Forms.Label txtExit;
        private System.Windows.Forms.PictureBox btnBack;
    }
}