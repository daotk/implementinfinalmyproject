﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
using DA.QuanTriHeThong;
using DA;

namespace BL.ThuNgan
{
    public class TypeDepartment_TN_BL
    {

        public static List<DO.ThuNgan.TypeDepartment_TN_DO> GetTypeDepart()
        {
            return DA.ThuNgan.TypeDepartment_TN_DA.GetTypeDepartment();
        }
    }
}//end class