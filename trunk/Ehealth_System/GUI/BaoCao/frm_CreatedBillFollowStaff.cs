using System;
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
            dp_DenNgay.Value.AddDays(7);
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
                dp_TuNgay.Value = DateTime.Now;
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
                dp_TuNgay.Value = DateTime.Now;
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
                dp_DenNgay.Value = dp_TuNgay.Value.AddDays(7);
            }
        }

        public void loadDatagrid()
        {
            CreateBill_BL bill = new CreateBill_BL();
            grd_BaoCao.DataSource = bill.GetAllBill();
        }

        private void Total()
        {
            int sc = grd_BaoCao.Rows.Count;
            float thanhtien = 0;
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
                List<DO.BaoCao.CreateBill_DO> ds1 = new List<CreateBill_DO>();
                List<DO.BaoCao.CreateBill_DO> ds = BL.BaoCao.CreateBill_BL.GetBillsByDay(dp_TuNgay.Value, cbo_Theo.SelectedValue.ToString());
                for (int i = 0; i < ds.Count; i++)
                {                    
                    if (ds[i]._BILLDATE.ToShortDateString() == dp_TuNgay.Value.ToShortDateString())
                    {
                        ds1.Add(ds[i]);
                        
                    }
                }
                grd_BaoCao.DataSource = ds1;
            }
            else if (rad_TheoTuan.Checked)
            {
                grd_BaoCao.DataSource = bill.GetBillsByWeek(dp_TuNgay.Value, dp_DenNgay.Value, cbo_Theo.SelectedValue.ToString());
            }
            else if (rad_TheoThang.Checked)
            {
                grd_BaoCao.DataSource = bill.GetBillsByMonth(cbo_Thang.SelectedItem.ToString(), cbo_Theo.SelectedValue.ToString());
            }
            Total();
            TotalBL();
        }
    }
}