using System;
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
        string nhaplieu1 = "Nhập liệu";
        string thungan1 = "Thu ngân";
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
            lbl_NgayThang.Text = "Thứ " + ThuTuongUng() + " ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month.ToString() + " năm " + DateTime.Now.Year.ToString();
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
            logger.Info(BL.StaticClass.UserName + " has to group user catalog");
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
            logger.Info(BL.StaticClass.UserName + " has to user catalog");
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
            logger.Info(BL.StaticClass.UserName + " has to permission");
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
            logger.Info(BL.StaticClass.UserName + " has to city catalog");
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
            logger.Info(BL.StaticClass.UserName + " has to district catalog");
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
            logger.Info(BL.StaticClass.UserName + " has to derpartment type catalog");
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
            logger.Info(BL.StaticClass.UserName + " has to department catalog");
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
            logger.Info(BL.StaticClass.UserName + " has to group service catalog");
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
            logger.Info(BL.StaticClass.UserName + " has to service catalog");
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
            logger.Info(BL.StaticClass.UserName + " has to list bill was created");
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
            logger.Info(BL.StaticClass.UserName + " has to list bill was payment");
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
            logger.Info(BL.StaticClass.UserName + " has to list bill was payment follow group service");
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
            logger.Info(BL.StaticClass.UserName + " has to revenue statistics");
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
                DialogResult result = MessageBox.Show(" Bạn chắc chắn muốn đăng xuất khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < tab_MainTab.Tabs.Count; i++)
                    {
                        tab_MainTab.Tabs.RemoveAt(i);
                    }
                    this.Hide();
                    BL.QuanTriHeThong.User_BL.UpdateStatusOnline(BL.StaticClass.UserID, false);
                    frm_Login login = new frm_Login();
                    login.Show();
                    logger.Info(BL.StaticClass.UserName + " has to logout");
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
                if (chk_NhapLieu.Checked == true && chk_NhapLieu.Enabled == true)
                {
                    if (checkTab(thungan1) == false)
                    {
                        if (checkTab(nhaplieu1) == false)
                        {
                            MoGiaoDienNhapLieu();
                            BL.ThuNgan.Desk_BL.UpdateTypistInfo(cbo_ChonBan.SelectedItem.Text.ToString(), true);
                            tabnhaplieu = true;
                            logger.Info(BL.StaticClass.UserName + " has to cashier");
                        }
                        else
                        {
                            MessageBox.Show("Bạn đang mở giao diện nhận liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đang ở giao diện thu ngân. Bạn phải đóng giao diện thu ngân mới có thễ mở giao diện nhập liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (chk_ThuNgan.Checked == true && chk_ThuNgan.Enabled == true)
                    {
                        if (checkTab(nhaplieu1) == false)
                        {
                            if (checkTab(thungan1) == false)
                            {
                                MoGiaoDienThuNgan();
                                BL.ThuNgan.Desk_BL.UpdateCashierInfo(cbo_ChonBan.SelectedItem.Text.ToString(), true);
                                tabthungan = true;
                                logger.Info(BL.StaticClass.UserName + " has to typist");
                            }
                            else
                            {
                                MessageBox.Show("Bạn đang mở giao diện thu ngân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bạn đang ở giao diện nhập liệu. Bạn phải đóng giao diện nhập liệu mới có thễ mở giao diện thu ngân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else { MessageBox.Show("Bạn chưa chọn bàn","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
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
            //panel Nguoi Dung
            if (btn_NhomNguoiDung.Enabled == false && btn_nguoidung.Enabled == false && btn_PhanQuyen.Enabled == false) { pn_NguoiDung.Visible = false; }
            //Panel Tinh Thanh pho
            if (btn_TinhThanhPho.Enabled == false && btn_Quan.Enabled == false) { pn_TinhThanhPho.Visible = false; }
            //Panel Phong ban
            if (btn_LoaiPhongBan.Enabled == false && btn_PhongBan.Enabled == false) { pn_DanhMucPhongBan.Visible = false; }
            //panel Dich vu
            if (btn_NhomDichVu.Enabled == false && btn_DichVu.Enabled == false) { pn_DanhMucDichVu.Visible = false; }
            //Panel Thu ngan
            if (btn_BatDau.Enabled == false) { pn_LamViec.Visible = false; }
            //Panel Ds bien lai
            if (btn_BienLaiDuocLap.Enabled == false && btn_BienLaiDuocThuTien.Enabled == false && btn_DanhSachThuTienTheoNhomDichVu.Enabled == false) { pn_DanhSachBienLai.Visible = false; }
            //Panel Doanh thu
            if (btn_DoanhThu.Enabled == false) { pn_DoanhThu.Visible = false; }
            //tab quan tri he thong
            if (pn_NguoiDung.Visible == false && pn_TinhThanhPho.Visible == false && pn_DanhMucPhongBan.Visible == false && pn_DanhMucDichVu.Visible == false) { tp_QuanTriHeThong.Visible = false; }
            //tab thu ngan
            if (pn_LamViec.Visible == false) { tp_ThuNgan.Visible = false; }
            //tab bao cao
            if (pn_DanhSachBienLai.Visible == false && pn_DoanhThu.Visible == false) { tp_BaoCao.Visible = false; }

        }
        private bool outprogram = false;
        private void frm_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (outprogram == false)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                     e.Cancel = true;
                }
                else
                {
                    if (result == DialogResult.Yes)
                    {
                        outprogram = true;
                        for (int i = 0; i < tab_MainTab.Tabs.Count; i++)
                        {
                            tab_MainTab.Tabs.RemoveAt(i);
                        }
                        logger.Info(BL.StaticClass.UserName + "  has to logout");
                        BL.QuanTriHeThong.User_BL.UpdateStatusOnline(BL.StaticClass.UserID, false);
                        Application.Exit();
                    }
                }
            }
        }

        private string ThuTuongUng()
        {
            int dayS = (int)DateTime.Now.DayOfWeek;
            string day = "";
            switch (dayS)
            {
                case 0:
                    day = "chủ nhật";
                    break;
                case 1:
                    day = "hai";
                    break;
                case 2:
                    day = "ba";
                    break;
                case 3:
                    day = "tư";
                    break;
                case 4:
                    day = "năm";
                    break;
                case 5:
                    day = "sáu";
                    break;
                case 6:
                    day = "bảy";
                    break;
            }
            return day;
        }



    }
}
