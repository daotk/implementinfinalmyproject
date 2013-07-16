﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using log4net;
using System.IO;

namespace GUI
{
    public partial class frm_MainForm : Form
    {
        string nhomnguoidung = "Nhóm người dùng";
        string nguoidung = "Người dùng";
        string tinhthanhpho = "Danh mục Tỉnh - Thành Phố";
        string quanhuyen = "Danh mục Quận - Huyện";
        string loaiphongban = "Danh mục loại phòng ban";
        string phongban = "Danh mục phòng ban";
        string nhomdichvu = "Danh mục nhóm dịch vụ";
        string dichvu = "Danh mục dịch vụ";
        string bienlaiduoclap = "Danh sách biên lai được lập";
        string bienlaiduocthutien = "Danh sách biên lai được thu tiền";
        string danhsachthutien = "Danh sách thu tiền";
        string doanhthu = "Thống kê doanh thu";
        string nhaplieu1 = "Nhập liệu 1";
        string thungan1 = "Thu ngân 1";
        string phanquyen = "Phân quyền";
        bool tabnhaplieu = false;
        bool tabthungan = false;
        bool chonban = false;

        public frm_MainForm()
        {
            InitializeComponent();
        }

        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private void Main_Load(object sender, EventArgs e)
        {
            lbl_TenBenhVien.Text = "Bệnh Viện ABC";
            lbl_UserName.Text = "Người dùng: " + BL.StaticClass.UserName + " (" + BL.StaticClass.GroupUser + ")";
            lbl_NgayThang.Text = "Ngày tháng: " + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            lbl_NgayGio.Text = "Giờ: " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            SetAuthorization(BL.StaticClass.Authorization);
            timer1.Start();
            //Load don vi
            List<DO.ThuNgan.Department_TN_DO> ds = BL.ThuNgan.Department_TN_BL.GetAllDepart();
            for (int i = 0; i < ds.Count(); i++)
            {
                if (ds[i]._DEPARTMENTTYPEID.Contains("TN"))
                {
                    RibbonButton btn = new RibbonButton();
                    btn.Text = ds[i]._DEPARTMENTNAME.ToString();
                    cbo_ChonDonVi.DropDownItems.Add(btn);
                }
            }
        }

        private void cbo_ChonDonVi_TextBoxTextChanged(object sender, EventArgs e)
        {
            cbo_ChonBan.DropDownItems.Clear();
            List<DO.ThuNgan.Desk_DO> ds = BL.ThuNgan.Desk_BL.GetAllDesk();
            for (int i = 0; i < ds.Count(); i++)
            {
                if (ds[i]._DEPARTMENTNAME.Contains(cbo_ChonDonVi.SelectedItem.Text))
                {
                    RibbonButton btn = new RibbonButton();
                    btn.Text = ds[i]._DESKNAME;
                    cbo_ChonBan.DropDownItems.Add(btn);
                }
            }
            chk_NhapLieu.Enabled = false;
            chk_ThuNgan.Enabled = false;
            //Lay don vu phong ban
            BL.StaticClass.donvithungan = cbo_ChonDonVi.SelectedItem.Text;
        }

        private void cbo_ChonBan_TextBoxTextChanged(object sender, EventArgs e)
        {
            List<DO.ThuNgan.Desk_DO> ds = BL.ThuNgan.Desk_BL.GetDesk(cbo_ChonBan.SelectedItem.Text);
            for (int i = 0; i < ds.Count(); i++)
            {
                //thu ngan
                if (ds[i]._CASHIER == false)
                {
                    chk_ThuNgan.Enabled = true;
                }
                else
                {
                    if (ds[i]._CASHIER == true)
                    {
                        chk_ThuNgan.Enabled = false;
                    }
                }
                //nhap lieu
                if (ds[i]._TYPIST == false)
                {
                    chk_NhapLieu.Enabled = true;
                }
                else
                {
                    if (ds[i]._TYPIST == true)
                    {
                        chk_NhapLieu.Enabled = false;
                    }
                }
                BL.StaticClass.tenbanthungan = ds[i]._DESKNAME;
                BL.StaticClass.banthungan = ds[i]._DESKID;
            }
            chonban = true;
        }

