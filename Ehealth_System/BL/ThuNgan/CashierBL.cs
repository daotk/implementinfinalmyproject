using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.Thu_Ngan;
using DA.Thu_Ngan;
namespace BL.ThuNgan
{
    public class CashierBL
    {
        public static List<HoaDonDO> LoadDSbenhnhan(string deskid)
        {
            return DA.Thu_Ngan.CashierDA.LoadDSbenhnhan(deskid);
        }

        public static List<DSbenhnhanDO> Loadbenhnhan(string mabenhnhan)
        {
            return DA.Thu_Ngan.CashierDA.Loadbenhnhan(mabenhnhan);
        }

        public static List<ThongTinBenhNhanDO> LoadThongTinBenhNhan(string tenbenhnhan)
        {
            return DA.Thu_Ngan.CashierDA.LoadThongTinBenhNhan(tenbenhnhan);
        }

        public static List<DSLoaiDichVuDO> LoadLoaiDichVu(string tenbenhnhan)
        {
            return DA.Thu_Ngan.CashierDA.LoadLoaiDichVu(tenbenhnhan);
        }

        public static void CapNhatBill(string mahoadon, string Conrfirmid, bool trangthai)
        {
            DA.Thu_Ngan.CashierDA.CapNhatBill(mahoadon, Conrfirmid, trangthai);
        }
    }
}