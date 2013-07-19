using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA.QuanTriHeThong;
using DO.QuanTriHeThong;

namespace BL.QuanTriHeThong
{
    public class User_BL
    {
        public static bool CheckLogin(string username, string password)
        {
            bool check = false;
            List<User_DO> ds = DA.QuanTriHeThong.User_DA.GetAllUserInfo();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i]._ACCOUNT == username && ds[i]._PASSWORD == password)
                {
                    BL.StaticClass.UserID = ds[i]._USERID;
                    BL.StaticClass.GroupUser = ds[i]._GROUPUSERNAME;
                    BL.StaticClass.UserName = ds[i]._USERNAME;
                    BL.StaticClass.Authorization = ds[i]._AUTHO;
                    BL.StaticClass.StatusUser = ds[i]._STATUS;
                    BL.StaticClass.Online = ds[i]._ONLINE;
                    check = true;
                }
            }
            return check;
        }

        public static List<User_DO> GetAllUserInfo()
        {
            return DA.QuanTriHeThong.User_DA.GetAllUserInfo();
        }

        public static List<DO.QuanTriHeThong.UserGroup_DO> GetAllUser1()
        {
            return DA.QuanTriHeThong.User_DA.GetAllUser1();
        }

        public static List<User_DO> GetUSerInfoFollowUserID(string userid)
        {
            return DA.QuanTriHeThong.User_DA.GetUserInfoFollowUserID(userid);
        }

        public static int InsertUser(string IdUser, string hovaten, string email,
          string nhomnguoidung, string taikhoan, string password, bool status)
        {
            return DA.QuanTriHeThong.User_DA.InsertUser(IdUser, hovaten, email, nhomnguoidung, taikhoan, password, status);
        }

        public static void UpdateUser(string IdUser, string hovaten, string email,
         string nhomnguoidung, string taikhoan, string matkhau, bool status)
        {
            DA.QuanTriHeThong.User_DA.UpdateUser(IdUser, hovaten, email, nhomnguoidung, taikhoan, matkhau, status);
        }

        public static void UpdateStatusOnline(string IdUser, bool status)
        {
            DA.QuanTriHeThong.User_DA.UpdateStatusOnline(IdUser, status);
        }

        public static void ChangePassword(string IdUser, string password)
        {
            DA.QuanTriHeThong.User_DA.ChangePassword(IdUser, password);
        }
    }
}