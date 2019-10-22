namespace Save_Name_in_Array
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
            this.inputNameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.saveName = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.totalInputTextBox = new System.Windows.Forms.TextBox();
            this.totalInputLabel = new System.Windows.Forms.Label();
            this.showAllName = new System.Windows.Forms.ListBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputNameLabel
            // 
            this.inputNameLabel.AutoSize = true;
            this.inputNameLabel.Location = new System.Drawing.Point(13, 56);
            this.inputNameLabel.Name = "inputNameLabel";
            this.inputNameLabel.Size = new System.Drawing.Size(69, 13);
            this.inputNameLabel.TabIndex = 0;
            this.inputNameLabel.Text = "EnterNumber";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(82, 53);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // saveName
            // 
            this.saveName.Location = new System.Drawing.Point(193, 51);
            this.saveName.Name = "saveName";
            this.saveName.Size = new System.Drawing.Size(75, 23);
            this.saveName.TabIndex = 2;
            this.saveName.Text = "Save";
            this.saveName.UseVisualStyleBackColor = true;
            this.saveName.Click += new System.EventHandler(this.saveName_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(193, 88);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 3;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // totalInputTextBox
            // 
            this.totalInputTextBox.Location = new System.Drawing.Point(57, 259);
            this.totalInputTextBox.Name = "totalInputTextBox";
            this.totalInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalInputTextBox.TabIndex = 4;
            // 
            // totalInputLabel
            // 
            this.totalInputLabel.AutoSize = true;
            this.totalInputLabel.Location = new System.Drawing.Point(13, 265);
            this.totalInputLabel.Name = "totalInputLabel";
            this.totalInputLabel.Size = new System.Drawing.Size(31, 13);
            this.totalInputLabel.TabIndex = 6;
            this.totalInputLabel.Text = "Total";
            // 
            // showAllName
            // 
            this.showAllName.FormattingEnabled = true;
            this.showAllName.Location = new System.Drawing.Point(62, 141);
            this.showAllName.Name = "showAllName";
            this.showAllName.Size = new System.Drawing.Size(120, 95);
            this.showAllName.TabIndex = 7;
            this.showAllName.SelectedIndexChanged += new System.EventHandler(this.showAllName_SelectedIndexChanged);
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(57, 285);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showAllName);
            this.Controls.Add(this.totalInputLabel);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.totalInputTextBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.saveName);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.inputNameLabel);
            this.Name = "Form1";
            this.Text = "Save Name in Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputNameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button saveName;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.TextBox totalInputTextBox;
        private System.Windows.Forms.Label totalInputLabel;
        private System.Windows.Forms.ListBox showAllName;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Label label1;
    }
}

