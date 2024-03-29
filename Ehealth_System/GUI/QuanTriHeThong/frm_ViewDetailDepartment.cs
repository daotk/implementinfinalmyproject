﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL.QuanTriHeThong;
using DA.QuanTriHeThong;
using DO;

namespace GUI.QuanTriHeThong
{
    public partial class frm_ViewDetailDepartment : Form
    {
        public string departmentid;
        bool flag_them = false;
        bool flag_sua = false;

        public frm_ViewDetailDepartment(string id)
        {
            departmentid = id;
            InitializeComponent();
            enableText(false);
            enablebtn(false);
        }

        public void enableText(bool enable)
        {
            txt_TenVietTat.Enabled = enable;
            txt_TenBan.Enabled = enable;
            chk_TrangThai.Enabled = enable;
        }//end

        public void enablebtn(bool enable)
        {
            btn_ThemMoi.Visible = !enable;
            btn_ChinhSua.Visible = !enable;
            btn_Luu.Visible = enable;
            btn_huy.Visible = enable;
        }//end

        public void loaddatagrid()
        {
            grd_Ban.DataSource = BL.QuanTriHeThong.Desk_BL.GetDesk(departmentid);
        }

        private void frm_ViewDetailDepartment_Load(object sender, EventArgs e)
        {
            loaddatagrid();
            btn_ChinhSua.Enabled = false;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            enablebtn(false);
            enableText(false);
            flag_them = false;
            txt_TenVietTat.Text = "";
            txt_TenBan.Text = "";
            chk_TrangThai.Checked = false;
            lbl_chedo.Text = "";
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            enablebtn(true);
            enableText(true);
            flag_them = true;
            txt_TenVietTat.Text = "";
            txt_TenBan.Text = "";
            chk_TrangThai.Checked = false;
            lbl_chedo.Text = "Bạn đang trong chế độ thêm mới";
        }

        private void grd_Ban_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < grd_Ban.RowCount; i++)
            {
                grd_Ban.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }

        public void huy()
        {
            enableText(false);
            enablebtn(false);
            flag_them = false;
            flag_sua = false;
        }//end

        public void focus()
        {
            if (grd_Ban.Rows.Count != 0)
            {
                int i;
                i = grd_Ban.SelectedCells[0].RowIndex;
                txt_TenVietTat.Text = grd_Ban.Rows[i].Cells[1].Value.ToString();
                txt_TenBan.Text = grd_Ban.Rows[i].Cells[3].Value.ToString();
                if (Convert.ToBoolean(grd_Ban.Rows[i].Cells[4].Value) == true) { chk_TrangThai.Checked = true; }
                else { chk_TrangThai.Checked = false; }
            }
        }//end

        private void grd_Ban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grd_Ban.Rows.Count != 0)
            {
                focus();
                btn_ChinhSua.Enabled = true;
            }
            else
            {
                btn_ChinhSua.Enabled = false;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (flag_them == true)
            {
                if (txt_TenVietTat.Text == null || txt_TenVietTat.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên viết tắt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txt_TenBan.Text == null || txt_TenBan.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (checkID() == false)
                {
                    BL.QuanTriHeThong.Desk_BL.add(txt_TenVietTat.Text, txt_TenBan.Text, departmentid, chk_TrangThai.Checked);
                    MessageBox.Show("Bàn thu ngân đã được tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tên viết tắt đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (flag_sua == true)
            {
                txt_TenVietTat.Enabled = false;
                if (txt_TenBan.Text == null || txt_TenBan.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int i = Desk_BL.edit(txt_TenVietTat.Text, txt_TenBan.Text, chk_TrangThai.Checked);

                if (i == -1)
                {
                    MessageBox.Show("Tên viết tắt đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Bàn thu ngân đã được chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            loaddatagrid();
            lbl_chedo.Text = "";
            huy();
        }

        private bool checkID()
        {
            bool result = false;
            List<DO.QuanTriHeThong.Desk_DO> ds = BL.QuanTriHeThong.Desk_BL.GetAllDesk();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i]._DESKID == txt_TenVietTat.Text)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            enablebtn(true);
            enableText(true);
            flag_sua = true;
            txt_TenVietTat.Enabled = false;
            lbl_chedo.Text = "Bạn đang trong chế độ chỉnh sửa";
        }//end
    }
}