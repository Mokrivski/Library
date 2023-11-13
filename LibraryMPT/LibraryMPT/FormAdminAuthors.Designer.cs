
namespace LibraryMPT
{
    partial class FormAdminAuthors
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.middlenameBox = new System.Windows.Forms.TextBox();
            this.authorsGrid = new System.Windows.Forms.DataGridView();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.authorsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(12, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(105, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(207, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // middlenameBox
            // 
            this.middlenameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middlenameBox.Location = new System.Drawing.Point(12, 264);
            this.middlenameBox.MaxLength = 150;
            this.middlenameBox.Name = "middlenameBox";
            this.middlenameBox.PlaceholderText = "Отчество (при наличии)";
            this.middlenameBox.Size = new System.Drawing.Size(282, 23);
            this.middlenameBox.TabIndex = 6;
            // 
            // authorsGrid
            // 
            this.authorsGrid.AllowUserToAddRows = false;
            this.authorsGrid.AllowUserToDeleteRows = false;
            this.authorsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.authorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorsGrid.ColumnHeadersVisible = false;
            this.authorsGrid.Location = new System.Drawing.Point(12, 12);
            this.authorsGrid.MultiSelect = false;
            this.authorsGrid.Name = "authorsGrid";
            this.authorsGrid.ReadOnly = true;
            this.authorsGrid.RowHeadersVisible = false;
            this.authorsGrid.RowTemplate.Height = 25;
            this.authorsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.authorsGrid.Size = new System.Drawing.Size(282, 176);
            this.authorsGrid.TabIndex = 5;
            this.authorsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.authorsGrid_CellClick);
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(12, 235);
            this.nameBox.MaxLength = 150;
            this.nameBox.Name = "nameBox";
            this.nameBox.PlaceholderText = "Имя";
            this.nameBox.Size = new System.Drawing.Size(282, 23);
            this.nameBox.TabIndex = 10;
            // 
            // surnameBox
            // 
            this.surnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameBox.Location = new System.Drawing.Point(12, 206);
            this.surnameBox.MaxLength = 150;
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.PlaceholderText = "Фамилия";
            this.surnameBox.Size = new System.Drawing.Size(282, 23);
            this.surnameBox.TabIndex = 11;
            // 
            // FormAdminAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 331);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.middlenameBox);
            this.Controls.Add(this.authorsGrid);
            this.MinimumSize = new System.Drawing.Size(322, 370);
            this.Name = "FormAdminAuthors";
            this.Text = "Авторы";
            this.Load += new System.EventHandler(this.FormAdminAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox middlenameBox;
        private System.Windows.Forms.DataGridView authorsGrid;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
    }
}