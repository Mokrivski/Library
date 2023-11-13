
namespace LibraryMPT
{
    partial class FormRegistration
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
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.repasswordBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.birthdateBox = new System.Windows.Forms.DateTimePicker();
            this.middlenameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.Location = new System.Drawing.Point(12, 356);
            this.passwordBox.MaxLength = 20;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.PlaceholderText = "Пароль";
            this.passwordBox.Size = new System.Drawing.Size(297, 23);
            this.passwordBox.TabIndex = 4;
            // 
            // loginBox
            // 
            this.loginBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBox.Location = new System.Drawing.Point(12, 312);
            this.loginBox.MaxLength = 20;
            this.loginBox.Name = "loginBox";
            this.loginBox.PlaceholderText = "Логин";
            this.loginBox.Size = new System.Drawing.Size(297, 23);
            this.loginBox.TabIndex = 3;
            // 
            // repasswordBox
            // 
            this.repasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repasswordBox.Location = new System.Drawing.Point(12, 402);
            this.repasswordBox.MaxLength = 20;
            this.repasswordBox.Name = "repasswordBox";
            this.repasswordBox.PasswordChar = '*';
            this.repasswordBox.PlaceholderText = "Повторите пароль";
            this.repasswordBox.Size = new System.Drawing.Size(297, 23);
            this.repasswordBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.phoneNumberBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.birthdateBox);
            this.groupBox1.Controls.Add(this.middlenameBox);
            this.groupBox1.Controls.Add(this.surnameBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 280);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личные данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Номер телефона:";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(20, 173);
            this.phoneNumberBox.Mask = "+7 (999) 000-0000";
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(254, 23);
            this.phoneNumberBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата рождения:";
            // 
            // birthdateBox
            // 
            this.birthdateBox.Location = new System.Drawing.Point(20, 229);
            this.birthdateBox.MinDate = new System.DateTime(1955, 12, 24, 0, 0, 0, 0);
            this.birthdateBox.Name = "birthdateBox";
            this.birthdateBox.Size = new System.Drawing.Size(254, 23);
            this.birthdateBox.TabIndex = 9;
            // 
            // middlenameBox
            // 
            this.middlenameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middlenameBox.Location = new System.Drawing.Point(20, 121);
            this.middlenameBox.MaxLength = 50;
            this.middlenameBox.Name = "middlenameBox";
            this.middlenameBox.PlaceholderText = "Отчество (при наличии)";
            this.middlenameBox.Size = new System.Drawing.Size(254, 23);
            this.middlenameBox.TabIndex = 8;
            // 
            // surnameBox
            // 
            this.surnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameBox.Location = new System.Drawing.Point(20, 33);
            this.surnameBox.MaxLength = 50;
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.PlaceholderText = "Фамилия";
            this.surnameBox.Size = new System.Drawing.Size(254, 23);
            this.surnameBox.TabIndex = 7;
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(20, 75);
            this.nameBox.MaxLength = 50;
            this.nameBox.Name = "nameBox";
            this.nameBox.PlaceholderText = "Имя";
            this.nameBox.Size = new System.Drawing.Size(254, 23);
            this.nameBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(13, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(209, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Регистрация";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.repasswordBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.MinimumSize = new System.Drawing.Size(337, 521);
            this.Name = "FormRegistration";
            this.Text = "Регистрация нового студента";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox repasswordBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker birthdateBox;
        private System.Windows.Forms.TextBox middlenameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox phoneNumberBox;
    }
}