﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;

namespace GUI
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private void frm_Login_Load(object sender, EventArgs e)
        {
            BL.QuanTriHeThong.User_BL.GetAllUserInfo();            
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string strUsername = "";
            string strPassword = "";
            if (txt_UserName.Text != "" && txt_Password.Text != "")
            {
                strUsername = txt_UserName.Text;
                strPassword = BL.MD5_BL.GetMD5(txt_Password.Text);
                bool check = BL.QuanTriHeThong.User_BL.CheckLogin(strUsername, strPassword);
                if (check == true)
                {
                    if (BL.StaticClass.StatusUser == true)
                    {
                        if (BL.StaticClass.Online == false)
                        {
                            this.Hide();
                            BL.QuanTriHeThong.User_BL.UpdateStatusOnline(BL.StaticClass.UserID, true);
                            frm_MainForm main = new frm_MainForm();
                            main.Show();
                            logger.Info(BL.StaticClass.UserName + " Login");
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản đang đăng nhập", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản của bạn không thề sử dụng. Liên hệ quản lý để biết thêm chi tiết", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                }
                else { MessageBox.Show("Bạn đã nhập sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning); }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}