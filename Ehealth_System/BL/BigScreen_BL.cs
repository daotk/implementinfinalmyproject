using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using DA;

namespace BL
{
    public class BigScreen_BL
    {
        public static List<DO.BigScreen_DO> Get()
        {
            return DA.BigScreen_DA.Get();
        }
    }
}