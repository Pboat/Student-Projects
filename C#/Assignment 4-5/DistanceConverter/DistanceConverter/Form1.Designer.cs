
namespace DistanceConverter
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
            this.toBox = new System.Windows.Forms.GroupBox();
            this.toListBox = new System.Windows.Forms.ListBox();
            this.fromBox = new System.Windows.Forms.GroupBox();
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.convertedDistanceLabel = new System.Windows.Forms.Label();
            this.conversionResultLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toBox.SuspendLayout();
            this.fromBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toBox
            // 
            this.toBox.Controls.Add(this.toListBox);
            this.toBox.Location = new System.Drawing.Point(189, 38);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(147, 100);
            this.toBox.TabIndex = 2;
            this.toBox.TabStop = false;
            this.toBox.Text = "To";
            // 
            // toListBox
            // 
            this.toListBox.FormattingEnabled = true;
            this.toListBox.ItemHeight = 15;
            this.toListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.toListBox.Location = new System.Drawing.Point(23, 26);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(101, 49);
            this.toListBox.TabIndex = 1;
            // 
            // fromBox
            // 
            this.fromBox.Controls.Add(this.fromListBox);
            this.fromBox.Location = new System.Drawing.Point(24, 38);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(147, 100);
            this.fromBox.TabIndex = 1;
            this.fromBox.TabStop = false;
            this.fromBox.Text = "From";
            // 
            // fromListBox
            // 
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.ItemHeight = 15;
            this.fromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.fromListBox.Location = new System.Drawing.Point(23, 26);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(101, 49);
            this.fromListBox.TabIndex = 0;
            // 
            // convertedDistanceLabel
            // 
            this.convertedDistanceLabel.AutoSize = true;
            this.convertedDistanceLabel.Location = new System.Drawing.Point(58, 159);
            this.convertedDistanceLabel.Name = "convertedDistanceLabel";
            this.convertedDistanceLabel.Size = new System.Drawing.Size(113, 15);
            this.convertedDistanceLabel.TabIndex = 3;
            this.convertedDistanceLabel.Text = "Converted Distance:";
            // 
            // conversionResultLabel
            // 
            this.conversionResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conversionResultLabel.Location = new System.Drawing.Point(189, 159);
            this.conversionResultLabel.Name = "conversionResultLabel";
            this.conversionResultLabel.Size = new System.Drawing.Size(100, 25);
            this.conversionResultLabel.TabIndex = 4;
            this.conversionResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(24, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(150, 15);
            this.instructionLabel.TabIndex = 5;
            this.instructionLabel.Text = "Enter a distance to convert:";
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(194, 6);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(142, 23);
            this.distanceTextBox.TabIndex = 0;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(73, 212);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(100, 25);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(179, 212);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 25);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 255);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.conversionResultLabel);
            this.Controls.Add(this.convertedDistanceLabel);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.toBox);
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.toBox.ResumeLayout(false);
            this.fromBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox toBox;
        private System.Windows.Forms.GroupBox fromBox;
        private System.Windows.Forms.Label convertedDistanceLabel;
        private System.Windows.Forms.Label conversionResultLabel;
        private System.Windows.Forms.ListBox toListBox;
        private System.Windows.Forms.ListBox fromListBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}

