using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;

namespace DA.QuanTriHeThong
{
    public class User_DA
    {
        public static List<User_DO> GetAllUserInfo()
        {
            List<User_DO> dsUser = new List<User_DO>();
            using (DA.Entity.EHealthSystemEntities dk = new DA.Entity.EHealthSystemEntities())
            {
                var query = from u in dk.User_Info select u;
                foreach (var row in query)
                {
                    User_DO us = new User_DO();
                    us._USERID = row.USERID;
                    us._USERNAME = row.USERNAME;
                    us._USERTYPEID = row.USERTYPEID;
                    us._GROUPUSERNAME = row.UserType_Info.USERTYPENAME;
                    us._EMAIL = row.EMAIL;
                    us._ACCOUNT = row.ACCOUNT;
                    us._PASSWORD = row.PASSWORD;
                    us._AUTHO = row.UserType_Info.AUTHORUZATION;
                    us._STATUS = row.STATUS;
                    us._ONLINE = row.ONLINE;
                    dsUser.Add(us);
                }
                return dsUser;
            }
        }//end 

        public static List<DO.QuanTriHeThong.UserGroup_DO> GetAllUser1()
        {
            List<DO.QuanTriHeThong.UserGroup_DO> ListDepartment = new List<DO.QuanTriHeThong.UserGroup_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.UserType_Info where u.USERTYPESTATUS == true select u;
                foreach (var row in query)
                {
                    DO.QuanTriHeThong.UserGroup_DO depart = new DO.QuanTriHeThong.UserGroup_DO();
                    depart.tennhom_ = row.USERTYPENAME;
                    depart.tenviettat_ = row.USERTYPEID;
                    ListDepartment.Add(depart);
                }
                return ListDepartment;
            }
        }//end

        public static void InsertUser(string IDUser, string HovaTen, string email,
          string nhomnguoidung, string taikhoan, string password, bool status)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                Entity.User_Info user = new Entity.User_Info();
                user.USERID = IDUser;
                user.USERNAME = HovaTen;
                user.EMAIL = email;
                user.USERTYPEID = nhomnguoidung;
                user.ACCOUNT = taikhoan;
                user.PASSWORD = password;
                user.STATUS = status;
                dk.User_Info.Add(user);
                dk.SaveChanges();
            }
        }

        public static void UpdateUser(string IDUser, string HovaTen, string email,
         string nhomnguoidung, string taikhoan, string matkhau, bool status)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = (from u in dk.User_Info
                             where u.USERID == IDUser
                             select u).First();
                query.USERNAME = HovaTen;
                query.EMAIL = email;
                query.USERTYPEID = nhomnguoidung;
                query.ACCOUNT = taikhoan;
                query.PASSWORD = matkhau;
                query.STATUS = status;
                dk.SaveChanges();
            }
        }

        public static void UpdateStatusOnline(string id, bool status)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = (from u in dk.User_Info
                             where u.USERID == id
                             select u).First();
                query.ONLINE = status;
                dk.SaveChanges();
            }
        }

        public static List<User_DO> GetUserInfoFollowUserID(string userid)
        {
            List<User_DO> dsUser = new List<User_DO>();
            using (DA.Entity.EHealthSystemEntities dk = new DA.Entity.EHealthSystemEntities())
            {
                var query = from u in dk.User_Info where u.USERID == userid select u;
                foreach (var row in query)
                {
                    User_DO us = new User_DO();
                    us._USERID = row.USERID;
                    us._USERNAME = row.USERNAME;
                    us._USERTYPEID = row.USERTYPEID;
                    us._GROUPUSERNAME = row.UserType_Info.USERTYPENAME;
                    us._EMAIL = row.EMAIL;
                    us._ACCOUNT = row.ACCOUNT;
                    us._PASSWORD = row.PASSWORD;
                    us._AUTHO = row.UserType_Info.AUTHORUZATION;
                    us._STATUS = row.STATUS;
                    dsUser.Add(us);
                }
                return dsUser;
            }
        }//end 

        public static void ChangePassword(string IDUser, string password)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = (from u in dk.User_Info
                             where u.USERID == IDUser
                             select u).First();
                query.PASSWORD = password;
                dk.SaveChanges();
            }
        }

    }
}
