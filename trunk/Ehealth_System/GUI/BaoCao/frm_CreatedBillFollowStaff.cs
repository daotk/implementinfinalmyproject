﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DA.BaoCao;
using DO.BaoCao;
using BL.BaoCao;
using CrystalDecisions.Shared;

namespace GUI.BaoCao
{
    public partial class frm_CreatedBillFollowStaff : Form
    {
        public frm_CreatedBillFollowStaff()
        {
            InitializeComponent();
        }

        private void dp_TuNgay_MonthCalendar_DateChanged(object sender, EventArgs e)
        {
            dp_DenNgay.Value.AddDays(6);
        }

        private void rad_TheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_TheoNgay.Checked == true)
            {
                dp_TuNgay.Visible = true;
                dp_DenNgay.Visible = false;
                lbl_TuNgay.Visible = true;
                lbl_TuNgay.Text = "Chọn ngày";
                lbl_DenNgay.Visible = false;
                lbl_ChonThang.Visible = false;
                cbo_Thang.Visible = false;
                dp_TuNgay.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            else
            {
                dp_TuNgay.Visible = false;
                dp_DenNgay.Visible = true;
                lbl_TuNgay.Visible = false;
                lbl_TuNgay.Text = "Từ ngày";
                lbl_DenNgay.Visible = true;
                lbl_ChonThang.Visible = true;
                cbo_Thang.Visible = true;
            }
        }

