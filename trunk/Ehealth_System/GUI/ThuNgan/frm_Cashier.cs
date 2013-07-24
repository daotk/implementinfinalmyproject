using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DO.Thu_Ngan;
using BL.ThuNgan;

namespace GUI.ThuNgan
{
    public partial class frm_Cashier : Form
    {
        DA.Entity.EHealthSystemEntities dk = new DA.Entity.EHealthSystemEntities();
        public frm_Cashier()
        {
            InitializeComponent();
        }
        private string DESKID;
        public frm_Cashier(string DeskID)
        {
            DESKID = DeskID;
            InitializeComponent();
        }

        private void frm_Cashier_Load(object sender, EventArgs e)
        {
            LoadDSBanhNhan();
            timer1.Start();
            rad_bienlai.Select();
        }

        private void LoadDSBanhNhan()
        {
            using (DA.Entity.EHealthSystemEntities dk = new DA.Entity.EHealthSystemEntities())
            {
                grd_HoaDon.DataSource = dk.sp_loadbenhnhan(DESKID);
            }
        }

        private bool CheckBenhNhan(string mabenhnhan)
        {
            bool test = false;
            List<DA.Entity.sp_searchbenhnhan_Result> abc = dk.sp_searchbenhnhan(txt_TimKiemHoaDon.Text, DESKID).ToList(); 
            for (int i = 0; i < abc.Count; i++)
            {
                if (mabenhnhan.Equals(abc[i].mabenhnhan_))
                {
                    test = true;
                }
            }
            return test;
        }

