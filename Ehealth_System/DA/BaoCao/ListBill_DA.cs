using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.BaoCao;

namespace DA.BaoCao
{
    public class ListBill_DA
    {
        public static List<DonViThuNgan_DO> GetDVTH()
        {
            List<DonViThuNgan_DO> dsThungan = new List<DonViThuNgan_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Department_Info select u;
                foreach (var row in query)
                {
                    DonViThuNgan_DO dv = new DonViThuNgan_DO();
                    dv._tenthungan = row.DEPARTMENTNAME;
                    dsThungan.Add(dv);
                }
                DonViThuNgan_DO dv1 = new DonViThuNgan_DO();
                dv1._tenthungan = "Tất cả thu ngân";
                dsThungan.Add(dv1);
            }
            return dsThungan;
        }

        public static List<LoaiDichVu_DO> GetDV()
        {
            List<LoaiDichVu_DO> dsDichvu = new List<LoaiDichVu_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.ServiceGroup_Info select u;
                foreach (var row in query)
                {
                    LoaiDichVu_DO dv = new LoaiDichVu_DO();
                    dv._tendichvu = row.SERVICEGROUPNAME;
                    dsDichvu.Add(dv);
                }
            }
            return dsDichvu;
        }

        public static List<ListBill_DO> GetDSBill()
        {
            List<ListBill_DO> dsBill = new List<ListBill_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Bill_Info
                            join p in dk.Patient_Info on u.PATIENTID equals p.PATIENTID
                            join k in dk.DeskCashiers on u.DESKID equals k.DESKID
                            select new
                            {
                                k.Department_Info.DEPARTMENTNAME,
                                u.BILLID,
                                p.PATIENTNAME,
                                p.AGE,
                                p.GENDER,
                                u.BILLDATE,
                                u.BILLCOST,
                                u.SERVICEGROUPNAME
                            };
                foreach (var row in query)
                {
                    ListBill_DO us = new ListBill_DO();
                    us._tendvtn = row.DEPARTMENTNAME;
                    us._mabl = row.BILLID;
                    us._tenbn = row.PATIENTNAME;
                    us._tuoi = row.AGE;
                    us._gioitinh = row.GENDER;
                    us._thoigian = row.BILLDATE;
                    us._tongtien = row.BILLCOST;
                    us._nhomdv = row.SERVICEGROUPNAME;
                    dsBill.Add(us);
                }
            }
            return dsBill;
        }

        public static List<ListBill_DO> GetDSLocBill(string LoaiDichVu, string NhomThuNgan, DateTime ngay)
        {
            List<ListBill_DO> dsSearch = new List<ListBill_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Bill_Info
                            join p in dk.Patient_Info on u.PATIENTID equals p.PATIENTID
                            join k in dk.DeskCashiers on u.DESKID equals k.DESKID
                            where u.SERVICEGROUPNAME == LoaiDichVu
                            && u.DeskCashier.Department_Info.DEPARTMENTNAME == NhomThuNgan
                            && u.BILLDATE.Day == ngay.Day
                            && u.BILLDATE.Month == ngay.Month
                            && u.BILLDATE.Year == ngay.Year
                            select u;
                foreach (var row in query)
                {
                    ListBill_DO u = new ListBill_DO();
                    u._tendvtn = row.DeskCashier.Department_Info.DEPARTMENTNAME;
                    u._mabl = row.BILLID;
                    u._tenbn = row.Patient_Info.PATIENTNAME;
                    u._tuoi = row.Patient_Info.AGE;
                    u._gioitinh = row.Patient_Info.GENDER;
                    u._thoigian = row.BILLDATE;
                    u._tongtien = row.BILLCOST;
                    u._nhomdv = row.SERVICEGROUPNAME;
                    dsSearch.Add(u);
                }
            }
            return dsSearch;
        }

        public static List<ListBill_DO> GetDSLocBillAll(string LoaiDichVu, string NhomThuNgan, DateTime ngay)
        {
            List<ListBill_DO> dsSearch = new List<ListBill_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Bill_Info
                            join p in dk.Patient_Info on u.PATIENTID equals p.PATIENTID
                            //join k in dk.DeskCashiers on u.DESKID equals k.DESKID
                            where u.SERVICEGROUPNAME == LoaiDichVu
                            && u.BILLDATE.Day == ngay.Day
                            && u.BILLDATE.Month == ngay.Month
                            && u.BILLDATE.Year == ngay.Year
                            select u;
                foreach (var row in query)
                {
                    ListBill_DO u = new ListBill_DO();
                    u._tendvtn = row.DeskCashier.Department_Info.DEPARTMENTNAME;
                    u._mabl = row.BILLID;
                    u._tenbn = row.Patient_Info.PATIENTNAME;
                    u._tuoi = row.Patient_Info.AGE;
                    u._gioitinh = row.Patient_Info.GENDER;
                    u._thoigian = row.BILLDATE;
                    u._tongtien = row.BILLCOST;
                    u._nhomdv = row.SERVICEGROUPNAME;
                    dsSearch.Add(u);
                }
            }
            return dsSearch;
        }
    }
}