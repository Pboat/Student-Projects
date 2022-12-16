
namespace PresentValueCalc
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
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.instructLabel = new System.Windows.Forms.Label();
            this.futureLabel = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.presentLabel = new System.Windows.Forms.Label();
            this.futureTextBox = new System.Windows.Forms.TextBox();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.presentTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(51, 237);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 33);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(208, 237);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 33);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // instructLabel
            // 
            this.instructLabel.AutoSize = true;
            this.instructLabel.Location = new System.Drawing.Point(58, 20);
            this.instructLabel.Name = "instructLabel";
            this.instructLabel.Size = new System.Drawing.Size(229, 15);
            this.instructLabel.TabIndex = 2;
            this.instructLabel.Text = "Calculate your investment\'s present value!";
            // 
            // futureLabel
            // 
            this.futureLabel.AutoSize = true;
            this.futureLabel.Location = new System.Drawing.Point(61, 66);
            this.futureLabel.Name = "futureLabel";
            this.futureLabel.Size = new System.Drawing.Size(75, 15);
            this.futureLabel.TabIndex = 3;
            this.futureLabel.Text = "Future Value:";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(7, 104);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(129, 15);
            this.interestLabel.TabIndex = 4;
            this.interestLabel.Text = "Annual % Interest Rate:";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(99, 142);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(37, 15);
            this.yearsLabel.TabIndex = 5;
            this.yearsLabel.Text = "Years:";
            // 
            // presentLabel
            // 
            this.presentLabel.AutoSize = true;
            this.presentLabel.Location = new System.Drawing.Point(56, 180);
            this.presentLabel.Name = "presentLabel";
            this.presentLabel.Size = new System.Drawing.Size(80, 15);
            this.presentLabel.TabIndex = 6;
            this.presentLabel.Text = "Present Value:";
            // 
            // futureTextBox
            // 
            this.futureTextBox.Location = new System.Drawing.Point(141, 63);
            this.futureTextBox.Name = "futureTextBox";
            this.futureTextBox.Size = new System.Drawing.Size(142, 23);
            this.futureTextBox.TabIndex = 0;
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(141, 101);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(142, 23);
            this.interestTextBox.TabIndex = 1;
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Location = new System.Drawing.Point(141, 139);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(142, 23);
            this.yearsTextBox.TabIndex = 2;
            // 
            // presentTextBox
            // 
            this.presentTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.presentTextBox.Location = new System.Drawing.Point(141, 177);
            this.presentTextBox.Name = "presentTextBox";
            this.presentTextBox.ReadOnly = true;
            this.presentTextBox.Size = new System.Drawing.Size(142, 23);
            this.presentTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 286);
            this.Controls.Add(this.presentTextBox);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.futureTextBox);
            this.Controls.Add(this.presentLabel);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.futureLabel);
            this.Controls.Add(this.instructLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Name = "Form1";
            this.Text = "Present Value Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label instructLabel;
        private System.Windows.Forms.Label futureLabel;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.Label presentLabel;
        private System.Windows.Forms.TextBox futureTextBox;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.TextBox yearsTextBox;
        private System.Windows.Forms.TextBox presentTextBox;
    }
}

