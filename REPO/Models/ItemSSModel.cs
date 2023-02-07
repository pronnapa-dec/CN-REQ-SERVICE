using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class ItemSS_Modal
    {
        //start 1 รายละเอียด //
        public string supersession_id { get; set; }
        public string sku { get; set; }
        public string ss_sku { get; set; }
        public int rank { get; set; }
        public string gbarcode { get; set; }
        public string spcode { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string remark { get; set; }
        public string is_itemsupersession { get; set; }
        public string replace_itemsupersession { get; set; }
        public string record_id { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string record_status { get; set; }
        public string pMessage { get; set; }


    }

    public partial class ItemSS_search_Modal
    {
        //start 1 รายละเอียด //
        public string sku { get; set; }
        public string ss_sku { get; set; }
        public string gbarcode { get; set; }
        public string name { get; set; }
        public string is_itemsupersession { get; set; }
        public string record_status { get; set; }
        public string record_id { get; set; }
        public string mode { get; set; }

    }

    public partial class ItemSS_stmas_modal
    {

        public string id { get; set; }
        public string text { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string gbarcode { get; set; }
        public string SPCODES { get; set; }
        public string gdescript { get; set; }
        public string gremark { get; set; }
        public string startdate { get; set; }
        public string userid { get; set; }
        public string CHRCODE { get; set; }
        public string OLDPARTS { get; set; }
        public string UOM { get; set; }
        public string gvat { get; set; }
        public string branch_id { get; set; }
        public string item_master { get; set; }
        public string type { get; set; }
        public string record_id { get; set; }

    }

    public partial class ItemSS_History_Modal
    {
        //start 1 รายละเอียด //
        public string supersession_log_id { get; set; }
        public string supersession_id { get; set; }
        public string sku { get; set; }
        public string ss_sku { get; set; }
        public int rank { get; set; }
        public string gbarcode { get; set; }
        public string spcode { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string remark { get; set; }
        public string is_itemsupersession { get; set; }
        public string replace_itemsupersession { get; set; }
        public string record_id { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string record_status { get; set; }
        public string pMessage { get; set; }


    }


}