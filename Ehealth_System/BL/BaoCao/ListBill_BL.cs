using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA.BaoCao;
using DO.BaoCao;
namespace BL.BaoCao
{
    public class ListBill_BL
    {
        public static List<ListBill_DO> GetDSBill()
        {
            return DA.BaoCao.ListBill_DA.GetDSBill();
        }
        public static List<DonViThuNgan_DO> GetDVTN()
        {
            return DA.BaoCao.ListBill_DA.GetDVTH();
        }
        public static List<LoaiDichVu_DO> GetDV()
        {
            return DA.BaoCao.ListBill_DA.GetDV();
        }
        public static List<ListBill_DO> GetDSLocDV(string NhomDV, string DVTN, DateTime ngay)
        {
            return DA.BaoCao.ListBill_DA.GetDSLocBill(NhomDV, DVTN, ngay);
        }

    }
}
