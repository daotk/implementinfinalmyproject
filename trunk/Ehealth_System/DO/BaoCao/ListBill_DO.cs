using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DO.BaoCao
{
    public class ListBill_DO
    {
        public string _tendvtn { get; set; }
        public string _mabl { get; set; }
        public string _tenbn { get; set; }
        public string _tuoi { get; set; }
        public string _gioitinh { get; set; }
        public DateTime _thoigian { get; set; }
        public string _tongtien { get; set; }
        public string _nhomdv { get; set; }
    }

    public class DonViThuNgan_DO
    {
        public string _tenthungan { get; set; }
    }

    public class LoaiDichVu_DO
    {
        public string _tendichvu { get; set; }
    }
}