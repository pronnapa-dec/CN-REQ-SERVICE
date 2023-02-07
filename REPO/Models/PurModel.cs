using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{

    public class PurModel
    {
        public string PO_no { get; set; }
        public string item_code { get; set; }
        public string item_name { get; set; }
        public string item_spcodes { get; set; }
        public string pr_receive_comment { get; set; }
        public string Sale_user { get; set; }
        public DateTime POdate { get; set; }
        public DateTime POdate_start { get; set; }
        public DateTime POdate_end { get; set; }
        public string invcustpo { get; set; }
        public string Buyer_Po_User { get; set; }
        public DateTime Receive_date_est { get; set; }
        public DateTime Receive_date_est_start { get; set; }
        public DateTime Receive_date_est_end { get; set; }
        public string WH { get; set; }
        public string GR_no { get; set; }
        public DateTime GR_date { get; set; }
        public DateTime GR_date_start { get; set; }
        public DateTime GR_date_end { get; set; }
        public string pr_receive_type { get; set; }
        public string created_by { get; set; }

    }

    public class PkPoIVModel
    {
        public string PO_no { get; set; }
        public string item_code { get; set; }
        public string item_name { get; set; }
        public string item_spcodes { get; set; }
        public string pr_receive_comment { get; set; }
        public string Sale_user { get; set; }
        public DateTime POdate { get; set; }
        public DateTime POdate_start { get; set; }
        public DateTime POdate_end { get; set; }
        public string invcustpo { get; set; }
        public string Buyer_Po_User { get; set; }
        public DateTime Receive_date_est { get; set; }
        public DateTime Receive_date_est_start { get; set; }
        public DateTime Receive_date_est_end { get; set; }
        public string WH { get; set; }
        public string GR_no { get; set; }
        public DateTime GR_date { get; set; }
        public DateTime GR_date_start { get; set; }
        public DateTime GR_date_end { get; set; }
        public string pr_receive_type { get; set; }
        public string created_by { get; set; }



        public string Year { get; set; }
        public string Month { get; set; }
        public string Vendor_code { get; set; }
        public string Vendor_name { get; set; }
        public string PO_qty { get; set; }
        public string GR_qty { get; set; }
        public string stkcod { get; set; }
        public string PO_qty_pending { get; set; }
        public string PO_type { get; set; }
        public string StockStatus { get; set; }
        public DateTime podatesend { get; set; }
        public DateTime pr_receive_date { get; set; }
        public string PO_Panding { get; set; }
        public string gbarcode { get; set; }

        public string Mode { get; set; }
    }

}