namespace Card_Identifier
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
			this.fiveDiamondsPBox = new System.Windows.Forms.PictureBox();
			this.tenSpadesPBox = new System.Windows.Forms.PictureBox();
			this.twoHeartsPBox = new System.Windows.Forms.PictureBox();
			this.queenHeartsPBox = new System.Windows.Forms.PictureBox();
			this.kingClubsPBox = new System.Windows.Forms.PictureBox();
			this.cardDescLabel = new System.Windows.Forms.Label();
			this.instructionLabel = new System.Windows.Forms.Label();
			this.exitButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.fiveDiamondsPBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tenSpadesPBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.twoHeartsPBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.queenHeartsPBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kingClubsPBox)).BeginInit();
			this.SuspendLayout();
			// 
			// fiveDiamondsPBox
			// 
			this.fiveDiamondsPBox.Image = global::Card_Identifier.Properties.Resources._5_Diamonds;
			this.fiveDiamondsPBox.Location = new System.Drawing.Point(15, 65);
			this.fiveDiamondsPBox.Name = "fiveDiamondsPBox";
			this.fiveDiamondsPBox.Size = new System.Drawing.Size(100, 160);
			this.fiveDiamondsPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.fiveDiamondsPBox.TabIndex = 0;
			this.fiveDiamondsPBox.TabStop = false;
			this.fiveDiamondsPBox.Click += new System.EventHandler(this.fiveDiamondsPBox_Click);
			// 
			// tenSpadesPBox
			// 
			this.tenSpadesPBox.Image = global::Card_Identifier.Properties.Resources._10_Spades;
			this.tenSpadesPBox.Location = new System.Drawing.Point(245, 65);
			this.tenSpadesPBox.Name = "tenSpadesPBox";
			this.tenSpadesPBox.Size = new System.Drawing.Size(100, 160);
			this.tenSpadesPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.tenSpadesPBox.TabIndex = 1;
			this.tenSpadesPBox.TabStop = false;
			this.tenSpadesPBox.Click += new System.EventHandler(this.tenSpadesPBox_Click);
			// 
			// twoHeartsPBox
			// 
			this.twoHeartsPBox.Image = global::Card_Identifier.Properties.Resources._2_Hearts;
			this.twoHeartsPBox.Location = new System.Drawing.Point(130, 65);
			this.twoHeartsPBox.Name = "twoHeartsPBox";
			this.twoHeartsPBox.Size = new System.Drawing.Size(100, 160);
			this.twoHeartsPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.twoHeartsPBox.TabIndex = 2;
			this.twoHeartsPBox.TabStop = false;
			this.twoHeartsPBox.Click += new System.EventHandler(this.twoHeartsPBox_Click);
			// 
			// queenHeartsPBox
			// 
			this.queenHeartsPBox.Image = global::Card_Identifier.Properties.Resources.Queen_Hearts;
			this.queenHeartsPBox.Location = new System.Drawing.Point(360, 65);
			this.queenHeartsPBox.Name = "queenHeartsPBox";
			this.queenHeartsPBox.Size = new System.Drawing.Size(100, 160);
			this.queenHeartsPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.queenHeartsPBox.TabIndex = 3;
			this.queenHeartsPBox.TabStop = false;
			this.queenHeartsPBox.Click += new System.EventHandler(this.queenHeartsPBox_Click);
			// 
			// kingClubsPBox
			// 
			this.kingClubsPBox.Image = global::Card_Identifier.Properties.Resources.King_Clubs;
			this.kingClubsPBox.Location = new System.Drawing.Point(475, 65);
			this.kingClubsPBox.Name = "kingClubsPBox";
			this.kingClubsPBox.Size = new System.Drawing.Size(100, 160);
			this.kingClubsPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.kingClubsPBox.TabIndex = 4;
			this.kingClubsPBox.TabStop = false;
			this.kingClubsPBox.Click += new System.EventHandler(this.kingClubsPBox_Click);
			// 
			// cardDescLabel
			// 
			this.cardDescLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cardDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cardDescLabel.Location = new System.Drawing.Point(45, 250);
			this.cardDescLabel.Name = "cardDescLabel";
			this.cardDescLabel.Size = new System.Drawing.Size(500, 32);
			this.cardDescLabel.TabIndex = 5;
			this.cardDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// instructionLabel
			// 
			this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.instructionLabel.Location = new System.Drawing.Point(45, 13);
			this.instructionLabel.Name = "instructionLabel";
			this.instructionLabel.Size = new System.Drawing.Size(500, 32);
			this.instructionLabel.TabIndex = 6;
			this.instructionLabel.Text = "Click a Card to See Its Name";
			this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// exitButton
			// 
			this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.Location = new System.Drawing.Point(260, 300);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 33);
			this.exitButton.TabIndex = 7;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 359);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.instructionLabel);
			this.Controls.Add(this.cardDescLabel);
			this.Controls.Add(this.kingClubsPBox);
			this.Controls.Add(this.queenHeartsPBox);
			this.Controls.Add(this.twoHeartsPBox);
			this.Controls.Add(this.tenSpadesPBox);
			this.Controls.Add(this.fiveDiamondsPBox);
			this.Name = "Form1";
			this.Text = "Card Identifier";
			((System.ComponentModel.ISupportInitialize)(this.fiveDiamondsPBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tenSpadesPBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.twoHeartsPBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.queenHeartsPBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kingClubsPBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox fiveDiamondsPBox;
		private System.Windows.Forms.PictureBox tenSpadesPBox;
		private System.Windows.Forms.PictureBox twoHeartsPBox;
		private System.Windows.Forms.PictureBox queenHeartsPBox;
		private System.Windows.Forms.PictureBox kingClubsPBox;
		private System.Windows.Forms.Label cardDescLabel;
		private System.Windows.Forms.Label instructionLabel;
		private System.Windows.Forms.Button exitButton;
	}
}

