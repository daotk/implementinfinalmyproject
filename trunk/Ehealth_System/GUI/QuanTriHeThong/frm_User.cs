﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL.QuanTriHeThong;

namespace GUI.QuanTriHeThong
{
    public partial class frm_User : Form
    {
        string matkhaucu;
        public frm_User()
        {
            InitializeComponent();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            PhanQuyen phanquyen = new PhanQuyen();
            phanquyen.ShowDialog();
        }

        private void frm_User_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
            LoadGroupUser();
            //if (cbo_NhomNguoiDung.Items.Count <= 0) { btn_ThemMoi.Enabled = false; }
        }

        private void LoadUserInfo()
        {
            grd_User.DataSource = BL.StaticClass.ConvertToDataTable( BL.QuanTriHeThong.User_BL.GetAllUserInfo());
            kasDGVPage1.SplitPages();
        }

        private void LoadGroupUser()
        {
            cbo_NhomNguoiDung.DataSource = BL.QuanTriHeThong.User_BL.GetAllUser1();
            cbo_NhomNguoiDung.DisplayMember = "tennhom_";
            cbo_NhomNguoiDung.ValueMember = "tenviettat_";
            cbo_NhomNguoiDung.SelectedIndex = -1;
        }

        private void grd_User_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < grd_User.RowCount; i++)
            {
                grd_User.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }

        private void grd_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grd_User.Rows.Count != 0)
            {
                string userid = grd_User.CurrentRow.Cells["MaNhanVien"].Value.ToString();
                List<DO.QuanTriHeThong.User_DO> user = BL.QuanTriHeThong.User_BL.GetUSerInfoFollowUserID(userid);
                txt_MaNhanVien.Text = user[0]._USERID;
                txt_HoTen.Text = user[0]._USERNAME;
                txt_Email.Text = user[0]._EMAIL;
                txt_TaiKhoan.Text = user[0]._ACCOUNT;
                matkhaucu = user[0]._PASSWORD;
                chk_TrangThai.Checked = user[0]._STATUS;
                cbo_NhomNguoiDung.SelectedValue = user[0]._USERTYPEID;
                btn_ChinhSua.Enabled = true;
            }
            else
            {
                btn_ChinhSua.Enabled = false;
            }
        }

        private string StatusSave = "";

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {

            if (btn_ThemMoi.Text == "Thêm mới")
            {
                LoadGroupUser();
                StatusSave = "Create";
                ///enable = true
                txt_MaNhanVien.Enabled = true;
                txt_HoTen.Enabled = true;
                txt_Email.Enabled = true;
                txt_TaiKhoan.Enabled = true;
                chk_Khoiphuc.Enabled = true;
                cbo_NhomNguoiDung.Enabled = true;
                chk_TrangThai.Enabled = true;
                btn_ChinhSua.Enabled = true;
                //set text = null
                txt_MaNhanVien.Text = "";
                txt_HoTen.Text = "";
                txt_Email.Text = "";
                txt_TaiKhoan.Text = "";
                //button
                btn_ThemMoi.Text = "Lưu";
                btn_ThemMoi.Image = global::GUI.Properties.Resources.Save_icon;
                btn_ChinhSua.Text = "Hủy bỏ";
                btn_ChinhSua.Image = global::GUI.Properties.Resources.cancel1;
                lbl_chedo.Text = "Bạn đang trong chế độ thêm mới";
            }
            else
            {
                if (StatusSave == "Create")
                {
                    if (btn_ThemMoi.Text == "Lưu")
                    {
                        if (txt_MaNhanVien.Text != "" && txt_HoTen.Text != "" && cbo_NhomNguoiDung.SelectedValue.ToString() != "" && txt_TaiKhoan.Text != "")
                        {
                            if (BL.QuanTriHeThong.User_BL.Account(txt_TaiKhoan.Text) == true)
                            {

                                MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                string taikhoan = txt_TaiKhoan.Text;
                                string manhanvien = txt_MaNhanVien.Text;
                                string hoten = txt_HoTen.Text;
                                string email = txt_Email.Text;

                                string matkhau = BL.MD5_BL.GetMD5(BL.StaticClass.matkhaumacdinh);
                                string nhomnguoidung = cbo_NhomNguoiDung.SelectedValue.ToString();
                                bool trangthai = chk_TrangThai.Checked;
                                if (BL.QuanTriHeThong.User_BL.InsertUser(manhanvien, hoten, email, nhomnguoidung, taikhoan, matkhau, trangthai) == -1)
                                {
                                    MessageBox.Show("Tên viết tăt đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                MessageBox.Show("Người dùng đã được tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadUserInfo();
                                StatusCancel();
                                lbl_chedo.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            lbl_chedo.Text = "Bạn đang trong chế độ thêm mới";
                        }
                    }
                }
                else
                {
                    if (StatusSave == "Edit")
                    {
                        lbl_chedo.Text = "Bạn đang trong chế độ chỉnh sửa";
                        if (btn_ThemMoi.Text == "Lưu")
                        {
                            //xử lý cập nhật
                            if (BL.QuanTriHeThong.User_BL.Account(txt_TaiKhoan.Text) == true)
                            {

                                MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                string manhanvien = txt_MaNhanVien.Text;
                                string hoten = txt_HoTen.Text;
                                string email = txt_Email.Text;
                                string taikhoan = txt_TaiKhoan.Text;
                                string matkhau;
                                if (chk_Khoiphuc.Checked == true) { matkhau = BL.MD5_BL.GetMD5(BL.StaticClass.matkhaumacdinh); } else { matkhau = matkhaucu; }
                                string nhomnguoidung = cbo_NhomNguoiDung.SelectedValue.ToString();
                                bool trangthai = chk_TrangThai.Checked;
                                if (txt_MaNhanVien.Text != "" && txt_HoTen.Text != "" && cbo_NhomNguoiDung.SelectedValue.ToString() != "" && txt_TaiKhoan.Text != "")
                                {
                                    BL.QuanTriHeThong.User_BL.UpdateUser(manhanvien, hoten, email, nhomnguoidung, taikhoan, matkhau, trangthai);
                                    MessageBox.Show("Người dùng đã được chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadUserInfo();
                                    StatusCancel();
                                    lbl_chedo.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    lbl_chedo.Text = "Bạn đang trong chế độ chỉnh sửa";
                                }
                            }
                        }
                    }
                }
            }
        }//end button Them moi

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            //LoadGroupUser();
            if (btn_ChinhSua.Text == "Chỉnh sửa")
            {
                if (grd_User.Rows.Count != 0)
                {
                    string userid = grd_User.CurrentRow.Cells["MaNhanVien"].Value.ToString();
                    List<DO.QuanTriHeThong.User_DO> user = BL.QuanTriHeThong.User_BL.GetUSerInfoFollowUserID(userid);
                    cbo_NhomNguoiDung.SelectedValue = user[0]._USERTYPEID;
                }
                ///xu ly chinh sua
                StatusSave = "Edit";
                btn_ThemMoi.Text = "Lưu";
                btn_ThemMoi.Image = global::GUI.Properties.Resources.Save_icon;
                btn_ChinhSua.Text = "Hủy bỏ";
                btn_ChinhSua.Image = global::GUI.Properties.Resources.cancel1;
                txt_HoTen.Enabled = true;
                txt_Email.Enabled = true;
                txt_TaiKhoan.Enabled = true;
                chk_Khoiphuc.Enabled = true;
                cbo_NhomNguoiDung.Enabled = true;
                chk_TrangThai.Enabled = true;
                lbl_chedo.Text = "Bạn đang trong chế độ chỉnh sửa";
            }
            else
            {
                //xu ly cancel
                ///enable = false
                StatusCancel();
                lbl_chedo.Text = "";
            }
        }//end button chinh sua

        private void StatusCancel()
        {
            txt_MaNhanVien.Enabled = false;
            txt_HoTen.Enabled = false;
            txt_Email.Enabled = false;
            txt_TaiKhoan.Enabled = false;
            chk_Khoiphuc.Enabled = false;
            cbo_NhomNguoiDung.Enabled = false;
            chk_TrangThai.Enabled = false;
            btn_ChinhSua.Enabled = false;
            //button
            btn_ThemMoi.Text = "Thêm mới";
            btn_ChinhSua.Text = "Chỉnh sửa";
        }

        private void txt_MaNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }
    }
}