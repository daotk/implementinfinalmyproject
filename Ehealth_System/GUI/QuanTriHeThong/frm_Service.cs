﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DO.QuanTriHeThong;
using BL.QuanTriHeThong;

namespace GUI.QuanTriHeThong
{
    public partial class frm_Service : Form
    {
        int totalcount;
        public frm_Service()
        {
            InitializeComponent();
        }

        private void frm_Service_Load(object sender, EventArgs e)
        {
            grd_NhomDichVu.DataSource = BL.StaticClass.ConvertToDataTable( BL.QuanTriHeThong.ServiceBL.GetService());
            kasDGVPage1.SplitPages();
            totalcount = grd_NhomDichVu.Rows.Count;
            loctheonhomdichvu();
            nhomdichvu();
            LoadDSService();
            lbl_KetQua.Text = "Kết quả: tìm được " + grd_NhomDichVu.DisplayedRowCount(true) + " trong tổng số " + totalcount;
            if (cbo_NhomDichVu.Items.Count <= 0)
            {
                btn_ThemMoi.Enabled = false;
            }
        }

        private void nhomdichvu()
        {
            cbo_NhomDichVu.DataSource = BL.QuanTriHeThong.ServiceBL.GetAllSer1();
            cbo_NhomDichVu.DisplayMember = "_SERVICEGROUPNAME";
            cbo_NhomDichVu.ValueMember = "_SERVICEGROUPID";
            cbo_NhomDichVu.SelectedIndex = -1;
        }

        private void loctheonhomdichvu()
        {
            cbo_LocTheoNhomDichVu.DataSource = BL.QuanTriHeThong.GroupService_BL.GetGroupService();
            cbo_LocTheoNhomDichVu.DisplayMember = "_SERVICEGROUPNAME";
            cbo_LocTheoNhomDichVu.ValueMember = "_SERVICEGROUPID";
            cbo_LocTheoNhomDichVu.SelectedIndex = -1;
        }

        private void LoadDSService()
        {
            grd_NhomDichVu.DataSource = BL.StaticClass.ConvertToDataTable(BL.QuanTriHeThong.ServiceBL.GetService());
            kasDGVPage1.SplitPages();
            btn_ChinhSua.Text = "Chỉnh sửa";
            btn_ChinhSua.Image = global::GUI.Properties.Resources.Edit_icon;
            btn_ThemMoi.Text = "Thêm mới";
            btn_ThemMoi.Image = global::GUI.Properties.Resources.Actions_list_add_icon;
            btn_ChinhSua.Enabled = false;
            txt_TenVietTat.Enabled = false;
            txt_DichVu.Enabled = false;
            txt_GiaTien.Enabled = false;
            chk_TrangThai.Enabled = false;
            txt_MoTa.Enabled = false;
            cbo_NhomDichVu.Enabled = false;
        }

