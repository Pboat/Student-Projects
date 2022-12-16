
namespace Name_Search
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.boyLabel = new System.Windows.Forms.Label();
            this.girlLabel = new System.Windows.Forms.Label();
            this.instructLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.positionGroupBox = new System.Windows.Forms.GroupBox();
            this.girlTextBox = new System.Windows.Forms.TextBox();
            this.boyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.positionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(30, 57);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // boyLabel
            // 
            this.boyLabel.AutoSize = true;
            this.boyLabel.Location = new System.Drawing.Point(16, 28);
            this.boyLabel.Name = "boyLabel";
            this.boyLabel.Size = new System.Drawing.Size(35, 15);
            this.boyLabel.TabIndex = 2;
            this.boyLabel.Text = "Boys:";
            // 
            // girlLabel
            // 
            this.girlLabel.AutoSize = true;
            this.girlLabel.Location = new System.Drawing.Point(16, 66);
            this.girlLabel.Name = "girlLabel";
            this.girlLabel.Size = new System.Drawing.Size(33, 15);
            this.girlLabel.TabIndex = 3;
            this.girlLabel.Text = "Girls:";
            // 
            // instructLabel
            // 
            this.instructLabel.AutoSize = true;
            this.instructLabel.Location = new System.Drawing.Point(13, 14);
            this.instructLabel.Name = "instructLabel";
            this.instructLabel.Size = new System.Drawing.Size(338, 15);
            this.instructLabel.TabIndex = 6;
            this.instructLabel.Text = "Type a name, and see if it\'s in the top 200 most popular names!";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(202, 193);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(78, 30);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(72, 193);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(78, 30);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(30, 85);
            this.nameTextBox.MaxLength = 512;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(137, 23);
            this.nameTextBox.TabIndex = 0;
            // 
            // positionGroupBox
            // 
            this.positionGroupBox.Controls.Add(this.girlTextBox);
            this.positionGroupBox.Controls.Add(this.boyTextBox);
            this.positionGroupBox.Controls.Add(this.boyLabel);
            this.positionGroupBox.Controls.Add(this.girlLabel);
            this.positionGroupBox.Location = new System.Drawing.Point(175, 40);
            this.positionGroupBox.Name = "positionGroupBox";
            this.positionGroupBox.Size = new System.Drawing.Size(162, 100);
            this.positionGroupBox.TabIndex = 10;
            this.positionGroupBox.TabStop = false;
            this.positionGroupBox.Text = "Position";
            // 
            // girlTextBox
            // 
            this.girlTextBox.Location = new System.Drawing.Point(55, 63);
            this.girlTextBox.Name = "girlTextBox";
            this.girlTextBox.ReadOnly = true;
            this.girlTextBox.Size = new System.Drawing.Size(90, 23);
            this.girlTextBox.TabIndex = 13;
            // 
            // boyTextBox
            // 
            this.boyTextBox.Location = new System.Drawing.Point(55, 25);
            this.boyTextBox.Name = "boyTextBox";
            this.boyTextBox.ReadOnly = true;
            this.boyTextBox.Size = new System.Drawing.Size(90, 23);
            this.boyTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Results:";
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(30, 151);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.Size = new System.Drawing.Size(307, 36);
            this.resultsTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 239);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.positionGroupBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.instructLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Popular Baby Name Search 1.0";
            this.positionGroupBox.ResumeLayout(false);
            this.positionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label boyLabel;
        private System.Windows.Forms.Label girlLabel;
        private System.Windows.Forms.Label instructLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox positionGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.TextBox girlTextBox;
        private System.Windows.Forms.TextBox boyTextBox;
    }
}

