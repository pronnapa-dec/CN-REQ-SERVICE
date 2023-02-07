using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class StmasModel
    {
        //start 1 รายละเอียด //
        public string code { get; set; }
        public string OLDPARTS { get; set; }
        public string name { get; set; }
        public string gzone { get; set; }
        public string gnamechr { get; set; }
        public string code_a { get; set; }
        public string CHRCODE { get; set; }
        public string gmodel { get; set; }
        public string code_b { get; set; }
        public string TYPE { get; set; }
        public string code_c { get; set; }
        public string GUSED { get; set; }
        public string code_d { get; set; }
        public string gOem { get; set; }
        public string code_e { get; set; }
        public string matchinno { get; set; }
        public string bodyno { get; set; }
        public string SPCODES { get; set; }
        public string Carbrand { get; set; }
        public string Carmodel { get; set; }
        public string CarFyear { get; set; }
        public string CarToyear { get; set; }
        public string Cargeneration { get; set; }
        public string CarEngine { get; set; }
        public string Carbody { get; set; }
        public string Carbodycode { get; set; }
        public string CodeOem { get; set; }
        public string gbarcode { get; set; }
        public string UOM { get; set; }
        public string gdescrip { get; set; }
        public string GDIMENSION { get; set; }
        public string Cartype { get; set; }
        public string named { get; set; }
        public string gvat { get; set; }
        public string Onpend { get; set; }
        public string Onhandv { get; set; }
        public string gamountv { get; set; }
        public string glocat { get; set; }
        public string gcondoth { get; set; }
        public string gset { get; set; }
        public string itemgroup { get; set; }
        public string Subcategory { get; set; }
        public string gremark { get; set; }
        public string Category { get; set; }
        public string CarFyear_CarToyear { get; set; }

        //start 2 อื่นๆ //
        public string stmas_donotsale { get; set; }
        public string stmas_ginactive { get; set; }
        public string stmas_donotpur { get; set; }
        public string stmas_custconfirm { get; set; }
        public string custconfirm { get; set; }
        public string stmas_minstock { get; set; }
        public string stmas_maxstock { get; set; }
        public string stmas_prodclass { get; set; }
        public string stmas_prodgroup { get; set; }
        public string stmas_prodstatus { get; set; }

        //start 3 สต็อก/สถานที่เก็บ //
        public string stmas_Onhandv { get; set; }
        public string WH02 { get; set; }
        public string WH03 { get; set; }
        public string WH04 { get; set; }
        public string WH05 { get; set; }
        public string WH06 { get; set; }
        public string WH07 { get; set; }
        public string WH08 { get; set; }
        public string WH09 { get; set; }
        public string WH10 { get; set; }
        public string WH11 { get; set; }
        public string WH12 { get; set; }

        //start 4 รูปภาพหน้า-หลัง //
        public string photo_file { get; set; }
        public string photo_fileb { get; set; }

        //start 5 รายการของแถม/Pro // 
        public string goodfree_greft { get; set; }
        public string goodfree_name { get; set; }
        public string goodfree_named { get; set; }
        public string goodfree_gtype { get; set; }
        public string goodfree_gqty { get; set; }
        public string gpromotion_recnum { get; set; }
        public string gpromotion_gremark { get; set; }
        public string gpromotion_Fmdate { get; set; }
        public string gpromotion_todate { get; set; }

        //start 4 ตารางราคาขาย // 
        public string Salecost { get; set; }
        public string gcost { get; set; }
        public string AvgSalecost { get; set; }
        public string Avgcost { get; set; }
        public string qtysmall { get; set; }
        public string costtype { get; set; }
        public float gprice { get; set; }
        public float gpricepur { get; set; }
        public float gpriceA { get; set; }
        public float gpriceB { get; set; }
        public float gpriceC { get; set; }
        public float gpriceD { get; set; }
        public float gpriceE { get; set; }
        public float gpriceF { get; set; }
        public string gperA { get; set; }
        public string gperB { get; set; }
        public string gperC { get; set; }
        public string gperD { get; set; }
        public string gperE { get; set; }
        public string gperF { get; set; }
        public float goodprice_purch { get; set; }
        public float goodprice_gpricepur { get; set; }

        //start 6 เจ้าหนี้การค้า // 
        public string stmas_GVENDOR { get; set; }
        public string stmas_gvendorname { get; set; }
        public string grtra_empcod { get; set; }
        public string grtra_empname { get; set; }
        public string grtra_punumber { get; set; }
        public DateTime grtra_trndate { get; set; }
        public string grtra_trnqty { get; set; }
        public string grtra_trnprnet { get; set; }
        public string apprice_apqty { get; set; }
        public string apprice_apprice { get; set; }

        //start 7 ข้างซ้าย-ขวา //
        public string photo_filec { get; set; }
        public string photo_filed { get; set; }

        //start 8 Part Compare/รายการพ่วง //
        public string partcompare_greft { get; set; }
        public string partcompare_OLDPART { get; set; }
        public string partcompare_NAME { get; set; }
        public string partcompare_gmodel { get; set; }
        public string partcompare_TYPE { get; set; }
        public string partcomp_exp_code { get; set; }
        public string partcomp_exp_OLDPART { get; set; }
        public string partcomp_exp_NAME { get; set; }
        public string partcomp_exp_gmodel { get; set; }
        public string partcomp_exp_TYPE { get; set; }

        //start 9 XX //
        public string InvoiceFreCode { get; set; }
        public string CountOfCustomersDistinctOpt1 { get; set; }
        public string CountOfCustomersDistinct_Pre12M { get; set; }
        public string CountOfCustomersDistinct_Pre3M { get; set; }
        public string CountOfCustomersDistinct_Pre6M { get; set; }
        public string SumOfSalesAmount_VSK { get; set; }
        public string CountOfInvoiceOrderLines_VSK { get; set; }
        public string SumOfSalesAmount_VSK2 { get; set; }
        public string CountOfInvoiceOrderLines_VSK2 { get; set; }
        public string SumOfSalesAmount_SP1 { get; set; }
        public string CountOfInvoiceOrderLines_SP1 { get; set; }
        public string SumOfSalesAmount_KLH { get; set; }
        public string CountOfInvoiceOrderLines_KLH { get; set; }
        public string SumOfSalesAmount_LLK { get; set; }
        public string CountOfInvoiceOrderLines_LLK { get; set; }
        public string CountInvoiceAllBranch { get; set; }
        public string InvoiceFreCodeDesc { get; set; }
        public string update_frecode { get; set; }
        public string Stock_Status_Suggest { get; set; }
        public string UpdateMaxMin { get; set; }
        public string LastUpdateByPM { get; set; }
        public string StockStatusChangeUser { get; set; }
        public string Item_Class { get; set; }
        public string Car_Type { get; set; }
        public string StockStatus { get; set; }
        public string RemarkByPM { get; set; }
        public string Product_division { get; set; }
        public string Main_Category { get; set; }
        public string Sub_Category { get; set; }
        public string PurDiscGroup { get; set; }
        public string Sale_Discount_Group { get; set; }
        public string Product_Life_Cycle { get; set; }
        public string Product_Positioning { get; set; }
        public string Source_Type { get; set; }
        public string PurchaseCondition { get; set; }
        public string MOQ { get; set; }
        public string PrefSupplierDisc { get; set; }
        public string ManualSafetyStockQty { get; set; }
        public string LeadTimeSupplier { get; set; }
        public string LeadTimeItem { get; set; }
        public string purchase { get; set; }
        public string DefaultSupplierCode { get; set; }
        public string DefaultSupplierName { get; set; }
        public string PackCodeRounding { get; set; }
        public string ReOrderQtyDaily { get; set; }
        public string ReOderDate { get; set; }
        public string StockSettingProposal { get; set; }
        public string StockSettingProposalPhase { get; set; }
        public string MinQtyWarehouse { get; set; }
        public string MaxQtyWarehouse { get; set; }
        public string Transfer_Unit { get; set; }
        public string PObranchPending_KLH { get; set; }
        public string codes { get; set; }
        public string MaxQty_D_Constant { get; set; }
        public string MinQty_E_Constant { get; set; }
        public string StockStatusReviewDate { get; set; }
        public string update_stockstatus { get; set; }
        public string StockingClass { get; set; }
        public string Status { get; set; }
        public string SaleFreqGrade { get; set; }
        public string OL_Ranking { get; set; }
        public string InvoiceFreCodeDesc_Suggest { get; set; }
        public string Group { get; set; }
        public string is_service { get; set; }
        public string ItemAged { get; set; }
        public string prodstatus_Ka { get; set; }
        public string prodgroup { get; set; }
        public string gOem_New { get; set; }
        public string MinStockByPM { get; set; }


    }

    public partial class StmasModel_v2
    {
        //start 1 รายละเอียด //
        public string code { get; set; }
        public string OLDPARTS { get; set; }
        public string name { get; set; }
        public string gzone { get; set; }
        public string gnamechr { get; set; }
        public string code_a { get; set; }
        public string CHRCODE { get; set; }
        public string gmodel { get; set; }
        public string code_b { get; set; }
        public string TYPE { get; set; }
        public string code_c { get; set; }
        public string GUSED { get; set; }
        public string code_d { get; set; }
        public string gOem { get; set; }
        public string code_e { get; set; }
        public string matchinno { get; set; }
        public string bodyno { get; set; }
        public string SPCODES { get; set; }
        public string Carbrand { get; set; }
        public string Carmodel { get; set; }
        public string CarFyear { get; set; }
        public string CarToyear { get; set; }
        public string Cargeneration { get; set; }
        public string CarEngine { get; set; }
        public string Carbody { get; set; }
        public string Carbodycode { get; set; }
        public string CodeOem { get; set; }
        public string gbarcode { get; set; }
        public string UOM { get; set; }
        public string gdescrip { get; set; }
        public string GDIMENSION { get; set; }
        public string Cartype { get; set; }
        public string named { get; set; }
        public string gvat { get; set; }
        public string Onpend { get; set; }
        public string Onhandv { get; set; }
        public string gamountv { get; set; }
        public string glocat { get; set; }
        public string gcondoth { get; set; }
        public string gset { get; set; }
        public string itemgroup { get; set; }
        public string Subcategory { get; set; }
        public string gremark { get; set; }
        public string Category { get; set; }
        public string CarFyear_CarToyear { get; set; }

        //start 2 อื่นๆ //
        //public string stmas_donotsale { get; set; }
        public string donotsale { get; set; }
        //public string stmas_ginactive { get; set; }
        public string ginactive { get; set; }
        //public string stmas_donotpur { get; set; }
        public string donotpur { get; set; }
        //public string stmas_custconfirm { get; set; }
        public string custconfirm { get; set; }
        public string stmas_minstock { get; set; }
        public string stmas_maxstock { get; set; }
        public string stmas_prodclass { get; set; }
        public string stmas_prodgroup { get; set; }
        public string stmas_prodstatus { get; set; }

        //start 3 สต็อก/สถานที่เก็บ //
        public string stmas_Onhandv { get; set; }
        public string WH02 { get; set; }
        public string WH03 { get; set; }
        public string WH04 { get; set; }
        public string WH05 { get; set; }
        public string WH06 { get; set; }
        public string WH07 { get; set; }
        public string WH08 { get; set; }
        public string WH09 { get; set; }
        public string WH10 { get; set; }
        public string WH11 { get; set; }
        public string WH12 { get; set; }

        //start 4 รูปภาพหน้า-หลัง //
        public string photo_file { get; set; }
        public string photo_fileb { get; set; }

        //start 5 รายการของแถม/Pro // 
        public string goodfree_greft { get; set; }
        public string goodfree_name { get; set; }
        public string goodfree_named { get; set; }
        public string goodfree_gtype { get; set; }
        public string goodfree_gqty { get; set; }
        public string gpromotion_recnum { get; set; }
        public string gpromotion_gremark { get; set; }
        public string gpromotion_Fmdate { get; set; }
        public string gpromotion_todate { get; set; }

        //start 4 ตารางราคาขาย // 
        public string Salecost { get; set; }
        public string gcost { get; set; }
        public string AvgSalecost { get; set; }
        public string Avgcost { get; set; }
        public string qtysmall { get; set; }
        public string costtype { get; set; }
        public float gprice { get; set; }
        public float gpricepur { get; set; }
        public float gpriceA { get; set; }
        public float gpriceB { get; set; }
        public float gpriceC { get; set; }
        public float gpriceD { get; set; }
        public float gpriceE { get; set; }
        public float gpriceF { get; set; }
        public string gperA { get; set; }
        public string gperB { get; set; }
        public string gperC { get; set; }
        public string gperD { get; set; }
        public string gperE { get; set; }
        public string gperF { get; set; }
        public float goodprice_purch { get; set; }
        public float goodprice_gpricepur { get; set; }

        //start 6 เจ้าหนี้การค้า // 
        public string stmas_GVENDOR { get; set; }
        public string stmas_gvendorname { get; set; }
        public string grtra_empcod { get; set; }
        public string grtra_empname { get; set; }
        public string grtra_punumber { get; set; }
        public DateTime grtra_trndate { get; set; }
        public string grtra_trnqty { get; set; }
        public string grtra_trnprnet { get; set; }
        public string apprice_apqty { get; set; }
        public string apprice_apprice { get; set; }

        //start 7 ข้างซ้าย-ขวา //
        public string photo_filec { get; set; }
        public string photo_filed { get; set; }

        //start 8 Part Compare/รายการพ่วง //
        public string partcompare_greft { get; set; }
        public string partcompare_OLDPART { get; set; }
        public string partcompare_NAME { get; set; }
        public string partcompare_gmodel { get; set; }
        public string partcompare_TYPE { get; set; }
        public string partcomp_exp_code { get; set; }
        public string partcomp_exp_OLDPART { get; set; }
        public string partcomp_exp_NAME { get; set; }
        public string partcomp_exp_gmodel { get; set; }
        public string partcomp_exp_TYPE { get; set; }

        //start 9 XX //
        public string InvoiceFreCode { get; set; }
        public string CountOfCustomersDistinctOpt1 { get; set; }
        public string CountOfCustomersDistinct_Pre12M { get; set; }
        public string CountOfCustomersDistinct_Pre3M { get; set; }
        public string CountOfCustomersDistinct_Pre6M { get; set; }
        public string SumOfSalesAmount_VSK { get; set; }
        public string CountOfInvoiceOrderLines_VSK { get; set; }
        public string SumOfSalesAmount_VSK2 { get; set; }
        public string CountOfInvoiceOrderLines_VSK2 { get; set; }
        public string SumOfSalesAmount_SP1 { get; set; }
        public string CountOfInvoiceOrderLines_SP1 { get; set; }
        public string SumOfSalesAmount_KLH { get; set; }
        public string CountOfInvoiceOrderLines_KLH { get; set; }
        public string SumOfSalesAmount_LLK { get; set; }
        public string CountOfInvoiceOrderLines_LLK { get; set; }
        public string CountInvoiceAllBranch { get; set; }
        public string InvoiceFreCodeDesc { get; set; }
        public string update_frecode { get; set; }
        public string Stock_Status_Suggest { get; set; }
        public string UpdateMaxMin { get; set; }
        public string LastUpdateByPM { get; set; }
        public string StockStatusChangeUser { get; set; }
        public string Item_Class { get; set; }
        public string Car_Type { get; set; }
        public string StockStatus { get; set; }
        public string RemarkByPM { get; set; }
        public string Product_division { get; set; }
        public string Main_Category { get; set; }
        public string Sub_Category { get; set; }
        public string PurDiscGroup { get; set; }
        public string Sale_Discount_Group { get; set; }
        public string Product_Life_Cycle { get; set; }
        public string Product_Positioning { get; set; }
        public string Source_Type { get; set; }
        public string PurchaseCondition { get; set; }
        public string MOQ { get; set; }
        public string PrefSupplierDisc { get; set; }
        public string ManualSafetyStockQty { get; set; }
        public string LeadTimeSupplier { get; set; }
        public string LeadTimeItem { get; set; }
        public string purchase { get; set; }
        public string DefaultSupplierCode { get; set; }
        public string DefaultSupplierName { get; set; }
        public string PackCodeRounding { get; set; }
        public string ReOrderQtyDaily { get; set; }
        public string ReOderDate { get; set; }
        public string StockSettingProposal { get; set; }
        public string StockSettingProposalPhase { get; set; }
        public string MinQtyWarehouse { get; set; }
        public string MaxQtyWarehouse { get; set; }
        public string Transfer_Unit { get; set; }
        public string PObranchPending_KLH { get; set; }
        public string codes { get; set; }
        public string MaxQty_D_Constant { get; set; }
        public string MinQty_E_Constant { get; set; }
        public string StockStatusReviewDate { get; set; }
        public string update_stockstatus { get; set; }
        public string StockingClass { get; set; }
        public string Status { get; set; }
        public string SaleFreqGrade { get; set; }
        public string OL_Ranking { get; set; }
        public string InvoiceFreCodeDesc_Suggest { get; set; }
        public string Group { get; set; }
        public string is_service { get; set; }
        public string ItemAged { get; set; }
        public string prodstatus_Ka { get; set; }
        public string prodgroup { get; set; }
        public string gOem_New { get; set; }
        public string MinStockByPM { get; set; }


    }

    public partial class GoodpriceModel
    {
        public string goodprice_gunit { get; set; }
        public string goodprice_prqty { get; set; }
        public string goodprice_qtysmall { get; set; }
        public string goodprice_gprice { get; set; }
        public string goodprice_gpriceA { get; set; }
        public string goodprice_gpriceB { get; set; }
        public string goodprice_gpriceC { get; set; }
        public string goodprice_gpriceD { get; set; }
        public string goodprice_gpriceE { get; set; }
        public string goodprice_gpriceF { get; set; }
        public string goodprice_goutput { get; set; }
        public double goodprice_item { get; set; }
        public double goodprice_purch { get; set; }
        public string goodprice_gpricepur { get; set; }
        public string goodprice_startdate { get; set; }
        public string goodprice_userid { get; set; }
        public string goodprice_code { get; set; }
        public string goodprice_gbarcode { get; set; }
        public string goodprice_itemname { get; set; }

    }

    public partial class GcodeModel
    {

        public string code { get; set; }
        public string gname { get; set; }
        public string codechr { get; set; }
        public string userid { get; set; }
        public string rec { get; set; }
        public DateTime startdate { get; set; }
        public string ctype { get; set; }

    }

    public partial class BarcodeModel
    {
        public string gbarcode { get; set; }
    }

    public partial class UOMModel
    {
        public string code { get; set; }
    }

    public partial class LocationModel
    {
        public string code { get; set; }
        public string whcode { get; set; }
        public string whname { get; set; }
    }

    public partial class PrinterZoneModel
    {
        public string code { get; set; }
        public string setprint { get; set; }
    }

    public partial class GlocatModel
    {
        public string code { get; set; }
        public string whcode { get; set; }
        public string whname { get; set; }
        public string mode { get; set; }

    }

    public partial class UomModel
    {
        public string code { get; set; }
        public string mode { get; set; }
    }

    public partial class Product_PurPlan_Stock_FactorModel
    {
        public string code { get; set; }
        public string barcode { get; set; }
        public string spcodes { get; set; }
        public string invcode { get; set; }
        public string itemname { get; set; }
        public string CHRCODE { get; set; }
        public string code1_gnamechr { get; set; }
        public double MinQty { get; set; }
        public double MaxQty { get; set; }
        public string StockSettingProposal { get; set; }
        public string Planing_Type { get; set; }
        public string Source_Type { get; set; }
        public string PurchaseCondition { get; set; }
        public int MOQ { get; set; }
        public string StockingClass { get; set; }
        public string OL_Ranking { get; set; }
        public string InvoiceFreCode_Suggest { get; set; }
        public string InvoiceFreCodeDesc_Suggest { get; set; }
        public string InvoiceFreCode { get; set; }
        public string InvoiceFreCodeDesc { get; set; }
        public int CountOfCustomersDistinct { get; set; }
        public int CountOfCustomersDistinctOpt1 { get; set; }
        public double SumOfSalesAmount { get; set; }
        public int CountInvoiceAllBranch { get; set; }
        public string Team { get; set; }
        public string prodgroup { get; set; }
        public string StockStatus { get; set; }
        public string StockStatus_Kfrank { get; set; }
        public string StockStatus_Suggest { get; set; }
        public string ItemAged { get; set; }
        public int count_customer { get; set; }
        public int count_invoice { get; set; }
        public int ManualSafetyStockQty { get; set; }
        public int LeadTimeSupplier { get; set; }
        public int LeadTimeItem { get; set; }
        public int CountOfCustomersDistinct_Pre12M { get; set; }
        public int CountOfCustomersDistinct_Pre3M { get; set; }
        public string insert_date { get; set; }
        public string StockStatusReviewDate { get; set; }
        public string StockStatusChangeUser { get; set; }
        public string RemarkByPM { get; set; }
        public string Comment { get; set; }
        public string SupDiscPer { get; set; }
        public string ProdLifeCycle { get; set; }
        public string SkuFocus { get; set; }
        public string DiscGroup { get; set; }
        public string SaleDiscGroup { get; set; }
        public string ProductLifeCycle { get; set; }
        public string LifeCycleFlag { get; set; }
        public string ProductActivity { get; set; }
        public string LifeCycleAction { get; set; }
        public string ReplacementBarcode { get; set; }
        public string LockCode { get; set; }
    }

    public partial class Product_PurPlan_Stock_FactorModel_v2
    {
        public string code { get; set; }
        public string barcode { get; set; }
        public string spcodes { get; set; }
        public string invcode { get; set; }
        public string itemname { get; set; }
        public string CHRCODE { get; set; }
        public string code1_gnamechr { get; set; }
        public double MinQty { get; set; }
        public double MaxQty { get; set; }
        public string StockSettingProposal { get; set; }
        public string Planing_Type { get; set; }
        public string Source_Type { get; set; }
        public string PurchaseCondition { get; set; }
        public int MOQ { get; set; }
        public string StockingClass { get; set; }
        public string OL_Ranking { get; set; }
        public string InvoiceFreCode_Suggest { get; set; }
        public string InvoiceFreCodeDesc_Suggest { get; set; }
        public string InvoiceFreCode { get; set; }
        public string InvoiceFreCodeDesc { get; set; }
        public int CountOfCustomersDistinct { get; set; }
        public int CountOfCustomersDistinctOpt1 { get; set; }
        public double SumOfSalesAmount { get; set; }
        public int CountInvoiceAllBranch { get; set; }
        public string Team { get; set; }
        public string prodgroup { get; set; }
        public string StockStatus { get; set; }
        public string StockStatus_Kfrank { get; set; }
        public string StockStatus_Suggest { get; set; }
        public string ItemAged { get; set; }
        public int count_customer { get; set; }
        public int count_invoice { get; set; }
        public int ManualSafetyStockQty { get; set; }
        public int LeadTimeSupplier { get; set; }
        public int LeadTimeItem { get; set; }
        public int CountOfCustomersDistinct_Pre12M { get; set; }
        public int CountOfCustomersDistinct_Pre3M { get; set; }
        public string insert_date { get; set; }
        public string StockStatusReviewDate { get; set; }
        public string StockStatusChangeUser { get; set; }
        public string RemarkByPM { get; set; }
        public string Comment { get; set; }
        public string SupDiscPer { get; set; }
        public string ProdLifeCycle { get; set; }
        public string SkuFocus { get; set; }
        public string DiscGroup { get; set; }
        public string SaleDiscGroup { get; set; }
        public string ProductLifeCycle { get; set; }
        public string LifeCycleFlag { get; set; }
        public string ProductActivity { get; set; }
        public string LifeCycleAction { get; set; }
        public string SupersessionBarcode { get; set; }
        public string RelationshipType { get; set; }
        public string LockCode { get; set; }
    }

    public partial class Product_PurPlan_Stock_FactorModel_V3
    {
        public string code { get; set; }
        public string barcode { get; set; }
        public string itemname { get; set; }
        public string spcodes { get; set; }
        public string code1_gnamechr { get; set; }
        public string UOM { get; set; }
        public string StockingClass { get; set; }
        public float MaxQty { get; set; }
        public float MinQty { get; set; }
        public string Status { get; set; }
        public string SaleFreqGrade { get; set; }
        public string OL_Ranking { get; set; }
        public string StockSettingProposal { get; set; }
        public string StockSettingProposalPhase { get; set; }
        public string invcode { get; set; }
        public string CHRCODE { get; set; }
        public string Planing_Type { get; set; }
        public string Source_Type { get; set; }
        public string PurchaseCondition { get; set; }
        public int MOQ { get; set; }
        public string PrefSupplierCode { get; set; }
        public string PrefSupplierName { get; set; }
        public float PrefSupplierDisc { get; set; }
        public string PurDiscGroup { get; set; }
        public string InvoiceFreCode_Suggest { get; set; }
        public string InvoiceFreCode { get; set; }
        public string StockStatus { get; set; }
        public float CountOfCustomersDistinct { get; set; }
        public float CountOfCustomersDistinctOpt1 { get; set; }
        public float CountOfCustomersDistinct_Pre12M { get; set; }
        public float CountOfCustomersDistinct_Pre6M { get; set; }
        public float CountOfCustomersDistinct_Pre3M { get; set; }
        public double SumOfSalesAmount_VSK { get; set; }
        public float CountOfInvoiceOrderLines_VSK { get; set; }
        public double SumOfSalesAmount_VSK2 { get; set; }
        public float CountOfInvoiceOrderLines_VSK2 { get; set; }
        public double SumOfSalesAmount_SP1 { get; set; }
        public float CountOfInvoiceOrderLines_SP1 { get; set; }
        public double SumOfSalesAmount_KLH { get; set; }
        public float CountOfInvoiceOrderLines_KLH { get; set; }
        public double SumOfSalesAmount_LLK { get; set; }
        public float CountOfInvoiceOrderLines_LLK { get; set; }
        public float CountInvoiceAllBranch { get; set; }
        public string InvoiceFreCodeDesc_Suggest { get; set; }
        public string InvoiceFreCodeDesc { get; set; }
        public DateTime update_frecode { get; set; }
        public DateTime update_stockstatus { get; set; }
        public int is_service { get; set; }
        public string ItemAged { get; set; }
        public string prodstatus_Ka { get; set; }
        public string StockStatus_Kfrank { get; set; }
        public DateTime startdate { get; set; }
        public string prodgroup { get; set; }
        public string StockStatus_Suggest { get; set; }
        public string StockStatus_Ka { get; set; }
        public int ManualSafetyStockQty { get; set; }
        public int LeadTimeSupplier { get; set; }
        public int LeadTimeItem { get; set; }
        public float Updated { get; set; }
        public float Onhand { get; set; }
        public string Group { get; set; }
        public float SaleQty { get; set; }
        public float Onhand_VSK { get; set; }
        public float Onhand_VSF { get; set; }
        public float Onhand_LKS { get; set; }
        public float Onhand_KLH { get; set; }
        public float Onhand_LLK { get; set; }
        public float OnhandAll { get; set; }
        public int MainItem { get; set; }
        public string InheritCode { get; set; }
        public string SubCategoryCode { get; set; }
        public DateTime UpdateMaxMin { get; set; }
        public float MaxQty07022020 { get; set; }
        public float CostStart310120 { get; set; }
        public float SaleCostStart310120 { get; set; }
        public float AvgCostStart310120 { get; set; }
        public float AvgSaleCostStart310120 { get; set; }
        public DateTime LastUpdateByPM { get; set; }
        public string RemarkByPM { get; set; }
        public string StockStatusReviewDate { get; set; }
        public string StockStatusChangeUser { get; set; }
        public int PackCodeRounding { get; set; }
        public int ReOrderQtyDaily { get; set; }
        public DateTime ReOderDate { get; set; }
        public string purchase { get; set; }
        public string TYPE { get; set; }
        public string Cartype { get; set; }
        public string gOem_New { get; set; }
        public string Maker { get; set; }
        public float MinStockByPM { get; set; }
        public float MinQtyWarehouse { get; set; }
        public float MaxQtyWarehouse { get; set; }
        public string Transfer_Unit { get; set; }
        public string DefaultSupplierCode { get; set; }
        public string DefaultSupplierName { get; set; }
        public string Comment { get; set; }
        public float SupDiscPer { get; set; }
        public string ProdLifeCycle { get; set; }
        public string SkuFocus { get; set; }
        public string DiscGroup { get; set; }
        public string SaleDiscGroup { get; set; }
        public string ProductLifeCycle { get; set; }
        public string LifeCycleFlag { get; set; }
        public string ProductActivity { get; set; }
        public string LifeCycleAction { get; set; }
        public string SupersessionBarcode { get; set; }
        public string RelationshipType { get; set; }
        public string LockCode { get; set; }
        public string Growth2 { get; set; }
        public string Maturity3 { get; set; }
        public DateTime dateto2_Growth { get; set; }
        public string Decline4 { get; set; }
        public string GoodBye8 { get; set; }
        public string SDD_Focus { get; set; }
        public string CertificationStatus { get; set; }
        public string Item_Class { get; set; }
        public string Product_Division { get; set; }
        public string Main_Category { get; set; }
        public string Sub_Category { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }

    }

    public partial class Product_PurPlan_Stock_FactorModel_V4
    {
        public string code { get; set; }
        public string barcode { get; set; }
        public string itemname { get; set; }
        public string spcodes { get; set; }
        public string code1_gnamechr { get; set; }
        public string UOM { get; set; }
        public string StockingClass { get; set; }
        public float MaxQty { get; set; }
        public float MinQty { get; set; }
        public string Status { get; set; }
        public string SaleFreqGrade { get; set; }
        public string OL_Ranking { get; set; }
        public string StockSettingProposal { get; set; }
        public string StockSettingProposalPhase { get; set; }
        public string Planing_Type { get; set; }
        public string Source_Type { get; set; }
        public string PurchaseCondition { get; set; }
        public int MOQ { get; set; }
        public string PrefSupplierCode { get; set; }
        public string PrefSupplierName { get; set; }
        public float PrefSupplierDisc { get; set; }
        public string PurDiscGroup { get; set; }
        public string InvoiceFreCode_Suggest { get; set; }
        public string InvoiceFreCode { get; set; }
        public string StockStatus { get; set; }
        public float CountOfCustomersDistinct { get; set; }
        public float CountOfCustomersDistinctOpt1 { get; set; }
        public float CountOfCustomersDistinct_Pre12M { get; set; }
        public float CountOfCustomersDistinct_Pre6M { get; set; }
        public float CountOfCustomersDistinct_Pre3M { get; set; }
        public double SumOfSalesAmount_VSK { get; set; }
        public float CountOfInvoiceOrderLines_VSK { get; set; }
        public double SumOfSalesAmount_VSK2 { get; set; }
        public float CountOfInvoiceOrderLines_VSK2 { get; set; }
        public double SumOfSalesAmount_SP1 { get; set; }
        public float CountOfInvoiceOrderLines_SP1 { get; set; }
        public double SumOfSalesAmount_KLH { get; set; }
        public float CountOfInvoiceOrderLines_KLH { get; set; }
        public double SumOfSalesAmount_LLK { get; set; }
        public float CountOfInvoiceOrderLines_LLK { get; set; }
        public float CountInvoiceAllBranch { get; set; }
        public string InvoiceFreCodeDesc_Suggest { get; set; }
        public string InvoiceFreCodeDesc { get; set; }
        public DateTime update_frecode { get; set; }
        public DateTime update_stockstatus { get; set; }
        public int is_service { get; set; }
        public string ItemAged { get; set; }
        public string prodstatus_Ka { get; set; }
        public string StockStatus_Kfrank { get; set; }
        public DateTime startdate { get; set; }
        public string prodgroup { get; set; }
        public string StockStatus_Suggest { get; set; }
        public string StockStatus_Ka { get; set; }
        public int ManualSafetyStockQty { get; set; }
        public int LeadTimeSupplier { get; set; }
        public int LeadTimeItem { get; set; }
        public float Updated { get; set; }
        public float Onhand { get; set; }
        public string Group { get; set; }
        public float SaleQty { get; set; }
        public float Onhand_VSK { get; set; }
        public float Onhand_VSF { get; set; }
        public float Onhand_LKS { get; set; }
        public float Onhand_KLH { get; set; }
        public float Onhand_LLK { get; set; }
        public float OnhandAll { get; set; }
        public float OnhandST { get; set; }
        public int MainItem { get; set; }
        public string InheritCode { get; set; }
        public string SubCategoryCode { get; set; }
        public DateTime UpdateMaxMin { get; set; }
        public float MaxQty07022020 { get; set; }
        public float CostStart310120 { get; set; }
        public float SaleCostStart310120 { get; set; }
        public float AvgCostStart310120 { get; set; }
        public float AvgSaleCostStart310120 { get; set; }
        public DateTime LastUpdateByPM { get; set; }
        public string RemarkByPM { get; set; }
        public string StockStatusReviewDate { get; set; }
        public string StockStatusChangeUser { get; set; }
        public int PackCodeRounding { get; set; }
        public int ReOrderQtyDaily { get; set; }
        public DateTime ReOderDate { get; set; }
        public string purchase { get; set; }
        public string TYPE { get; set; }
        public string Cartype { get; set; }
        public string carmodel { get; set; }
        public string carbrand { get; set; }
        public string gOem_New { get; set; }
        public string Maker { get; set; }
        public float MinStockByPM { get; set; }
        public float MinQtyWarehouse { get; set; }
        public float MaxQtyWarehouse { get; set; }
        public string Transfer_Unit { get; set; }
        public string DefaultSupplierCode { get; set; }
        public string DefaultSupplierName { get; set; }
        public string Comment { get; set; }
        public float SupDiscPer { get; set; }
        public string ProdLifeCycle { get; set; }
        public string SkuFocus { get; set; }
        public string DiscGroup { get; set; }
        public string SaleDiscGroup { get; set; }
        public string ProductLifeCycle { get; set; }
        public string LifeCycleFlag { get; set; }
        public string ProductActivity { get; set; }
        public string LifeCycleAction { get; set; }
        public string LifeCycleReviewDate { get; set; }
        public string SupersessionBarcode { get; set; }
        public string RelationshipType { get; set; }
        public string LockCode { get; set; }
        public string Growth2 { get; set; }
        public string Maturity3 { get; set; }
        public DateTime dateto2_Growth { get; set; }
        public string Decline4 { get; set; }
        public string GoodBye8 { get; set; }
        public string SDD_Focus { get; set; }
        public string CertificationStatus { get; set; }
        public string Item_Class { get; set; }
        public string Product_Division { get; set; }
        public string Main_Category { get; set; }
        public string Sub_Category { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string invcode { get; set; }
        public string CHRCODE { get; set; }
        public float UsagePerCar { get; set; }
        public float ServiceYear { get; set; }
        public float ProductSize { get; set; }
        public float ProductQtyPerPack { get; set; }

    }

    public partial class ItemMasterModel
    {
        //Tab1 - Information
        public string stmas_code { get; set; }
        public string prodpurplan_cartype { get; set; }
        public float prodpurplan_usagepercar { get; set; }
        public float prodpurplan_serviceyear { get; set; }

        //Tab2 - StockPrice
        public string prodrepplan_klh_stockstatus { get; set; }
        public float prodrepplan_klh_minqty { get; set; }
        public float prodrepplan_klh_maxqty { get; set; }
        public float prodpurplan_productsize { get; set; }
        public float prodpurplan_productqtyperpack { get; set; }

        //Tab3 - Inventory#1
        public string prodpurplan_stockstatus { get; set; }
        public string prodpurplan_remarkbypm { get; set; }
        public string prodpurplan_skufocus { get; set; }
        public string prodpurplan_lifecycleaction { get; set; }
        public string prodpurplan_lifecyclereviewdate { get; set; }
        public string prodpurplan_certificationstatus { get; set; }
        public string prodpurplan_lockcode { get; set; }
        public string prodpurplan_supersessionbarcode { get; set; }
        public string prodpurplan_relationshiptype { get; set; }
        public string vitemmaster_productdivision { get; set; }
        public string vitemmaster_maincategory { get; set; }
        public string vitemmaster_subcategory { get; set; }
        public string stmas_donotpur { get; set; }
        public string stmas_donotsale { get; set; }
        public string stmas_ginactive { get; set; }
        public string stmas_custconfirm { get; set; }

        //Tab4 - Inventory#2
        public string prodpurplan_plantype { get; set; }
        public string prodpurplan_sourcetype { get; set; }
        public int prodpurplan_manualsafetystock { get; set; }
        public int prodpurplan_moq { get; set; }
        public int prodpurplan_leadtimesupplier { get; set; }
        public int prodpurplan_leadtimeitem { get; set; }
        public double prodpurplan_minqtyconst { get; set; }
        public double prodpurplan_maxqtyconst { get; set; }
        public string prodpurplan_prefsuppliercode { get; set; }
        public double prodpurplan_prefsupplierdisc { get; set; }
        public string prodpurplan_discgroup { get; set; }
        public string prodpurplan_salediscgroup { get; set; }
        public string prodpurplan_purdiscgroup { get; set; }
        public string prodpurplan_purchase { get; set; }
        public string prodpurplan_purcon { get; set; }
        public string prodpurplan_transferunit { get; set; }
        public double prodpurplan_minqtywarehouse { get; set; }
        public double prodpurplan_maxqtywarehouse { get; set; }


        public string prodpurplan_createdby { get; set; }
        public string prodpurplan_createddate { get; set; }
        public string prodpurplan_updatedby { get; set; }
        public string prodpurplan_updatedby2 { get; set; }
        public string prodpurplan_updateddate { get; set; }

    }

    public partial class ApmasModel
    {
        public string code { get; set; }
        public string lname { get; set; }
    }

    public partial class StockStatusHistoryModel
    {
        public string trans_id { get; set; }
        public DateTime trans_date { get; set; }
        public string product_code { get; set; }
        public string stockstatus { get; set; }
        public string remarkbypm { get; set; }
        public string review_date { get; set; }
        public string change_user { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
    }

    public partial class vGRMinDateModel
    {
        public string stkcod { get; set; }
        public string GRdateMin { get; set; }
    }

    public partial class vGRMaxDateModel
    {
        public string stkcod { get; set; }
        public string GRdateMax { get; set; }
    }

    public partial class GoodPriceModel
    {
        public string gunit { get; set; }
        public double prqty { get; set; }
        public double qtysmall { get; set; }
        public double gprice { get; set; }
        public double gpriceA { get; set; }
        public double gpriceB { get; set; }
        public double gpriceC { get; set; }
        public double gpriceD { get; set; }
        public double gpriceE { get; set; }
        public double gpriceF { get; set; }
        public string goutput { get; set; }
        public int item { get; set; }
        public int purch { get; set; }
        public double gpricepur { get; set; }
        public string code { get; set; }
        public DateTime startdate { get; set; }
        public string userid { get; set; }
        public string gbarcode { get; set; }
        public string itemname { get; set; }
        public int backpu { get; set; }
    }

    public partial class vGRDateModel
    {
        public string item_code { get; set; }
        public string GRdateMin { get; set; }
        public string GRdateMax { get; set; }
        public string is_GRZ { get; set; }
    }


    public partial class Product_ReplenishPlan_Stock_Factor_KLH_Model
    {
        public string code { get; set; }
        public string itemname { get; set; }
        public string barcode { get; set; }
        public string spcodes { get; set; }
        public string uom { get; set; }
        public float MaxQty { get; set; }
        public float MinQty { get; set; }
        public int MOQ { get; set; }
        public string StockStatus { get; set; }
        public float SumOfSalesAmount { get; set; }
        public float CountOfInvoiceOrderLines { get; set; }
        public string InvoiceFreCodeDesc { get; set; }
        public DateTime update_frecode { get; set; }
        public DateTime update_stockstatus { get; set; }
        public DateTime startdate { get; set; }
        public int PackCodeRounding { get; set; }
        public DateTime UpdateDate { get; set; }
        public string userReview { get; set; }

    }


    //public partial class stmasMakerCatFactorModel
    //{
    //    public string code { get; set; }
    //    public string SubCategory { get; set; }
    //    public string MainCategory { get; set; }
    //    public string ProductDivision { get; set; }
    //}

    //public partial class vItemMasterModel
    //{
    //    public string code { get; set; }
    //    public string gbarcode { get; set; }
    //    public string SPCODES { get; set; }
    //    public string name { get; set; }
    //    public string gnamechr { get; set; }
    //    public string gOem { get; set; }
    //    public string TYPE { get; set; }
    //    public string gmodel { get; set; }
    //    public string GUSED { get; set; }
    //    public string UOM { get; set; }
    //    public string named { get; set; }
    //    public string Status_pur { get; set; }
    //    public float Onhand_All { get; set; }
    //    public float Onhand_Cost { get; set; }
    //    public float Onhand { get; set; }
    //    public float Onhand_LKS { get; set; }
    //    public float Onhand_VSF { get; set; }
    //    public float Onhand_KLH { get; set; }
    //    public float Onhand_LLK { get; set; }
    //    public float onhandST { get; set; }
    //    public float onhandST_LKS { get; set; }
    //    public string onhandST_VSF { get; set; }
    //    public string onhandST_KLH { get; set; }
    //    public string onhandST_LLK { get; set; }
    //    public string ZA { get; set; }
    //    public string ZB { get; set; }
    //    public string Z8 { get; set; }
    //    public string carbrand { get; set; }
    //    public string cartype { get; set; }
    //    public string carmodel { get; set; }
    //    public string carFmyear { get; set; }
    //    public string carToyear { get; set; }
    //    public string carGeneration { get; set; }
    //    public string carEngine { get; set; }
    //    public string carBody { get; set; }
    //    public string BodyCode { get; set; }
    //    public string OemSearch { get; set; }
    //    public string glocat { get; set; }
    //    public string gpricepur { get; set; }
    //    public string gprice { get; set; }
    //    public string gcost { get; set; }
    //    public string gpriceA { get; set; }
    //    public string gpriceB { get; set; }
    //    public string gpriceC { get; set; }
    //    public string gpriceD { get; set; }
    //    public string gpriceE { get; set; }
    //    public string gpriceF { get; set; }
    //    public string gperA { get; set; }
    //    public string gperB { get; set; }
    //    public string gperC { get; set; }
    //    public string gperD { get; set; }
    //    public string gperE { get; set; }
    //    public string gperF { get; set; }
    //    public string Salecost { get; set; }
    //    public string avgcost { get; set; }
    //    public string AvgSalecost { get; set; }
    //    public string gvat { get; set; }
    //    public string typevat { get; set; }
    //    public string costtype { get; set; }
    //    public string Maker { get; set; }
    //    public string purchase { get; set; }
    //    public string vendorcode { get; set; }
    //    public string vendorname { get; set; }
    //    public string StockingClass { get; set; }
    //    public string MaxQty_D_Constant { get; set; }
    //    public string MinQty_E_Constant { get; set; }
    //    public string Status { get; set; }
    //    public string partOem { get; set; }
    //    public string userid { get; set; }
    //    public string startdate { get; set; }
    //    public string Item_Class { get; set; }
    //    public string UpdateDate { get; set; }
    //    public string PrefSupplierCode { get; set; }
    //    public string PrefSupplierName { get; set; }
    //    public string PrefSupplierDisc { get; set; }
    //    public string PurDiscGroup { get; set; }
    //    public string SaleDiscGroup { get; set; }
    //    public string DiscGroup { get; set; }
    //    public string InvoiceFreCodeDesc { get; set; }
    //    public string StockStatus { get; set; }
    //    public string StockStatus_Suggest { get; set; }
    //    public string InvoiceFreCode { get; set; }
    //    public string CountOfCustomersDistinct_Pre12M { get; set; }
    //    public string CountOfCustomersDistinct_Pre3M { get; set; }
    //    public string ManualSafetyStockQty { get; set; }
    //    public string LeadTimeSupplier { get; set; }
    //    public string LeadTimeItem { get; set; }
    //    public string LastUpdateByPM { get; set; }
    //    public string RemarkByPM { get; set; }
    //    public string RemarkByPIT { get; set; }
    //    public string SubCategory { get; set; }
    //    public string MainCategory { get; set; }
    //    public string ProductDivision { get; set; }
    //    public string CountInvoiceAllBranch { get; set; }
    //    public string DefaultSupplierCode { get; set; }
    //    public string DefaultSupplierName { get; set; }
    //    public string MaxQty_KLH { get; set; }
    //    public string MinQty_KLH { get; set; }
    //    public string Stockstatus_KLH { get; set; }
    //    public string SkuFocus { get; set; }
    //    public string ItemAged { get; set; }

    //}
}