
namespace HourlyWageCalculator
{
    partial class MainForm
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
            this.hourlyTextBox = new System.Windows.Forms.TextBox();
            this.calculateYearlyButton = new System.Windows.Forms.Button();
            this.yearlyTextBox = new System.Windows.Forms.TextBox();
            this.calculateHourlyButton = new System.Windows.Forms.Button();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.yearlyLabel = new System.Windows.Forms.Label();
            this.hourlyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hourlyTextBox
            // 
            this.hourlyTextBox.Location = new System.Drawing.Point(147, 32);
            this.hourlyTextBox.Name = "hourlyTextBox";
            this.hourlyTextBox.Size = new System.Drawing.Size(100, 23);
            this.hourlyTextBox.TabIndex = 2;
            // 
            // calculateYearlyButton
            // 
            this.calculateYearlyButton.Location = new System.Drawing.Point(263, 22);
            this.calculateYearlyButton.Name = "calculateYearlyButton";
            this.calculateYearlyButton.Size = new System.Drawing.Size(75, 41);
            this.calculateYearlyButton.TabIndex = 0;
            this.calculateYearlyButton.Text = "Calculate Yearly";
            this.calculateYearlyButton.UseVisualStyleBackColor = true;
            this.calculateYearlyButton.Click += new System.EventHandler(this.calculateYearlyButton_Click);
            // 
            // yearlyTextBox
            // 
            this.yearlyTextBox.Location = new System.Drawing.Point(147, 79);
            this.yearlyTextBox.Name = "yearlyTextBox";
            this.yearlyTextBox.Size = new System.Drawing.Size(100, 23);
            this.yearlyTextBox.TabIndex = 3;
            // 
            // calculateHourlyButton
            // 
            this.calculateHourlyButton.Location = new System.Drawing.Point(263, 69);
            this.calculateHourlyButton.Name = "calculateHourlyButton";
            this.calculateHourlyButton.Size = new System.Drawing.Size(75, 41);
            this.calculateHourlyButton.TabIndex = 1;
            this.calculateHourlyButton.Text = "Calculate Hourly";
            this.calculateHourlyButton.UseVisualStyleBackColor = true;
            this.calculateHourlyButton.Click += new System.EventHandler(this.calculateHourlyButton_Click);
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(7, 125);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(134, 15);
            this.hoursLabel.TabIndex = 1;
            this.hoursLabel.Text = "Hours worked per week:";
            this.hoursLabel.Click += new System.EventHandler(this.hoursLabel_Click);
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(147, 122);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 23);
            this.hoursTextBox.TabIndex = 3;
            // 
            // yearlyLabel
            // 
            this.yearlyLabel.AutoSize = true;
            this.yearlyLabel.Location = new System.Drawing.Point(70, 82);
            this.yearlyLabel.Name = "yearlyLabel";
            this.yearlyLabel.Size = new System.Drawing.Size(71, 15);
            this.yearlyLabel.TabIndex = 4;
            this.yearlyLabel.Text = "Yearly Wage";
            // 
            // hourlyLabel
            // 
            this.hourlyLabel.AutoSize = true;
            this.hourlyLabel.Location = new System.Drawing.Point(62, 35);
            this.hourlyLabel.Name = "hourlyLabel";
            this.hourlyLabel.Size = new System.Drawing.Size(79, 15);
            this.hourlyLabel.TabIndex = 5;
            this.hourlyLabel.Text = "Hourly Wage:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 175);
            this.Controls.Add(this.hourlyLabel);
            this.Controls.Add(this.yearlyLabel);
            this.Controls.Add(this.hourlyTextBox);
            this.Controls.Add(this.calculateYearlyButton);
            this.Controls.Add(this.yearlyTextBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.calculateHourlyButton);
            this.Controls.Add(this.hoursLabel);
            this.Name = "MainForm";
            this.Text = "Wage Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox hourlyTextBox;
        private System.Windows.Forms.Button calculateYearlyButton;
        private System.Windows.Forms.TextBox yearlyTextBox;
        private System.Windows.Forms.Button calculateHourlyButton;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.Label yearlyLabel;
        private System.Windows.Forms.Label hourlyLabel;
    }
}

