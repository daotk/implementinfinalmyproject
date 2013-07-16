using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL.BaoCao;
using DO.BaoCao;
using CrystalDecisions.Shared;
namespace GUI.BaoCao
{
    public partial class DoanhThu : Form
    {
        bool add = false;
        bool addnam = false;
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            rad_TheoNgay.Checked = true;
        //    LoadTenLoaiDichVu();
            LoadDonViThuNgan();
           // Opacity = 50;
            grd_BaoCao.Rows.Clear();
        }

        private void LoadDonViThuNgan()
        {
            cbo_DonVi.DataSource = BL.BaoCao.RevenusReportBL.GetDonViThuNgan();
            cbo_DonVi.DisplayMember = "tendonvithungan_";
            cbo_DonVi.ValueMember = "tendonvithungan_";
            cbo_DonVi.Text = "";
        }

      

        private bool CheckXenBaoCao() {
            bool test = true;
            if (cbo_DonVi.Text == "" || cbo_DonVi.Text == null) {
                test = false;
            }
            
            if (rad_TheoNgay.Checked == false && rad_TheoThang.Checked == false && rad_TheoTuan.Checked == false)
            {
                test = false;
            }
            if (dp_TuNgay.Text == null || dp_TuNgay.Text == "")
            {
                test = false;
            }
            return test;
        }
        int tongsotien = 0;
        int tongsobienlai = 0;
        private void btn_XemBaoCao_Click(object sender, EventArgs e)
        {           
            if (CheckXenBaoCao())
            {
                if (rad_TheoNgay.Checked)
                {
                    grd_BaoCao.Rows.Clear();
                    if (cbo_DonVi.Text == "Tất cả đơn vị")
                    {
                        int sotien = 0;
                        int sobienlai = 0;
                        List<thongtinbaocaoDO> abc = BL.BaoCao.RevenusReportBL.GetDonViThuNganTheoNgayAll(
                           cbo_DonVi.Text, Convert.ToDateTime(dp_TuNgay.Value.ToShortDateString()));
                        //grd_BaoCao.DataSource = abc;
                        if (abc.Count != 0)
                        {
                            for (int i = 0; i < abc.Count; i++)
                            {
                                sotien = sotien + Convert.ToInt32(abc[i].tongtien_.ToString());
                                sobienlai++;
                            }
                            DataGridViewRow row1 = new DataGridViewRow();
                            grd_BaoCao.Rows.Add(row1);
                            grd_BaoCao.Rows[0].Cells["TenDonViThuNgan"].Value = "Tất cả đơn vị";
                            grd_BaoCao.Rows[0].Cells["Date"].Value = abc[0].ngaydangky_.ToShortDateString();
                            grd_BaoCao.Rows[0].Cells["TongTien"].Value = sotien;
                            grd_BaoCao.Rows[0].Cells["Column5"].Value = sobienlai;

                        }
                        else { }
                            
                            
                    }
                    else {
                        int sotien = 0;
                        int sobienlai = 0;
                        List<thongtinbaocaoDO> abc = BL.BaoCao.RevenusReportBL.GetDonViThuNganTheoNgay(
                           cbo_DonVi.Text, Convert.ToDateTime(dp_TuNgay.Value.ToShortDateString()));
                        //grd_BaoCao.DataSource = abc;
                        if (abc.Count != 0)
                        {
                            for (int i = 0; i < abc.Count; i++)
                            {
                                sotien = sotien + Convert.ToInt32(abc[i].tongtien_.ToString());
                                sobienlai++;
                            }
                            DataGridViewRow row1 = new DataGridViewRow();
                            grd_BaoCao.Rows.Add(row1);
                            grd_BaoCao.Rows[0].Cells["TenDonViThuNgan"].Value = abc[0].tendonvithungan_;
                            grd_BaoCao.Rows[0].Cells["Date"].Value = abc[0].ngaydangky_.ToShortDateString();
                            grd_BaoCao.Rows[0].Cells["TongTien"].Value = sotien;
                            grd_BaoCao.Rows[0].Cells["Column5"].Value = sobienlai;

                        }
                        else { }
                     }
                    
                }
                else {
                    if (rad_TheoTuan.Checked)
                    {
                        grd_BaoCao.Rows.Clear();
                        if (cbo_DonVi.Text == "Tất cả đơn vị")
                        {
                            int count = 0;

                            DateTime a = Convert.ToDateTime(dp_TuNgay.Value.ToShortDateString());
                           
                            //   MessageBox.Show(abn.ToShortDateString() + " " + b);
                            for (int i = 0; i < 7; i++)
                            {
                                var dueDatePlusDays = a.AddDays(i);
                                //  abn.AddDays(7);
                                int sotien = 0;
                                int sobienlai = 0;
                                List<thongtinbaocaoDO> abc = BL.BaoCao.RevenusReportBL.GetDonViThuNganTheoNgayAll(
                                   cbo_DonVi.Text, dueDatePlusDays);
                                //grd_BaoCao.DataSource = abc;
                                if (abc.Count != 0)
                                {
                                    for (int j = 0; j < abc.Count; j++)
                                    {
                                        sotien = sotien + Convert.ToInt32(abc[j].tongtien_.ToString());
                                        sobienlai++;
                                    }
                                    DataGridViewRow row1 = new DataGridViewRow();
                                    grd_BaoCao.Rows.Add(row1);
                                    grd_BaoCao.Rows[count].Cells["TenDonViThuNgan"].Value = "Tất cả đơn vị";
                                    grd_BaoCao.Rows[count].Cells["Date"].Value = abc[0].ngaydangky_.ToShortDateString();
                                    grd_BaoCao.Rows[count].Cells["TongTien"].Value = sotien;
                                    grd_BaoCao.Rows[count].Cells["Column5"].Value = sobienlai;
                                    count++;
                                }
                                else { }
                                //MessageBox.Show(dueDatePlusDays.ToString());

                            }    // end for month
                        }
                        else
                        {
                            int count = 0;

                            DateTime a = Convert.ToDateTime(dp_TuNgay.Value.ToShortDateString());

                            //   MessageBox.Show(abn.ToShortDateString() + " " + b);
                            for (int i = 0; i < 7; i++)
                            {
                                var dueDatePlusDays = a.AddDays(i);
                                //  abn.AddDays(7);
                                int sotien = 0;
                                int sobienlai = 0;
                                List<thongtinbaocaoDO> abc = BL.BaoCao.RevenusReportBL.GetDonViThuNganTheoNgay(
                                   cbo_DonVi.Text, dueDatePlusDays);
                                //grd_BaoCao.DataSource = abc;
                                if (abc.Count != 0)
                                {
                                    for (int j = 0; j < abc.Count; j++)
                                    {
                                        sotien = sotien + Convert.ToInt32(abc[j].tongtien_.ToString());
                                        sobienlai++;
                                    }
                                    DataGridViewRow row1 = new DataGridViewRow();
                                    grd_BaoCao.Rows.Add(row1);
                                    grd_BaoCao.Rows[count].Cells["TenDonViThuNgan"].Value = abc[0].tendonvithungan_;
                                    grd_BaoCao.Rows[count].Cells["Date"].Value = abc[0].ngaydangky_.ToShortDateString();
                                    grd_BaoCao.Rows[count].Cells["TongTien"].Value = sotien;
                                    grd_BaoCao.Rows[count].Cells["Column5"].Value = sobienlai;
                                    count++;
                                }
                                else { }
                                //MessageBox.Show(dueDatePlusDays.ToString());

                            }    // end for month
                        }
                        
                    }
                    else {
                        if (rad_TheoThang.Checked) {
                            grd_BaoCao.Rows.Clear();
                            if (cbo_DonVi.Text == "Tất cả đơn vị")
                            {
                                int count = 0;

                                DateTime a = Convert.ToDateTime(dp_TuNgay.Value.ToShortDateString());
                                DateTime abn = new DateTime(a.Year, a.Month, 1);
                                int b = Convert.ToInt32(DateTime.DaysInMonth(a.Year, a.Month).ToString());
                                //   MessageBox.Show(abn.ToShortDateString() + " " + b);
                                for (int i = 0; i < b; i++)
                                {
                                    var dueDatePlusDays = abn.AddDays(i);
                                    //  abn.AddDays(7);
                                    int sotien = 0;
                                    int sobienlai = 0;
                                    List<thongtinbaocaoDO> abc = BL.BaoCao.RevenusReportBL.GetDonViThuNganTheoNgayAll(
                                       cbo_DonVi.Text, dueDatePlusDays);
                                    //grd_BaoCao.DataSource = abc;
                                    if (abc.Count != 0)
                                    {
                                        for (int j = 0; j < abc.Count; j++)
                                        {
                                            sotien = sotien + Convert.ToInt32(abc[j].tongtien_.ToString());
                                            sobienlai++;
                                        }
                                        DataGridViewRow row1 = new DataGridViewRow();
                                        grd_BaoCao.Rows.Add(row1);
                                        grd_BaoCao.Rows[count].Cells["TenDonViThuNgan"].Value = "Tất cả đơn vị";
                                        grd_BaoCao.Rows[count].Cells["Date"].Value = abc[0].ngaydangky_.ToShortDateString();
                                        grd_BaoCao.Rows[count].Cells["TongTien"].Value = sotien;
                                        grd_BaoCao.Rows[count].Cells["Column5"].Value = sobienlai;
                                        count++;
                                    }
                                    else { }
                                    //MessageBox.Show(dueDatePlusDays.ToString());

                                }    // end for month    
                            }
                            else {
                                int count = 0;
                                
                                DateTime a = Convert.ToDateTime(dp_TuNgay.Value.ToShortDateString());
                                DateTime abn = new DateTime(a.Year, a.Month, 1);
                                int b = Convert.ToInt32(DateTime.DaysInMonth(a.Year, a.Month).ToString());
                             //   MessageBox.Show(abn.ToShortDateString() + " " + b);
                                for (int i = 0; i < b; i++) {
                                    var dueDatePlusDays = abn.AddDays(i);
                                  //  abn.AddDays(7);
                                    int sotien = 0;
                                    int sobienlai = 0;
                                    List<thongtinbaocaoDO> abc = BL.BaoCao.RevenusReportBL.GetDonViThuNganTheoNgay(
                                       cbo_DonVi.Text, dueDatePlusDays);
                                    //grd_BaoCao.DataSource = abc;
                                    if (abc.Count != 0)
                                    {
                                        for (int j = 0; j < abc.Count; j++)
                                        {
                                            sotien = sotien + Convert.ToInt32(abc[j].tongtien_.ToString());
                                            sobienlai++;
                                        }
                                        DataGridViewRow row1 = new DataGridViewRow();
                                        grd_BaoCao.Rows.Add(row1);
                                        grd_BaoCao.Rows[count].Cells["TenDonViThuNgan"].Value = abc[0].tendonvithungan_;
                                        grd_BaoCao.Rows[count].Cells["Date"].Value = abc[0].ngaydangky_.ToShortDateString();
                                        grd_BaoCao.Rows[count].Cells["TongTien"].Value = sotien;
                                        grd_BaoCao.Rows[count].Cells["Column5"].Value = sobienlai;
                                        count++;
                                    }
                                    else { }
                                    //MessageBox.Show(dueDatePlusDays.ToString());
                                    
                                }    // end for month
                            }
                            
                        }
                    }
                }
               
                for (int i = 0; i < grd_BaoCao.RowCount; i++) {
                    tongsobienlai = tongsobienlai + Convert.ToInt32(grd_BaoCao.Rows[i].Cells["Column5"].Value.ToString());
                    tongsotien = tongsotien + Convert.ToInt32(grd_BaoCao.Rows[i].Cells["TongTien"].Value.ToString());
                }
                labelX4.Text = tongsotien.ToString();
                labelX2.Text = tongsobienlai.ToString();
               
            }
            else {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
            }
        }

