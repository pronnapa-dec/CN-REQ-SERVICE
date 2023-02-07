using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class CnBranchModel
    {
        //start 1 รายละเอียด //
        public string cn_pre_job_id { get; set; }
        public string cn_pre_job_jobno { get; set; }
        public DateTime cn_pre_job_datetime { get; set; }
        public string cn_pre_job_datetime_start { get; set; }
        public string cn_pre_job_datetime_end { get; set; }
        public string cn_pre_job_assige { get; set; }
        public string cn_pre_job_branch { get; set; }
        public string cn_pre_job_item_barcode { get; set; }
        public string cn_pre_job_item_name { get; set; }
        public string cn_pre_job_item_spcode { get; set; }
        public int cn_pre_job_qty { get; set; }
        public string cn_pre_job_type { get; set; }
        public string cn_pre_job_status { get; set; }
        public string cn_pre_job_comment { get; set; }
        public string job_comment { get; set; }
        public string stmas_name { get; set; }
        public string stmas_SPCODES { get; set; }
        public string cn_pre_job_detail_remark { get; set; }
        public string cn_pre_job_detail_item_condition { get; set; }
        public string Mode { get; set; }
        public string branch_name { get; set; }
        public string branch_address { get; set; }
        public string created_by { get; set; }
        public string pMessage { get; set; }
        public DateTime salefile_datetime { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public string salefile_number { get; set; }
        public string salefile_invcode { get; set; }


    }

    public partial class CnBranch_HistoryModel
    {
        public string cn_branch_pre_job_detail_id { get; set; }
        public string cn_branch_pre_job_id { get; set; }
        public string cn_pre_job_branch { get; set; }
        public string cn_pre_job_detail_assige { get; set; }
        public string cn_pre_job_type { get; set; }
        public string cn_pre_job_detail_driver { get; set; }
        public string cn_pre_job_detail_status { get; set; }
        public string cn_pre_job_detail_comment { get; set; }
        public string Mode { get; set; }
        public string stmas_name { get; set; }
        public string stmas_SPCODES { get; set; }
        public string cn_pre_job_detail_item_condition { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public DateTime cn_pre_job_detail_pickup_date { get; set; }
        public int record_status { get; set; }
        public string pMessage { get; set; }
        public string cn_pre_job_detail_remark { get; set; }
        public string cn_pre_job_remark_trp { get; set; }
        public string cn_pre_job_assige { get; set; }
    }
    
    public partial class CnBranch_Lov
    {
        public string lov_id { get; set; }
        public string lov_group { get; set; }
        public string lov_type { get; set; }
        public string parent_lov_id { get; set; }
        public string lov_code { get; set; }
        public string lov1 { get; set; }
        public string lov2 { get; set; }
        public string lov3 { get; set; }
        public string lov4 { get; set; }
        public string lov5 { get; set; }
        public string lov6 { get; set; }
        public string lov7 { get; set; }
        public string lov8 { get; set; }
        public string lov9 { get; set; }
        public string lov10 { get; set; }
        public string lov_desc { get; set; }
        public string lov_order { get; set; }
        public string active_flag { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }

    }

    public partial class stmas_modal
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

    }
    public partial class emmas_modal
    {
        public string code { get; set; }
        public string lname { get; set; }
        public string id { get; set; }
        public string text { get; set; }

    }

    public partial class salefile_modal
    {
        public string number { get; set; }
        public DateTime invdate { get; set; }
        public string invcode { get; set; }
        public string invname { get; set; }
        public string startdate { get; set; }
        public int item { get; set; }

    }

    public partial class saletra_modal
    {
        public string number { get; set; }
        public string stkcod { get; set; }
        public string stkname { get; set; }
        public string gbarcode { get; set; }
        public string stkunit { get; set; }
        public string spcodes { get; set; }
        public string stktype { get; set; }
        public string empcod { get; set; }
        public string empname { get; set; }
        public string trnqty { get; set; }
        public string whdiscode { get; set; }
        public DateTime startdate { get; set; }

    }

}