
namespace LibraryMPT
{
    partial class FormAdminOrders
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
            this.borrowedBooksGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateGive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBooksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowedBooksGrid
            // 
            this.borrowedBooksGrid.AllowUserToAddRows = false;
            this.borrowedBooksGrid.AllowUserToDeleteRows = false;
            this.borrowedBooksGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowedBooksGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.borrowedBooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowedBooksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Reader,
            this.DateGive,
            this.Book});
            this.borrowedBooksGrid.Location = new System.Drawing.Point(12, 12);
            this.borrowedBooksGrid.MultiSelect = false;
            this.borrowedBooksGrid.Name = "borrowedBooksGrid";
            this.borrowedBooksGrid.ReadOnly = true;
            this.borrowedBooksGrid.RowHeadersVisible = false;
            this.borrowedBooksGrid.RowTemplate.Height = 25;
            this.borrowedBooksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.borrowedBooksGrid.Size = new System.Drawing.Size(1186, 329);
            this.borrowedBooksGrid.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Reader
            // 
            this.Reader.HeaderText = "Читатель";
            this.Reader.Name = "Reader";
            this.Reader.ReadOnly = true;
            // 
            // DateGive
            // 
            this.DateGive.HeaderText = "Дата возврата";
            this.DateGive.Name = "DateGive";
            this.DateGive.ReadOnly = true;
            // 
            // Book
            // 
            this.Book.HeaderText = "Книга";
            this.Book.Name = "Book";
            this.Book.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1186, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Книга выдана";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdminOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.borrowedBooksGrid);
            this.MinimumSize = new System.Drawing.Size(1226, 438);
            this.Name = "FormAdminOrders";
            this.Text = "Заказы на выдачу";
            this.Load += new System.EventHandler(this.FormAdminOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBooksGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView borrowedBooksGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reader;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateGive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.Button button1;
    }
}