        private string status;

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            if (btn_ThemMoi.Text == "Thêm mới")
            {
                
                lbl_chedo.Text = "Bạn đang trong chế độ thêm mới";
                status = "Create";
                Pank();
                btn_ThemMoi.Text = "Lưu";
                btn_ThemMoi.Image = global::GUI.Properties.Resources.Save_icon;
                btn_ChinhSua.Text = "Hủy bỏ";
                btn_ChinhSua.Image = global::GUI.Properties.Resources.cancel1;
                btn_ChinhSua.Enabled = true;
                txt_TenVietTat.Enabled = true;
                txt_DichVu.Enabled = true;
                txt_GiaTien.Enabled = true;
                chk_TrangThai.Enabled = true;
                txt_MoTa.Enabled = true;
                cbo_NhomDichVu.Enabled = true;
            }
            else
            {
                if (status == "Create")
                {
                    if (btn_ThemMoi.Text == "Lưu")
                    {
                        //Luu
                        if (Check())
                        {
                            if (CheckID() == false)
                            {
                                BL.QuanTriHeThong.ServiceBL.CreateService(txt_TenVietTat.Text, txt_DichVu.Text, cbo_NhomDichVu.SelectedValue.ToString(), txt_GiaTien.Text, txt_MoTa.Text, chk_TrangThai.Checked);
                                MessageBox.Show("Dịch vụ đã được tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDSService();
                                if (txt_TimKiem.Text == null || txt_TimKiem.Text == "")
                                {
                                    if (cbo_LocTheoNhomDichVu.SelectedIndex == -1)
                                    {
                                       // grd_NhomDichVu.DataSource = BL.QuanTriHeThong.ServiceBL.GetService();
                                        LoadDSService();
                                        lbl_KetQua.Text = "Kết quả: tìm được " + grd_NhomDichVu.DisplayedRowCount(true) + " trong tổng số " + totalcount;
                                    }
                                    else
                                    {
                                        grd_NhomDichVu.DataSource =BL.StaticClass.ConvertToDataTable( BL.QuanTriHeThong.ServiceBL.SearchGroupService(cbo_LocTheoNhomDichVu.SelectedValue.ToString()));
                                        kasDGVPage1.SplitPages();

                                        lbl_KetQua.Text = "Kết quả: tìm được " + grd_NhomDichVu.DisplayedRowCount(true) + " trong tổng số " + totalcount;
                                    }
                                }
                                else
                                {
                                    if (cbo_LocTheoNhomDichVu.SelectedIndex == -1)
                                    {
                                        grd_NhomDichVu.DataSource = BL.StaticClass.ConvertToDataTable(BL.QuanTriHeThong.ServiceBL.SearchService(txt_TimKiem.Text));
                                        kasDGVPage1.SplitPages();
                                        lbl_KetQua.Text = "Kết quả: tìm được " + grd_NhomDichVu.DisplayedRowCount(true) + " trong tổng số " + totalcount;
                                    }
                                    else
                                    {
                                        grd_NhomDichVu.DataSource = BL.StaticClass.ConvertToDataTable( BL.QuanTriHeThong.ServiceBL.SearchBohtService(txt_TimKiem.Text, cbo_LocTheoNhomDichVu.SelectedValue.ToString()));
                                        kasDGVPage1.SplitPages();
                                        lbl_KetQua.Text = "Kết quả: tìm được " + grd_NhomDichVu.DisplayedRowCount(true) + " trong tổng số " + totalcount;
                                    }
                                }
                                
                                Pank();
                                status = "";
                                lbl_chedo.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Tên viết tắt đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                lbl_chedo.Text = "Bạn đang trong chế độ thêm mới";
                            }
                        }
                    }
                }
                else
                {
                    if (Check())
                    {
                        if (status == "Edit")
                        {

                            if (btn_ThemMoi.Text == "Lưu")
                            {

                                BL.QuanTriHeThong.ServiceBL.EditService(txt_TenVietTat.Text, txt_DichVu.Text, cbo_NhomDichVu.SelectedValue.ToString(), txt_GiaTien.Text, txt_MoTa.Text, chk_TrangThai.Checked);
                                MessageBox.Show("Dịch vụ đã được chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                LoadDSService();
                                if (cbo_LocTheoNhomDichVu.SelectedIndex != -1)
                                {
                                    if (txt_TimKiem.Text == null || txt_TimKiem.Text == "")
                                    {
                                        int index = cbo_LocTheoNhomDichVu.SelectedIndex;
                                        nhomdichvu();
                                        loctheonhomdichvu();
                                        cbo_LocTheoNhomDichVu.SelectedIndex = index;
                                    }
                                    else
                                    {
                                        grd_NhomDichVu.DataSource =BL.StaticClass.ConvertToDataTable( BL.QuanTriHeThong.ServiceBL.SearchBohtService(txt_TimKiem.Text, cbo_LocTheoNhomDichVu.SelectedValue.ToString()));
                                        kasDGVPage1.SplitPages();
                                        lbl_KetQua.Text = "Kết quả: tìm được " + grd_NhomDichVu.DisplayedRowCount(true) + " trong tổng số " + totalcount;
                                        
                                    }
                                }
                                else
                                {
                                    if (txt_TimKiem.Text == null || txt_TimKiem.Text == "")
                                    {
                                        grd_NhomDichVu.DataSource =BL.StaticClass.ConvertToDataTable( BL.QuanTriHeThong.ServiceBL.SearchService(txt_TimKiem.Text));
                                        kasDGVPage1.SplitPages();
                                        lbl_KetQua.Text = "Kết quả: tìm được " + grd_NhomDichVu.DisplayedRowCount(true) + " trong tổng số " + totalcount;
                                    }
                                    else
                                    {
                                        grd_NhomDichVu.DataSource =BL.StaticClass.ConvertToDataTable( BL.QuanTriHeThong.ServiceBL.SearchService(txt_TimKiem.Text));
                                        kasDGVPage1.SplitPages();
                                        lbl_KetQua.Text = "Kết quả: tìm được " + grd_NhomDichVu.DisplayedRowCount(true) + " trong tổng số " + totalcount;
                                    }
                                }
                                status = "";
                                lbl_chedo.Text = "";
                                
                            }
                        }
                    }
                }
            }
            
        }

        private bool CheckID()
        {
            bool result = false;
            List<DO.QuanTriHeThong.ServiceDO> ds = BL.QuanTriHeThong.ServiceBL.GetService();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].serviceid_.ToUpper() == txt_TenVietTat.Text.ToUpper())
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private void Pank()
        {
            txt_TenVietTat.Text = "";
            txt_DichVu.Text = "";
            txt_MoTa.Text = "";
            txt_GiaTien.Text = "";
            chk_TrangThai.Checked = false;
        }

