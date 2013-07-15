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

                DonViThuNganDO us1 = new DonViThuNganDO();
                us1.tendonvithungan_ = "Tất cả đơn vị";
                dsusergroup.Add(us1); 
                foreach (var row in query)
                {
                    DonViThuNganDO us = new DonViThuNganDO();
                    us.tendonvithungan_ = row.DEPARTMENTNAME;
                    dsusergroup.Add(us);
                }
                
                
            }
            return dsusergroup;
        }

        public static List<thongtinbaocaoDO> GetDonViThuNganTheoNgay( string tendonvithungan
            , DateTime ngay )
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
                            
                            select  u ;
                foreach (var row in query)
                {
                    thongtinbaocaoDO us = new thongtinbaocaoDO();
                    us.tendonvithungan_ = row.DeskCashier.Department_Info.DEPARTMENTNAME;
                    
                    us.ngaydangky_ = row.BILLDATE;
                    us.tongtien_ = row.BILLCOST;
               //     us.tennhomdichvu_ = row.SERVICEGROUPNAME;
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }

        public static List<thongtinbaocaoDO> GetDonViThuNganTheoThang( string tendonvithungan
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
                
                    us.ngaydangky_ = row.BILLDATE;
                    us.tongtien_ = row.BILLCOST;
                   
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }
        public static List<thongtinbaocaoDO> GetDonViThuNganTheoTuan(string tendonvithungan
            , DateTime begin,DateTime end)
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
                                && u.BILLDATE<= end 
                                && u.BILLDATE>= begin
                                


                            select u;
                foreach (var row in query)
                {
                    thongtinbaocaoDO us = new thongtinbaocaoDO();
                    us.tendonvithungan_ = row.DeskCashier.Department_Info.DEPARTMENTNAME;
                    
                    us.ngaydangky_ = row.BILLDATE;
                    us.tongtien_ = row.BILLCOST;
                    
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }

        public static List<thongtinbaocaoDO> GetDonViThuNganTheoNgayAll( string tendonvithungan
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
                             //     && p.Department_Info.DEPARTMENTNAME == tendonvithungan
                                  && u.BILLDATE.Day == ngay.Day
                                  && u.BILLDATE.Month == ngay.Month
                                  && u.BILLDATE.Year == ngay.Year

                            select u;
                foreach (var row in query)
                {
                    thongtinbaocaoDO us = new thongtinbaocaoDO();
                    us.tendonvithungan_ = row.DeskCashier.Department_Info.DEPARTMENTNAME;
                    
                    
                    us.ngaydangky_ = row.BILLDATE;
                    us.tongtien_ = row.BILLCOST;
                   
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }
        public static List<thongtinbaocaoDO> GetDonViThuNganTheoThangAll( string tendonvithungan
            , DateTime ngay)
        {
            List<thongtinbaocaoDO> dsusergroup = new List<thongtinbaocaoDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Bill_Info
                            join p in dk.DeskCashiers on u.DESKID equals p.DESKID
                            join k in dk.Patient_Info on u.PATIENTID equals k.PATIENTID
                            where 
                               //    p.Department_Info.DEPARTMENTNAME == tendonvithungan
                                 u.BILLSTATUS == true
                                 && u.BILLDATE.Month == ngay.Month


                            select u;
                foreach (var row in query)
                {
                    thongtinbaocaoDO us = new thongtinbaocaoDO();
                    us.tendonvithungan_ = row.DeskCashier.Department_Info.DEPARTMENTNAME;
                    
                   
                    us.ngaydangky_ = row.BILLDATE;
                    us.tongtien_ = row.BILLCOST;
                   
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }

    }
}
