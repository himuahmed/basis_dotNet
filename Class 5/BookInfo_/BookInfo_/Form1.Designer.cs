namespace BookInfo_
{
    partial class Form1
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
            this.bookInfo = new System.Windows.Forms.GroupBox();
            this.searchBook = new System.Windows.Forms.GroupBox();
            this.isbnInputTextBox = new System.Windows.Forms.TextBox();
            this.bookInputTextBox = new System.Windows.Forms.TextBox();
            this.isbnInput = new System.Windows.Forms.Label();
            this.bookInput = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookSearchTextBox = new System.Windows.Forms.TextBox();
            this.isbnSearchTextBox = new System.Windows.Forms.TextBox();
            this.bookInfo.SuspendLayout();
            this.searchBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookInfo
            // 
            this.bookInfo.Controls.Add(this.addButton);
            this.bookInfo.Controls.Add(this.bookInput);
            this.bookInfo.Controls.Add(this.isbnInput);
            this.bookInfo.Controls.Add(this.bookInputTextBox);
            this.bookInfo.Controls.Add(this.isbnInputTextBox);
            this.bookInfo.Location = new System.Drawing.Point(50, 28);
            this.bookInfo.Name = "bookInfo";
            this.bookInfo.Size = new System.Drawing.Size(606, 158);
            this.bookInfo.TabIndex = 0;
            this.bookInfo.TabStop = false;
            this.bookInfo.Text = "Book Info";
            // 
            // searchBook
            // 
            this.searchBook.Controls.Add(this.searchButton);
            this.searchBook.Controls.Add(this.label1);
            this.searchBook.Controls.Add(this.label2);
            this.searchBook.Controls.Add(this.bookSearchTextBox);
            this.searchBook.Controls.Add(this.isbnSearchTextBox);
            this.searchBook.Location = new System.Drawing.Point(50, 234);
            this.searchBook.Name = "searchBook";
            this.searchBook.Size = new System.Drawing.Size(606, 170);
            this.searchBook.TabIndex = 1;
            this.searchBook.TabStop = false;
            this.searchBook.Text = "Search Book";
            // 
            // isbnInputTextBox
            // 
            this.isbnInputTextBox.Location = new System.Drawing.Point(214, 31);
            this.isbnInputTextBox.Name = "isbnInputTextBox";
            this.isbnInputTextBox.Size = new System.Drawing.Size(243, 20);
            this.isbnInputTextBox.TabIndex = 0;
            // 
            // bookInputTextBox
            // 
            this.bookInputTextBox.Location = new System.Drawing.Point(214, 79);
            this.bookInputTextBox.Name = "bookInputTextBox";
            this.bookInputTextBox.Size = new System.Drawing.Size(243, 20);
            this.bookInputTextBox.TabIndex = 0;
            // 
            // isbnInput
            // 
            this.isbnInput.AutoSize = true;
            this.isbnInput.Location = new System.Drawing.Point(144, 34);
            this.isbnInput.Name = "isbnInput";
            this.isbnInput.Size = new System.Drawing.Size(32, 13);
            this.isbnInput.TabIndex = 1;
            this.isbnInput.Text = "ISBN";
            // 
            // bookInput
            // 
            this.bookInput.AutoSize = true;
            this.bookInput.Location = new System.Drawing.Point(144, 82);
            this.bookInput.Name = "bookInput";
            this.bookInput.Size = new System.Drawing.Size(63, 13);
            this.bookInput.TabIndex = 2;
            this.bookInput.Text = "Book Name";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(501, 75);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(444, 95);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ISBN";
            // 
            // bookSearchTextBox
            // 
            this.bookSearchTextBox.Location = new System.Drawing.Point(157, 99);
            this.bookSearchTextBox.Name = "bookSearchTextBox";
            this.bookSearchTextBox.Size = new System.Drawing.Size(243, 20);
            this.bookSearchTextBox.TabIndex = 4;
            // 
            // isbnSearchTextBox
            // 
            this.isbnSearchTextBox.Location = new System.Drawing.Point(157, 51);
            this.isbnSearchTextBox.Name = "isbnSearchTextBox";
            this.isbnSearchTextBox.Size = new System.Drawing.Size(243, 20);
            this.isbnSearchTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBook);
            this.Controls.Add(this.bookInfo);
            this.Name = "Form1";
            this.Text = "BookInfoUI";
            this.bookInfo.ResumeLayout(false);
            this.bookInfo.PerformLayout();
            this.searchBook.ResumeLayout(false);
            this.searchBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bookInfo;
        private System.Windows.Forms.GroupBox searchBook;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label bookInput;
        private System.Windows.Forms.Label isbnInput;
        private System.Windows.Forms.TextBox bookInputTextBox;
        private System.Windows.Forms.TextBox isbnInputTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookSearchTextBox;
        private System.Windows.Forms.TextBox isbnSearchTextBox;
    }
}

