using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;
using System.Threading;

namespace GUI
{
    public partial class frm_Config : Form
    {
        Thread t;
        public frm_Config()
        {
            t = new Thread(new ThreadStart(LoadOpenForm));
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

            if (chk_OpenBig.Checked == true)
            {
                BL.StaticClass.OpenBigScreen = true;
            }
            else
            {
                BL.StaticClass.OpenBigScreen = false;
            }
            if (BL.StaticClass.OpenBigScreen == true)
            {
                t.Start();
            }
            else
            {
                t.Abort();
            }
            BL.StaticClass.tenbenhvien = txt_TenBenhVien.Text;
            BL.StaticClass.tenbenhvien = txt_TenBenhVien.Text;
            BL.StaticClass.matkhaumacdinh = txt_Matkhaumacdinh.Text;
            MessageBox.Show("Cập nhật thành công");
        }

        private void LoadOpenForm()
        {
            Application.Run(new BigScreen());
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_Config_Load(object sender, EventArgs e)
        {
            if (BL.StaticClass.OpenBigScreen == true)
            {
                chk_OpenBig.Checked = true;
            }
            else
            {
                chk_OpenBig.Checked = false;
            }
        }
    }
}