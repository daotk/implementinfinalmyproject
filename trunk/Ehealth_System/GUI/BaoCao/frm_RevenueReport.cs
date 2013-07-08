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
            LoadTenLoaiDichVu();
            LoadDonViThuNgan();
            grd_BaoCao.Rows.Clear();
        }

        private void LoadDonViThuNgan()
        {
            cbo_DonVi.DataSource = BL.BaoCao.RevenusReportBL.GetDonViThuNgan();
            cbo_DonVi.DisplayMember = "tendonvithungan_";
            cbo_DonVi.ValueMember = "tendonvithungan_";
            cbo_DonVi.Text = "";
        }

        private void LoadTenLoaiDichVu()
        {
            cbo_LoaiDichVu.DataSource = BL.BaoCao.RevenusReportBL.GetLoaiDichVu();
            cbo_LoaiDichVu.DisplayMember = "tendichvu_";
            cbo_LoaiDichVu.ValueMember = "tendichvu_";
            cbo_LoaiDichVu.Text = "";

        }

        private bool CheckXenBaoCao() {
            bool test = true;
            if (cbo_DonVi.Text == "" || cbo_DonVi.Text == null) {
                test = false;
            }
            if (cbo_LoaiDichVu.Text == "" || cbo_LoaiDichVu.Text == null)
            {
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
        private void btn_XemBaoCao_Click(object sender, EventArgs e)
        {           
            if (CheckXenBaoCao())
            {
                if (rad_TheoNgay.Checked)
                {
                    grd_BaoCao.Rows.Clear();
                    int count = 0;
                    List<thongtinbaocaoDO> abc = BL.BaoCao.RevenusReportBL.GetDonViThuNganTheoNgay(cbo_LoaiDichVu.Text,
                       cbo_DonVi.Text, Convert.ToDateTime(dp_TuNgay.Value.ToShortDateString()));
                    for (int c = 0; c < abc.Count; c++)
                    {
                        DataGridViewRow row1 = new DataGridViewRow();
                        grd_BaoCao.Rows.Add(row1);
                        grd_BaoCao.Rows[count].Cells[1].Value = abc[c].tendonvithungan_;
                        grd_BaoCao.Rows[count].Cells[2].Value = abc[c].mabienlai_;
                        grd_BaoCao.Rows[count].Cells[3].Value = abc[c].hotenbenhnhan_;
                        grd_BaoCao.Rows[count].Cells[4].Value = abc[c].tuoibenhnhan_;
                        grd_BaoCao.Rows[count].Cells[5].Value = abc[c].gioitinh_;
                        grd_BaoCao.Rows[count].Cells[6].Value = abc[c].ngaydangky_;
                        grd_BaoCao.Rows[count].Cells[7].Value = abc[c].tongtien_;
                        grd_BaoCao.Rows[count].Cells[8].Value = abc[c].tennhomdichvu_;
                        count++;
                    }
                    count = 0;
                }
                else {
                    if (rad_TheoTuan.Checked)
                    {
                        grd_BaoCao.Rows.Clear();
                        int count = 0;
                        //DataGridViewRow row = new DataGridViewRow();
                        //grd_BaoCao.Rows.Add(row);
                        for (int i = 0; i < 7; i++) {
                            var a = new DateTime();
                            a = Convert.ToDateTime(dp_TuNgay.Value.ToShortDateString());
                            var dueDatePlusDays = a.AddDays(i);
                            List<thongtinbaocaoDO> qwe = BL.BaoCao.RevenusReportBL.GetDonViThuNganTheoNgay(cbo_LoaiDichVu.Text,
                            cbo_DonVi.Text, Convert.ToDateTime(dueDatePlusDays.ToShortDateString()));
                            for (int c = 0; c < qwe.Count; c++)
                            {
                                DataGridViewRow row1 = new DataGridViewRow();
                                grd_BaoCao.Rows.Add(row1);
                                grd_BaoCao.Rows[count].Cells[1].Value = qwe[c].tendonvithungan_;
                                grd_BaoCao.Rows[count].Cells[2].Value = qwe[c].mabienlai_;
                                grd_BaoCao.Rows[count].Cells[3].Value = qwe[c].hotenbenhnhan_;
                                grd_BaoCao.Rows[count].Cells[4].Value = qwe[c].tuoibenhnhan_;
                                grd_BaoCao.Rows[count].Cells[5].Value = qwe[c].gioitinh_;
                                grd_BaoCao.Rows[count].Cells[6].Value = qwe[c].ngaydangky_;
                                grd_BaoCao.Rows[count].Cells[7].Value = qwe[c].tongtien_;
                                grd_BaoCao.Rows[count].Cells[8].Value = qwe[c].tennhomdichvu_;
                                count++;
                            }
                            
                        }
                        count = 0;
                        
                    }
                    else {
                        if (rad_TheoThang.Checked) {
                            grd_BaoCao.Rows.Clear();
                            int count = 0;
                            List<thongtinbaocaoDO> xyz = BL.BaoCao.RevenusReportBL.GetDonViThuNganTheoThang(cbo_LoaiDichVu.Text,
                             cbo_DonVi.Text, Convert.ToDateTime(dp_TuNgay.Value.ToShortDateString()));
                            for (int c = 0; c < xyz.Count; c++)
                            {
                                DataGridViewRow row1 = new DataGridViewRow();
                                grd_BaoCao.Rows.Add(row1);
                                grd_BaoCao.Rows[count].Cells[1].Value = xyz[c].tendonvithungan_;
                                grd_BaoCao.Rows[count].Cells[2].Value = xyz[c].mabienlai_;
                                grd_BaoCao.Rows[count].Cells[3].Value = xyz[c].hotenbenhnhan_;
                                grd_BaoCao.Rows[count].Cells[4].Value = xyz[c].tuoibenhnhan_;
                                grd_BaoCao.Rows[count].Cells[5].Value = xyz[c].gioitinh_;
                                grd_BaoCao.Rows[count].Cells[6].Value = xyz[c].ngaydangky_;
                                grd_BaoCao.Rows[count].Cells[7].Value = xyz[c].tongtien_;
                                grd_BaoCao.Rows[count].Cells[8].Value = xyz[c].tennhomdichvu_;
                                count++;
                            }
                            count = 0;
                            
                            
                        }
                    }
                }


               
            }
            else {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
            }
        }

        


      

    }
}
