﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Objects;
using DO.BaoCao;
using DO.QuanTriHeThong;

namespace DA.BaoCao
{
    //initialize class
    public class CreateBill_DA
    {
        //initialize new constructor to get all bill informations
        public static List<CreateBill_DO> GetAllBills()
        {
            //initialize constructor to get data from Entity model and assign them to grid view
            List<CreateBill_DO> ListBill = new List<CreateBill_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from bill in dk.Bill_Info
                            join user in dk.User_Info on bill.USERID equals user.USERID
                            join patient in dk.Patient_Info on bill.PATIENTID equals patient.PATIENTID
                            //join bill_info in dk.DetailBill_Info on bill.BILLID equals bill_info.BILLID
                            //join service_info in dk.Service_Info on bill_info.SERVICEID equals service_info.SERVICEID
                            //join servicegroup_info in dk.ServiceGroup_Info on service_info.SERVICEGROUPID equals servicegroup_info.SERVICEGROUPID
                            select new { user.USERNAME, bill.BILLID, patient.PATIENTNAME, patient.GENDER, patient.AGE, bill.BILLDATE, bill.BILLCOST, bill.SERVICEGROUPNAME, bill.BILLSTATUS };
                foreach (var row in query)
                {
                    CreateBill_DO bill = new CreateBill_DO();
                    bill._BILLID = row.BILLID;
                    bill._PATIENTNAME = row.PATIENTNAME;
                    bill._USERNAME = row.USERNAME;
                    bill._PATIENTGENDER = row.GENDER;
                    bill._PATIENTAGE = row.AGE;
                    bill._SERVICEGROUPNAME = row.SERVICEGROUPNAME;
                    bill._BILLDATE = row.BILLDATE;
                    bill._BILLCOST = Convert.ToInt32(row.BILLCOST);
                    bill._BILLSTATUS = row.BILLSTATUS;
                    ListBill.Add(bill);
                }
                //return a list of bill
                return ListBill;
            }
        }