        private void rad_TheoTuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_TheoTuan.Checked == true)
            {
                dp_TuNgay.Visible = true;
                dp_DenNgay.Visible = true;
                dp_DenNgay.Enabled = false;
                lbl_TuNgay.Visible = true;
                lbl_DenNgay.Visible = true;
                lbl_ChonThang.Visible = false;
                cbo_Thang.Visible = false;
                dp_TuNgay.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                dp_DenNgay.Value = dp_TuNgay.Value.AddDays(6);
            }
            else
            {
                dp_TuNgay.Visible = true;
                dp_DenNgay.Visible = false;
                dp_DenNgay.Enabled = true;
                lbl_TuNgay.Visible = true;
                lbl_DenNgay.Visible = false;
                lbl_ChonThang.Visible = false;
                cbo_Thang.Visible = false;
            }
        }

        private void rad_TheoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_TheoThang.Checked == true)
            {
                dp_TuNgay.Visible = false;
                dp_DenNgay.Visible = false;
                lbl_TuNgay.Visible = false;
                lbl_DenNgay.Visible = false;
                lbl_ChonThang.Visible = true;
                cbo_Thang.Visible = true;
                cbo_Thang.SelectedIndex = DateTime.Now.Month - 1;
            }
            else
            {
                dp_TuNgay.Visible = true;
                dp_DenNgay.Visible = true;
                lbl_TuNgay.Visible = true;
                lbl_DenNgay.Visible = true;
                lbl_ChonThang.Visible = false;
                cbo_Thang.Visible = false;
            }
        }

        private void dp_TuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (rad_TheoTuan.Checked == true)
            {
                dp_DenNgay.Value = dp_TuNgay.Value.AddDays(6);
            }
        }

        public void loadDatagrid()
        {
            CreateBill_BL bill = new CreateBill_BL();
            grd_BaoCao.DataSource = bill.GetAllBill();
        }
        float thanhtien;
        int sc;
        private void Total()
        {
            sc = grd_BaoCao.Rows.Count;
            thanhtien = 0;
            for (int i = 0; i < sc; i++)
            {
                thanhtien += float.Parse(grd_BaoCao.Rows[i].Cells[8].Value.ToString());
            }
            lbl_Tongtien.Text = thanhtien.ToString();
        }

        private void TotalBL()
        {
            int sc = grd_BaoCao.Rows.Count;
            lbl_Tongbienlai.Text = sc.ToString();
        }

        private void frm_CreatedBillFollowStaff_Load(object sender, EventArgs e)
        {
            rad_TheoNgay.Checked = true;
            CreateBill_BL bill = new CreateBill_BL();
            cbo_Theo.DataSource = bill.GetAllUser();
            cbo_Theo.DisplayMember = "_USERNAME";
            cbo_Theo.ValueMember = "_USERID";
            cbo_Thang.SelectedIndex = 0;
            if (cbo_Theo.Items.Count <= 0)
            {
                btn_BaoCao.Enabled = false;
            }
            //loadDatagrid();
        }

        private void grd_BaoCao_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < grd_BaoCao.RowCount; i++)
            {
                grd_BaoCao.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            BL.BaoCao.CreateBill_BL bill = new CreateBill_BL();
            if (rad_TheoNgay.Checked)
            {
                grd_BaoCao.DataSource = bill.GetBillsByDay(dp_TuNgay.Value, cbo_Theo.SelectedValue.ToString());
            }
            else if (rad_TheoTuan.Checked)
            {
                grd_BaoCao.DataSource = bill.GetBillsByWeek(dp_TuNgay.Value, Convert.ToDateTime(dp_DenNgay.Value.AddDays(1).ToShortDateString()), cbo_Theo.SelectedValue.ToString());
            }
            else if (rad_TheoThang.Checked)
            {
                grd_BaoCao.DataSource = bill.GetBillsByMonth(cbo_Thang.SelectedItem.ToString(), cbo_Theo.SelectedValue.ToString());
            }
            Total();
            TotalBL();
        }

        private void btn_InBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                if (thanhtien != 0)
                {
                    DataSet3 ds = new DataSet3();
                    DataTable demoTable = ds.Tables.Add("Report3");
                    demoTable.Columns.Add("STT", typeof(int));
                    demoTable.Columns.Add("Tên NV", typeof(string));
                    demoTable.Columns.Add("Mã HD", typeof(string));
                    demoTable.Columns.Add("Họ tên BN", typeof(string));
                    demoTable.Columns.Add("Tuổi BN", typeof(string));
                    demoTable.Columns.Add("Giới tính", typeof(string));
                    demoTable.Columns.Add("Ngày lập", typeof(DateTime));
                    demoTable.Columns.Add("Tổng tiền", typeof(string));
                    demoTable.Columns.Add("Nhóm DV", typeof(string));



                    DataRow r;
                    int i;
                    for (i = 0; i < grd_BaoCao.Rows.Count; i++)
                    {
                        r = demoTable.NewRow();
                        r["STT"] = grd_BaoCao.Rows[i].Cells[0].Value;
                        r["Tên NV"] = grd_BaoCao.Rows[i].Cells[3].Value;
                        r["Mã HD"] = grd_BaoCao.Rows[i].Cells[1].Value;
                        r["Họ tên BN"] = grd_BaoCao.Rows[i].Cells[2].Value;
                        r["Tuổi BN"] = grd_BaoCao.Rows[i].Cells[4].Value;
                        r["Giới tính"] = grd_BaoCao.Rows[i].Cells[5].Value;
                        r["Ngày lập"] = grd_BaoCao.Rows[i].Cells[7].Value;
                        r["Tổng tiền"] = grd_BaoCao.Rows[i].Cells[8].Value;
                        r["Nhóm DV"] = grd_BaoCao.Rows[i].Cells[6].Value;
                        demoTable.Rows.Add(r);
                    }
                    CrystalReport_CreateBill objRpt = new CrystalReport_CreateBill();
                    objRpt.SetDataSource(ds.Tables[1]);
                    objRpt.SetParameterValue("TongTien", thanhtien.ToString());//lấy tổng số tiền hiển thị ra receipt
                    objRpt.SetParameterValue("TongBL", sc.ToString());

                    //Lưu với định dạng pdf
                    objRpt.PrintToPrinter(1, false, 0, 0);

                    //ExportOptions CrExportOptions;
                    //DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                    //PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                    //CrDiskFileDestinationOptions.DiskFileName = @"E:\ThuTien_1.pdf";
                    //CrExportOptions = objRpt.ExportOptions;
                    //{
                    //    CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    //    CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                    //    CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                    //    CrExportOptions.FormatOptions = CrFormatTypeOptions;
                    //}
                    //objRpt.Export();
                    ////Mở file pdf ngay sau khi lưu
                    //System.Diagnostics.Process.Start(@"E:\ThuTien_1.pdf");
                }
                else
                {
                    MessageBox.Show("Bạn phải thống kê trước khi in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//end
    }
}