namespace FinalPorject
{
    partial class FormStudent
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbStudGroup = new System.Windows.Forms.ComboBox();
            this.cbStudSpec = new System.Windows.Forms.ComboBox();
            this.cbStudFaculty = new System.Windows.Forms.ComboBox();
            this.cbGroupNumber = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbStudLanguage = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbStudGender = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbStudAge = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStudEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStudPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudNation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudBirthland = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorReg = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfileBack = new System.Windows.Forms.PictureBox();
            this.lbltext = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfileBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cbStudGroup);
            this.panel2.Controls.Add(this.cbStudSpec);
            this.panel2.Controls.Add(this.cbStudFaculty);
            this.panel2.Controls.Add(this.cbGroupNumber);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.cbStudLanguage);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cbStudGender);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cbStudAge);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtStudEmail);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtStudPassword);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtStudNumber);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtStudNation);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtStudBirthland);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ErrorReg);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(38, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 467);
            this.panel2.TabIndex = 1;
            // 
            // cbStudGroup
            // 
            this.cbStudGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStudGroup.FormattingEnabled = true;
            this.cbStudGroup.Items.AddRange(new object[] {
            "Главная",
            "Средняя",
            "Низкая"});
            this.cbStudGroup.Location = new System.Drawing.Point(352, 291);
            this.cbStudGroup.Name = "cbStudGroup";
            this.cbStudGroup.Size = new System.Drawing.Size(257, 28);
            this.cbStudGroup.TabIndex = 58;
            // 
            // cbStudSpec
            // 
            this.cbStudSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudSpec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStudSpec.FormattingEnabled = true;
            this.cbStudSpec.Location = new System.Drawing.Point(352, 223);
            this.cbStudSpec.Name = "cbStudSpec";
            this.cbStudSpec.Size = new System.Drawing.Size(257, 28);
            this.cbStudSpec.TabIndex = 57;
            this.cbStudSpec.SelectedIndexChanged += new System.EventHandler(this.cbStudSpec_SelectedIndexChanged);
            // 
            // cbStudFaculty
            // 
            this.cbStudFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudFaculty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStudFaculty.FormattingEnabled = true;
            this.cbStudFaculty.Items.AddRange(new object[] {
            "Факультет информационных технологий",
            "Факультет медицины и здравоохранения",
            "Факультет экономики и бизнеса",
            "Факультет искусств и дизайна"});
            this.cbStudFaculty.Location = new System.Drawing.Point(355, 66);
            this.cbStudFaculty.Name = "cbStudFaculty";
            this.cbStudFaculty.Size = new System.Drawing.Size(257, 28);
            this.cbStudFaculty.TabIndex = 56;
            this.cbStudFaculty.SelectedIndexChanged += new System.EventHandler(this.cbStudFaculty_SelectedIndexChanged);
            // 
            // cbGroupNumber
            // 
            this.cbGroupNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbGroupNumber.FormattingEnabled = true;
            this.cbGroupNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbGroupNumber.Location = new System.Drawing.Point(649, 144);
            this.cbGroupNumber.Name = "cbGroupNumber";
            this.cbGroupNumber.Size = new System.Drawing.Size(78, 28);
            this.cbGroupNumber.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(351, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 54;
            this.label14.Text = "Группа:";
            // 
            // cbStudLanguage
            // 
            this.cbStudLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudLanguage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStudLanguage.FormattingEnabled = true;
            this.cbStudLanguage.Items.AddRange(new object[] {
            "Казахский",
            "Русский",
            "Английский"});
            this.cbStudLanguage.Location = new System.Drawing.Point(748, 144);
            this.cbStudLanguage.Name = "cbStudLanguage";
            this.cbStudLanguage.Size = new System.Drawing.Size(158, 28);
            this.cbStudLanguage.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(744, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "Язык обучения:";
            // 
            // cbStudGender
            // 
            this.cbStudGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStudGender.FormattingEnabled = true;
            this.cbStudGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский",
            "Вертолет"});
            this.cbStudGender.Location = new System.Drawing.Point(468, 144);
            this.cbStudGender.Name = "cbStudGender";
            this.cbStudGender.Size = new System.Drawing.Size(141, 28);
            this.cbStudGender.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(464, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 20);
            this.label12.TabIndex = 48;
            this.label12.Text = "Пол:";
            // 
            // cbStudAge
            // 
            this.cbStudAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStudAge.FormattingEnabled = true;
            this.cbStudAge.Items.AddRange(new object[] {
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cbStudAge.Location = new System.Drawing.Point(355, 144);
            this.cbStudAge.Name = "cbStudAge";
            this.cbStudAge.Size = new System.Drawing.Size(93, 28);
            this.cbStudAge.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(351, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 49;
            this.label13.Text = "Возраст:";
            // 
            // txtStudEmail
            // 
            this.txtStudEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStudEmail.Location = new System.Drawing.Point(649, 225);
            this.txtStudEmail.Name = "txtStudEmail";
            this.txtStudEmail.Size = new System.Drawing.Size(257, 27);
            this.txtStudEmail.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(645, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Email:";
            // 
            // txtStudPassword
            // 
            this.txtStudPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStudPassword.Location = new System.Drawing.Point(649, 292);
            this.txtStudPassword.Name = "txtStudPassword";
            this.txtStudPassword.Size = new System.Drawing.Size(257, 27);
            this.txtStudPassword.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(645, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Придумайте пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(645, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Номер гр.:";
            // 
            // txtStudNumber
            // 
            this.txtStudNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStudNumber.Location = new System.Drawing.Point(649, 68);
            this.txtStudNumber.Name = "txtStudNumber";
            this.txtStudNumber.Size = new System.Drawing.Size(257, 27);
            this.txtStudNumber.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(645, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Номер телефона:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(351, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Специальность:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastName.Location = new System.Drawing.Point(60, 145);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(257, 27);
            this.txtLastName.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(56, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Фамилия:";
            // 
            // txtStudNation
            // 
            this.txtStudNation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStudNation.Location = new System.Drawing.Point(60, 292);
            this.txtStudNation.Name = "txtStudNation";
            this.txtStudNation.Size = new System.Drawing.Size(257, 27);
            this.txtStudNation.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(56, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Национальность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(348, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Факультет:";
            // 
            // txtStudBirthland
            // 
            this.txtStudBirthland.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStudBirthland.Location = new System.Drawing.Point(60, 225);
            this.txtStudBirthland.Name = "txtStudBirthland";
            this.txtStudBirthland.Size = new System.Drawing.Size(257, 27);
            this.txtStudBirthland.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(56, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Место рождения:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstName.Location = new System.Drawing.Point(60, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(257, 27);
            this.txtFirstName.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Имя:";
            // 
            // ErrorReg
            // 
            this.ErrorReg.AutoSize = true;
            this.ErrorReg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorReg.Location = new System.Drawing.Point(54, 10);
            this.ErrorReg.Name = "ErrorReg";
            this.ErrorReg.Size = new System.Drawing.Size(0, 20);
            this.ErrorReg.TabIndex = 29;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(60, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 43);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Зарегистрировать";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnProfileBack);
            this.panel1.Controls.Add(this.lbltext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 121);
            this.panel1.TabIndex = 2;
            // 
            // btnProfileBack
            // 
            this.btnProfileBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfileBack.Image = global::FinalPorject.Properties.Resources.icons8_назад_50__1_;
            this.btnProfileBack.Location = new System.Drawing.Point(21, 41);
            this.btnProfileBack.Name = "btnProfileBack";
            this.btnProfileBack.Size = new System.Drawing.Size(50, 47);
            this.btnProfileBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProfileBack.TabIndex = 18;
            this.btnProfileBack.TabStop = false;
            this.btnProfileBack.Click += new System.EventHandler(this.btnProfileBack_Click);
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbltext.ForeColor = System.Drawing.Color.White;
            this.lbltext.Location = new System.Drawing.Point(98, 41);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(352, 45);
            this.lbltext.TabIndex = 0;
            this.lbltext.Text = "Регистрация Студента";
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormStudent";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Univer";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfileBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Label ErrorReg;
        private System.Windows.Forms.ComboBox cbStudGroup;
        private System.Windows.Forms.ComboBox cbStudSpec;
        private System.Windows.Forms.ComboBox cbStudFaculty;
        private System.Windows.Forms.ComboBox cbGroupNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbStudLanguage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbStudGender;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbStudAge;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStudEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStudPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStudNation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudBirthland;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnProfileBack;
    }
}