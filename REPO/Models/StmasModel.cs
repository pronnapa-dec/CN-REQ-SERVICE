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
        public string stmas_minstock { get; set; }
        public string stmas_maxstock { get; set; }
        public string stmas_prodclass { get; set; }
        public string stmas_prodgroup { get; set; }
        public string stmas_prodstatus { get; set; }
        public string stmas_custconfirm { get; set; }

        //start 3 สต็อก/สถานที่เก็บ //
        public string stmas_Onhandv { get; set; }

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
        public string gprice { get; set; }
        public string gpricepur { get; set; }
        public string gpriceA { get; set; }
        public string gpriceB { get; set; }
        public string gpriceC { get; set; }
        public string gpriceD { get; set; }
        public string gpriceE { get; set; }
        public string gpriceF { get; set; }
        public string gperA { get; set; }
        public string gperB { get; set; }
        public string gperC { get; set; }
        public string gperD { get; set; }
        public string gperE { get; set; }
        public string gperF { get; set; }
        public string goodprice_purch { get; set; }
        public string goodprice_gpricepur { get; set; }

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

}