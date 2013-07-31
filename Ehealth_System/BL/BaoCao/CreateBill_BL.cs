using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.BaoCao;
using DA.BaoCao;
using DO.QuanTriHeThong;

namespace BL.BaoCao
{
    //initialize class
    public class CreateBill_BL
    {
        //initialize new constructor to get all cities
        public List<CreateBill_DO> GetAllBill()
        {
            return CreateBill_DA.GetAllBills();
        }

        public List<CreateBill_DO> GetBillsByDay(DateTime time, string userid)
        {
            return CreateBill_DA.GetBillsByDay(time, userid);
        }

        public List<CreateBill_DO> GetBillsByWeek(DateTime fromtime, DateTime totime, string userid)
        {
            return CreateBill_DA.GetBillsByWeek(fromtime, totime, userid);
        }

        public List<CreateBill_DO> GetBillsByMonth(DateTime month, string userid)
        {
            return CreateBill_DA.GetBillsByMonth(month, userid);
        }

        public List<User_DO> GetAllUser()
        {
            return CreateBill_DA.GetAllUsers();
        }
    }//end class
}//end namespace