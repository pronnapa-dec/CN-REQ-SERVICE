using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class Zone_Model
    {
				
        public string lov_id { get; set; }
        public string lov_group { get; set; }
        public string lov_type { get; set; }
        public string parent_lov_id { get; set; }
        public string lov_code { get; set; }
        public string lov1 { get; set; }
        public string record_status { get; set; }
        public string mode { get; set; }
        public string pMessage { get; set; }
        

    }
    public partial class Devilery_Zone_Delete_Model
    {
        public string id { get; set; }
        public string record_status { get; set; }
        public string updated_by { get; set; }
        public string pMessage { get; set; }

    }

    public partial class Customer_Setup_Model
    {
        public string id { get; set; }
        public string emmas_code { get; set; }
        public   string ecate { get; set; }
        public string etran { get; set; }
        public string eaddress { get; set; }
        public string etumbol { get; set; }
        public string eamphur { get; set; }
        public string eprovinc { get; set; }
        public string etumbol_id { get; set; }
        public string eamphur_id { get; set; }
        public string eprovinc_id { get; set; }
        public string ezip { get; set; }
        public string etel { get; set; }
        public string etel_ext { get; set; }
        public string emobile { get; set; } 
        public string efax { get; set; }
        public string eemail { get; set; }
        public int edefault { get; set; }
        public string record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string pMessage { get; set; }
        public string mode { get; set; }
        public int item_trp { get; set; }
        
        // kung เพิ่ม 3 field 2021/01/18
        public string location_name { get; set; }
        public string route { get; set; }
        public string subroute { get; set; }
        
    }

    public partial class Customer_Setup_Trp_Model
    {
        public string id { get; set; }
        public string emmas_code { get; set; }
        public string vendor_id { get; set; }
        public string lov_deliverycost_code { get; set; }
        public string lov_zone_code { get; set; }
        public string lov_route_code { get; set; }
        public string lov_route_name { get; set; }
        public string name { get; set; }
        public int tdefault { get; set; }
        public string record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string pMessage { get; set; }
        public string mode { get; set; }
        public string emmas_addr_id { get; set; }
        public int item_trp { get; set; }


    }

    public partial class Packing_Job_Model
    {

        public string id { get; set; }
        public string emmas_code { get; set; }
        public string emmas_name { get; set; }
        public string inv_qty { get; set; }
        public string vendor_id { get; set; }
        public string vendor_name { get; set; }
        public string lov_deliverycost_code { get; set; }
        public string packing_job_no { get; set; }
        public DateTime packing_job_date { get; set; }
        public DateTime packing_job_start_date { get; set; }
        public DateTime packing_job_end_date { get; set; }
        public string emmas_sender_name { get; set; }
        public string emmas_addr_id { get; set; }
        public string packing_delivery_name { get; set; }
        public string packing_delivery_addr { get; set; }
        public string packing_delivery_tumbol { get; set; }
        public string packing_delivery_amphur { get; set; }
        public string packing_delivery_provinc { get; set; }
        public string packing_delivery_zip { get; set; }
        public string packing_ref_code { get; set; }
        public string trp_salefile_user_id { get; set; }
        public string record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string pMessage { get; set; }
        public string packing_box_qty { get; set; }
        public string mode { get; set; }
        public string salefile_number { get; set; }
        public string salefile_name { get; set; }
        public string salefile_invcode { get; set; }
        public string salefile_invpo { get; set; }
        public string salefile_userid { get; set; }
        public DateTime salefile_startdate { get; set; }
        public string salefile_evcode { get; set; }
        public string salefile_evname { get; set; }
        public string salefile_evadd { get; set; }
        public string salefile_tsno { get; set; }
        public int salefile_item { get; set; }
        
    }

    public partial class Packing_Job_Update_Model
    {
        public string id { get; set; }
        public string emmas_code { get; set; }
        public string vendor_id { get; set; }
        public string lov_deliverycost_code { get; set; }
        public string packing_job_no { get; set; }
        public DateTime packing_job_date { get; set; }
        public string emmas_sender_name { get; set; }
        public string emmas_addr_id { get; set; }
        public string packing_delivery_name { get; set; }
        public string packing_delivery_addr { get; set; }
        public string packing_delivery_tumbol { get; set; }
        public string packing_delivery_amphur { get; set; }
        public string packing_delivery_provinc { get; set; }
        public string packing_delivery_zip { get; set; }
        public string packing_ref_code { get; set; }
        public string lov_packing_box { get; set; }
        public int packing_box_qty { get; set; }
        public string record_status { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string pMessage { get; set; }


    }

    public partial class Packing_Job_Delete_Model
    {
        public string id { get; set; }
        public string record_status { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }


    }

    public partial class Box_Modal
    {

        public string id { get; set; }
        public string packing_job_no { get; set; }
        public string packing_job_id { get; set; }
        public string lov_packing_box { get; set; }
        public int packing_box_qty { get; set; }
        public string record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }


    }

    public partial class Packing_Job_Invoice_Model
    {

        public string id { get; set; }
        public string salefile_number { get; set; }
        public string packing_job_id { get; set; }
        public string packing_job_no { get; set; }
        public string salefile_name { get; set; }
        public string salefile_invcode { get; set; }
        public string salefile_invpo { get; set; }
        public string salefile_userid { get; set; }
        public DateTime salefile_startdate { get; set; }
        public string salefile_evcode { get; set; }
        public string salefile_evname { get; set; }
        public string salefile_evadd { get; set; }
        public string salefile_tsno { get; set; }
        public string salefile_item { get; set; }
        public string record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string pMessage { get; set; }
        public string mode { get; set; }

    }
}