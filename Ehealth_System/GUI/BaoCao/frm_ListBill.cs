using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DO.BaoCao;
using DA.BaoCao;
using BL.BaoCao;
using CrystalDecisions.Shared;
namespace GUI.BaoCao
{
    public partial class frm_ListBill : Form
    {

        public frm_ListBill()
        {
            InitializeComponent();
        }

        private void frm_ListBill_Load(object sender, EventArgs e)
        {
            //LoadBill();
            LoadDichvu();
            LoadDonvithungan();
            


        }

        private void LoadBill()
        {
            dataGridViewX1.DataSource = BL.BaoCao.ListBill_BL.GetDSBill();
           
        }
        private void LoadDonvithungan()
        {
            cbo_TheoTN.DataSource = BL.BaoCao.ListBill_BL.GetDVTN();
            cbo_TheoTN.DisplayMember = "DEPARTMENTTYPENAME";
            cbo_TheoTN.ValueMember = "_tenthungan";
            cbo_TheoTN.Text = "";
        }
        private void LoadDichvu()
        {
            cbo_TheoDV.DataSource = BL.BaoCao.ListBill_BL.GetDV();
            cbo_TheoDV.DisplayMember = "SERVICEGROUPNAME";
            cbo_TheoDV.ValueMember = "_tendichvu";
            cbo_TheoDV.Text = "";
        }
        private void dataGridViewX1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridViewX1.RowCount; i++)
            {
                dataGridViewX1.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }
        private bool CheckXenBaoCao()
        {
            bool test = true;
            if (cbo_TheoDV.Text == "" || cbo_TheoDV.Text == null)
            {
                test = false;
            }
            if (cbo_TheoTN.Text == "" || cbo_TheoTN.Text == null)
            {
                test = false;
            }

            if (dp_ChonNgay.Text == null || dp_ChonNgay.Text == "")
            {
                test = false;
            }
            return test;
        }
        private void btn_XemBaoCao_Click(object sender, EventArgs e)
        {
           
            if (CheckXenBaoCao())
            {
                if (cbo_TheoTN.Text == "Tất cả thu ngân")
                {
                    dataGridViewX1.DataSource = BL.BaoCao.ListBill_BL.GetDSLocDVAll(cbo_TheoDV.Text,
                       cbo_TheoTN.Text, Convert.ToDateTime(dp_ChonNgay.Value.ToShortDateString()));
                    
                    Total();
                    TotalBL();
                }
                else
                {
                    dataGridViewX1.DataSource = BL.BaoCao.ListBill_BL.GetDSLocDV(cbo_TheoDV.Text,
                       cbo_TheoTN.Text, Convert.ToDateTime(dp_ChonNgay.Value.ToShortDateString()));
                    Total();
                    TotalBL();
                }
                
            }
            else
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        float thanhtien = 0;
        int sc;
        private void Total()
        {
            float thanhtien1 = 0;
            sc = dataGridViewX1.Rows.Count;
            for (int i = 0; i < sc; i++)
            {
                thanhtien1 += float.Parse(dataGridViewX1.Rows[i].Cells[7].Value.ToString());
            }
            lbl_Tongtien.Text = thanhtien1.ToString();
        }
        private void TotalBL()
        {
            sc = dataGridViewX1.Rows.Count;
            lbl_Tongbienlai.Text = sc.ToString();
        }

        private void btn_InBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(lbl_Tongtien.Text) != 0)
                {
                    DataSet1 ds = new DataSet1();
                    DataTable demoTable = ds.Tables.Add("Report");
                    demoTable.Columns.Add("STT", typeof(int));
                    demoTable.Columns.Add("Tên đơn vị thu ngân", typeof(string));
                    demoTable.Columns.Add("Mã biên lai", typeof(string));
                    demoTable.Columns.Add("Họ tên bệnh nhân", typeof(string));
                    demoTable.Columns.Add("Tuổi BN", typeof(string));
                    demoTable.Columns.Add("Giới tính", typeof(string));
                    demoTable.Columns.Add("Ngày giờ đăng kí", typeof(DateTime));
                    demoTable.Columns.Add("Tổng tiền BL", typeof(string));
                    demoTable.Columns.Add("Tên nhóm dịch vụ", typeof(string));


                    DataRow r;
                    int i;
                    for (i = 0; i < (dataGridViewX1.Rows.Count); i++)
                    {
                        r = demoTable.NewRow();
                        r["STT"] = dataGridViewX1.Rows[i].Cells[0].Value;
                        r["Tên đơn vị thu ngân"] = dataGridViewX1.Rows[i].Cells[1].Value;
                        r["Mã biên lai"] = dataGridViewX1.Rows[i].Cells[2].Value;
                        r["Họ tên bệnh nhân"] = dataGridViewX1.Rows[i].Cells[3].Value;
                        r["Tuổi BN"] = dataGridViewX1.Rows[i].Cells[4].Value;
                        r["Giới tính"] = dataGridViewX1.Rows[i].Cells[5].Value;
                        r["Ngày giờ đăng kí"] = dataGridViewX1.Rows[i].Cells[6].Value;
                        r["Tổng tiền BL"] = dataGridViewX1.Rows[i].Cells[7].Value;
                        r["Tên nhóm dịch vụ"] = dataGridViewX1.Rows[i].Cells[8].Value;
                       
                        demoTable.Rows.Add(r);
                    }
                    CrystalReport_ListBill1 objRpt = new CrystalReport_ListBill1();
                    objRpt.SetDataSource(ds.Tables[1]);
                    objRpt.SetParameterValue("TongTien", thanhtien.ToString());//lấy tổng số tiền hiển thị ra receipt
                    objRpt.SetParameterValue("TongBL", sc.ToString());
                    objRpt.PrintToPrinter(1, false, 0, 0);
                    //Lưu với định dạng pdf
                    //ExportOptions CrExportOptions;
                    //DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                    //PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                    //CrDiskFileDestinationOptions.DiskFileName = @"E:\ThongKe_DanhSach_BienLai_3.pdf";
                    //CrExportOptions = objRpt.ExportOptions;
                    //{
                    //    CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    //    CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                    //    CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                    //    CrExportOptions.FormatOptions = CrFormatTypeOptions;
                    //}
                    //objRpt.Export();
                    ////Mở file pdf ngay sau khi lưu
                    //System.Diagnostics.Process.Start(@"E:\ThongKe_DanhSach_BienLai_3.pdf");
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
        }

        private void dataGridViewX1_Sorted(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dataGridViewRow in
                                  dataGridViewX1.Rows.Cast<DataGridViewRow>())
            {
                dataGridViewRow.Cells["Tên đơn vị thu ngân"].Value = dataGridViewRow.Index + 1;
            }
        }
    }
}
