﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
using DA.QuanTriHeThong;

namespace BL.QuanTriHeThong
{
    public class TypeDepartment_BL
    {
        public static List<TypeDepartment_DO> GetAllDepartment()
        {
            return DA.QuanTriHeThong.TypeDepartment_DA.GetAllDepartments();
        }

        public static int add(String ID, String name, String desscription, bool status)
        {
            return DA.QuanTriHeThong.TypeDepartment_DA.add(ID, name, desscription, status);
        }

        public static int edit(String ID, String name, String desscription, bool status)
        {
            return DA.QuanTriHeThong.TypeDepartment_DA.edit(ID, name, desscription, status);
        }

        public static List<TypeDepartment_DO> SearchTypeDepart(String name)
        {
            return TypeDepartment_DA.SearchTypeDepart(name);
        }
    }
}//end class