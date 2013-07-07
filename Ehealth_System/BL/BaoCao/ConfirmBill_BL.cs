using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA.BaoCao;
using DO.BaoCao;
using DO.QuanTriHeThong;
using DA.QuanTriHeThong;

namespace BL.BaoCao
{
   public class ConfirmBill_BL
    {
        public List<ConfirmBill_DO> GetAllBill()
        {
            return ConfirmBill_DA.GetAllBills();
        }

        public List<ConfirmBill_DO> GetBillsByDay(DateTime time, string userid)
        {
            return ConfirmBill_DA.GetBillsByDay(time, userid);
        }

        public List<ConfirmBill_DO> GetBillsByWeek(DateTime fromtime, DateTime totime, string userid)
        {
            return ConfirmBill_DA.GetBillsByWeek(fromtime, totime, userid);
        }

        public List<ConfirmBill_DO> GetBillsByMonth(string month, string userid)
        {
            return ConfirmBill_DA.GetBillsByMonth(month, userid);
        }

        public List<User_DO> GetAllUser()
        {
            return ConfirmBill_DA.GetAllUsers();
        }
    }//end class
}//end namespace