        private void LoadHospitalName()
        {
            lbl_TenBenhVien.Text = BL.StaticClass.tenbenhvien;
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cảm ơn bạn đã sử dụng phần mềm của chúng tôi.\nNếu có gặp khó khăn trong quá trình sử dụng các bạn có thể liên lạc với chúng tôi qua mail: team02k16t01@googlegroup.com.\nDH Văn Lang\nK16T01\nTeam 02");
        }

        private void btn_Changepass_Click(object sender, EventArgs e)
        {
            ChangePassword changepass = new ChangePassword();
            changepass.ShowDialog();
        }

        private void btn_NhomNguoiDung_Click(object sender, EventArgs e)
        {
            logger.Info(BL.StaticClass.UserName + " đã vào danh mục nhóm người dùng");
            if (checkTab(nhomnguoidung) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(nhomnguoidung);
                QuanTriHeThong.frm_GroupUser k = new QuanTriHeThong.frm_GroupUser();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void btn_nguoidung_Click(object sender, EventArgs e)
        {
            logger.Info(BL.StaticClass.UserName + " đã vào danh mục người dùng");
            if (checkTab(nguoidung) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(nguoidung);
                QuanTriHeThong.frm_User k = new QuanTriHeThong.frm_User();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void btn_PhanQuyen_Click(object sender, EventArgs e)
        {
            logger.Info(BL.StaticClass.UserName + " đã vào phân quyền");
            if (checkTab(phanquyen) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(phanquyen);
                GUI.PhanQuyen k = new PhanQuyen();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void btn_TinhThanhPho_Click(object sender, EventArgs e)
        {
            logger.Info(BL.StaticClass.UserName + " đã vào danh mục Tỉnh - Thành phố");
            tab_MainTab.Visible = true;
            if (checkTab(tinhthanhpho) == false)
            {
                TabItem t = tab_MainTab.CreateTab(tinhthanhpho);
                QuanTriHeThong.frm_City k = new QuanTriHeThong.frm_City();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void btn_QuanHuyen_Click(object sender, EventArgs e)
        {
            logger.Info(BL.StaticClass.UserName + " đã vào danh mục Quận - Huyện");
            if (checkTab(quanhuyen) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(quanhuyen);
                QuanTriHeThong.frm_District k = new QuanTriHeThong.frm_District();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void btn_LoaiPhongBan_Click(object sender, EventArgs e)
        {
            logger.Info(BL.StaticClass.UserName + " đã vào danh mục loại phòng ban");
            if (checkTab(loaiphongban) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(loaiphongban);
                QuanTriHeThong.frm_TypeDepartment k = new QuanTriHeThong.frm_TypeDepartment();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }


        private void btn_PhongBan1_Click(object sender, EventArgs e)
        {
            logger.Info(BL.StaticClass.UserName + " đã vào danh mục phòng ban");
            if (checkTab(phongban) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(phongban);
                QuanTriHeThong.frm_Department k = new QuanTriHeThong.frm_Department();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void btn_LoaiDichVu_Click(object sender, EventArgs e)
        {
            logger.Info(BL.StaticClass.UserName + " đã vào danh mục nhóm dịch vụ");
            if (checkTab(nhomdichvu) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(nhomdichvu);
                QuanTriHeThong.frm_TypeService k = new QuanTriHeThong.frm_TypeService();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void btn_dichvu_Click(object sender, EventArgs e)
        {
            logger.Info(BL.StaticClass.UserName + " đã vào danh mục dịch vụ");
            if (checkTab(dichvu) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(dichvu);
                QuanTriHeThong.frm_Service k = new QuanTriHeThong.frm_Service();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void btn_BienLaiDuocLap_Click(object sender, EventArgs e)
        {
            logger.Info(BL.StaticClass.UserName + " đã vào thống kê danh sách biên lai được lập");
            if (checkTab(bienlaiduoclap) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(bienlaiduoclap);
                BaoCao.frm_CreatedBillFollowStaff k = new BaoCao.frm_CreatedBillFollowStaff();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void btn_BienLaiDuocThuTien_Click(object sender, EventArgs e)
        {
            logger.Info(BL.StaticClass.UserName + " đã vào thống kê danh sách biên lai được thu tiền");
            if (checkTab(bienlaiduocthutien) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(bienlaiduocthutien);
                BaoCao.DSBienLaiDuocThuTien k = new BaoCao.DSBienLaiDuocThuTien();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }

        }

        private void btn_DanhSachThuTienTheoNhomDichVu_Click(object sender, EventArgs e)
        {
            logger.Info(BL.StaticClass.UserName + " đã vào thống kê danh sách biên lai được thu tiền theo nhóm dịch vụ");
            if (checkTab(danhsachthutien) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(danhsachthutien);
                BaoCao.frm_ListBill k = new BaoCao.frm_ListBill();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            logger.Info(BL.StaticClass.UserName + " đã vào thống kê doanh thu");
            if (checkTab(doanhthu) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(doanhthu);
                BaoCao.DoanhThu k = new BaoCao.DoanhThu();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void btn_CauHinh_Click(object sender, EventArgs e)
        {
            frm_Config config = new frm_Config();
            if (config.ShowDialog() == DialogResult.Cancel || config.ShowDialog() == DialogResult.OK)
            {
                LoadHospitalName();
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            if (tab_MainTab.Tabs.Count == 0)
            {
                DialogResult result = MessageBox.Show(" Bạn chắc chắn muốn đăng xuất khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    BL.QuanTriHeThong.User_BL.UpdateStatusOnline(BL.StaticClass.UserID, false);
                    frm_Login login = new frm_Login();
                    login.Show();
                    logger.Info(BL.StaticClass.UserName + " đã đăng xuất");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải đóng hết tab để đăng xuất");
            }
        }

        private bool checkTab(string name)
        {
            for (int i = 0; i < tab_MainTab.Tabs.Count; i++)
            {
                if (tab_MainTab.Tabs[i].Text == name)
                {
                    tab_MainTab.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_NgayGio.Text = "Giờ: " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            if (checkTab(nhaplieu1) == true)
            {
                MessageBox.Show("Bạn đang ở vị trí nhập liệu bàn 1. Bạn không thể tham gia vào nhập liệu bàn 2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (checkTab(thungan1) == true)
            {
                MessageBox.Show("Bạn đang ở vị trí thu ngân bàn 1. Bạn không thể tham gia vào thu ngân bàn 2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tabControl1_TabRemoved(object sender, EventArgs e)
        {
            if (tabnhaplieu == true)
            {
                BL.ThuNgan.Desk_BL.UpdateTypistInfo(BL.StaticClass.tenbanthungan, false);
                tabnhaplieu = false;
            }
            if (tabthungan == true)
            {
                tabthungan = false;
                BL.ThuNgan.Desk_BL.UpdateCashierInfo(BL.StaticClass.tenbanthungan, false);
            }
            if (tab_MainTab.Tabs.Count == 0)
            {
                pic_Bacground.Visible = true;
                tab_MainTab.Visible = false;
            }
        }

        private void btn_BatDau_Click(object sender, EventArgs e)
        {
            if (chonban == true)
            {
                if (chk_NhapLieu.Checked == true && chk_NhapLieu.Enabled == true && checkTab(thungan1) == false)
                {
                    if (checkTab(nhaplieu1) == false)
                    {
                        MoGiaoDienNhapLieu();
                        BL.ThuNgan.Desk_BL.UpdateTypistInfo(cbo_ChonBan.SelectedItem.Text.ToString(), true);
                        tabnhaplieu = true;
                        logger.Info(BL.StaticClass.UserName + " đã vào thu ngân");
                    }
                }
                else
                {
                    if (chk_ThuNgan.Checked == true && chk_ThuNgan.Enabled == true && checkTab(nhaplieu1) == false)
                    {
                        if (checkTab(thungan1) == false)
                        {
                            MoGiaoDienThuNgan();
                            BL.ThuNgan.Desk_BL.UpdateCashierInfo(cbo_ChonBan.SelectedItem.Text.ToString(), true);
                            tabthungan = true;
                            logger.Info(BL.StaticClass.UserName + " đã vào nhập liệu");
                        }
                    }
                }
            }
            else { MessageBox.Show("Bạn chưa chọn bàn"); }
        }//end event button start

        private void MoGiaoDienNhapLieu()
        {
            if (checkTab(nhaplieu1) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(nhaplieu1);
                ThuNgan.frm_InputData k = new ThuNgan.frm_InputData();
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void MoGiaoDienThuNgan()
        {
            if (checkTab(thungan1) == false)
            {
                tab_MainTab.Visible = true;
                TabItem t = tab_MainTab.CreateTab(thungan1);
                ThuNgan.frm_Cashier k = new ThuNgan.frm_Cashier(BL.StaticClass.banthungan);
                k.TopLevel = false;
                k.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(k);
                k.Show();
                tab_MainTab.SelectedTabIndex = tab_MainTab.Tabs.Count - 1;
                pic_Bacground.Visible = false;
            }
        }

        private void SetAuthorization(string authorization)
        {
            if (authorization[0].ToString() == "0") { btn_CauHinh.Enabled = false; }
            if (authorization[1].ToString() == "0") { btn_NhomNguoiDung.Enabled = false; }
            if (authorization[2].ToString() == "0") { btn_nguoidung.Enabled = false; }
            if (authorization[3].ToString() == "0") { btn_PhanQuyen.Enabled = false; }
            if (authorization[4].ToString() == "0") { btn_TinhThanhPho.Enabled = false; }
            if (authorization[5].ToString() == "0") { btn_Quan.Enabled = false; }
            if (authorization[6].ToString() == "0") { btn_LoaiPhongBan.Enabled = false; }
            if (authorization[7].ToString() == "0") { btn_PhongBan.Enabled = false; }
            if (authorization[8].ToString() == "0") { btn_NhomDichVu.Enabled = false; }
            if (authorization[9].ToString() == "0") { btn_DichVu.Enabled = false; }
            if (authorization[10].ToString() == "0") { btn_BatDau.Enabled = false; }
            if (authorization[11].ToString() == "0") { btn_BienLaiDuocLap.Enabled = false; }
            if (authorization[12].ToString() == "0") { btn_BienLaiDuocThuTien.Enabled = false; }
            if (authorization[13].ToString() == "0") { btn_DanhSachThuTienTheoNhomDichVu.Enabled = false; }
            if (authorization[14].ToString() == "0") { btn_DoanhThu.Enabled = false; }
        }

        private void frm_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Chương trình sẽ đóng hết tab trước khi thoát", "Thông báo");
                for (int i = 0; i < tab_MainTab.Tabs.Count; i++)
                {
                    tab_MainTab.Tabs.RemoveAt(i);
                }
                this.Hide();
                BL.QuanTriHeThong.User_BL.UpdateStatusOnline(BL.StaticClass.UserID, false);
                frm_Login login = new frm_Login();
                login.Show();
                logger.Info(BL.StaticClass.UserName + " đã thoát");
            }
            else
            {
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Chương trình sẽ đóng hết tab trước khi thoát", "Thông báo");
                    for (int i = 0; i < tab_MainTab.Tabs.Count; i++)
                    {
                        tab_MainTab.Tabs.RemoveAt(i);
                    }
                    logger.Info(BL.StaticClass.UserName + "  Has to Logout");
                    BL.QuanTriHeThong.User_BL.UpdateStatusOnline(BL.StaticClass.UserID, false);
                    this.Close();
                }
                else
                {
                    if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}
