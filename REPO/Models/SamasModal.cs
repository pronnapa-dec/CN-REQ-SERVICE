using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class SamasModal
    {
        //start 1 รายละเอียด //
        public string code { get; set; }
        public string lname { get; set; }
        public string stel { get; set; }
        public string sumtt { get; set; }
        public string sdescript { get; set; }
        public DateTime startdate { get; set; }
        public string userid { get; set; }
        public decimal scost { get; set; }
        public string salegroup { get; set; }
        public string salechannel { get; set; }
        public string saleperson { get; set; }
        public string Smngcode { get; set; }
        public string Ssupvcode { get; set; }
        public string Srepcode { get; set; }
        public string Ssuppcode { get; set; }
        public string Ssuppsupvcode { get; set; }
        public string Salename { get; set; }
        public string SaleRepresentative { get; set; }
        public string SaleSupport { get; set; }
        public string SupportSupervisor { get; set; }
        public string SaleManager { get; set; }
        public string StoreManager { get; set; }
        public string SaleSupervisor { get; set; }
        public string Branch { get; set; }
        public string mode { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public string pMessage { get; set; }
    }

    public partial class SalebranchModal
    {
        public string lov_id { get; set; }
        public string lov_group { get; set; }
        public string lov_type { get; set; }
        public string parent_lov_id { get; set; }
        public string lov_code { get; set; }
        public string lov1 { get; set; }
        public string lov2 { get; set; }


    }

    public class sa_Ressale_Model
    {
        public string pMessage { get; set; }
    }

}
