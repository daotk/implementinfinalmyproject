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
            LoadData();

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
        private void LoadData()
        {
            dataGridViewX1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
            }
        }
        private void Total()
        {
            int sc = dataGridViewX1.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc; i++)
            {
                thanhtien += float.Parse(dataGridViewX1.Rows[i].Cells[7].Value.ToString());
            }
            lbl_Tongtien.Text = thanhtien.ToString();
        }
        private void TotalBL()
        {
            int sc = dataGridViewX1.Rows.Count;
            lbl_Tongbienlai.Text = sc.ToString();
        }
    }
}
