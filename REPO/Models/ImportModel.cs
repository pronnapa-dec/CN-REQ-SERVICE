using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class ImportNetPriceModel
    {
        public int NET { get; set; }
        public int item { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string gunit { get; set; }
        public double gcost { get; set; }
        public double avgcost { get; set; }
        public double gprice { get; set; }
        public double gpriceA { get; set; }
        public double gpriceB { get; set; }
        public double gpriceC { get; set; }
        public double gpriceD { get; set; }
        public double gpriceE { get; set; }
        public double gpriceF { get; set; }
        public string TYPE { get; set; }
        public string carbrand { get; set; }
        public string named { get; set; }
        public string UOM { get; set; }
        public DateTime startdate { get; set; }
        public string userid { get; set; }
        public string ecode { get; set; }
        public double qty_a { get; set; }
        public double qty_b { get; set; }
        public double prod_net { get; set; }
        public string gbarcode { get; set; }
        public string gpartno { get; set; }

        public string qtysmall { get; set; }
        public string created_by { get; set; }
    }

    public partial class ImportPriceModel
    {
        public int NET { get; set; }
        public int item { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public double gcost { get; set; }
        public double avgcost { get; set; }
        public double gprice { get; set; }
        public double gpriceA { get; set; }
        public double gpriceB { get; set; }
        public double gpriceC { get; set; }
        public double gpriceD { get; set; }
        public double gpriceE { get; set; }
        public double gpriceF { get; set; }
        public string gperA { get; set; }
        public string gperB { get; set; }
        public string gperC { get; set; }
        public string gperD { get; set; }
        public string gperE { get; set; }
        public string gperF { get; set; }
        public string TYPE { get; set; }
        public string carbrand { get; set; }
        public string named { get; set; }
        public string UOM { get; set; }
        public DateTime startdate { get; set; }
        public string userid { get; set; }
        public string ecode { get; set; }

    }

    public partial class ImportUpdateDataTranModel
    {
        public string auth { get; set; }
        public string temp_id { get; set; }
        public string trans_id { get; set; }
        public int item { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string cartype { get; set; }
        public string usagepercar { get; set; }
        public string serviceyear { get; set; }
        public Double productqtyperpack { get; set; }
        public Double productsize { get; set; }
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
        public Double manualsafetystock { get; set; }
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
        public string spcodes { get; set; }
        public string codeoem { get; set; }
        public string gdimension { get; set; }
        public string carbrand { get; set; }
        public string carmodel { get; set; }
        public string cargeneration { get; set; }
        public string matchinno { get; set; }
        public string bodyno { get; set; }
        public string carengine { get; set; }
        public string carbody { get; set; }
        public string carbodycode { get; set; }
        public string carfmyear { get; set; }
        public string cartoyear { get; set; }
        public string gdescript { get; set; }
        public Double stdmargin { get; set; }
        public int grvat { get; set; }
        public string itemname { get; set; }
        public string code_a { get; set; }
        public string gnamechr { get; set; }
        public string chrcode { get; set; }
        public string code_b { get; set; }
        public string gmodel { get; set; }
        public string code_c { get; set; }
        public string type { get; set; }
        public string code_d { get; set; }
        public string gused { get; set; }
        public string code_e { get; set; }
        public string goem { get; set; }
        public string latestreviewdate { get; set; }
        public string nextreviewdate { get; set; }
        public int reviewtimes { get; set; }
        public string oldparts { get; set; }
        public string created_by { get; set; }
        public string created_by2 { get; set; }
        public DateTime created_date { get; set; }
        public string record_status { get; set; }

        public int is_itemname_error { get; set; }
        public int is_c1_error { get; set; }
        public int is_c2_error { get; set; }
        public int is_c3_error { get; set; }
        public int is_c4_error { get; set; }
        public int is_c5_error { get; set; }
        public int is_duplicate { get; set; }
        public string error_text { get; set; }
        public int is_error { get; set; }
        public int is_code_error { get; set; }
        public int is_code5_change { get; set; }
        public int is_code5_master { get; set; }
        public int is_itemname_change { get; set; }
        public int is_newitemname_duplicate { get; set; }


        public string minqty { get; set; }
        public string maxqty { get; set; }

    }


    public partial class ImportUpdateDataModel
    {
        public string temp_id { get; set; }
        public int countitem_all { get; set; }
        public int countitem_incomplete { get; set; }
        public int countitem_complete { get; set; }
        public string created_by { get; set; }
        public string created_by2 { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public string updated_by2 { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public int countitem_updated { get; set; }
    }

    public partial class ImportPriceListModel
    {
        public string temp_id { get; set; }
        public int countitem_all { get; set; }
        public int countitem_incomplete { get; set; }
        public int countitem_complete { get; set; }
        public int countitem_insert { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
    }

    public partial class ImportPriceListTranModel
    {
        public string temp_id { get; set; }
        public string trans_id { get; set; }
        public int item { get; set; }
        public string spcodes { get; set; }
        public string carbrand { get; set; }
        public string goem { get; set; }
        public string itemname_en { get; set; }
        public string itemname_th { get; set; }
        public float gprice { get; set; }
        public DateTime price_effectdate { get; set; }
        public int record_status { get; set; }
        public int is_inserted { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }

    }

    public partial class ImportCommonPriceModel
    {
        public string temp_id { get; set; }
        public int countitem_all { get; set; }
        public int countitem_incomplete { get; set; }
        public int countitem_complete { get; set; }
        public string created_by { get; set; }
        public string created_by2 { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public string updated_by2 { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public int countitem_updated { get; set; }
        public string branch { get; set; }
    }

    public partial class ImportCommonPriceTranModel
    {
        public string temp_id { get; set; }
        public string trans_id { get; set; }
        public int item { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string branch { get; set; }
        public Double gprice_current { get; set; }
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
        public int vat_current { get; set; }
        public string created_by { get; set; }
        public string created_by2 { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public string updated_by2 { get; set; }
        public DateTime updated_date { get; set; }
        public string record_status { get; set; }

        public string is_updated { get; set; }
        public string log_stmas { get; set; }
        public string error_id { get; set; }
        public string error_message { get; set; }

    }

}