using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class CnModel
    {
        //start 1 รายละเอียด //
        public string cn_pre_job_id { get; set; }
        public string cn_pre_job_jobno { get; set; }
        public DateTime cn_pre_job_datetime { get; set; }
        public DateTime cn_pre_job_datetime_start { get; set; }
        public DateTime cn_pre_job_datetime_end { get; set; }
        public string cn_pre_job_assige { get; set; }
        public string salefile_number { get; set; }
        public string salefile_invcode { get; set; }
        public string saletra_item_barcode { get; set; }
        public string saletra_item_name { get; set; }
        public string saletra_item_spcodes { get; set; }
        public string saletra_item_whdiscode { get; set; }
        public int cn_pre_job_qty { get; set; }
        public string cn_pre_job_type { get; set; }
        public string cn_pre_job_status { get; set; }
        public string cn_pre_job_comment { get; set; }
        public string created_by { get; set; }
        public string pMessage { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public string cn_pre_job_detail_assige { get; set; }
        public string cn_pre_job_detail_driver { get; set; }
        public string cn_pre_job_detail_status { get; set; }
        public string cn_pre_job_detail_comment { get; set; }
        public string Mode { get; set; }
        public string saletra_empcod { get; set; }
        public string saletra_empname { get; set; }
        public string cn_pre_job_detail_remark { get; set; }
        public string cn_pre_job_detail_item_condition { get; set; }


    }

    public partial class Cn_HistoryModel
    {
        public string cn_pre_job_detail_id { get; set; }
        public string cn_pre_job_id { get; set; }
        public string cn_pre_job_detail_assige { get; set; }
        public string cn_pre_job_detail_driver { get; set; }
        public string cn_pre_job_detail_status { get; set; }
        public string cn_pre_job_detail_comment { get; set; }
        public string Mode { get; set; }
        public string saletra_empcod { get; set; }
        public string saletra_empname { get; set; }
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

    public partial class CnOnjobGet
    {
        //start 1 รายละเอียด //
        public string cn_pre_job_id { get; set; }
        public string cn_pre_job_jobno { get; set; }
        public DateTime cn_pre_job_datetime { get; set; }
        public DateTime cn_pre_job_datetime_start { get; set; }
        public DateTime cn_pre_job_datetime_end { get; set; }
        public DateTime cn_on_job_datetime_start { get; set; }
        public DateTime cn_on_job_datetime_end { get; set; }
        public string cn_pre_job_assige { get; set; }
        public string salefile_number { get; set; }
        public string salefile_invcode { get; set; }
        public string saletra_item_barcode { get; set; }
        public string saletra_item_name { get; set; }
        public string saletra_item_spcodes { get; set; }
        public string saletra_item_whdiscode { get; set; }
        public int cn_pre_job_qty { get; set; }
        public string cn_pre_job_type { get; set; }
        public string cn_pre_job_status { get; set; }
        public string cn_pre_job_comment { get; set; }
        public string created_by { get; set; }
        public string pMessage { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public string cn_pre_job_detail_assige { get; set; }
        public string cn_pre_job_detail_driver { get; set; }
        public string cn_pre_job_detail_status { get; set; }
        public string cn_pre_job_detail_comment { get; set; }
        public string Mode { get; set; }
        public string saletra_empcod { get; set; }
        public string saletra_empname { get; set; }
        public string cn_pre_job_detail_remark { get; set; }
        public string cn_on_job_status { get; set; }
        public string cn_job_status { get; set; }
        public string cn_on_jobno { get; set; }
        public string cn_on_job_id { get; set; }
        public string rettra_number { get; set; }

        
    }

    public partial class CnOnjob
    {
        //start 1 รายละเอียด //
        public string cn_on_job_id { get; set; }
        public string cn_pre_job_id { get; set; }
        public DateTime cn_on_job_datetime_start { get; set; }
        public DateTime cn_on_job_datetime_end { get; set; }
        public string cn_on_jobno { get; set; }
        public string cn_on_job_assige { get; set; }
        public string cn_on_job_status { get; set; }
        public string cn_on_job_type { get; set; }
        public string cn_pre_job_jobno { get; set; }
        public string cn_on_job_detail_remark { get; set; }
        public DateTime cn_on_job_datetime { get; set; }
        public string created_by { get; set; }
        public string pMessage { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public string Mode { get; set; }

    }

    public partial class CnOnjob_His
    {
        //start 1 รายละเอียด //
        public string cn_on_job_id { get; set; }
        public string cn_on_job_detail_id { get; set; }
        public string cn_on_job_detail_assige { get; set; }
        public string cn_on_job_detail_status { get; set; }
        public string cn_on_job_detail_remark { get; set; }
        public string cn_on_job_detail_damage { get; set; }
        public string cn_on_jobno { get; set; }
        public DateTime cn_on_job_detail_datetime { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public string pMessage { get; set; }

    }

    public partial class Cn_Lov
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

}