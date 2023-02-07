using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class LogImportUpdataDataModel
    {
        //ImportUpdateDataTranModel
        public string auth { get; set; }
        public string temp_id { get; set; }
        public string trans_id { get; set; }
        public int item { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string cartype { get; set; }
        public string usagepercar { get; set; }
        public string serviceyear { get; set; }
        public string productqtyperpack { get; set; }
        public string productsize { get; set; }
        public Double maxdiscountpercent { get; set; }
        public Double minmarginpercent { get; set; }
        public int vatdiscmargin { get; set; }
        public string stockstatus { get; set; }
        public string remarkbypm { get; set; }
        public string skufocus { get; set; }
        public string donotpur { get; set; }
        public string donotsale { get; set; }
        public string ginactive { get; set; }
        public string custconfirm { get; set; }
        public string lifecycleaction { get; set; }
        public DateTime lifecyclereviewdate { get; set; }
        public string certificationstatus { get; set; }
        public string lockcode { get; set; }
        public string supersessionbarcode { get; set; }
        public string relationshiptype { get; set; }
        public string planing_type { get; set; }
        public string source_type { get; set; }
        public string manualsafetystock { get; set; }
        public Double moq { get; set; }
        public string leadtimesupplier { get; set; }
        public string leadtimeitem { get; set; }
        public Double minqtyconst { get; set; }
        public Double maxqtyconst { get; set; }
        public string purchase { get; set; }
        public string purcon { get; set; }
        public string prefsuppliercode { get; set; }
        public string prefsuppliername { get; set; }
        //public Double prefsupplierdisc { get; set; }
        public string prefsupplierdisc { get; set; }
        public string discgroup { get; set; }
        public string purdiscgroup { get; set; }
        public string salediscgroup { get; set; }
        public string transferunit { get; set; }
        public Double minqtywarehouse { get; set; }
        public Double maxqtywarehouse { get; set; }
        public string created_by { get; set; }
        public string created_by2 { get; set; }
        public DateTime created_date { get; set; }
        public string record_status { get; set; }

        public Double minqty { get; set; }
        public Double maxqty { get; set; }


        //ImportUpdateDataModel
        public int countitem_all { get; set; }
        public int countitem_incomplete { get; set; }
        public int countitem_complete { get; set; }


        public string ori_name { get; set; }
        public string ori_cartype { get; set; }
        public string ori_usagepercar { get; set; }
        public string ori_serviceyear { get; set; }
        public string ori_productqtyperpack { get; set; }
        public string ori_productsize { get; set; }
        public Double ori_maxdiscountpercent { get; set; }
        public Double ori_minmarginpercent { get; set; }
        public int ori_vatdiscmargin { get; set; }
        public string ori_stockstatus { get; set; }
        public string ori_remarkbypm { get; set; }
        public string ori_skufocus { get; set; }
        public string ori_donotpur { get; set; }
        public string ori_donotsale { get; set; }
        public string ori_ginactive { get; set; }
        public string ori_custconfirm { get; set; }
        public string ori_lifecycleaction { get; set; }
        public DateTime ori_lifecyclereviewdate { get; set; }
        public string ori_certificationstatus { get; set; }
        public string ori_lockcode { get; set; }
        public string ori_supersessionbarcode { get; set; }
        public string ori_relationshiptype { get; set; }
        public string ori_planing_type { get; set; }
        public string ori_source_type { get; set; }
        public string ori_manualsafetystock { get; set; }
        public Double ori_moq { get; set; }
        public string ori_leadtimesupplier { get; set; }
        public string ori_leadtimeitem { get; set; }
        public Double ori_minqtyconst { get; set; }
        public Double ori_maxqtyconst { get; set; }
        public string ori_purchase { get; set; }
        public string ori_purcon { get; set; }
        public string ori_prefsuppliercode { get; set; }
        public string ori_prefsuppliername { get; set; }
        //public Double ori_prefsupplierdisc { get; set; }
        public string ori_prefsupplierdisc { get; set; }
        public string ori_discgroup { get; set; }
        public string ori_purdiscgroup { get; set; }
        public string ori_salediscgroup { get; set; }
        public string ori_transferunit { get; set; }
        public Double ori_minqtywarehouse { get; set; }
        public Double ori_maxqtywarehouse { get; set; }


        public string log_stmas { get; set; }
        public string log_productplan { get; set; }
    }

    public partial class LogImportCommonPriceModel
    {
        //ImportCommonPriceTranModel
        public string temp_id { get; set; }
        public string trans_id { get; set; }
        public int item { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string branch { get; set; }
        public Double gpricepur { get; set; }
        public Double gprice { get; set; }
        public Double gpricea { get; set; }
        public Double gpriceb { get; set; }
        public Double gpricec { get; set; }
        public Double gpriced { get; set; }
        public Double gpricee { get; set; }
        public Double gpricef { get; set; }
        public string gpera { get; set; }
        public string gperb { get; set; }
        public string gperc { get; set; }
        public string gperd { get; set; }
        public string gpere { get; set; }
        public string gperf { get; set; }
        public int vat { get; set; }
        public string created_by { get; set; }
        public string created_by2 { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public string updated_by2 { get; set; }
        public DateTime updated_date { get; set; }
        public string record_status { get; set; }
        public string is_updated { get; set; }
        public string log_stmas { get; set; }

    }
}