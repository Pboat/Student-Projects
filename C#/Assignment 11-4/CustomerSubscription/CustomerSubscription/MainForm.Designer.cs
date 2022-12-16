
namespace CustomerSubscription
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
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.subscribeCheckBox = new System.Windows.Forms.CheckBox();
            this.contactGroupBox = new System.Windows.Forms.GroupBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(47, 230);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(84, 34);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(199, 230);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(84, 34);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // subscribeCheckBox
            // 
            this.subscribeCheckBox.AutoSize = true;
            this.subscribeCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subscribeCheckBox.Location = new System.Drawing.Point(71, 147);
            this.subscribeCheckBox.Name = "subscribeCheckBox";
            this.subscribeCheckBox.Size = new System.Drawing.Size(157, 19);
            this.subscribeCheckBox.TabIndex = 4;
            this.subscribeCheckBox.Text = "Subscribe to mailing list?";
            this.subscribeCheckBox.UseVisualStyleBackColor = true;
            // 
            // contactGroupBox
            // 
            this.contactGroupBox.Controls.Add(this.addressTextBox);
            this.contactGroupBox.Controls.Add(this.addressLabel);
            this.contactGroupBox.Controls.Add(this.phoneLabel);
            this.contactGroupBox.Controls.Add(this.lastNameLabel);
            this.contactGroupBox.Controls.Add(this.firstNameLabel);
            this.contactGroupBox.Controls.Add(this.phoneTextBox);
            this.contactGroupBox.Controls.Add(this.lastNameTextBox);
            this.contactGroupBox.Controls.Add(this.firstNameTextBox);
            this.contactGroupBox.Controls.Add(this.subscribeCheckBox);
            this.contactGroupBox.Location = new System.Drawing.Point(32, 29);
            this.contactGroupBox.Name = "contactGroupBox";
            this.contactGroupBox.Size = new System.Drawing.Size(267, 185);
            this.contactGroupBox.TabIndex = 0;
            this.contactGroupBox.TabStop = false;
            this.contactGroupBox.Text = "Contact information";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(128, 31);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(128, 60);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(128, 89);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 23);
            this.phoneTextBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(47, 34);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(65, 15);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(48, 63);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(64, 15);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last name:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(23, 92);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(89, 15);
            this.phoneLabel.TabIndex = 8;
            this.phoneLabel.Text = "Phone number:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(60, 121);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(52, 15);
            this.addressLabel.TabIndex = 9;
            this.addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(128, 118);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 23);
            this.addressTextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 295);
            this.Controls.Add(this.contactGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Name = "MainForm";
            this.Text = "Customer Contact Submission";
            this.contactGroupBox.ResumeLayout(false);
            this.contactGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox subscribeCheckBox;
        private System.Windows.Forms.GroupBox contactGroupBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
    }
}

