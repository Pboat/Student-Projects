
namespace Morse_Translator
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
            this.textGroupBox = new System.Windows.Forms.GroupBox();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.arrowLabel = new System.Windows.Forms.Label();
            this.morseGroupBox = new System.Windows.Forms.GroupBox();
            this.morseTextBox = new System.Windows.Forms.TextBox();
            this.textConvertButton = new System.Windows.Forms.Button();
            this.morseConvertButton = new System.Windows.Forms.Button();
            this.textGroupBox.SuspendLayout();
            this.morseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textGroupBox
            // 
            this.textGroupBox.Controls.Add(this.textTextBox);
            this.textGroupBox.Location = new System.Drawing.Point(25, 29);
            this.textGroupBox.Name = "textGroupBox";
            this.textGroupBox.Size = new System.Drawing.Size(200, 140);
            this.textGroupBox.TabIndex = 0;
            this.textGroupBox.TabStop = false;
            this.textGroupBox.Text = "Text";
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(6, 19);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textTextBox.Size = new System.Drawing.Size(188, 115);
            this.textTextBox.TabIndex = 1;
            // 
            // arrowLabel
            // 
            this.arrowLabel.AutoSize = true;
            this.arrowLabel.Location = new System.Drawing.Point(231, 103);
            this.arrowLabel.Name = "arrowLabel";
            this.arrowLabel.Size = new System.Drawing.Size(43, 15);
            this.arrowLabel.TabIndex = 0;
            this.arrowLabel.Text = "<---->";
            // 
            // morseGroupBox
            // 
            this.morseGroupBox.Controls.Add(this.morseTextBox);
            this.morseGroupBox.Location = new System.Drawing.Point(275, 29);
            this.morseGroupBox.Name = "morseGroupBox";
            this.morseGroupBox.Size = new System.Drawing.Size(200, 140);
            this.morseGroupBox.TabIndex = 1;
            this.morseGroupBox.TabStop = false;
            this.morseGroupBox.Text = "Morse Code";
            // 
            // morseTextBox
            // 
            this.morseTextBox.Location = new System.Drawing.Point(6, 19);
            this.morseTextBox.Multiline = true;
            this.morseTextBox.Name = "morseTextBox";
            this.morseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.morseTextBox.Size = new System.Drawing.Size(188, 115);
            this.morseTextBox.TabIndex = 2;
            // 
            // textConvertButton
            // 
            this.textConvertButton.Location = new System.Drawing.Point(75, 175);
            this.textConvertButton.Name = "textConvertButton";
            this.textConvertButton.Size = new System.Drawing.Size(93, 29);
            this.textConvertButton.TabIndex = 3;
            this.textConvertButton.Text = "Convert Text";
            this.textConvertButton.UseVisualStyleBackColor = true;
            this.textConvertButton.Click += new System.EventHandler(this.textConvertButton_Click);
            // 
            // morseConvertButton
            // 
            this.morseConvertButton.Location = new System.Drawing.Point(319, 175);
            this.morseConvertButton.Name = "morseConvertButton";
            this.morseConvertButton.Size = new System.Drawing.Size(93, 29);
            this.morseConvertButton.TabIndex = 4;
            this.morseConvertButton.Text = "Convert Morse";
            this.morseConvertButton.UseVisualStyleBackColor = true;
            this.morseConvertButton.Click += new System.EventHandler(this.morseConvertButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 232);
            this.Controls.Add(this.morseConvertButton);
            this.Controls.Add(this.textConvertButton);
            this.Controls.Add(this.morseGroupBox);
            this.Controls.Add(this.arrowLabel);
            this.Controls.Add(this.textGroupBox);
            this.Name = "MainForm";
            this.Text = "Morse Code Translator";
            this.textGroupBox.ResumeLayout(false);
            this.textGroupBox.PerformLayout();
            this.morseGroupBox.ResumeLayout(false);
            this.morseGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox textGroupBox;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Label arrowLabel;
        private System.Windows.Forms.GroupBox morseGroupBox;
        private System.Windows.Forms.TextBox morseTextBox;
        private System.Windows.Forms.Button textConvertButton;
        private System.Windows.Forms.Button morseConvertButton;
    }
}

