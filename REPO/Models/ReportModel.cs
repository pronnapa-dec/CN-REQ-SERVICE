using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class ReportModel
    {
        public string report_id { get; set; }
        public string report_app { get; set; }
        public string report_pos { get; set; }
        public string report_name { get; set; }
        public string report_link { get; set; }
        public string report_versions { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
      
    }

    public partial class MasterDataCustomerModel
    {
        public string mode { get; set; }
        public string sales_representative { get; set; }
        public string channel { get; set; }
        public string area { get; set; }
        public string year { get; set; }

    }
}