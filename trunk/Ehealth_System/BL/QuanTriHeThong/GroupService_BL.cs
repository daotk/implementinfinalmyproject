using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA.QuanTriHeThong;
using DO.QuanTriHeThong;
namespace BL.QuanTriHeThong
{
    public class GroupService_BL
    {
        public static List<GroupService_DO> GetGroupService()
        {
            return DA.QuanTriHeThong.GroupService_DA.GetGroupService();
        }

        public static void CreateGroupService(string GroupService, string GroupServiceName, string GroupServiceDescription, bool GroupServiceStatus)
        {
            DA.QuanTriHeThong.GroupService_DA.CreateGroupService(GroupService, GroupServiceName, GroupServiceDescription, GroupServiceStatus);
        }

        public static void EditGroupService(string GroupService, string GroupServiceName, string GroupServiceDescription, bool GroupServiceStatus)
        {
            DA.QuanTriHeThong.GroupService_DA.EditGroupService(GroupService, GroupServiceName, GroupServiceDescription, GroupServiceStatus);
        }

        public static List<GroupService_DO> Get_GroupService(string tenviettats)
        {
            return DA.QuanTriHeThong.GroupService_DA.Get_GroupService(tenviettats);
        }

        public static List<GroupService_DO> SearchGroupService(string ID)
        {
            return DA.QuanTriHeThong.GroupService_DA.SearchTypeService(ID);
        }
    }
}