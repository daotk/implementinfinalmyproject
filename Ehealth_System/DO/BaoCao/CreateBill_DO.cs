﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Objects;
namespace DO.BaoCao
{
    //initialize class
    public class CreateBill_DO
    {
        public string _BILLID { set; get; }
        public string _PATIENTNAME { set; get; }
        public string _USERNAME { set; get; }
        public string _PATIENTAGE { set; get; }
        public string _PATIENTGENDER { set; get; }
        public string _SERVICEGROUPNAME { set; get; }
        public DateTime _BILLDATE { set; get; }
        public string _BILLCOST { set; get; }
        public bool _BILLSTATUS { set; get; }
    }//end class
}//end namespace