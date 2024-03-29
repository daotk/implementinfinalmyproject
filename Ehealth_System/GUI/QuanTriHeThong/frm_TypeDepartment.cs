﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DO.QuanTriHeThong;
using DA.QuanTriHeThong;
using BL.QuanTriHeThong;

namespace GUI.QuanTriHeThong
{
    public partial class frm_TypeDepartment : Form
    {
        bool flag_them = false;
        bool flag_sua = false;
        int totalcount;
        public frm_TypeDepartment()
        {
            InitializeComponent();
            enableText(false);
            enablebtn(false);
        }//end

        private void frm_TypeDepartment_Load(object sender, EventArgs e)
        {
            loadDatagrid();
            focus();
            lbl_KetQua.Text = "Kết quả : Tìm được 0 trong tổng số" + " " + totalcount + " loại phòng ban";
        }//end

        public void enableText(bool enable)
        {
            txt_TenVietTat.Enabled = enable;
            txt_LoaiPhongBan.Enabled = enable;
            txt_MoTa.Enabled = enable;
            chk_TrangThai.Enabled = enable;

        }//end

        public void enablebtn(bool enable)
        {
            btn_ThemMoi.Visible = !enable;
            btn_ChinhSua.Visible = !enable;
            btn_luu.Visible = enable;
            btn_huy.Visible = enable;
        }//end

        public void Huy()
        {
            enableText(false);
            enablebtn(false);
            flag_them = false;
            flag_sua = false;
            focus();
            //lbl_thongbao.Text = "Bạn đang ở chế độ : xem danh sách";
        }//end

        public void loadDatagrid()
        {
            grd_LoaiPhongBan.DataSource =BL.StaticClass.ConvertToDataTable( BL.QuanTriHeThong.TypeDepartment_BL.GetAllDepartment());
            kasDGVPage1.SplitPages();
            int count = grd_LoaiPhongBan.Rows.Count;
            totalcount = count;
            btn_ChinhSua.Enabled = false;

        }//end

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (flag_them == true)
            {
                if (txt_TenVietTat.Text == null || txt_TenVietTat.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên viết tắt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txt_LoaiPhongBan.Text == null || txt_LoaiPhongBan.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập loại phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int i = TypeDepartment_BL.add(txt_TenVietTat.Text, txt_LoaiPhongBan.Text, txt_MoTa.Text, chk_TrangThai.Checked);
                if (i == -1)
                {
                    MessageBox.Show("Loại phòng ban đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("Loại phòng ban đã được tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (flag_sua == true)
            {
                txt_TenVietTat.Enabled = false;
                if (txt_LoaiPhongBan.Text == null || txt_LoaiPhongBan.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập loại phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int i = TypeDepartment_BL.edit(txt_TenVietTat.Text, txt_LoaiPhongBan.Text, txt_MoTa.Text, chk_TrangThai.Checked);

                if (i == -1)
                {
                    MessageBox.Show("Tên viết tắt đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Loại phòng ban đã được chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            loadDatagrid();
            lbl_chedo.Text = "";
            Huy();
        }//end

        private void grd_LoaiPhongBan_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < grd_LoaiPhongBan.RowCount; i++)
            {
                grd_LoaiPhongBan.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }//end

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            enablebtn(true);
            enableText(true);
            flag_them = true;
            txt_TenVietTat.Text = "";
            txt_LoaiPhongBan.Text = "";
            txt_MoTa.Text = "";
            chk_TrangThai.Checked = false;
            //lbl_thongbao.Text = "Bạn đang ở chế độ : Thêm mới ";
            lbl_chedo.Text = "Bạn đang trong chế độ thêm mới";
        }//end

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            enablebtn(true);
            enableText(true);
            flag_sua = true;
            txt_TenVietTat.Enabled = false;
            //lbl_thongbao.Text = "Bạn đang ở chế độ : chỉnh sửa";
            lbl_chedo.Text = "Bạn đang trong chế độ chỉnh sửa";
        }//end

        private void grd_LoaiPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (grd_LoaiPhongBan.Rows.Count != 0)
            {
                focus();
                btn_ChinhSua.Enabled = true;
            }
            else
            {
                btn_ChinhSua.Enabled = false;
            }

        }//end

        public void focus()
        {
            if (grd_LoaiPhongBan.Rows.Count != 0)
            {
                int i;
                i = grd_LoaiPhongBan.SelectedCells[0].RowIndex;
                txt_TenVietTat.Text = grd_LoaiPhongBan.Rows[i].Cells[1].Value.ToString();
                txt_LoaiPhongBan.Text = grd_LoaiPhongBan.Rows[i].Cells[2].Value.ToString();
                if (grd_LoaiPhongBan.Rows[i].Cells[3].Value == null)
                {
                    txt_MoTa.Text = "";
                }
                else
                {
                    txt_MoTa.Text = grd_LoaiPhongBan.Rows[i].Cells[3].Value.ToString();
                }
                //txt_MoTa.Text = grd_LoaiPhongBan.Rows[i].Cells[3].Value.ToString();
                if (Convert.ToBoolean(grd_LoaiPhongBan.Rows[i].Cells[4].Value) == true) { chk_TrangThai.Checked = true; }
                else { chk_TrangThai.Checked = false; }
            }
        }//end

        private void btn_huy_Click(object sender, EventArgs e)
        {
            enablebtn(false);
            enableText(false);
            flag_them = false;
            txt_TenVietTat.Text = "";
            txt_LoaiPhongBan.Text = "";
            txt_MoTa.Text = "";
            chk_TrangThai.Checked = false;
            focus();
            lbl_chedo.Text = "";
            //lbl_thongbao.Text = "Bạn đang ở chế độ : Xem danh sách";
        }//end

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            grd_LoaiPhongBan.DataSource = BL.StaticClass.ConvertToDataTable(BL.QuanTriHeThong.TypeDepartment_BL.SearchTypeDepart(txt_TimKiem.Text));
            kasDGVPage1.SplitPages();
            lbl_KetQua.Text = "Kết quả: tìm được " + grd_LoaiPhongBan.DisplayedRowCount(true) + " trong tổng số " + totalcount + " loại phòng ban";
            btn_ChinhSua.Enabled = false;
        }

        private void txt_TenVietTat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }//end
    }
}//end class