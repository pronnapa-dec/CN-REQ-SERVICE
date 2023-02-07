using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class CnReqModel
    {
		public string cn_req_job_id { get; set; }
		public string cn_req_job_jobno { get; set; }
		public DateTime cn_req_job_date { get; set; }
		public DateTime cn_req_job_startdate { get; set; }
		public DateTime cn_req_job_enddate { get; set; }
		public string trndate { get; set; }
		public string number { get; set; }
		public string invpo { get; set; }
		public string empcod { get; set; }
		public string empname { get; set; }
		public string stkcod { get; set; }
		public string gbarcode { get; set; }
		public string spcodes { get; set; }
		public string stkname { get; set; }
		public string item { get; set; }
		public string stkunit { get; set; }
		public string whdiscode { get; set; }
		public string userid { get; set; }
		public string salegroup_uptodate { get; set; }
		public string named { get; set; }
		public string customerGrade { get; set; }
		public string PKuser { get; set; }
		public string saleperson { get; set; }
		public int cn_req_job_qty { get; set; }
		public string cn_req_job_cause { get; set; }
		public string cn_req_job_lastassige { get; set; }
		public int cn_req_job_source { get; set; }
		public string cn_req_salefile_number { get; set; }
		public string cn_req_salefile_stkcod { get; set; }
		public string cn_req_job_assige { get; set; }
		public string cn_req_job_note { get; set; }
		public string created_by { get; set; }
		public DateTime created_date { get; set; }
		public string updated_by { get; set; }
		public DateTime updated_date { get; set; }
		public int record_status { get; set; }
		public int cn_req_job_last_item_condition { get; set; }
		public string cn_req_job_lastdriver { get; set; }
		public string cn_req_job_status { get; set; }

	}
    public partial class CnReqSaletraModel
    {
        public DateTime trndate { get; set; }
        public string number { get; set; }
        public string invpo { get; set; }
        public string empcod { get; set; }
        public string empname { get; set; }
        public string stkcod { get; set; }
        public string gbarcode { get; set; }
        public string spcodes { get; set; }
        public string stkname { get; set; }
        public int item { get; set; }
        public string stkunit { get; set; }
        public string whdiscode { get; set; }
        public string userid { get; set; }
        public string salegroup_uptodate { get; set; }
        public string named { get; set; }
        public string customerGrade { get; set; }
        public string PKuser { get; set; }
        public string saleperson { get; set; }
				 
    }
	public partial class CnReqLOVModel
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
		public DateTime updated_create { get; set; }

	}

	public partial class CnReqSourceModel
	{

		public string cn_req_job_id { get; set; }
		public string cn_req_job_jobno { get; set; }
		public int cn_req_job_source { get; set; }
		public string created_by { get; set; }
		public DateTime created_date { get; set; }

	}

	public partial class CnReqAssigeModel
	{

		public string cn_req_job_id { get; set; }
		public string cn_req_job_jobno { get; set; }
		public string cn_req_job_assige { get; set; }
		public string cn_req_job_note { get; set; }
		public string created_by { get; set; }
		public DateTime created_date { get; set; }
		public int record_status { get; set; }
		public int cn_req_job_item_condition { get; set; }
		public string cn_req_job_driver_name { get; set; }
		public DateTime cn_req_job_received_date { get; set; }


	}

	public partial class CnReqDriverModel
	{
		public string cn_req_job_id { get; set; }
		public string cn_req_job_jobno { get; set; }
		public string cn_req_job_lastdriver { get; set; }
		public string cn_req_job_driver_code { get; set; }
		public string cn_req_job_driver_name { get; set; }
		public string cn_req_job_driver_tel { get; set; }
		public string cn_req_job_received_date { get; set; }
		public string cn_req_job_note { get; set; }
		public int record_status { get; set; }
		public string created_by { get; set; }
		public DateTime created_date { get; set; }

	}

	public partial class CnReqConditionModel
	{
		public string cn_req_job_id { get; set; }
		public string cn_req_job_jobno { get; set; }
		public string cn_req_job_item_condition { get; set; }
		public string cn_req_job_note { get; set; }
		public int record_status { get; set; }
		public string item_condition { get; set; }
		public string created_by { get; set; }
		public DateTime created_date { get; set; }

	}

	public partial class CnReqStatusModel
	{
		public string cn_req_job_id { get; set; }
		public string cn_req_job_jobno { get; set; }
		public string cn_req_job_status { get; set; }
		public string cn_req_job_note { get; set; }
		public int record_status { get; set; }
		public string created_by { get; set; }
		public DateTime created_date { get; set; }

	}
}