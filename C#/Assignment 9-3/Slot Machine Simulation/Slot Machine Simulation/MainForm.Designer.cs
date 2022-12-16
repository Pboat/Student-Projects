
namespace Slot_Machine_Simulation
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
            this.slotLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.slotMiddlePictureBox = new System.Windows.Forms.PictureBox();
            this.slotRightPictureBox = new System.Windows.Forms.PictureBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.spinButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slotLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotMiddlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotRightPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // slotLeftPictureBox
            // 
            this.slotLeftPictureBox.Image = global::Slot_Machine_Simulation.Properties.Resources.Apple;
            this.slotLeftPictureBox.Location = new System.Drawing.Point(12, 12);
            this.slotLeftPictureBox.Name = "slotLeftPictureBox";
            this.slotLeftPictureBox.Size = new System.Drawing.Size(128, 128);
            this.slotLeftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.slotLeftPictureBox.TabIndex = 0;
            this.slotLeftPictureBox.TabStop = false;
            // 
            // slotMiddlePictureBox
            // 
            this.slotMiddlePictureBox.Image = global::Slot_Machine_Simulation.Properties.Resources.Banana;
            this.slotMiddlePictureBox.Location = new System.Drawing.Point(148, 12);
            this.slotMiddlePictureBox.Name = "slotMiddlePictureBox";
            this.slotMiddlePictureBox.Size = new System.Drawing.Size(128, 128);
            this.slotMiddlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.slotMiddlePictureBox.TabIndex = 1;
            this.slotMiddlePictureBox.TabStop = false;
            // 
            // slotRightPictureBox
            // 
            this.slotRightPictureBox.Image = global::Slot_Machine_Simulation.Properties.Resources.Cherries;
            this.slotRightPictureBox.Location = new System.Drawing.Point(284, 12);
            this.slotRightPictureBox.Name = "slotRightPictureBox";
            this.slotRightPictureBox.Size = new System.Drawing.Size(128, 128);
            this.slotRightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.slotRightPictureBox.TabIndex = 2;
            this.slotRightPictureBox.TabStop = false;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(87, 175);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(108, 15);
            this.moneyLabel.TabIndex = 3;
            this.moneyLabel.Text = "Amount Inserted: $";
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(201, 172);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(119, 23);
            this.moneyTextBox.TabIndex = 4;
            // 
            // spinButton
            // 
            this.spinButton.Location = new System.Drawing.Point(87, 211);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(90, 29);
            this.spinButton.TabIndex = 5;
            this.spinButton.Text = "Spin";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(201, 211);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 29);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.slotRightPictureBox);
            this.Controls.Add(this.slotMiddlePictureBox);
            this.Controls.Add(this.slotLeftPictureBox);
            this.Name = "MainForm";
            this.Text = "Orchard Slots";
            ((System.ComponentModel.ISupportInitialize)(this.slotLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotMiddlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotRightPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slotLeftPictureBox;
        private System.Windows.Forms.PictureBox slotMiddlePictureBox;
        private System.Windows.Forms.PictureBox slotRightPictureBox;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Button exitButton;
    }
}

