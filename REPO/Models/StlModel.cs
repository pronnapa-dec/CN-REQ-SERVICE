using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{

    //P SOMO
    public partial class CustomerProfileMasterModel
    {
        public string emmas_code { get; set; }
        public string emmas_eaddress { get; set; }
        public float emmas_eamount { get; set; }
        public float emmas_eamountvat { get; set; }
        public string emmas_eamphur { get; set; }
        public DateTime emmas_ebgservice { get; set; }
        public string emmas_ebranch { get; set; }
        public string emmas_ecodechr { get; set; }
        public string emmas_ecrcut { get; set; }
        public string emmas_edescript { get; set; }
        public float emmas_edue { get; set; }
        public string emmas_efax { get; set; }
        public string emmas_egdis { get; set; }
        public string emmas_egroup { get; set; }
        public string emmas_egroupk { get; set; }
        public string emmas_egroupkE { get; set; }
        public string emmas_ekbill { get; set; }
        public string emmas_ekcheck { get; set; }
        public string emmas_ekcust { get; set; }
        public string emmas_eline { get; set; }
        public string emmas_eOwn0 { get; set; }
        public float emmas_eOwn3 { get; set; }
        public string emmas_eprovinc { get; set; }
        public string emmas_eregdate { get; set; }
        public string emmas_etel { get; set; }
        public string emmas_etran { get; set; }
        public string emmas_etrans { get; set; }
        public string emmas_etumbol { get; set; }
        public string emmas_euserid { get; set; }
        public string emmas_evat { get; set; }
        public string emmas_ezip { get; set; }
        public string emmas_lname { get; set; }
        public string emmas_netprice { get; set; }
        public string emmas_taxid { get; set; }
        public string salegrch_area { get; set; }
        public string salegrch_branch { get; set; }
        public int salegrch_delivery_stdtime { get; set; }
        public string salegrch_delivery_subroute { get; set; }
        public string salegrch_eaddress2 { get; set; }
        public string salegrch_eamphur2 { get; set; }
        public string salegrch_eprovinc2 { get; set; }
        public string salegrch_etumbol2 { get; set; }
        public string salegrch_ezip2 { get; set; }
        public string salegrch_grouprank { get; set; }
        public string salegrch_idcardno { get; set; }
        public string salegrch_salearea { get; set; }
        public string samas_partspecialist { get; set; }
        public string samas_salechannel { get; set; }
        public string samas_salecode { get; set; }
        public string samas_saleexecutive { get; set; }
        public string samas_salegroup { get; set; }
        public string samas_salemanager { get; set; }
        public string samas_salename { get; set; }
        public string samas_salesupervisor { get; set; }
        public string samas_salesupervisorsupport { get; set; }
        public string samas_storemanager { get; set; }
        public string salegrch_customer_houseno { get; set; }
        public string salegrch_customer_villageno { get; set; }
        public string salegrch_customer_village { get; set; }
        public string salegrch_customer_lane { get; set; }
        public string salegrch_customer_streetname { get; set; }
        public string salegrch_customer_houseno2 { get; set; }
        public string salegrch_customer_villageno2 { get; set; }
        public string salegrch_customer_village2 { get; set; }
        public string salegrch_customer_lane2 { get; set; }
        public string salegrch_customer_streetname2 { get; set; }
        public string salegrch_banklist { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }

    }
    public partial class CustomerProfileDataModel
    {
        public string contact_contactnumber { get; set; }
        public string contact_description { get; set; }
        public string contact_extension { get; set; }
        public string contact_purpose_code { get; set; }
        public string emmasaddr_eaddress { get; set; }
        public string emmasaddr_eamphur { get; set; }
        public string emmasaddr_edefault { get; set; }
        public string emmasaddr_eprovinc { get; set; }
        public string emmasaddr_etumbol { get; set; }
        public string emmasaddr_ezip { get; set; }
        public string emmastrp_lov_deliverycost_code { get; set; }
        public string emmastrp_tdefault { get; set; }
        public string trpvendor_lov_route_code { get; set; }
        public string trpvendor_lov_zone_code { get; set; }
        public string trpvendor_name { get; set; }

    }

    public partial class CustomerProfileMTBModel
    {
        public string emmasmtb_balanceofcredit { get; set; }
        public string emmasmtb_sumcreditlimit { get; set; }
        public string emmasmtb_sumeamount { get; set; }

    }
    //P SOMO

    public partial class CustomerModel
    {

        public string code { get; set; }
        public string etel { get; set; }
        public string etran { get; set; }
        public string grouprank { get; set; }
        public string ebranch { get; set; }
        public string efax { get; set; }
        public DateTime ebgservice { get; set; }
        public string lname { get; set; }
        public string ecodechr { get; set; }
        public string eregdate { get; set; }
        public string eOwn3 { get; set; }
        public string eOwn0 { get; set; }
        public string customer_idcardno { get; set; }
        public string edescript { get; set; }
        public string eaddress { get; set; }
        public string etumbol { get; set; }
        public string eamphur { get; set; }
        public string eprovinc { get; set; }
        public string ezip { get; set; }
        public string customer_eaddress2 { get; set; }
        public string customer_etumbol2 { get; set; }
        public string customer_eamphur2 { get; set; }
        public string customer_eprovinc2 { get; set; }
        public string customer_ezip2 { get; set; }
        public string salecode { get; set; }
        public string salename { get; set; }
        public string egdis { get; set; }
        public string StoreManager { get; set; }
        public string salechannel { get; set; }
        public string Branch { get; set; }
        public string salegroup { get; set; }
        public string Area { get; set; }
        public string SaleArea { get; set; }
        public string SaleManager { get; set; }
        public string SaleSupervisor { get; set; }
        public string SaleRepresentative { get; set; }
        public string SupportSupervisor { get; set; }
        public string SaleSupport { get; set; }
        public string year { get; set; }
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
        public string euserid { get; set; }
        public string taxid { get; set; }
        public string evat { get; set; }
        public string edue { get; set; }
        public string egroup { get; set; }
        public string ekcust { get; set; }
        public string egroupkE { get; set; }
        public string egroupk { get; set; }
        public string ekbill { get; set; }
        public string ecrcut { get; set; }
        public string ekcheck { get; set; }
        public string ecredit { get; set; }
        public string ecredit2 { get; set; }
        public string eamount { get; set; }
        public string eamountvat { get; set; }

    }
    public partial class CustomerProfileModel
    {
        public string temp_id { get; set; }
        public string trans_id { get; set; }
        public string code { get; set; }
        public string grouprank { get; set; }
        public string lname { get; set; }
        public string etel { get; set; }
        public string efax { get; set; }
        public string eaddress { get; set; }
        public string etumbol { get; set; }
        public string eamphur { get; set; }
        public string eprovinc { get; set; }
        public string ezip { get; set; }
        public string salechannel { get; set; }
        public string salegroup { get; set; }
        //public string salerepresentative { get; set; }
        public string customername_with_no_branch { get; set; }
        public string year { get; set; }
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
        public string created_by { get; set; }
        public DateTime created_datatime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datatime { get; set; }
        public string record_status { get; set; }
        public string salearea { get; set; }
        public string area { get; set; }
        public string branch { get; set; }
        public string storemanager { get; set; }
        public string salemanager { get; set; }
        public string salesupervisor { get; set; }
        public string salerepresentative { get; set; }
        public string salesupportsupervisor { get; set; }
        public string salesupport { get; set; }
    }
    public partial class CustomerContactModel
    {
        public string code { get; set; }
        public string contactnumber { get; set; }
        public string contactname { get; set; }
        public string extension { get; set; }
        public string purpose_code { get; set; }
        public string purpose_desc { get; set; }
        public string description { get; set; }
        public string created_by { get; set; }
        public DateTime created_datatime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datatime { get; set; }
        public int record_status { get; set; }
        public string pMessage { get; set; }

    }
    public partial class SaletargetrModel
    {

        public string emmas_code { get; set; }
        public decimal saletargetc_rebatestarget_q1 { get; set; }
        public decimal saletargetc_rebatestarget_q1_input { get; set; }
        public decimal saletargetc_rebatestarget_q2 { get; set; }
        public decimal saletargetc_rebatestarget_q2_input { get; set; }
        public decimal saletargetc_rebatestarget_q3 { get; set; }
        public decimal saletargetc_rebatestarget_q3_input { get; set; }
        public decimal saletargetc_rebatestarget_q4 { get; set; }
        public decimal saletargetc_rebatestarget_q4_input { get; set; }
        public decimal saletargetc_rebatestarget_year { get; set; }
        public decimal saletargetc_rebatestarget_year_per { get; set; }
        public decimal saletargetc_salestarget_m01 { get; set; }
        public decimal saletargetc_salestarget_m01_input { get; set; }
        public decimal saletargetc_salestarget_m02 { get; set; }
        public decimal saletargetc_salestarget_m02_input { get; set; }
        public decimal saletargetc_salestarget_m03 { get; set; }
        public decimal saletargetc_salestarget_m03_input { get; set; }
        public decimal saletargetc_salestarget_m04 { get; set; }
        public decimal saletargetc_salestarget_m04_input { get; set; }
        public decimal saletargetc_salestarget_m05 { get; set; }
        public decimal saletargetc_salestarget_m05_input { get; set; }
        public decimal saletargetc_salestarget_m06 { get; set; }
        public decimal saletargetc_salestarget_m06_input { get; set; }
        public decimal saletargetc_salestarget_m07 { get; set; }
        public decimal saletargetc_salestarget_m07_input { get; set; }
        public decimal saletargetc_salestarget_m08 { get; set; }
        public decimal saletargetc_salestarget_m08_input { get; set; }
        public decimal saletargetc_salestarget_m09 { get; set; }
        public decimal saletargetc_salestarget_m09_input { get; set; }
        public decimal saletargetc_salestarget_m10 { get; set; }
        public decimal saletargetc_salestarget_m10_input { get; set; }
        public decimal saletargetc_salestarget_m11 { get; set; }
        public decimal saletargetc_salestarget_m11_input { get; set; }
        public decimal saletargetc_salestarget_m12 { get; set; }
        public decimal saletargetc_salestarget_m12_input { get; set; }
        public decimal saletargetc_salestarget_q1 { get; set; }
        public decimal saletargetc_salestarget_q2 { get; set; }
        public decimal saletargetc_salestarget_q3 { get; set; }
        public decimal saletargetc_salestarget_q4 { get; set; }
        public decimal saletargetc_saletarget_year { get; set; }
        public decimal saletargetcsum1_rebatesactual_q1 { get; set; }
        public decimal saletargetcsum1_rebatesactual_q2 { get; set; }
        public decimal saletargetcsum1_rebatesactual_q3 { get; set; }
        public decimal saletargetcsum1_rebatesactual_q4 { get; set; }
        public decimal saletargetcsum1_rebatesactual_year { get; set; }
        public decimal saletargetcsum1_salesactual_m01 { get; set; }
        public decimal saletargetcsum1_salesactual_m02 { get; set; }
        public decimal saletargetcsum1_salesactual_m03 { get; set; }
        public decimal saletargetcsum1_salesactual_m04 { get; set; }
        public decimal saletargetcsum1_salesactual_m05 { get; set; }
        public decimal saletargetcsum1_salesactual_m06 { get; set; }
        public decimal saletargetcsum1_salesactual_m07 { get; set; }
        public decimal saletargetcsum1_salesactual_m08 { get; set; }
        public decimal saletargetcsum1_salesactual_m09 { get; set; }
        public decimal saletargetcsum1_salesactual_m10 { get; set; }
        public decimal saletargetcsum1_salesactual_m11 { get; set; }
        public decimal saletargetcsum1_salesactual_m12 { get; set; }
        public decimal saletargetcsum1_salesactual_q1 { get; set; }
        public decimal saletargetcsum1_salesactual_q2 { get; set; }
        public decimal saletargetcsum1_salesactual_q3 { get; set; }
        public decimal saletargetcsum1_salesactual_q4 { get; set; }
        public decimal saletargetcsum1_salesactual_year { get; set; }
        public string saletargetcsum1_salestarget_year { get; set; }
        public decimal saletargetcsum2_rebatestarget_q1_per { get; set; }
        public decimal saletargetcsum2_rebatestarget_q2_per { get; set; }
        public decimal saletargetcsum2_rebatestarget_q3_per { get; set; }
        public decimal saletargetcsum2_rebatestarget_q4_per { get; set; }
        public decimal saletargetcsum2_salestarget_m01_per { get; set; }
        public decimal saletargetcsum2_salestarget_m02_per { get; set; }
        public decimal saletargetcsum2_salestarget_m03_per { get; set; }
        public decimal saletargetcsum2_salestarget_m04_per { get; set; }
        public decimal saletargetcsum2_salestarget_m05_per { get; set; }
        public decimal saletargetcsum2_salestarget_m06_per { get; set; }
        public decimal saletargetcsum2_salestarget_m07_per { get; set; }
        public decimal saletargetcsum2_salestarget_m08_per { get; set; }
        public decimal saletargetcsum2_salestarget_m09_per { get; set; }
        public decimal saletargetcsum2_salestarget_m10_per { get; set; }
        public decimal saletargetcsum2_salestarget_m11_per { get; set; }
        public decimal saletargetcsum2_salestarget_m12_per { get; set; }
        public decimal saletargetcsum2_salestarget_q1_per { get; set; }
        public decimal saletargetcsum2_salestarget_q2_per { get; set; }
        public decimal saletargetcsum2_salestarget_q3_per { get; set; }
        public decimal saletargetcsum2_salestarget_q4_per { get; set; }
        public decimal saletargetcsum2_saletarget_year_per { get; set; }
        public string created_by { get; set; }

    }

    //start kung add new modal (2022/01/14)
    public partial class Province_Modal
    {
        public int glb_province_id { get; set; }
        public string glb_province_code { get; set; }
        public string glb_province_name { get; set; }
        public int glb_geo_code { get; set; }

    }

    public partial class Amphur_Modal
    {
        public string glb_amphur_id { get; set; }
        public string glb_province_id { get; set; }
        public string glb_amphur_code { get; set; }
        public string glb_amphur_name { get; set; }
        public string glb_amphur_postcode { get; set; }
    }

    public partial class District_Modal
    {
        public string glb_district_id { get; set; }
        public string glb_amphur_id { get; set; }
        public string glb_district_code { get; set; }
        public string glb_district_name { get; set; }
        public string glb_province_id { get; set; }

    }

    public partial class Lov_Modal
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
        public string glb_district_id { get; set; }
        public string glb_amphur_id { get; set; }
        public string glb_district_code { get; set; }
        public string glb_district_name { get; set; }
        public string glb_province_id { get; set; }
        public string name { get; set; }

    }

    public partial class Route_Valiable_Modal
    {
        public string lov_id { get; set; }
    }
    public partial class SubRoute_Valiable_Modal
    {
        public string lov_id { get; set; }
        public string parent_lov_id { get; set; }
    }

    public partial class Customer_Addredd_187_Modal
    {
        public string emmasaddr_id { get; set; }
        public string emmasaddr_emmas_code { get; set; }
        public string emmasaddr_location_name { get; set; }
        public string emmasaddr_eaddress { get; set; }
        public string emmasaddr_eprovinc { get; set; }
        public string emmasaddr_eamphur { get; set; }
        public string emmasaddr_etumbol { get; set; }
        public string emmasaddr_eprovinc_id { get; set; }
        public string emmasaddr_eamphur_id { get; set; }
        public string emmasaddr_etumbol_id { get; set; }
        public string emmasaddr_ezip { get; set; }
        public int emmasaddr_edefault { get; set; }
        public int item_trp { get; set; }
        public string record_status { get; set; }
        public string pMessage { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string mode { get; set; }

    }

    public partial class Devilery_Zone_Model
    {
        public string id { get; set; }
        public string lov_route_code { get; set; }
        public string lov_zone_code { get; set; }
        public string name { get; set; }
        public string opening { get; set; }
        public string closetime { get; set; }
        public string note { get; set; }
        public string record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string pMessage { get; set; }
        public string mode { get; set; }

    }


    //end kung add new modal (2022/01/14)

    public partial class CustomerOwnerModel
    {
        public string code { get; set; }
        public string owner_name { get; set; }
        public string owner_idno { get; set; }
        public string created_by { get; set; }
        public DateTime created_datatime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datatime { get; set; }
        public int record_status { get; set; }
        public string pMessage { get; set; }

    }

    public partial class CustomerBankAccountModel
    {
        public string code { get; set; }
        public string customer_bac_bank { get; set; }
        public string customer_bac_bankname { get; set; }
        public string customer_bac_bankno { get; set; }
        public string customer_bac_type { get; set; }
        public string customer_bac_comment { get; set; }
        public string created_by { get; set; }
        public DateTime created_datatime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datatime { get; set; }
        public int record_status { get; set; }
        public string pMessage { get; set; }

    }

}