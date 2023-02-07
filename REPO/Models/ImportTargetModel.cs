using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class ImportCustomerTargetModel
    {
        public string code { get; set; }
        public string year { get; set; }
        public double M01 { get; set; }
        public double M02 { get; set; }
        public double M03 { get; set; }
        public double M04 { get; set; }
        public double M05 { get; set; }
        public double M06 { get; set; }
        public double M07 { get; set; }
        public double M08 { get; set; }
        public double M09 { get; set; }
        public double M10 { get; set; }
        public double M11 { get; set; }
        public double M12 { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public string created_by2 { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public string updated_by2 { get; set; }
        public DateTime updated_datetime { get; set; }

    }

    public partial class ImportCustomerTargetTranModel
    {
        public string temp_id { get; set; }
        public string trans_id { get; set; }
        public string item { get; set; }
        public string code { get; set; }
        public string lname { get; set; }
        public string year { get; set; }
        public string targetgroup { get; set; }
        public string M01 { get; set; }
        public string M02 { get; set; }
        public string M03 { get; set; }
        public string M04 { get; set; }
        public string M05 { get; set; }
        public string M06 { get; set; }
        public string M07 { get; set; }
        public string M08 { get; set; }
        public string M09 { get; set; }
        public string M10 { get; set; }
        public string M11 { get; set; }
        public string M12 { get; set; }
        public string record_status { get; set; }
        public string created_by { get; set; }
        public string created_by2 { get; set; }
        public string created_datetime { get; set; }
        public string updated_by { get; set; }
        public string updated_by2 { get; set; }
        public string updated_date { get; set; }

    }
}