        private void grd_BaoCao_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < grd_BaoCao.RowCount; i++) {
                grd_BaoCao.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);   
            }
        }

        private void grd_BaoCao_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < grd_BaoCao.RowCount; i++)
            {
                grd_BaoCao.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }

        private void btn_InBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                if (tongsotien != 0)
                {
                    DataSet4 ds = new DataSet4();
                    DataTable demoTable = ds.Tables.Add("Report");
                    demoTable.Columns.Add("STT", typeof(int));
                    demoTable.Columns.Add("ĐV thu ngân", typeof(string));
                    demoTable.Columns.Add("Ngày", typeof(DateTime));
                    demoTable.Columns.Add("Tổng tiền BL", typeof(string));
                    demoTable.Columns.Add("Tổng số BL", typeof(string));
                   
                    DataRow r;
                    int i;
                    for (i = 0; i < (grd_BaoCao.Rows.Count); i++)
                    {
                        r = demoTable.NewRow();
                        r["STT"] = grd_BaoCao.Rows[i].Cells[0].Value;
                        r["ĐV thu ngân"] = grd_BaoCao.Rows[i].Cells[1].Value;
                        r["Ngày"] = grd_BaoCao.Rows[i].Cells[2].Value;
                        r["Tổng tiền BL"] = grd_BaoCao.Rows[i].Cells[3].Value;
                        r["Tổng số BL"] = grd_BaoCao.Rows[i].Cells[4].Value;
                   
                        demoTable.Rows.Add(r);
                    }
                    CrystalReport_Revenue objRpt = new CrystalReport_Revenue();
                    objRpt.SetDataSource(ds.Tables[1]);
                    objRpt.SetParameterValue("TongTien", tongsotien.ToString());//lấy tổng số tiền hiển thị ra receipt
                    objRpt.SetParameterValue("TongBL", tongsobienlai.ToString());
                    //Lưu với định dạng pdf
                    ExportOptions CrExportOptions;
                    DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                    PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                    CrDiskFileDestinationOptions.DiskFileName = @"E:\ThongKe_DanhSach_BienLai_3.pdf";
                    CrExportOptions = objRpt.ExportOptions;
                    {
                        CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                        CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                        CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                        CrExportOptions.FormatOptions = CrFormatTypeOptions;
                    }
                    objRpt.Export();
                    //Mở file pdf ngay sau khi lưu
                    System.Diagnostics.Process.Start(@"E:\ThongKe_DanhSach_BienLai_3.pdf");
                }
                else
                {
                    MessageBox.Show("Bạn phải thống kê trước khi in");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        


      

    }
}
