
namespace Stadium_Seating
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
            this.ticketBox = new System.Windows.Forms.GroupBox();
            this.revenueBox = new System.Windows.Forms.GroupBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.classATicketLabel = new System.Windows.Forms.Label();
            this.classCTicketLabel = new System.Windows.Forms.Label();
            this.classBTicketLabel = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.classARevLabel = new System.Windows.Forms.Label();
            this.classBRevLabel = new System.Windows.Forms.Label();
            this.classCRevLabel = new System.Windows.Forms.Label();
            this.totalRevLabel = new System.Windows.Forms.Label();
            this.classARevTotalLabel = new System.Windows.Forms.Label();
            this.classBRevTotalLabel = new System.Windows.Forms.Label();
            this.classCRevTotalLabel = new System.Windows.Forms.Label();
            this.totalRevTotalLabel = new System.Windows.Forms.Label();
            this.calcRevButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticketBox.SuspendLayout();
            this.revenueBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketBox
            // 
            this.ticketBox.Controls.Add(this.cTextBox);
            this.ticketBox.Controls.Add(this.bTextBox);
            this.ticketBox.Controls.Add(this.aTextBox);
            this.ticketBox.Controls.Add(this.classBTicketLabel);
            this.ticketBox.Controls.Add(this.classCTicketLabel);
            this.ticketBox.Controls.Add(this.classATicketLabel);
            this.ticketBox.Controls.Add(this.instructionLabel);
            this.ticketBox.Location = new System.Drawing.Point(24, 23);
            this.ticketBox.Name = "ticketBox";
            this.ticketBox.Size = new System.Drawing.Size(195, 146);
            this.ticketBox.TabIndex = 0;
            this.ticketBox.TabStop = false;
            this.ticketBox.Text = "Ticket\'s Sold";
            // 
            // revenueBox
            // 
            this.revenueBox.Controls.Add(this.totalRevTotalLabel);
            this.revenueBox.Controls.Add(this.classCRevTotalLabel);
            this.revenueBox.Controls.Add(this.classBRevTotalLabel);
            this.revenueBox.Controls.Add(this.classARevTotalLabel);
            this.revenueBox.Controls.Add(this.totalRevLabel);
            this.revenueBox.Controls.Add(this.classCRevLabel);
            this.revenueBox.Controls.Add(this.classBRevLabel);
            this.revenueBox.Controls.Add(this.classARevLabel);
            this.revenueBox.Location = new System.Drawing.Point(275, 23);
            this.revenueBox.Name = "revenueBox";
            this.revenueBox.Size = new System.Drawing.Size(195, 146);
            this.revenueBox.TabIndex = 1;
            this.revenueBox.TabStop = false;
            this.revenueBox.Text = "Revenue Generated";
            // 
            // instructionLabel
            // 
            this.instructionLabel.Location = new System.Drawing.Point(3, 19);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(159, 39);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // classATicketLabel
            // 
            this.classATicketLabel.AutoSize = true;
            this.classATicketLabel.Location = new System.Drawing.Point(6, 64);
            this.classATicketLabel.Name = "classATicketLabel";
            this.classATicketLabel.Size = new System.Drawing.Size(48, 15);
            this.classATicketLabel.TabIndex = 1;
            this.classATicketLabel.Text = "Class A:";
            // 
            // classCTicketLabel
            // 
            this.classCTicketLabel.AutoSize = true;
            this.classCTicketLabel.Location = new System.Drawing.Point(6, 117);
            this.classCTicketLabel.Name = "classCTicketLabel";
            this.classCTicketLabel.Size = new System.Drawing.Size(48, 15);
            this.classCTicketLabel.TabIndex = 2;
            this.classCTicketLabel.Text = "Class C:";
            // 
            // classBTicketLabel
            // 
            this.classBTicketLabel.AutoSize = true;
            this.classBTicketLabel.Location = new System.Drawing.Point(7, 91);
            this.classBTicketLabel.Name = "classBTicketLabel";
            this.classBTicketLabel.Size = new System.Drawing.Size(47, 15);
            this.classBTicketLabel.TabIndex = 3;
            this.classBTicketLabel.Text = "Class B:";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(75, 61);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 23);
            this.aTextBox.TabIndex = 0;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(75, 88);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 23);
            this.bTextBox.TabIndex = 1;
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(75, 114);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(100, 23);
            this.cTextBox.TabIndex = 2;
            // 
            // classARevLabel
            // 
            this.classARevLabel.AutoSize = true;
            this.classARevLabel.Location = new System.Drawing.Point(19, 40);
            this.classARevLabel.Name = "classARevLabel";
            this.classARevLabel.Size = new System.Drawing.Size(48, 15);
            this.classARevLabel.TabIndex = 0;
            this.classARevLabel.Text = "Class A:";
            // 
            // classBRevLabel
            // 
            this.classBRevLabel.AutoSize = true;
            this.classBRevLabel.Location = new System.Drawing.Point(19, 66);
            this.classBRevLabel.Name = "classBRevLabel";
            this.classBRevLabel.Size = new System.Drawing.Size(47, 15);
            this.classBRevLabel.TabIndex = 1;
            this.classBRevLabel.Text = "Class B:";
            // 
            // classCRevLabel
            // 
            this.classCRevLabel.AutoSize = true;
            this.classCRevLabel.Location = new System.Drawing.Point(19, 96);
            this.classCRevLabel.Name = "classCRevLabel";
            this.classCRevLabel.Size = new System.Drawing.Size(48, 15);
            this.classCRevLabel.TabIndex = 2;
            this.classCRevLabel.Text = "Class C:";
            // 
            // totalRevLabel
            // 
            this.totalRevLabel.AutoSize = true;
            this.totalRevLabel.Location = new System.Drawing.Point(30, 122);
            this.totalRevLabel.Name = "totalRevLabel";
            this.totalRevLabel.Size = new System.Drawing.Size(36, 15);
            this.totalRevLabel.TabIndex = 3;
            this.totalRevLabel.Text = "Total:";
            // 
            // classARevTotalLabel
            // 
            this.classARevTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classARevTotalLabel.Location = new System.Drawing.Point(72, 35);
            this.classARevTotalLabel.Name = "classARevTotalLabel";
            this.classARevTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.classARevTotalLabel.TabIndex = 4;
            // 
            // classBRevTotalLabel
            // 
            this.classBRevTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBRevTotalLabel.Location = new System.Drawing.Point(72, 61);
            this.classBRevTotalLabel.Name = "classBRevTotalLabel";
            this.classBRevTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.classBRevTotalLabel.TabIndex = 5;
            // 
            // classCRevTotalLabel
            // 
            this.classCRevTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classCRevTotalLabel.Location = new System.Drawing.Point(72, 90);
            this.classCRevTotalLabel.Name = "classCRevTotalLabel";
            this.classCRevTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.classCRevTotalLabel.TabIndex = 6;
            // 
            // totalRevTotalLabel
            // 
            this.totalRevTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalRevTotalLabel.Location = new System.Drawing.Point(72, 117);
            this.totalRevTotalLabel.Name = "totalRevTotalLabel";
            this.totalRevTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalRevTotalLabel.TabIndex = 7;
            // 
            // calcRevButton
            // 
            this.calcRevButton.Location = new System.Drawing.Point(119, 187);
            this.calcRevButton.Name = "calcRevButton";
            this.calcRevButton.Size = new System.Drawing.Size(80, 40);
            this.calcRevButton.TabIndex = 3;
            this.calcRevButton.Text = "Calculate Revenue";
            this.calcRevButton.UseVisualStyleBackColor = true;
            this.calcRevButton.Click += new System.EventHandler(this.calcRevButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(205, 187);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 40);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(291, 187);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 40);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 249);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcRevButton);
            this.Controls.Add(this.revenueBox);
            this.Controls.Add(this.ticketBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ticketBox.ResumeLayout(false);
            this.ticketBox.PerformLayout();
            this.revenueBox.ResumeLayout(false);
            this.revenueBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ticketBox;
        private System.Windows.Forms.GroupBox revenueBox;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label classBTicketLabel;
        private System.Windows.Forms.Label classCTicketLabel;
        private System.Windows.Forms.Label classATicketLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label totalRevTotalLabel;
        private System.Windows.Forms.Label classCRevTotalLabel;
        private System.Windows.Forms.Label classBRevTotalLabel;
        private System.Windows.Forms.Label classARevTotalLabel;
        private System.Windows.Forms.Label totalRevLabel;
        private System.Windows.Forms.Label classCRevLabel;
        private System.Windows.Forms.Label classBRevLabel;
        private System.Windows.Forms.Label classARevLabel;
        private System.Windows.Forms.Button calcRevButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

