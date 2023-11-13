
namespace LibraryMPT
{
    partial class FormStudentOrders
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publishing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
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
            this.ID,
            this.Date,
            this.NameBook,
            this.Year,
            this.Publishing,
            this.Author});
            this.booksGrid.Location = new System.Drawing.Point(12, 12);
            this.booksGrid.MultiSelect = false;
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.ReadOnly = true;
            this.booksGrid.RowHeadersVisible = false;
            this.booksGrid.RowTemplate.Height = 25;
            this.booksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksGrid.Size = new System.Drawing.Size(625, 302);
            this.booksGrid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(625, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Оформить заказ на выдачу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(486, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отменить заказ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
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
            // FormStudentOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.booksGrid);
            this.MinimumSize = new System.Drawing.Size(665, 435);
            this.Name = "FormStudentOrders";
            this.Text = "Мои заказы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStudentOrders_FormClosed);
            this.Load += new System.EventHandler(this.FormStudentOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booksGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publishing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
    }
}