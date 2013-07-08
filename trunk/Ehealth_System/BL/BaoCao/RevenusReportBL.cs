using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA.BaoCao;
using DO.BaoCao;
namespace BL.BaoCao
{
    public class RevenusReportBL
    {
        public static List<LoaiDichVuDO> GetLoaiDichVu()
        {
            return DA.BaoCao.RevenusReportDA.GetLoaiDichVu();
        }
        public static List<DonViThuNganDO> GetDonViThuNgan()
        {
            return DA.BaoCao.RevenusReportDA.GetDonViThuNgan();
        }
        public static List<thongtinbaocaoDO> GetDonViThuNganTheoNgay(string tenloaidichvu, string tendonvithungan
            , DateTime ngay)
        {
            return DA.BaoCao.RevenusReportDA.GetDonViThuNganTheoNgay(tenloaidichvu, tendonvithungan, ngay);
        }
        public static List<thongtinbaocaoDO> GetDonViThuNganTheoThang(string tenloaidichvu, string tendonvithungan
           , DateTime ngay)
        {
            return DA.BaoCao.RevenusReportDA.GetDonViThuNganTheoThang(tenloaidichvu, tendonvithungan, ngay);
        }
    }
}
