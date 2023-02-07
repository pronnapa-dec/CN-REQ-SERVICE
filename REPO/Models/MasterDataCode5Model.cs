using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class ImportMasterDataCode5TranModel
    {
        public string temp_id { get; set; }
        public string trans_id { get; set; }
        public int item { get; set; }
        public string c5_code { get; set; }
        public string c5_gname { get; set; }
        public string carbrand_code { get; set; }
        public string carbrand_name { get; set; }
        public string carmodel_code { get; set; }
        public string carmodel_name { get; set; }
        public string carFmyear { get; set; }
        public string carToyear { get; set; }
        public string carGeneration { get; set; }
        public string cartype { get; set; }

        public int record_status { get; set; }
        public int is_updated { get; set; }
        public int is_newitem { get; set; }
        public int is_updateitem { get; set; }
        public int is_code_dup { get; set; }
        public int is_gname_dup { get; set; }
        public string created_by { get; set; }
        public string created_by2 { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public string updated_by2 { get; set; }
        public DateTime updated_date { get; set; }
    }


}