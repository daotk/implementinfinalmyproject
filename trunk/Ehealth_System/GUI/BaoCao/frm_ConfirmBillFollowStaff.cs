using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL.BaoCao;
using DA.BaoCao;


namespace GUI.BaoCao
{
    public partial class DSBienLaiDuocThuTien : Form
    {
        public DSBienLaiDuocThuTien()
        {
            InitializeComponent();
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
                lbl_thang.Visible = false;
                cbo_Thang.Visible = false;
                //dp_TuNgay.Value = DateTime.Now;
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
                lbl_thang.Visible = false;
                cbo_Thang.Visible = false;
            }
        }//end

        private void rad_TheoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_TheoThang.Checked == true)
            {
                dp_TuNgay.Visible = false;
                dp_DenNgay.Visible = false;
                lbl_TuNgay.Visible = false;
                lbl_DenNgay.Visible = false;
                lbl_thang.Visible = true;
                cbo_Thang.Visible = true;
                cbo_Thang.SelectedIndex = DateTime.Now.Month - 1;
            }
            else
            {
                dp_TuNgay.Visible = true;
                dp_DenNgay.Visible = true;
                lbl_TuNgay.Visible = true;
                lbl_DenNgay.Visible = true;
                lbl_thang.Visible = false;
                cbo_Thang.Visible = false;
            }
        }//end

        private void rad_TheoNgay_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rad_TheoNgay.Checked == true)
            {
                dp_TuNgay.Visible = true;
                dp_DenNgay.Visible = false;
                lbl_TuNgay.Visible = true;
                lbl_TuNgay.Text = "Chọn ngày";
                lbl_DenNgay.Visible = false;
                lbl_thang.Visible = false;
                cbo_Thang.Visible = false;
                //dp_TuNgay.Value = DateTime.Now;
                dp_TuNgay.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                dp_DenNgay.Value = dp_TuNgay.Value.AddDays(6);
            }
            else
            {
                dp_TuNgay.Visible = false;
                dp_DenNgay.Visible = true;
                lbl_TuNgay.Visible = false;
                lbl_TuNgay.Text = "Từ ngày";
                lbl_DenNgay.Visible = true;
                lbl_thang.Visible = true;
                cbo_Thang.Visible = true;
            }
        }//end

        public void loadDatagrid()
        {
            ConfirmBill_BL bill = new ConfirmBill_BL();
            grd_BaoCao.DataSource = bill.GetAllBill();
        }//end

        private void grd_BaoCao_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < grd_BaoCao.RowCount; i++)
            {
                grd_BaoCao.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }//end

        private void btn_XemBaoCao_Click(object sender, EventArgs e)
        {
            BL.BaoCao.ConfirmBill_BL bill = new BL.BaoCao.ConfirmBill_BL();

            if (rad_TheoNgay.Checked)
            {
                grd_BaoCao.DataSource = bill.GetBillsByDay(dp_TuNgay.Value, cbo_Theo.SelectedValue.ToString());
            }
            else if (rad_TheoTuan.Checked)
            {
                grd_BaoCao.DataSource = bill.GetBillsByWeek(dp_TuNgay.Value, Convert.ToDateTime(dp_DenNgay.Value.AddDays(1).ToShortDateString()), cbo_Theo.SelectedValue.ToString());
                //grd_BaoCao.DataSource = bill.GetBillsByWeek(dp_TuNgay.Value, dp_DenNgay.Value, cbo_Theo.SelectedValue.ToString());
            }
            else if (rad_TheoThang.Checked)
            {
                grd_BaoCao.DataSource = bill.GetBillsByMonth(cbo_Thang.SelectedItem.ToString(), cbo_Theo.SelectedValue.ToString());
            }
            else { MessageBox.Show("Vui lòng nhập đủ thông tin"); }

            Total();
            TotalBL();
        }//end

        private void DSBienLaiDuocThuTien_Load(object sender, EventArgs e)
        {
            //loadDatagrid();
            rad_TheoNgay.Checked = true;
            lbl_thang.Visible = false;
            cbo_Thang.Visible = false;
            ConfirmBill_BL bill = new ConfirmBill_BL();
            cbo_Theo.DataSource = bill.GetAllUser();
            cbo_Theo.DisplayMember = "_USERNAME";
            cbo_Theo.ValueMember = "_USERID";
            cbo_Thang.SelectedIndex = 0;

            if (cbo_Theo.Items.Count <= 0)
            {
                btn_XemBaoCao.Enabled = false;
            }

        }//end

        private void dp_TuNgay_MonthCalendar_DateChanged(object sender, EventArgs e)
        {
            dp_DenNgay.Value.AddDays(6);
        }//end

        private void dp_TuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (rad_TheoTuan.Checked == true)
            {
                dp_DenNgay.Value = dp_TuNgay.Value.AddDays(6);
            }
        }//end

        private void Total()
        {
            int sc = grd_BaoCao.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc; i++)
            {
                thanhtien += float.Parse(grd_BaoCao.Rows[i].Cells[8].Value.ToString());
            }
            lbl_Tongtien.Text = thanhtien.ToString();
        }//end

        private void TotalBL()
        {
            int sc = grd_BaoCao.Rows.Count;
            lbl_Tongbienlai.Text = sc.ToString();
        }//end   
    }//end class
}//end namespace