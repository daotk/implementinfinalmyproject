using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;


namespace DA
{
    public class BigScreen_DA
    {
        public static List<DO.BigScreen_DO> Get()
        {
            List<BigScreen_DO> dsthongtin = new List<BigScreen_DO>();
            using (DA.Entity.EHealthSystemEntities dk = new DA.Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Bill_Info select u;
                foreach (var row in query)
                {
                    DO.BigScreen_DO us = new DO.BigScreen_DO();
                    us._MaBN = row.Patient_Info.PATIENTID;
                    us._TenBN = row.Patient_Info.PATIENTNAME;
                    us._TongTien = row.BILLCOST;
                    dsthongtin.Add(us);
                }
                return dsthongtin;
            }
        }
    }
}
