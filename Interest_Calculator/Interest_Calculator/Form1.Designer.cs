namespace Interest_Calculator
{
    partial class Interest_Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rulesComboBox = new System.Windows.Forms.ComboBox();
            this.optionLabel = new System.Windows.Forms.Label();
            this.firstInputLabel = new System.Windows.Forms.Label();
            this.secondInputLabel = new System.Windows.Forms.Label();
            this.thirdInputLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.thirdTextBoxLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(143, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 2;
            // 
            // rulesComboBox
            // 
            this.rulesComboBox.FormattingEnabled = true;
            this.rulesComboBox.Items.AddRange(new object[] {
            "Principal (P)",
            "Rate (R)",
            "Time Period (t)",
            "Total P+I (A)"});
            this.rulesComboBox.Location = new System.Drawing.Point(143, 69);
            this.rulesComboBox.Name = "rulesComboBox";
            this.rulesComboBox.Size = new System.Drawing.Size(140, 21);
            this.rulesComboBox.TabIndex = 3;
            this.rulesComboBox.Text = "--Select--";
            this.rulesComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // optionLabel
            // 
            this.optionLabel.AutoSize = true;
            this.optionLabel.Location = new System.Drawing.Point(57, 72);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(58, 13);
            this.optionLabel.TabIndex = 8;
            this.optionLabel.Text = "Solve For :";
            this.optionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstInputLabel
            // 
            this.firstInputLabel.AutoSize = true;
            this.firstInputLabel.Location = new System.Drawing.Point(57, 130);
            this.firstInputLabel.Name = "firstInputLabel";
            this.firstInputLabel.Size = new System.Drawing.Size(19, 13);
            this.firstInputLabel.TabIndex = 9;
            this.firstInputLabel.Text = " ---";
            // 
            // secondInputLabel
            // 
            this.secondInputLabel.AutoSize = true;
            this.secondInputLabel.Location = new System.Drawing.Point(57, 174);
            this.secondInputLabel.Name = "secondInputLabel";
            this.secondInputLabel.Size = new System.Drawing.Size(19, 13);
            this.secondInputLabel.TabIndex = 13;
            this.secondInputLabel.Text = " ---";
            // 
            // thirdInputLabel
            // 
            this.thirdInputLabel.AutoSize = true;
            this.thirdInputLabel.Location = new System.Drawing.Point(57, 224);
            this.thirdInputLabel.Name = "thirdInputLabel";
            this.thirdInputLabel.Size = new System.Drawing.Size(19, 13);
            this.thirdInputLabel.TabIndex = 12;
            this.thirdInputLabel.Text = " ---";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clearButton.Location = new System.Drawing.Point(40, 327);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 38);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.calculateButton.Location = new System.Drawing.Point(208, 327);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(86, 38);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTextBox.Location = new System.Drawing.Point(17, 411);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(319, 20);
            this.resultTextBox.TabIndex = 7;
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Location = new System.Drawing.Point(154, 102);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(101, 13);
            this.rulesLabel.TabIndex = 10;
            this.rulesLabel.Text = "Where: A = P(1 + rt)";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(101, 194);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(0, 13);
            this.yearLabel.TabIndex = 11;
            // 
            // timeComboBox
            // 
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Items.AddRange(new object[] {
            "days ( 365/Yr )",
            "days ( 360/Yr )",
            "weeks",
            "months",
            "quarters",
            "years"});
            this.timeComboBox.Location = new System.Drawing.Point(189, 238);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(94, 21);
            this.timeComboBox.TabIndex = 4;
            this.timeComboBox.Text = "--Select--";
            // 
            // thirdTextBoxLabel
            // 
            this.thirdTextBoxLabel.AutoSize = true;
            this.thirdTextBoxLabel.Location = new System.Drawing.Point(101, 246);
            this.thirdTextBoxLabel.Name = "thirdTextBoxLabel";
            this.thirdTextBoxLabel.Size = new System.Drawing.Size(0, 13);
            this.thirdTextBoxLabel.TabIndex = 14;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Red;
            this.title.Location = new System.Drawing.Point(47, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(247, 24);
            this.title.TabIndex = 15;
            this.title.Text = "Simple Interest Calculator";
            // 
            // Interest_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 439);
            this.Controls.Add(this.title);
            this.Controls.Add(this.thirdTextBoxLabel);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.rulesLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.thirdInputLabel);
            this.Controls.Add(this.secondInputLabel);
            this.Controls.Add(this.firstInputLabel);
            this.Controls.Add(this.optionLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rulesComboBox);
            this.Name = "Interest_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Interest Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox rulesComboBox;
        private System.Windows.Forms.Label optionLabel;
        private System.Windows.Forms.Label firstInputLabel;
        private System.Windows.Forms.Label secondInputLabel;
        private System.Windows.Forms.Label thirdInputLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label rulesLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.Label thirdTextBoxLabel;
        private System.Windows.Forms.Label title;
    }
}

