using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class DimensionExportModel
    {
        public DateTime Date { get; set; }
        public string Barcode { get; set; }
        public string Code { get; set; }
        public string Itemname { get; set; }
        public string Itemcode { get; set; }
        public string Location { get; set; }
        public string UOM { get; set; }
        public string uom_qty { get; set; }
        public Double width { get; set; }
        public Double height { get; set; }
        public Double length { get; set; }
        public Double weight { get; set; }
        public string packing { get; set; }
        public string packing2 { get; set; }
        public string exp { get; set; }
        public string careful { get; set; }
        public string special { get; set; }
        public string chem { get; set; }
        public string bigsize { get; set; }
        public DateTime created_datetime { get; set; }

    }
}