
namespace LibraryMPT
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
            this.booksGrid = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publishing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.моиЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksGrid
            // 
            this.booksGrid.AllowUserToAddRows = false;
            this.booksGrid.AllowUserToDeleteRows = false;
            this.booksGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.NameBook,
            this.Year,
            this.Publishing,
            this.Author});
            this.booksGrid.Location = new System.Drawing.Point(12, 69);
            this.booksGrid.MultiSelect = false;
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.ReadOnly = true;
            this.booksGrid.RowHeadersVisible = false;
            this.booksGrid.RowTemplate.Height = 25;
            this.booksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksGrid.Size = new System.Drawing.Size(667, 368);
            this.booksGrid.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата возврата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // NameBook
            // 
            this.NameBook.HeaderText = "Название книги";
            this.NameBook.Name = "NameBook";
            this.NameBook.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Год";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Publishing
            // 
            this.Publishing.HeaderText = "Издатель";
            this.Publishing.Name = "Publishing";
            this.Publishing.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.HeaderText = "Автор(ы)";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberLabel.Location = new System.Drawing.Point(12, 33);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(290, 21);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "Номер вашего читательского билета: 1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.моиЗаказыToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // моиЗаказыToolStripMenuItem
            // 
            this.моиЗаказыToolStripMenuItem.Name = "моиЗаказыToolStripMenuItem";
            this.моиЗаказыToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.моиЗаказыToolStripMenuItem.Text = "Мои заказы";
            this.моиЗаказыToolStripMenuItem.Click += new System.EventHandler(this.моиЗаказыToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.выйтиToolStripMenuItem.Text = "Выйти из аккаунта";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 449);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.booksGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(707, 488);
            this.Name = "FormStudent";
            this.Text = "Мои книги";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStudent_FormClosed);
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView booksGrid;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem моиЗаказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publishing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
    }
}