        private bool Check()
        {
            bool test = true;
            if (txt_TenVietTat.Text == null || txt_TenVietTat.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên viết tắt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                test = false;
            }
            else
            {
                if (txt_DichVu.Text == null || txt_DichVu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    test = false;
                }
                else
                {
                    if (txt_GiaTien.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập giá tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        test = false;
                    }
                }
            }
            return test;
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            //nhomdichvu();
            if (btn_ChinhSua.Text == "Chỉnh sửa")
            {
                //loctheonhomdichvu();
                if (grd_NhomDichVu.Rows.Count != 0)
                {
                    string ID = grd_NhomDichVu.CurrentRow.Cells[1].Value.ToString();
                    List<ServiceDO> dsuser = BL.QuanTriHeThong.ServiceBL.Get_Service(ID);
                    cbo_NhomDichVu.SelectedValue = dsuser[0].servicegroupid_;
                }
                btn_ThemMoi.Text = "Lưu";
                btn_ThemMoi.Image = global::GUI.Properties.Resources.Save_icon;
                btn_ChinhSua.Text = "Hủy bỏ";
                btn_ChinhSua.Image = global::GUI.Properties.Resources.cancel1;
                btn_ChinhSua.Enabled = true;
                txt_TenVietTat.Enabled = false;
                txt_DichVu.Enabled = true;
                txt_GiaTien.Enabled = true;
                chk_TrangThai.Enabled = true;
                txt_MoTa.Enabled = true;
                cbo_NhomDichVu.Enabled = true;
                status = "Edit";
                lbl_chedo.Text = "Bạn đang trong chế độ chỉnh sửa";
            }
            else
            {
                if (btn_ChinhSua.Text == "Hủy bỏ")
                {
                    btn_ThemMoi.Text = "Thêm mới";
                    btn_ThemMoi.Image = global::GUI.Properties.Resources.Actions_list_add_icon;
                    btn_ChinhSua.Text = "Chỉnh sửa";
                    btn_ChinhSua.Image = global::GUI.Properties.Resources.Edit_icon;
                    btn_ChinhSua.Enabled = false;
                    txt_TenVietTat.Enabled = false;
                    txt_DichVu.Enabled = false;
                    txt_GiaTien.Enabled = false;
                    chk_TrangThai.Enabled = false;
                    txt_MoTa.Enabled = false;
                    cbo_NhomDichVu.Enabled = false;
                    lbl_chedo.Text = "";
                }
            }
        }

        private void grd_NhomDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grd_NhomDichVu.Rows.Count != 0)
            {
                btn_ChinhSua.Enabled = true;
                string ID = grd_NhomDichVu.CurrentRow.Cells["TenVietTat"].Value.ToString();
                List<ServiceDO> dsuser = BL.QuanTriHeThong.ServiceBL.Get_Service(ID);
                txt_TenVietTat.Text = dsuser[0].serviceid_;
                txt_DichVu.Text = dsuser[0].servicename_;
                cbo_NhomDichVu.SelectedValue = dsuser[0].servicegroupid_;
                txt_MoTa.Text = dsuser[0].servicedescription_;
                txt_GiaTien.Text = dsuser[0].servicecost_;
                chk_TrangThai.Checked = dsuser[0].servicestatus_;
            }
            else
            {
                btn_ChinhSua.Enabled = false;
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            loctheonhomdichvu();
            btn_ChinhSua.Enabled = false;
            grd_NhomDichVu.DataSource =BL.StaticClass.ConvertToDataTable( BL.QuanTriHeThong.ServiceBL.SearchService(txt_TimKiem.Text));
            kasDGVPage1.SplitPages();
            lbl_KetQua.Text = "Kết quả: tìm được " + grd_NhomDichVu.DisplayedRowCount(true) + " trong tổng số " + totalcount;
        }

        private void cbo_LocTheoNhomDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == null || txt_TimKiem.Text == "")
            {
                if (cbo_LocTheoNhomDichVu.SelectedIndex >= 0)
                {
                    //loctheonhomdichvu();
                    btn_ChinhSua.Enabled = false;
                    grd_NhomDichVu.DataSource = BL.StaticClass.ConvertToDataTable(BL.QuanTriHeThong.ServiceBL.SearchGroupService(cbo_LocTheoNhomDichVu.SelectedValue.ToString()));
                    kasDGVPage1.SplitPages();
                    lbl_KetQua.Text = "Kết quả: tìm được " + grd_NhomDichVu.DisplayedRowCount(true) + " trong tổng số " + totalcount;
                }
            }
            else
            { 
                if(cbo_LocTheoNhomDichVu.SelectedIndex>=0)
                {
                    btn_ChinhSua.Enabled = false;
                    grd_NhomDichVu.DataSource = BL.StaticClass.ConvertToDataTable( BL.QuanTriHeThong.ServiceBL.SearchBohtService(txt_TimKiem.Text, cbo_LocTheoNhomDichVu.SelectedValue.ToString()));
                    kasDGVPage1.SplitPages();
                    lbl_KetQua.Text = "Kết quả: tìm được " + grd_NhomDichVu.DisplayedRowCount(true) + " trong tổng số " + totalcount;
                }
            }
            
        }

        private void grd_NhomDichVu_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < grd_NhomDichVu.RowCount; i++)
            {
                grd_NhomDichVu.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }

        private void txt_GiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))) { e.Handled = true; }
        }

        private void txt_TenVietTat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }
    }
}