namespace Dice_Simulator
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
			this.title_Label = new System.Windows.Forms.Label();
			this.exitBtn = new System.Windows.Forms.Button();
			this.rollBtn = new System.Windows.Forms.Button();
			this.die1Img = new System.Windows.Forms.PictureBox();
			this.die1Txtbox = new System.Windows.Forms.TextBox();
			this.die2Txtbox = new System.Windows.Forms.TextBox();
			this.die2Img = new System.Windows.Forms.PictureBox();
			this.resetBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.die1Img)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.die2Img)).BeginInit();
			this.SuspendLayout();
			// 
			// title_Label
			// 
			this.title_Label.AutoSize = true;
			this.title_Label.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title_Label.ForeColor = System.Drawing.Color.Crimson;
			this.title_Label.Location = new System.Drawing.Point(2, 21);
			this.title_Label.Name = "title_Label";
			this.title_Label.Size = new System.Drawing.Size(274, 42);
			this.title_Label.TabIndex = 0;
			this.title_Label.Text = "Dice Simulator";
			// 
			// exitBtn
			// 
			this.exitBtn.BackColor = System.Drawing.Color.Crimson;
			this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exitBtn.ForeColor = System.Drawing.SystemColors.Window;
			this.exitBtn.Location = new System.Drawing.Point(99, 306);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(75, 23);
			this.exitBtn.TabIndex = 1;
			this.exitBtn.Text = "Exit";
			this.exitBtn.UseVisualStyleBackColor = false;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// rollBtn
			// 
			this.rollBtn.BackColor = System.Drawing.Color.Crimson;
			this.rollBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rollBtn.ForeColor = System.Drawing.SystemColors.Window;
			this.rollBtn.Location = new System.Drawing.Point(99, 227);
			this.rollBtn.Name = "rollBtn";
			this.rollBtn.Size = new System.Drawing.Size(75, 23);
			this.rollBtn.TabIndex = 2;
			this.rollBtn.Text = "Roll";
			this.rollBtn.UseVisualStyleBackColor = false;
			this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
			// 
			// die1Img
			// 
			this.die1Img.Image = global::Dice_Simulator.Properties.Resources.Die1;
			this.die1Img.InitialImage = global::Dice_Simulator.Properties.Resources.Die1;
			this.die1Img.Location = new System.Drawing.Point(21, 76);
			this.die1Img.Name = "die1Img";
			this.die1Img.Size = new System.Drawing.Size(107, 105);
			this.die1Img.TabIndex = 4;
			this.die1Img.TabStop = false;
			// 
			// die1Txtbox
			// 
			this.die1Txtbox.ForeColor = System.Drawing.Color.Crimson;
			this.die1Txtbox.Location = new System.Drawing.Point(21, 187);
			this.die1Txtbox.Name = "die1Txtbox";
			this.die1Txtbox.ReadOnly = true;
			this.die1Txtbox.Size = new System.Drawing.Size(107, 20);
			this.die1Txtbox.TabIndex = 5;
			this.die1Txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// die2Txtbox
			// 
			this.die2Txtbox.ForeColor = System.Drawing.Color.Crimson;
			this.die2Txtbox.Location = new System.Drawing.Point(148, 187);
			this.die2Txtbox.Name = "die2Txtbox";
			this.die2Txtbox.ReadOnly = true;
			this.die2Txtbox.Size = new System.Drawing.Size(107, 20);
			this.die2Txtbox.TabIndex = 6;
			this.die2Txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// die2Img
			// 
			this.die2Img.Image = global::Dice_Simulator.Properties.Resources.Die1;
			this.die2Img.Location = new System.Drawing.Point(148, 76);
			this.die2Img.Name = "die2Img";
			this.die2Img.Size = new System.Drawing.Size(107, 105);
			this.die2Img.TabIndex = 7;
			this.die2Img.TabStop = false;
			// 
			// resetBtn
			// 
			this.resetBtn.BackColor = System.Drawing.Color.Crimson;
			this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.resetBtn.ForeColor = System.Drawing.SystemColors.Window;
			this.resetBtn.Location = new System.Drawing.Point(99, 267);
			this.resetBtn.Name = "resetBtn";
			this.resetBtn.Size = new System.Drawing.Size(75, 23);
			this.resetBtn.TabIndex = 8;
			this.resetBtn.Text = "Reset";
			this.resetBtn.UseVisualStyleBackColor = false;
			this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LawnGreen;
			this.ClientSize = new System.Drawing.Size(277, 341);
			this.Controls.Add(this.resetBtn);
			this.Controls.Add(this.die2Img);
			this.Controls.Add(this.die2Txtbox);
			this.Controls.Add(this.die1Txtbox);
			this.Controls.Add(this.die1Img);
			this.Controls.Add(this.rollBtn);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.title_Label);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.die1Img)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.die2Img)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title_Label;
		private System.Windows.Forms.Button exitBtn;
		private System.Windows.Forms.Button rollBtn;
		private System.Windows.Forms.PictureBox die1Img;
		private System.Windows.Forms.TextBox die1Txtbox;
		private System.Windows.Forms.TextBox die2Txtbox;
		private System.Windows.Forms.PictureBox die2Img;
		private System.Windows.Forms.Button resetBtn;
	}
}

