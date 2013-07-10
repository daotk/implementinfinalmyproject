using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.BaoCao;

namespace DA.BaoCao
{
    public class RevenusReportDA
    {
        public static List<LoaiDichVuDO> GetLoaiDichVu()
        {
            List<LoaiDichVuDO> dsusergroup = new List<LoaiDichVuDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.ServiceGroup_Info select u;
                foreach (var row in query)
                {
                    LoaiDichVuDO us = new LoaiDichVuDO();
                    us.tendichvu_ = row.SERVICEGROUPNAME;
                    dsusergroup.Add(us);
                }
                LoaiDichVuDO us1 = new LoaiDichVuDO();
                us1.tendichvu_ = "Tất cả loại dịch vụ";
                dsusergroup.Add(us1);
            }
            return dsusergroup;
        }

        public static List<DonViThuNganDO> GetDonViThuNgan()
        {
            List<DonViThuNganDO> dsusergroup = new List<DonViThuNganDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Department_Info 
                            where u.DEPARTMENTTYPEID == "TN"
                            select u;
                foreach (var row in query)
                {
                    DonViThuNganDO us = new DonViThuNganDO();
                    us.tendonvithungan_ = row.DEPARTMENTNAME;
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }

        public static List<thongtinbaocaoDO> GetDonViThuNganTheoNgay(string tenloaidichvu, string tendonvithungan
            , DateTime ngay )
        {
            List<thongtinbaocaoDO> dsusergroup = new List<thongtinbaocaoDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Bill_Info
                            join p in dk.DeskCashiers on u.DESKID equals p.DESKID
                            join k in dk.Patient_Info on u.PATIENTID equals k.PATIENTID
                            where u.SERVICEGROUPNAME == tenloaidichvu
                                  && u.BILLSTATUS == true
                                  && p.Department_Info.DEPARTMENTNAME == tendonvithungan
                                  && u.BILLDATE.Day == ngay.Day 
                                  && u.BILLDATE.Month == ngay.Month
                                  && u.BILLDATE.Year == ngay.Year
                            
                            select  u ;
                foreach (var row in query)
                {
                    thongtinbaocaoDO us = new thongtinbaocaoDO();
                    us.tendonvithungan_ = row.DeskCashier.Department_Info.DEPARTMENTNAME;
                    us.mabienlai_ = row.BILLID;
                    us.hotenbenhnhan_ = row.Patient_Info.PATIENTNAME;
                    us.tuoibenhnhan_ = row.Patient_Info.AGE;
                    us.gioitinh_ = row.Patient_Info.GENDER;
                    us.ngaydangky_ = row.BILLDATE;
                    us.tongtien_ = row.BILLCOST;
                    us.tennhomdichvu_ = row.SERVICEGROUPNAME;
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }

        public static List<thongtinbaocaoDO> GetDonViThuNganTheoThang(string tenloaidichvu, string tendonvithungan
            , DateTime ngay)
        {
            List<thongtinbaocaoDO> dsusergroup = new List<thongtinbaocaoDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Bill_Info
                            join p in dk.DeskCashiers on u.DESKID equals p.DESKID
                            join k in dk.Patient_Info on u.PATIENTID equals k.PATIENTID
                            where u.SERVICEGROUPNAME == tenloaidichvu
                                  && p.Department_Info.DEPARTMENTNAME == tendonvithungan
                                && u.BILLSTATUS == true
                                 && u.BILLDATE.Month == ngay.Month
                                

                            select u;
                foreach (var row in query)
                {
                    thongtinbaocaoDO us = new thongtinbaocaoDO();
                    us.tendonvithungan_ = row.DeskCashier.Department_Info.DEPARTMENTNAME;
                    us.mabienlai_ = row.BILLID;
                    us.hotenbenhnhan_ = row.Patient_Info.PATIENTNAME;
                    us.tuoibenhnhan_ = row.Patient_Info.AGE;
                    us.gioitinh_ = row.Patient_Info.GENDER;
                    us.ngaydangky_ = row.BILLDATE;
                    us.tongtien_ = row.BILLCOST;
                    us.tennhomdichvu_ = row.SERVICEGROUPNAME;
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }

        public static List<thongtinbaocaoDO> GetDonViThuNganTheoNgayAll(string tenloaidichvu, string tendonvithungan
            , DateTime ngay)
        {
            List<thongtinbaocaoDO> dsusergroup = new List<thongtinbaocaoDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Bill_Info
                            join p in dk.DeskCashiers on u.DESKID equals p.DESKID
                            join k in dk.Patient_Info on u.PATIENTID equals k.PATIENTID
                            where 
                                   u.BILLSTATUS == true
                                  && p.Department_Info.DEPARTMENTNAME == tendonvithungan
                                  && u.BILLDATE.Day == ngay.Day
                                  && u.BILLDATE.Month == ngay.Month
                                  && u.BILLDATE.Year == ngay.Year

                            select u;
                foreach (var row in query)
                {
                    thongtinbaocaoDO us = new thongtinbaocaoDO();
                    us.tendonvithungan_ = row.DeskCashier.Department_Info.DEPARTMENTNAME;
                    us.mabienlai_ = row.BILLID;
                    us.hotenbenhnhan_ = row.Patient_Info.PATIENTNAME;
                    us.tuoibenhnhan_ = row.Patient_Info.AGE;
                    us.gioitinh_ = row.Patient_Info.GENDER;
                    us.ngaydangky_ = row.BILLDATE;
                    us.tongtien_ = row.BILLCOST;
                    us.tennhomdichvu_ = row.SERVICEGROUPNAME;
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }
        public static List<thongtinbaocaoDO> GetDonViThuNganTheoThangAll(string tenloaidichvu, string tendonvithungan
            , DateTime ngay)
        {
            List<thongtinbaocaoDO> dsusergroup = new List<thongtinbaocaoDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Bill_Info
                            join p in dk.DeskCashiers on u.DESKID equals p.DESKID
                            join k in dk.Patient_Info on u.PATIENTID equals k.PATIENTID
                            where 
                                   p.Department_Info.DEPARTMENTNAME == tendonvithungan
                                && u.BILLSTATUS == true
                                 && u.BILLDATE.Month == ngay.Month


                            select u;
                foreach (var row in query)
                {
                    thongtinbaocaoDO us = new thongtinbaocaoDO();
                    us.tendonvithungan_ = row.DeskCashier.Department_Info.DEPARTMENTNAME;
                    us.mabienlai_ = row.BILLID;
                    us.hotenbenhnhan_ = row.Patient_Info.PATIENTNAME;
                    us.tuoibenhnhan_ = row.Patient_Info.AGE;
                    us.gioitinh_ = row.Patient_Info.GENDER;
                    us.ngaydangky_ = row.BILLDATE;
                    us.tongtien_ = row.BILLCOST;
                    us.tennhomdichvu_ = row.SERVICEGROUPNAME;
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }

    }
}
