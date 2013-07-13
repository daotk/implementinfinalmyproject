using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;

namespace DA.QuanTriHeThong
{
    public class GroupService_DA
    {
        public static List<GroupService_DO> GetGroupService()
        {
            List<GroupService_DO> dsGroupService = new List<GroupService_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.ServiceGroup_Info select u;
                foreach (var row in query)
                {
                    GroupService_DO us = new GroupService_DO();
                    us._SERVICEGROUPID = row.SERVICEGROUPID;
                    us._SERVICEGROUPNAME = row.SERVICEGROUPNAME;
                    us._SERVICEBROUPDESCRIPTION = row.SERVICEBROUPDESCRIPTION;
                    us._SERVICEGROUPSTATUS = row.SERVICEGROUPSTATUS;
                    dsGroupService.Add(us);
                }
                return dsGroupService;
            }
        }

        public static void CreateGroupService(string GroupService, string GroupServiceName, string GroupServiceDescription, bool GroupServiceStatus)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                Entity.ServiceGroup_Info user = new Entity.ServiceGroup_Info();
                user.SERVICEGROUPID = GroupService;
                user.SERVICEGROUPNAME = GroupServiceName;
                user.SERVICEBROUPDESCRIPTION = GroupServiceDescription;
                user.SERVICEGROUPSTATUS = GroupServiceStatus;
                dk.ServiceGroup_Info.AddObject(user);
                dk.SaveChanges();
            }
        }

        public static void EditGroupService(string GroupService, string GroupServiceName, string GroupServiceDescription, bool GroupServiceStatus)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = (from u in dk.ServiceGroup_Info
                             where u.SERVICEGROUPID == GroupService
                             select u).First();
                query.SERVICEGROUPID = GroupService;
                query.SERVICEGROUPNAME = GroupServiceName;
                query.SERVICEBROUPDESCRIPTION = GroupServiceDescription;
                query.SERVICEGROUPSTATUS = GroupServiceStatus;
                dk.SaveChanges();
            }
        }
        public static List<GroupService_DO> Get_GroupService(string tenviettats)
        {
            List<GroupService_DO> serviceinfo = new List<GroupService_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.ServiceGroup_Info where u.SERVICEGROUPID == tenviettats select u;
                foreach (var row in query)
                {
                    GroupService_DO us = new GroupService_DO();
                    us._SERVICEGROUPID = row.SERVICEGROUPID;
                    us._SERVICEGROUPNAME = row.SERVICEGROUPNAME;
                    us._SERVICEBROUPDESCRIPTION = row.SERVICEBROUPDESCRIPTION;
                    us._SERVICEGROUPSTATUS = row.SERVICEGROUPSTATUS;
                    serviceinfo.Add(us);
                }
            }
            return serviceinfo;
        }

        public static List<GroupService_DO> SearchTypeService(string Search)
        {
            List<GroupService_DO> search = new List<GroupService_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.ServiceGroup_Info where (u.SERVICEGROUPNAME.Contains(Search)) select u;
                foreach (var row in query)
                {
                    GroupService_DO groupservice = new GroupService_DO();
                    groupservice._SERVICEGROUPID = row.SERVICEGROUPID;
                    groupservice._SERVICEGROUPNAME = row.SERVICEGROUPNAME;
                    groupservice._SERVICEBROUPDESCRIPTION = row.SERVICEBROUPDESCRIPTION;
                    groupservice._SERVICEGROUPSTATUS = row.SERVICEGROUPSTATUS;
                    search.Add(groupservice);
                }
                return search;
            }
        }
    }
}