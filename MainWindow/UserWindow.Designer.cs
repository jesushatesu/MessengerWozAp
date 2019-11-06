﻿namespace MainWindow
{
	partial class UserWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWindow));
            this.mainFoneSingIn = new System.Windows.Forms.Panel();
            this.Left = new System.Windows.Forms.Panel();
            this.userInfoBox = new System.Windows.Forms.Panel();
            this.userName = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.topblokAuth = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wozzup = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMinimized = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.mainFoneSingIn.SuspendLayout();
            this.Left.SuspendLayout();
            this.userInfoBox.SuspendLayout();
            this.topblokAuth.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFoneSingIn
            // 
            this.mainFoneSingIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(191)))), ((int)(((byte)(239)))));
            this.mainFoneSingIn.Controls.Add(this.Left);
            this.mainFoneSingIn.Controls.Add(this.topblokAuth);
            this.mainFoneSingIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFoneSingIn.Location = new System.Drawing.Point(0, 0);
            this.mainFoneSingIn.Margin = new System.Windows.Forms.Padding(2);
            this.mainFoneSingIn.Name = "mainFoneSingIn";
            this.mainFoneSingIn.Size = new System.Drawing.Size(781, 466);
            this.mainFoneSingIn.TabIndex = 1;
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.Left.Controls.Add(this.userInfoBox);
            this.Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left.Location = new System.Drawing.Point(0, 28);
            this.Left.Margin = new System.Windows.Forms.Padding(2);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(298, 438);
            this.Left.TabIndex = 7;
            // 
            // userInfoBox
            // 
            this.userInfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.userInfoBox.Controls.Add(this.userName);
            this.userInfoBox.Controls.Add(this.buttonLogOut);
            this.userInfoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.userInfoBox.Location = new System.Drawing.Point(0, 0);
            this.userInfoBox.Margin = new System.Windows.Forms.Padding(2);
            this.userInfoBox.Name = "userInfoBox";
            this.userInfoBox.Size = new System.Drawing.Size(298, 49);
            this.userInfoBox.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(9, 11);
            this.userName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(105, 24);
            this.userName.TabIndex = 1;
            this.userName.Text = "LoginUser";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(182, 11);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(113, 24);
            this.buttonLogOut.TabIndex = 0;
            this.buttonLogOut.Text = "log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // topblokAuth
            // 
            this.topblokAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.topblokAuth.Controls.Add(this.panel2);
            this.topblokAuth.Controls.Add(this.buttonMinimized);
            this.topblokAuth.Controls.Add(this.closeButton);
            this.topblokAuth.Dock = System.Windows.Forms.DockStyle.Top;
            this.topblokAuth.Location = new System.Drawing.Point(0, 0);
            this.topblokAuth.Margin = new System.Windows.Forms.Padding(2);
            this.topblokAuth.Name = "topblokAuth";
            this.topblokAuth.Size = new System.Drawing.Size(781, 28);
            this.topblokAuth.TabIndex = 6;
        
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.wozzup);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 28);
            this.panel2.TabIndex = 5;
            // 
            // wozzup
            // 
            this.wozzup.AutoSize = true;
            this.wozzup.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wozzup.Location = new System.Drawing.Point(28, 2);
            this.wozzup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wozzup.Name = "wozzup";
            this.wozzup.Size = new System.Drawing.Size(70, 26);
            this.wozzup.TabIndex = 2;
            this.wozzup.Text = "Wozzup";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(7, 3);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMinimized
            // 
            this.buttonMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimized.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimized.Image")));
            this.buttonMinimized.Location = new System.Drawing.Point(730, 2);
            this.buttonMinimized.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinimized.Name = "buttonMinimized";
            this.buttonMinimized.Size = new System.Drawing.Size(19, 20);
            this.buttonMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonMinimized.TabIndex = 4;
            this.buttonMinimized.TabStop = false;
            this.buttonMinimized.Click += new System.EventHandler(this.buttonMinimized_Click);
            this.buttonMinimized.MouseEnter += new System.EventHandler(this.buttonMinimized_MouseEnter);
            this.buttonMinimized.MouseLeave += new System.EventHandler(this.buttonMinimized_MouseLeave);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(753, 2);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(19, 20);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 3;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 466);
            this.Controls.Add(this.mainFoneSingIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserWindow";
            this.mainFoneSingIn.ResumeLayout(false);
            this.Left.ResumeLayout(false);
            this.userInfoBox.ResumeLayout(false);
            this.userInfoBox.PerformLayout();
            this.topblokAuth.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel mainFoneSingIn;
		private System.Windows.Forms.Panel topblokAuth;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label wozzup;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox buttonMinimized;
		private System.Windows.Forms.PictureBox closeButton;
		private new System.Windows.Forms.Panel Left;
		private System.Windows.Forms.Panel userInfoBox;
		private System.Windows.Forms.Label userName;
		private System.Windows.Forms.Button buttonLogOut;
	}
}