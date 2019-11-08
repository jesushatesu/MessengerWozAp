﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using WOZAP;

namespace MainWindow
{

	public partial class UserWindow : Form, IServerChatCallback
	{
		private SingInWindow _singInWindow;
		private string _userName;
        private List<ChatUser> _allUsers;
        WOZAP.IService service;
         
		public UserWindow(string userName, SingInWindow singInWindow)
		{
            InitializeComponent();
			_userName = userName;
			_singInWindow = singInWindow;
            this.userName.Text = userName;
			List<User> allUsers;

			//service.Connect(_userName, out allUsers);
			//foreach (User user in allUsers)
			//{
			//	_allUsers.Add(new ChatUser { name = user.name, isConnected = user.isConnected });

			//}
			ChatUser u1 = new ChatUser { name = "user1", isConnected = true , haveMsg = true };
			ChatUser u2 = new ChatUser { name = "user2", isConnected = false , haveMsg = false };
			ChatUser u3 = new ChatUser { name = "user3", isConnected = true , haveMsg = true };
			_allUsers.Add(u1);
			_allUsers.Add(u2);
			_allUsers.Add(u3);
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			this.Close();
			_singInWindow.Close();
		}

		private void closeButton_MouseEnter(object sender, EventArgs e)
		{
			this.closeButton.BackColor = Color.Red;
		}

		private void closeButton_MouseLeave(object sender, EventArgs e)
		{
			this.closeButton.BackColor = Color.FromArgb(62, 128, 182);
		}

		private void buttonMinimized_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void buttonMinimized_MouseEnter(object sender, EventArgs e)
		{
			this.buttonMinimized.BackColor = Color.FromArgb(131, 175, 230);
		}

		private void buttonMinimized_MouseLeave(object sender, EventArgs e)
		{
			this.buttonMinimized.BackColor = Color.FromArgb(62, 128, 182);
		}

		private void buttonLogOut_Click(object sender, EventArgs e)
		{
			this.Close();
			_singInWindow.Show();
		}

		public void MsgCallback(string fromUser, string msg)
		{
			
		}

		// Тут может быть вопрос с циклом List.ForEach
		public void ConnectUserCallback(string userName)
		{
			bool flag = true;
			_allUsers.ForEach(user =>
			{ 
				if (user.name == userName) 
				{
					user.isConnected = true;
					flag = false;
				} 
			});

			if (flag)
			{
				_allUsers.Add(new ChatUser { name = userName, isConnected = true, haveMsg = false });
			}
		}

		// Тут может быть вопрос с циклом List.ForEach
		public void DisconnectUserCallback(string userName)
		{
			_allUsers.ForEach(user =>
			{
				if (user.name == userName)
				{
					user.isConnected = false;
				}
			});
		}

    
	}
}
