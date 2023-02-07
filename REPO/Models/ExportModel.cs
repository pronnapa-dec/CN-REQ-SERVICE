using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class ExportGoodPriceModel
    {
        public string code { get; set; }
        public string itemname { get; set; }
        public string goutput { get; set; }
        public int prqty { get; set; }
        public string gunit { get; set; }
        public double qtysmall { get; set; }
        public double gpricepur { get; set; }
        public double gprice { get; set; }
        public double gpriceA { get; set; }
        public double gpriceB { get; set; }
        public double gpriceC { get; set; }
        public double gpriceD { get; set; }
        public double gpriceE { get; set; }
        public double gpriceF { get; set; }

    }
}