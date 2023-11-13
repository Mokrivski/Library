
namespace LibraryMPT
{
    partial class FormAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.списокКнигToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЧитателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзАккаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарегистрироватьАдминистратораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowedBooksGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateGive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBooksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокКнигToolStripMenuItem,
            this.добавитьЧитателяToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.выйтиИзАккаунтаToolStripMenuItem,
            this.зарегистрироватьАдминистратораToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // списокКнигToolStripMenuItem
            // 
            this.списокКнигToolStripMenuItem.Name = "списокКнигToolStripMenuItem";
            this.списокКнигToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.списокКнигToolStripMenuItem.Text = "Заказы";
            this.списокКнигToolStripMenuItem.Click += new System.EventHandler(this.списокКнигToolStripMenuItem_Click);
            // 
            // добавитьЧитателяToolStripMenuItem
            // 
            this.добавитьЧитателяToolStripMenuItem.Name = "добавитьЧитателяToolStripMenuItem";
            this.добавитьЧитателяToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.добавитьЧитателяToolStripMenuItem.Text = "Список книг";
            this.добавитьЧитателяToolStripMenuItem.Click += new System.EventHandler(this.добавитьЧитателяToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.заказыToolStripMenuItem.Text = "Читатели";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // выйтиИзАккаунтаToolStripMenuItem
            // 
            this.выйтиИзАккаунтаToolStripMenuItem.Name = "выйтиИзАккаунтаToolStripMenuItem";
            this.выйтиИзАккаунтаToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.выйтиИзАккаунтаToolStripMenuItem.Text = "Выйти из аккаунта";
            this.выйтиИзАккаунтаToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзАккаунтаToolStripMenuItem_Click);
            // 
            // зарегистрироватьАдминистратораToolStripMenuItem
            // 
            this.зарегистрироватьАдминистратораToolStripMenuItem.Name = "зарегистрироватьАдминистратораToolStripMenuItem";
            this.зарегистрироватьАдминистратораToolStripMenuItem.Size = new System.Drawing.Size(213, 20);
            this.зарегистрироватьАдминистратораToolStripMenuItem.Text = "Зарегистрировать администратора";
            this.зарегистрироватьАдминистратораToolStripMenuItem.Click += new System.EventHandler(this.зарегистрироватьАдминистратораToolStripMenuItem_Click);
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
            this.borrowedBooksGrid.Location = new System.Drawing.Point(12, 68);
            this.borrowedBooksGrid.MultiSelect = false;
            this.borrowedBooksGrid.Name = "borrowedBooksGrid";
            this.borrowedBooksGrid.ReadOnly = true;
            this.borrowedBooksGrid.RowHeadersVisible = false;
            this.borrowedBooksGrid.RowTemplate.Height = 25;
            this.borrowedBooksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.borrowedBooksGrid.Size = new System.Drawing.Size(1158, 354);
            this.borrowedBooksGrid.TabIndex = 1;
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
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberLabel.Location = new System.Drawing.Point(12, 44);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(129, 21);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "Выданные книги";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1158, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Книга возвращена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.borrowedBooksGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1198, 511);
            this.Name = "FormAdmin";
            this.Text = "Панель администратора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBooksGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem списокКнигToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЧитателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзАккаунтаToolStripMenuItem;
        private System.Windows.Forms.DataGridView borrowedBooksGrid;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reader;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateGive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.ToolStripMenuItem зарегистрироватьАдминистратораToolStripMenuItem;
    }
}