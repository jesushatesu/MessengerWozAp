﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
	public partial class UserListItem : UserControl
	{

		public UserListItem()
		{
			InitializeComponent();
		}

		#region Properties

		private string _userName;
		private Image _connectedImage;
		private Image _haveMsgImage;

		[Category("Custom Props")]
		public string UserName
		{
			get { return _userName; }
			set { _userName = value; this.userNameLabel.Text = value; }
		}

		[Category("Custom Props")]
		public Image ConnectedImage
		{
			get { return _connectedImage; }
			set { _connectedImage = value; this.isConnectImage.Image = value; }
		}

		[Category("Custom Props")]
		public Image HaveMsgImage
		{
			get { return _haveMsgImage; }
			set { _haveMsgImage = value; this.haveMsgImage.Image = value; }
		}

		#endregion

		private void UserListItem_MouseMove(object sender, MouseEventArgs e)
		{
			this.BackColor = Color.FromArgb(159, 156, 202);
			this.haveMsgImage.BackColor = Color.FromArgb(159, 156, 202);
		}

		private void UserListItem_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = Color.White;
			this.haveMsgImage.BackColor = Color.White;
		}

		private void userNameLabel_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = Color.White;
			this.haveMsgImage.BackColor = Color.White;
		}

		private void isConnectImage_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = Color.White;
			this.haveMsgImage.BackColor = Color.White;
		}

		private void haveMsgImage_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = Color.White;
			this.haveMsgImage.BackColor = Color.White;
		}

		private void userNameLabel_MouseMove(object sender, MouseEventArgs e)
		{
			this.BackColor = Color.FromArgb(159, 156, 202);
			this.haveMsgImage.BackColor = Color.FromArgb(159, 156, 202);
		}

		private void haveMsgImage_MouseMove(object sender, MouseEventArgs e)
		{
			this.BackColor = Color.FromArgb(159, 156, 202);
			this.haveMsgImage.BackColor = Color.FromArgb(159, 156, 202);
		}

		private void isConnectImage_MouseMove(object sender, MouseEventArgs e)
		{
			this.BackColor = Color.FromArgb(159, 156, 202);
			this.haveMsgImage.BackColor = Color.FromArgb(159, 156, 202);
		}
	}
}