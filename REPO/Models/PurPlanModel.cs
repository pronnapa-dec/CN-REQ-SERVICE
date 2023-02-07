using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class InventoryCodeModel
    {
        public string invcode { get; set; }
        public DateTime insert_date { get; set; }
    }
    public partial class InvfreCodeModel
    {
        public string invfrecode { get; set; }
        public int movements { get; set; }
        public int period { get; set; }
        public string description { get; set; }
        public string customerminimum { get; set; }
        public string invcode { get; set; }
        public DateTime insert_date { get; set; }
    }
    public partial class PurPlanModel
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
        public string CertificationStatus { get; set; }
    }

}