        private void txt_TimKiemHoaDon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_TimKiemHoaDon.Text == "" || txt_TimKiemHoaDon.Text == null)
                {
                    LoadDSBanhNhan();
                }
                else
                {
                    if (CheckBenhNhan(txt_TimKiemHoaDon.Text))
                    {
                        grd_HoaDon.DataSource=dk.sp_searchbenhnhan(txt_TimKiemHoaDon.Text,DESKID).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Bệnh nhân không có trong danh sách chưa thu tiền","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        LoadDSBanhNhan();
                    }
                }
            }
        }

        private void grd_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string tenbenhnhan = grd_HoaDon.CurrentRow.Cells[1].Value.ToString();
                List<ThongTinBenhNhanDO> xyz = BL.ThuNgan.CashierBL.LoadThongTinBenhNhan(tenbenhnhan);
                txt_MaHoaDon.Text = xyz[0].mahoadon_;
                txt_MabenhNhan.Text = xyz[0].mabenhnhan_;
                txt_TenBenhNhan.Text = xyz[0].tenbenhnhan_;
                txt_GioiTinh.Text = xyz[0].gioitinh_;
                txt_DiaChi.Text = xyz[0].diachi_;
                txt_SDT.Text = xyz[0].sodienthoai_;
                grd_DichVu.DataSource = BL.ThuNgan.CashierBL.LoadLoaiDichVu(tenbenhnhan);
                LoadTongSoTien();
            }
            catch
            {
            }
        }

        private void LoadTongSoTien()
        {
            int tongsotien = 0;
            for (int i = 0; i < grd_DichVu.RowCount; i++)
            {
                tongsotien = tongsotien + Convert.ToInt32(grd_DichVu.Rows[i].Cells["DonGia"].Value);
            }
            lbl_TongTienNhan.Text = tongsotien.ToString();
        }

        private void grd_DichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string tongtien = grd_DichVu.CurrentRow.Cells[4].Value.ToString();
                txt_SoTien.Text = tongtien;
                MaHoaDon1 = grd_DichVu.CurrentRow.Cells["loaiduchvu"].Value.ToString();
            }
            catch
            {
                //    MessageBox.Show("Cell click DV");
            }
        }

        private void txt_SoTienNhan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_SoTienNhan.Text == "")
                {
                    txt_SoTienHoanLai.Text = "";
                }
                txt_SoTienHoanLai.Text = (Convert.ToInt32(txt_SoTienNhan.Text) - Convert.ToInt32(txt_SoTien.Text)).ToString();
            }
            catch
            {
            }
        }

        private string MaHoaDon1;

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (MaHoaDon1 == "" || MaHoaDon1 == null)
            {
                MessageBox.Show("Chưa chọn nhóm dịch vụ cần thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Cap nhat hoa don
                BL.ThuNgan.CashierBL.CapNhatBill(MaHoaDon1, BL.StaticClass.UserID, true);
                grd_DichVu.DataSource = BL.ThuNgan.CashierBL.LoadLoaiDichVu(txt_TenBenhNhan.Text);
                MessageBox.Show("Xác nhận thu tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MaHoaDon1 = "";
                txt_SoTien.Text = "";
                LoadDSBanhNhan();
                LoadTongSoTien();
            }
        }

        private void txt_SoTienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadDSBanhNhan();
            timer1.Interval = 10000;
        }

        private void txt_TongSoTienNhan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_TongSoTienNhan.Text == "")
                {
                    lbl_TongTienHoanLai.Text = "";
                }
                lbl_TongTienHoanLai.Text = (Convert.ToInt32(txt_TongSoTienNhan.Text) - Convert.ToInt32(lbl_TongTienNhan.Text)).ToString();
            }
            catch
            {
            }
        }

        private void txt_TongSoTienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < grd_DichVu.RowCount; i++)
                {
                    //cap nha
                    BL.ThuNgan.CashierBL.CapNhatBill(grd_DichVu.Rows[i].Cells["loaiduchvu"].Value.ToString(), BL.StaticClass.UserID, true);
                }
                grd_DichVu.DataSource = BL.ThuNgan.CashierBL.LoadLoaiDichVu(txt_TenBenhNhan.Text);
                LoadDSBanhNhan();
                txt_SoTien.Text = "";
                lbl_TongTienNhan.Text = "";
                MessageBox.Show("Xác nhận thu tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private void panelEx4_FontChanged(object sender, EventArgs e)
        {
            if (rad_bienlai.Checked)
            {
                txt_SoTien.Visible = true;
                txt_SoTienHoanLai.Visible = true;
                txt_SoTienNhan.Visible = true;
                lbl_SoTien.Visible = true;
                lbl_SoTienNhan.Visible = true;
                lbl_SoTienHoanLai.Visible = true;
                btn_XacNhan.Visible = true;
                lbl_TongTienNhan.Visible = false;
                labelX5.Visible = false;
                labelX4.Visible = false;
                labelX3.Visible = false;
                txt_TongSoTienNhan.Visible = false;
                lbl_TongTienHoanLai.Visible = false;
                buttonX1.Visible = false;
            }
            else
            {
                if (rab_tatcabienlai.Checked)
                {
                    lbl_TongTienNhan.Visible = true;
                    labelX5.Visible = true;
                    labelX4.Visible = true;
                    labelX3.Visible = true;
                    txt_TongSoTienNhan.Visible = true;
                    lbl_TongTienHoanLai.Visible = true;
                    buttonX1.Visible = true;
                    txt_SoTien.Visible = false;
                    txt_SoTienHoanLai.Visible = false;
                    txt_SoTienNhan.Visible = false;
                    lbl_SoTien.Visible = false;
                    lbl_SoTienNhan.Visible = false;
                    lbl_SoTienHoanLai.Visible = false;
                    btn_XacNhan.Visible = false;
                }
            }
        }


        private void rad_bienlai_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_bienlai.Checked)
            {
                txt_SoTien.Visible = true;
                txt_SoTienHoanLai.Visible = true;
                txt_SoTienNhan.Visible = true;
                lbl_SoTien.Visible = true;
                lbl_SoTienNhan.Visible = true;
                lbl_SoTienHoanLai.Visible = true;
                btn_XacNhan.Visible = true;
                lbl_TongTienNhan.Visible = false;
                labelX5.Visible = false;
                labelX4.Visible = false;
                labelX3.Visible = false;
                txt_TongSoTienNhan.Visible = false;
                lbl_TongTienHoanLai.Visible = false;
                buttonX1.Visible = false;
            }
            else
            {
                lbl_TongTienNhan.Visible = true;
                labelX5.Visible = true;
                labelX4.Visible = true;
                labelX3.Visible = true;
                txt_TongSoTienNhan.Visible = true;
                lbl_TongTienHoanLai.Visible = true;
                buttonX1.Visible = true;
                txt_SoTien.Visible = false;
                txt_SoTienHoanLai.Visible = false;
                txt_SoTienNhan.Visible = false;
                lbl_SoTien.Visible = false;
                lbl_SoTienNhan.Visible = false;
                lbl_SoTienHoanLai.Visible = false;
                btn_XacNhan.Visible = false;
            }
        }

        private void grd_DichVu_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < grd_DichVu.RowCount; i++)
            {
                grd_DichVu.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }

        private void grd_DichVu_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < grd_DichVu.RowCount; i++)
            {
                grd_DichVu.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }

       

       
    }
}