        public static List<User_DO> GetAllUsers()
        {
            //initialize constructor to get data from Entity model and assign them to grid view
            List<User_DO> ListUser = new List<User_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.User_Info
                            where u.USERTYPEID == "TN" && u.STATUS == true
                            select u;
                User_DO user1 = new User_DO();
                user1._USERID = "0";
                user1._USERNAME = "Tất cả nhân viên";
                ListUser.Add(user1);
                foreach (var row in query)
                {
                    User_DO user = new User_DO();
                    user._USERID = row.USERID;
                    user._USERNAME = row.USERNAME;
                    ListUser.Add(user);
                }
                //return a list of bill
                return ListUser;
            }
        }

        public static List<CreateBill_DO> GetBillsByDay(DateTime time, string userid)
        {
            //initialize constructor to get data from Entity model and assign them to grid view
            List<CreateBill_DO> ListBill = new List<CreateBill_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                if (userid == "0")
                {
                    var query = from bill in dk.Bill_Info
                                join user in dk.User_Info on bill.USERID equals user.USERID
                                join patient in dk.Patient_Info on bill.PATIENTID equals patient.PATIENTID
                                //join bill_info in dk.DetailBill_Info on bill.BILLID equals bill_info.BILLID
                                //join service_info in dk.Service_Info on bill_info.SERVICEID equals service_info.SERVICEID
                                //join servicegroup_info in dk.ServiceGroup_Info on service_info.SERVICEGROUPID equals servicegroup_info.SERVICEGROUPID
                                where bill.BILLDATE.Day == time.Day && bill.BILLDATE.Month == time.Month
                                   && bill.BILLDATE.Year == time.Year
                                select new { user.USERNAME, bill.BILLID, patient.PATIENTNAME, patient.GENDER, patient.AGE, bill.BILLDATE, bill.BILLCOST, bill.SERVICEGROUPNAME, bill.BILLSTATUS };
                    foreach (var row in query)
                    {
                        CreateBill_DO bill = new CreateBill_DO();
                        bill._BILLID = row.BILLID;
                        bill._PATIENTNAME = row.PATIENTNAME;
                        bill._USERNAME = row.USERNAME;
                        bill._PATIENTGENDER = row.GENDER;
                        bill._PATIENTAGE = row.AGE;
                        bill._SERVICEGROUPNAME = row.SERVICEGROUPNAME;
                        bill._BILLDATE = row.BILLDATE;
                        bill._BILLCOST = Convert.ToInt32(row.BILLCOST);
                        bill._BILLSTATUS = row.BILLSTATUS;
                        ListBill.Add(bill);
                    }
                }
                else
                {
                    var query = from bill in dk.Bill_Info
                                join user in dk.User_Info on bill.USERID equals user.USERID
                                join patient in dk.Patient_Info on bill.PATIENTID equals patient.PATIENTID
                                //join bill_info in dk.DetailBill_Info on bill.BILLID equals bill_info.BILLID
                                //join service_info in dk.Service_Info on bill_info.SERVICEID equals service_info.SERVICEID
                                //join servicegroup_info in dk.ServiceGroup_Info on service_info.SERVICEGROUPID equals servicegroup_info.SERVICEGROUPID
                                where bill.USERID == userid && bill.BILLDATE.Day == time.Day && bill.BILLDATE.Month == time.Month
                                   && bill.BILLDATE.Year == time.Year
                                select new { user.USERNAME, bill.BILLID, patient.PATIENTNAME, patient.GENDER, patient.AGE, bill.BILLDATE, bill.BILLCOST, bill.SERVICEGROUPNAME, bill.BILLSTATUS };
                    foreach (var row in query)
                    {
                        CreateBill_DO bill = new CreateBill_DO();
                        bill._BILLID = row.BILLID;
                        bill._PATIENTNAME = row.PATIENTNAME;
                        bill._USERNAME = row.USERNAME;
                        bill._PATIENTGENDER = row.GENDER;
                        bill._PATIENTAGE = row.AGE;
                        bill._SERVICEGROUPNAME = row.SERVICEGROUPNAME;
                        bill._BILLDATE = row.BILLDATE;
                        bill._BILLCOST = Convert.ToInt32(row.BILLCOST);
                        bill._BILLSTATUS = row.BILLSTATUS;
                        ListBill.Add(bill);
                    }
                }
                //return a list of bill
                return ListBill;
            }
        }

        public static List<CreateBill_DO> GetBillsByWeek(DateTime fromtime, DateTime totime, string userid)
        {
            //initialize constructor to get data from Entity model and assign them to grid view
            List<CreateBill_DO> ListBill = new List<CreateBill_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                if (userid == "0")
                {
                    var query = from bill in dk.Bill_Info
                                join user in dk.User_Info on bill.USERID equals user.USERID
                                join patient in dk.Patient_Info on bill.PATIENTID equals patient.PATIENTID
                                //join bill_info in dk.DetailBill_Info on bill.BILLID equals bill_info.BILLID
                                //join service_info in dk.Service_Info on bill_info.SERVICEID equals service_info.SERVICEID
                                //join servicegroup_info in dk.ServiceGroup_Info on service_info.SERVICEGROUPID equals servicegroup_info.SERVICEGROUPID
                                where bill.BILLDATE >= fromtime && bill.BILLDATE < totime
                                select new { user.USERNAME, bill.BILLID, patient.PATIENTNAME, patient.GENDER, patient.AGE, bill.BILLDATE, bill.BILLCOST, bill.SERVICEGROUPNAME, bill.BILLSTATUS };
                    foreach (var row in query)
                    {
                        CreateBill_DO bill = new CreateBill_DO();
                        bill._BILLID = row.BILLID;
                        bill._PATIENTNAME = row.PATIENTNAME;
                        bill._USERNAME = row.USERNAME;
                        bill._PATIENTGENDER = row.GENDER;
                        bill._PATIENTAGE = row.AGE;
                        bill._SERVICEGROUPNAME = row.SERVICEGROUPNAME;
                        bill._BILLDATE = row.BILLDATE;
                        bill._BILLCOST = Convert.ToInt32(row.BILLCOST);
                        bill._BILLSTATUS = row.BILLSTATUS;
                        ListBill.Add(bill);
                    }
                }
                else
                {
                    var query = from bill in dk.Bill_Info
                                join user in dk.User_Info on bill.USERID equals user.USERID
                                join patient in dk.Patient_Info on bill.PATIENTID equals patient.PATIENTID
                                //join bill_info in dk.DetailBill_Info on bill.BILLID equals bill_info.BILLID
                                //join service_info in dk.Service_Info on bill_info.SERVICEID equals service_info.SERVICEID
                                //join servicegroup_info in dk.ServiceGroup_Info on service_info.SERVICEGROUPID equals servicegroup_info.SERVICEGROUPID
                                where bill.USERID == userid && bill.BILLDATE >= fromtime && bill.BILLDATE < totime
                                select new { user.USERNAME, bill.BILLID, patient.PATIENTNAME, patient.GENDER, patient.AGE, bill.BILLDATE, bill.BILLCOST, bill.SERVICEGROUPNAME, bill.BILLSTATUS };
                    foreach (var row in query)
                    {
                        CreateBill_DO bill = new CreateBill_DO();
                        bill._BILLID = row.BILLID;
                        bill._PATIENTNAME = row.PATIENTNAME;
                        bill._USERNAME = row.USERNAME;
                        bill._PATIENTGENDER = row.GENDER;
                        bill._PATIENTAGE = row.AGE;
                        bill._SERVICEGROUPNAME = row.SERVICEGROUPNAME;
                        bill._BILLDATE = row.BILLDATE;
                        bill._BILLCOST = Convert.ToInt32(row.BILLCOST);
                        bill._BILLSTATUS = row.BILLSTATUS;
                        ListBill.Add(bill);
                    }
                }
                //return a list of bill
                return ListBill;
            }
        }

        public static List<CreateBill_DO> GetBillsByMonth(DateTime month, string userid)
        {
          //  int m = Convert.ToInt16(month);
            //initialize constructor to get data from Entity model and assign them to grid view
            List<CreateBill_DO> ListBill = new List<CreateBill_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                if (userid == "0")
                {
                    var query = from bill in dk.Bill_Info
                                join user in dk.User_Info on bill.USERID equals user.USERID
                                join patient in dk.Patient_Info on bill.PATIENTID equals patient.PATIENTID
                                //join bill_info in dk.DetailBill_Info on bill.BILLID equals bill_info.BILLID
                                //join service_info in dk.Service_Info on bill_info.SERVICEID equals service_info.SERVICEID
                                //join servicegroup_info in dk.ServiceGroup_Info on service_info.SERVICEGROUPID equals servicegroup_info.SERVICEGROUPID
                                where  
                                bill.BILLDATE.Month == month.Month
                                && bill.BILLDATE.Year == month.Year
                                select new { user.USERNAME, bill.BILLID, patient.PATIENTNAME, patient.GENDER, patient.AGE, bill.BILLDATE, bill.BILLCOST, bill.SERVICEGROUPNAME, bill.BILLSTATUS };
                    foreach (var row in query)
                    {
                        CreateBill_DO bill = new CreateBill_DO();
                        bill._BILLID = row.BILLID;
                        bill._PATIENTNAME = row.PATIENTNAME;
                        bill._USERNAME = row.USERNAME;
                        bill._PATIENTGENDER = row.GENDER;
                        bill._PATIENTAGE = row.AGE;
                        bill._SERVICEGROUPNAME = row.SERVICEGROUPNAME;
                        bill._BILLDATE = row.BILLDATE;
                        bill._BILLCOST = Convert.ToInt32(row.BILLCOST);
                        bill._BILLSTATUS = row.BILLSTATUS;
                        ListBill.Add(bill);
                    }
                }
                else
                {
                    var query = from bill in dk.Bill_Info
                                join user in dk.User_Info on bill.USERID equals user.USERID
                                join patient in dk.Patient_Info on bill.PATIENTID equals patient.PATIENTID
                                //join bill_info in dk.DetailBill_Info on bill.BILLID equals bill_info.BILLID
                                //join service_info in dk.Service_Info on bill_info.SERVICEID equals service_info.SERVICEID
                                //join servicegroup_info in dk.ServiceGroup_Info on service_info.SERVICEGROUPID equals servicegroup_info.SERVICEGROUPID
                                where bill.USERID == userid && 
                                bill.BILLDATE.Month == month.Month
                                && bill.BILLDATE.Year == month.Year
                                select new { user.USERNAME, bill.BILLID, patient.PATIENTNAME, patient.GENDER, patient.AGE, bill.BILLDATE, bill.BILLCOST, bill.SERVICEGROUPNAME, bill.BILLSTATUS };
                    foreach (var row in query)
                    {
                        CreateBill_DO bill = new CreateBill_DO();
                        bill._BILLID = row.BILLID;
                        bill._PATIENTNAME = row.PATIENTNAME;
                        bill._USERNAME = row.USERNAME;
                        bill._PATIENTGENDER = row.GENDER;
                        bill._PATIENTAGE = row.AGE;
                        bill._SERVICEGROUPNAME = row.SERVICEGROUPNAME;
                        bill._BILLDATE = row.BILLDATE;
                        bill._BILLCOST = Convert.ToInt32(row.BILLCOST);
                        bill._BILLSTATUS = row.BILLSTATUS;
                        ListBill.Add(bill);
                    }
                }
                //return a list of bill
                return ListBill;
            }
        }
    }//end class
}//end namespace