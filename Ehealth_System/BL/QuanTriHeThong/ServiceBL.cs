﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
using DA.QuanTriHeThong;

namespace BL.QuanTriHeThong
{
    public class ServiceBL
    {
        public static List<ServiceDO> GetService()
        {
            return DA.QuanTriHeThong.ServiceDA.GetService();
        }

        public static List<DO.QuanTriHeThong.GroupService_DO> GetAllSer1()
        {
            return ServiceDA.GetAllSer1();
        }

        public static void CreateService(string serviceid, string servicename, string servicegroupid, string servicecost, string servicedescription, bool trangthais)
        {
            DA.QuanTriHeThong.ServiceDA.CreateService(serviceid, servicename, servicegroupid, servicecost, servicedescription, trangthais);
        }

        public static void EditService(string serviceid, string servicename, string servicegroupid, string servicecost, string servicedescription, bool trangthais)
        {
            DA.QuanTriHeThong.ServiceDA.EditService(serviceid, servicename, servicegroupid, servicecost, servicedescription, trangthais);
        }

        public static List<ServiceDO> Get_Service(string tenviettats)
        {
            return DA.QuanTriHeThong.ServiceDA.Get_Service(tenviettats);
        }

        public static List<ServiceDO> SearchService(string ID)
        {
            return DA.QuanTriHeThong.ServiceDA.SearchService(ID);
        }

        public static List<ServiceDO> SearchGroupService(string ID)
        {
            return DA.QuanTriHeThong.ServiceDA.SearchGroupService(ID);
        }
        public static List<ServiceDO> SearchBohtService(string ID,String GroupID)
        {
            return DA.QuanTriHeThong.ServiceDA.SearchBothService(ID,GroupID);
        }
    }
}