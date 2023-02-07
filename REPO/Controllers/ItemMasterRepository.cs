using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using MySql.Data.MySqlClient;
using REPO.Models;

namespace REPO.Controllers
{
    public class ItemMasterRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection MIS_SERVICE;
        public SqlConnection VSK_Data;
        public SqlConnection VorwinsKLH;
        public MySqlConnection MariaDBConn;

        private void Connection()
        {
            string STR_MIS_SERVICE = ConfigurationManager.ConnectionStrings["MIS_SERVICE"].ToString();
            MIS_SERVICE = new SqlConnection(STR_MIS_SERVICE);

            string STR_VSK_Data = ConfigurationManager.ConnectionStrings["VSK_Data"].ToString();
            VSK_Data = new SqlConnection(STR_VSK_Data);

            string STR_VorwinsKLH = ConfigurationManager.ConnectionStrings["VorwinsKLH"].ToString();
            VorwinsKLH = new SqlConnection(STR_VorwinsKLH);

            string STR_VSK_Barcode = ConfigurationManager.ConnectionStrings["MariaDBConn"].ToString();
            MariaDBConn = new MySqlConnection(STR_VSK_Barcode);
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public List<StmasModel_v2> Stmas_Get(string item_code)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@item_code", item_code);

                Connection();
                VSK_Data.Open();
                List<StmasModel_v2> RequestModelList = SqlMapper.Query<StmasModel_v2>(VSK_Data, "SP_Stmas_Get_v1", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<StmasModel> Stmas_Search(string item_code, string item_name, string item_CHRCODE, string item_SPCODES, string item_gbarcode, string mode)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@item_code", item_code);
                objParam.Add("@item_name", item_name);
                objParam.Add("@item_CHRCODE", item_CHRCODE);
                objParam.Add("@item_SPCODES", item_SPCODES);
                objParam.Add("@item_gbarcode", item_gbarcode);
                objParam.Add("@mode", mode);

                Connection();
                VSK_Data.Open();
                List<StmasModel> RequestModelList = SqlMapper.Query<StmasModel>(VSK_Data, "SP_Stmas_Search", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<GcodeModel> Gcode_Get(GcodeModel GcodeModel)
        {

            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", GcodeModel.code);
                objParam.Add("@gname", GcodeModel.gname);
                objParam.Add("@codechr", GcodeModel.codechr);
                objParam.Add("@ctype", GcodeModel.ctype);

                Connection();
                VSK_Data.Open();
                List<GcodeModel> RequestModelList = SqlMapper.Query<GcodeModel>(VSK_Data, "SP_Gcode_Get", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<BarcodeModel> Barcode_Get(BarcodeModel BarcodeModel)
        {

            try
            {
                string SQLQuery = "SELECT RTRIM(gbarcode) as gbarcode FROM [dbo].[stmas]";

                Connection();
                VSK_Data.Open();
                List<BarcodeModel> RequestModelList = VSK_Data.Query<BarcodeModel>(SQLQuery).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<UOMModel> UOM_Get(UOMModel UOMModel)
        {

            try
            {
                string SQLQuery = "SELECT RTRIM(code) as code FROM [dbo].[tbdata]";

                Connection();
                VSK_Data.Open();
                List<UOMModel> RequestModelList = VSK_Data.Query<UOMModel>(SQLQuery).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<LocationModel> Location_Get(LocationModel LocationModel)
        {

            try
            {
                string SQLQuery = "SELECT RTRIM(code) as code, RTRIM(whcode) as whcode, RTRIM(whname) as whname FROM [dbo].[glocat]";

                Connection();
                VSK_Data.Open();
                List<LocationModel> RequestModelList = VSK_Data.Query<LocationModel>(SQLQuery).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PrinterZoneModel> PrinterZone_Get(PrinterZoneModel PrinterZoneModel)
        {

            try
            {
                string SQLQuery = "SELECT RTRIM(code) as code, RTRIM(SETPRINT) as setprint FROM [dbo].[tbdata]";

                Connection();
                VSK_Data.Open();
                List<PrinterZoneModel> RequestModelList = VSK_Data.Query<PrinterZoneModel>(SQLQuery).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<Product_PurPlan_Stock_FactorModel_V4> Product_PurPlan_Stock_Factor_List_Get(string search_item_gbarcode, string search_item_spcodes, string search_item_code, string search_item_code1, string search_item_code3, string search_item_productdivision, string search_item_maincategory, string search_item_subcategory, string search_item_carmodel, string search_item_carbrand, string search_item_stockstatus, string search_item_skufocus, string search_item_code_2, string search_item_gbarcode_2, string search_item_spcodes_2, string search_item_code1_2, string search_item_code3_2, string mode)
        {

            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@search_item_gbarcode", search_item_gbarcode);
                objParam.Add("@search_item_spcodes", search_item_spcodes);
                objParam.Add("@search_item_code", search_item_code);
                objParam.Add("@search_item_code1", search_item_code1);
                objParam.Add("@search_item_code3", search_item_code3);
                objParam.Add("@search_item_productdivision", search_item_productdivision);
                objParam.Add("@search_item_maincategory", search_item_maincategory);
                objParam.Add("@search_item_subcategory", search_item_subcategory);
                objParam.Add("@search_item_carmodel", search_item_carmodel);
                objParam.Add("@search_item_carbrand", search_item_carbrand);
                objParam.Add("@search_item_stockstatus", search_item_stockstatus);
                objParam.Add("@search_item_skufocus", search_item_skufocus);
                objParam.Add("@search_item_code_2", search_item_code_2);
                objParam.Add("@search_item_gbarcode_2", search_item_gbarcode_2);
                objParam.Add("@search_item_spcodes_2", search_item_spcodes_2);
                objParam.Add("@search_item_code1_2", search_item_code1_2);
                objParam.Add("@search_item_code3_2", search_item_code3_2);
                objParam.Add("@mode", mode);

                Connection();
                VSK_Data.Open();
                List<Product_PurPlan_Stock_FactorModel_V4> RequestModelList = SqlMapper.Query<Product_PurPlan_Stock_FactorModel_V4>(VSK_Data, "SP_ProductPurPlanStockFactor_Get_v1", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //public List<ItemMasterListModel> Product_PurPlan_Stock_Factor_List_Get2(string search_item_gbarcode, string search_item_spcodes, string search_item_code, string search_item_code1, string search_item_code3, string search_item_productdivision, string search_item_maincategory, string search_item_subcategory, string search_item_carmodel, string search_item_carbrand, string search_item_stockstatus, string search_item_skufocus, string search_item_code_2, string search_item_gbarcode_2, string search_item_spcodes_2, string search_item_code1_2, string search_item_code3_2, string mode)
        //{

        //    try
        //    {
        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@search_item_gbarcode", search_item_gbarcode);
        //        objParam.Add("@search_item_spcodes", search_item_spcodes);
        //        objParam.Add("@search_item_code", search_item_code);
        //        objParam.Add("@search_item_code1", search_item_code1);
        //        objParam.Add("@search_item_code3", search_item_code3);
        //        objParam.Add("@search_item_productdivision", search_item_productdivision);
        //        objParam.Add("@search_item_maincategory", search_item_maincategory);
        //        objParam.Add("@search_item_subcategory", search_item_subcategory);
        //        objParam.Add("@search_item_carmodel", search_item_carmodel);
        //        objParam.Add("@search_item_carbrand", search_item_carbrand);
        //        objParam.Add("@search_item_stockstatus", search_item_stockstatus);
        //        objParam.Add("@search_item_skufocus", search_item_skufocus);
        //        objParam.Add("@search_item_code_2", search_item_code_2);
        //        objParam.Add("@search_item_gbarcode_2", search_item_gbarcode_2);
        //        objParam.Add("@search_item_spcodes_2", search_item_spcodes_2);
        //        objParam.Add("@search_item_code1_2", search_item_code1_2);
        //        objParam.Add("@search_item_code3_2", search_item_code3_2);
        //        objParam.Add("@mode", mode);

        //        Connection();
        //        VSK_Data.Open();
        //        List<Product_PurPlan_Stock_FactorModel_V4> RequestModelList = SqlMapper.Query<Product_PurPlan_Stock_FactorModel_V4>(VSK_Data, "SP_ProductPurPlanStockFactor_Get_v1", objParam, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_Data.Close();
        //        return RequestModelList.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}


        public List<Product_PurPlan_Stock_FactorModel> Product_PurPlan_Stock_Factor_Get(string item_code)
        {

            try
            {

                string SQLQuery = "SELECT TOP 1 * FROM Product_PurPlan_Stock_Factor$ WHERE code = '" + item_code + "'";

                Connection();
                VSK_Data.Open();
                List<Product_PurPlan_Stock_FactorModel> RequestModelList = VSK_Data.Query<Product_PurPlan_Stock_FactorModel>(SQLQuery, commandTimeout: 600).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<Product_PurPlan_Stock_FactorModel_v2> Product_PurPlan_Stock_Factor_Get_v2(string item_code)
        {

            try
            {

                string SQLQuery = "SELECT TOP 1 * FROM Product_PurPlan_Stock_Factor$ WHERE code = '" + item_code + "'";

                Connection();
                VSK_Data.Open();
                List<Product_PurPlan_Stock_FactorModel_v2> RequestModelList = VSK_Data.Query<Product_PurPlan_Stock_FactorModel_v2>(SQLQuery, commandTimeout: 600).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<Product_PurPlan_Stock_FactorModel_V3> Product_PurPlan_Stock_Factor_Get_V3(string item_code)
        {

            try
            {

                string SQLQuery = "SELECT TOP 1 * FROM View_Product_PurPlan_Stock_Factor$_web WHERE code = '" + item_code + "'";


                //string SQLQuery = " SELECT TOP 1 rtrim(code)"
                //+ ", rtrim(barcode)"
                //+ ", rtrim(itemname)"
                //+ ", rtrim(spcodes)"
                //+ ", rtrim(code1_gnamechr)"
                //+ ", rtrim(UOM)"
                //+ ", rtrim(StockingClass)"
                //+ ", rtrim(MaxQty(D)Constant) as MaxQty"
                //+ ", rtrim(MinQty(E)Constant) as MinQty"
                //+ ", rtrim(Status)"
                //+ ", rtrim(SaleFreqGrade)"
                //+ ", rtrim(OL_Ranking)"
                //+ ", rtrim(StockSettingProposal)"
                //+ ", rtrim(StockSettingProposalPhase)"
                //+ ", rtrim(Planing_Type)"
                //+ ", rtrim(Source_Type)"
                //+ ", rtrim(PurchaseCondition)"
                //+ ", rtrim(MOQ)"
                //+ ", rtrim(PrefSupplierCode)"
                //+ ", rtrim(PrefSupplierName)"
                //+ ", rtrim(PrefSupplierDisc)"
                //+ ", rtrim(PurDiscGroup)"
                //+ ", rtrim(InvoiceFreCode_Suggest)"
                //+ ", rtrim(InvoiceFreCode)"
                //+ ", rtrim(StockStatus)"
                //+ ", rtrim(CountOfCustomersDistinct)"
                //+ ", rtrim(CountOfCustomersDistinctOpt1)"
                //+ ", rtrim(CountOfCustomersDistinct(Pre12M)) as CountOfCustomersDistinct_Pre12M"
                //+ ", rtrim(CountOfCustomersDistinct(Pre3M)) as CountOfCustomersDistinct_Pre3M"
                //+ ", rtrim(CountOfCustomersDistinct(Pre6M)) as CountOfCustomersDistinct_Pre6M"
                //+ ", rtrim(SumOfSalesAmount_VSK)"
                //+ ", rtrim(CountOfInvoiceOrderLines_VSK)"
                //+ ", rtrim(SumOfSalesAmount_VSK2)"
                //+ ", rtrim(CountOfInvoiceOrderLines_VSK2)"
                //+ ", rtrim(SumOfSalesAmount_SP1)"
                //+ ", rtrim(CountOfInvoiceOrderLines_SP1)"
                //+ ", rtrim(SumOfSalesAmount_KLH)"
                //+ ", rtrim(CountOfInvoiceOrderLines_KLH)"
                //+ ", rtrim(SumOfSalesAmount_LLK)"
                //+ ", rtrim(CountOfInvoiceOrderLines_LLK)"
                //+ ", rtrim(CountInvoiceAllBranch)"
                //+ ", rtrim(InvoiceFreCodeDesc_Suggest)"
                //+ ", rtrim(InvoiceFreCodeDesc)"
                //+ ", rtrim(update_frecode)"
                //+ ", rtrim(update_stockstatus)"
                //+ ", rtrim(is_service)"
                //+ ", rtrim(ItemAged)"
                //+ ", rtrim(prodstatus_Ka)"
                //+ ", rtrim(StockStatus_Kfrank)"
                //+ ", rtrim(startdate)"
                //+ ", rtrim(prodgroup)"
                //+ ", rtrim(StockStatus_Suggest)"
                //+ ", rtrim(StockStatus_Ka)"
                //+ ", rtrim(ManualSafetyStockQty)"
                //+ ", rtrim(LeadTimeSupplier)"
                //+ ", rtrim(LeadTimeItem)"
                //+ ", rtrim(Updated)"
                //+ ", rtrim(Onhand)"
                //+ ", rtrim(Group)"
                //+ ", rtrim(SaleQty)"
                //+ ", rtrim(Onhand_VSK)"
                //+ ", rtrim(Onhand_VSF)"
                //+ ", rtrim(Onhand_LKS)"
                //+ ", rtrim(Onhand_KLH)"
                //+ ", rtrim(Onhand_LLK)"
                //+ ", rtrim(OnhandAll)"
                //+ ", rtrim(MainItem)"
                //+ ", rtrim(InheritCode)"
                //+ ", rtrim(SubCategoryCode)"
                //+ ", rtrim(UpdateMaxMin)"
                //+ ", rtrim(MaxQty07022020)"
                //+ ", rtrim(CostStart310120)"
                //+ ", rtrim(SaleCostStart310120)"
                //+ ", rtrim(AvgCostStart310120)"
                //+ ", rtrim(AvgSaleCostStart310120)"
                //+ ", rtrim(LastUpdateByPM)"
                //+ ", rtrim(RemarkByPM)"
                //+ ", rtrim(StockStatusReviewDate)"
                //+ ", rtrim(StockStatusChangeUser)"
                //+ ", rtrim(PackCodeRounding)"
                //+ ", rtrim(ReOrderQtyDaily)"
                //+ ", rtrim(ReOderDate)"
                //+ ", rtrim(purchase)"
                //+ ", rtrim(TYPE)"
                //+ ", rtrim(Cartype)"
                //+ ", rtrim(gOem(New)) as gOem_New"
                //+ ", rtrim(Maker)"
                //+ ", rtrim(MinStockByPM)"
                //+ ", rtrim(MinQtyWarehouse)"
                //+ ", rtrim(MaxQtyWarehouse)"
                //+ ", rtrim(Transfer Unit) as Transfer_Unit"
                //+ ", rtrim(DefaultSupplierCode)"
                //+ ", rtrim(DefaultSupplierName)"
                //+ ", rtrim(Comment)"
                //+ ", rtrim(SupDiscPer)"
                //+ ", rtrim(ProdLifeCycle)"
                //+ ", rtrim(SkuFocus)"
                //+ ", rtrim(DiscGroup)"
                //+ ", rtrim(SaleDiscGroup)"
                //+ ", rtrim(ProductLifeCycle)"
                //+ ", rtrim(LifeCycleFlag)"
                //+ ", rtrim(ProductActivity)"
                //+ ", rtrim(LifeCycleAction)"
                //+ ", rtrim(SupersessionBarcode)"
                //+ ", rtrim(RelationshipType)"
                //+ ", rtrim(Lock code) as LockCode"
                //+ ", rtrim(2_Growth) as Growth2"
                //+ ", rtrim(3_Maturity) as Maturity3"
                //+ ", rtrim(dateto2_Growth)"
                //+ ", rtrim(4_Decline) as Decline4"
                //+ ", rtrim(8_GoodBye) as GoodBye8"
                //+ " FROM VSK_Data.dbo.Product_PurPlan_Stock_Factor$"
                //+ " WHERE code = '" + item_code + "'";

                Connection();
                VSK_Data.Open();
                List<Product_PurPlan_Stock_FactorModel_V3> RequestModelList = VSK_Data.Query<Product_PurPlan_Stock_FactorModel_V3>(SQLQuery, commandTimeout: 600).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<Product_PurPlan_Stock_FactorModel_V4> Product_PurPlan_Stock_Factor_Get_V4(string item_code)
        {
            try
            {

                string SQLQuery = "SELECT TOP 1 * FROM View_Product_PurPlan_Stock_Factor$_web WHERE code = '" + item_code + "'";

                Connection();
                VSK_Data.Open();
                List<Product_PurPlan_Stock_FactorModel_V4> RequestModelList = VSK_Data.Query<Product_PurPlan_Stock_FactorModel_V4>(SQLQuery, commandTimeout: 600).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<GoodpriceModel> Goodprice_Get(string item_code, string item_gbarcode)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@item_code", item_code);
                objParam.Add("@item_gbarcode", item_gbarcode);

                Connection();
                VSK_Data.Open();
                List<GoodpriceModel> RequestModelList = SqlMapper.Query<GoodpriceModel>(VSK_Data, "SP_Goodprice_Get", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<GlocatModel> Glocat_get(string wh_code)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@wh_code", wh_code);

                Connection();
                VSK_Data.Open();
                List<GlocatModel> RequestModelList = SqlMapper.Query<GlocatModel>(VSK_Data, "SP_Glocat_Get", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<StmasModel_v2> Stmas_Search_V2(string item_code, string item_name, string item_CHRCODE, string item_SPCODES, string item_gbarcode, string mode)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@item_code", item_code);
                objParam.Add("@item_name", item_name);
                objParam.Add("@item_CHRCODE", item_CHRCODE);
                objParam.Add("@item_SPCODES", item_SPCODES);
                objParam.Add("@item_gbarcode", item_gbarcode);
                objParam.Add("@mode", mode);

                Connection();
                VSK_Data.Open();
                List<StmasModel_v2> RequestModelList = SqlMapper.Query<StmasModel_v2>(VSK_Data, "SP_Stmas_Search_V3", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<StmasModel_v2> stmas_search_V3(string item_gbarcode, string item_spcodes, string item_code, string item_name, string item_code1, string item_code2, string item_code3, string item_code4, string item_code5, string mode)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@item_gbarcode", item_gbarcode);
                objParam.Add("@item_spcodes", item_spcodes);
                objParam.Add("@item_code", item_code);
                objParam.Add("@item_name", item_name);
                objParam.Add("@item_code1", item_code1);
                objParam.Add("@item_code2", item_code2);
                objParam.Add("@item_code3", item_code3);
                objParam.Add("@item_code4", item_code4);
                objParam.Add("@item_code5", item_code5);
                objParam.Add("@mode", mode);

                Connection();
                VSK_Data.Open();
                List<StmasModel_v2> RequestModelList = SqlMapper.Query<StmasModel_v2>(VSK_Data, "SP_Stmas_Search_V4", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<StmasModel_v2> stmas_search_V4(string item_gbarcode, string item_spcodes, string item_code, string item_name, string item_code1, string item_code3, string search_item_productdivision, string search_item_maincategory, string search_item_subcategory, string mode)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@item_gbarcode", item_gbarcode);
                objParam.Add("@item_spcodes", item_spcodes);
                objParam.Add("@item_code", item_code);
                objParam.Add("@item_name", item_name);
                objParam.Add("@item_code1", item_code1);
                objParam.Add("@item_code3", item_code3);
                objParam.Add("@search_item_productdivision", search_item_productdivision);
                objParam.Add("@search_item_maincategory", search_item_maincategory);
                objParam.Add("@search_item_subcategory", search_item_subcategory);
                objParam.Add("@mode", mode);

                Connection();
                VSK_Data.Open();
                List<StmasModel_v2> RequestModelList = SqlMapper.Query<StmasModel_v2>(VSK_Data, "SP_Stmas_Search_V5", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #region VSK-PROG-ITEMMASTER-001 :  ItemMaster_Update
        public List<ItemMasterModel> ItemMaster_Update(ItemMasterModel ItemMasterModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@stmas_code", ItemMasterModel.stmas_code);
                objParam.Add("@prodpurplan_cartype", ItemMasterModel.prodpurplan_cartype);
                objParam.Add("@prodpurplan_usagepercar", ItemMasterModel.prodpurplan_usagepercar);
                objParam.Add("@prodpurplan_serviceyear", ItemMasterModel.prodpurplan_serviceyear);
                objParam.Add("@stmas_spcodes", ItemMasterModel.stmas_spcodes);
                objParam.Add("@stmas_codeoem", ItemMasterModel.stmas_codeoem);
                objParam.Add("@stmas_gdimension", ItemMasterModel.stmas_gdimension);
                objParam.Add("@prodpurplan_carbrand", ItemMasterModel.prodpurplan_carbrand);
                objParam.Add("@prodpurplan_carmodel", ItemMasterModel.prodpurplan_carmodel);
                objParam.Add("@stmas_cargeneration", ItemMasterModel.stmas_cargeneration);
                objParam.Add("@stmas_matchinno", ItemMasterModel.stmas_matchinno);
                objParam.Add("@stmas_bodyno", ItemMasterModel.stmas_bodyno);
                objParam.Add("@stmas_carengine", ItemMasterModel.stmas_carengine);
                objParam.Add("@stmas_carbody", ItemMasterModel.stmas_carbody);
                objParam.Add("@stmas_carbodycode", ItemMasterModel.stmas_carbodycode);
                objParam.Add("@stmas_carfyear", ItemMasterModel.stmas_carfyear);
                objParam.Add("@stmas_cartoyear", ItemMasterModel.stmas_cartoyear);
                objParam.Add("@stmas_gdescrip", ItemMasterModel.stmas_gdescrip);
                objParam.Add("@prodrepplan_vsf_stockstatus", ItemMasterModel.prodrepplan_vsf_stockstatus);
                objParam.Add("@prodrepplan_vsf_minqty", ItemMasterModel.prodrepplan_vsf_minqty);
                objParam.Add("@prodrepplan_vsf_maxqty", ItemMasterModel.prodrepplan_vsf_maxqty);
                objParam.Add("@prodrepplan_lks_stockstatus", ItemMasterModel.prodrepplan_lks_stockstatus);
                objParam.Add("@prodrepplan_lks_minqty", ItemMasterModel.prodrepplan_lks_minqty);
                objParam.Add("@prodrepplan_lks_maxqty", ItemMasterModel.prodrepplan_lks_maxqty);
                objParam.Add("@prodrepplan_klh_stockstatus", ItemMasterModel.prodrepplan_klh_stockstatus);
                objParam.Add("@prodrepplan_klh_minqty", ItemMasterModel.prodrepplan_klh_minqty);
                objParam.Add("@prodrepplan_klh_maxqty", ItemMasterModel.prodrepplan_klh_maxqty);
                objParam.Add("@prodrepplan_llk_stockstatus", ItemMasterModel.prodrepplan_llk_stockstatus);
                objParam.Add("@prodrepplan_llk_minqty", ItemMasterModel.prodrepplan_llk_minqty);
                objParam.Add("@prodrepplan_llk_maxqty", ItemMasterModel.prodrepplan_llk_maxqty);
                objParam.Add("@prodrepplan_nwm_stockstatus", ItemMasterModel.prodrepplan_nwm_stockstatus);
                objParam.Add("@prodrepplan_nwm_minqty", ItemMasterModel.prodrepplan_nwm_minqty);
                objParam.Add("@prodrepplan_nwm_maxqty", ItemMasterModel.prodrepplan_nwm_maxqty);
                objParam.Add("@prodpurplan_productsize", ItemMasterModel.prodpurplan_productsize);
                objParam.Add("@prodpurplan_productqtyperpack", ItemMasterModel.prodpurplan_productqtyperpack);
                objParam.Add("@prodpurplan_maxdiscountpercent", ItemMasterModel.prodpurplan_maxdiscountpercent);
                objParam.Add("@prodpurplan_minmarginpercent", ItemMasterModel.prodpurplan_minmarginpercent);
                objParam.Add("@prodpurplan_stdmargin", ItemMasterModel.prodpurplan_stdmargin);
                objParam.Add("@prodpurplan_vatdiscmargin", ItemMasterModel.prodpurplan_vatdiscmargin);
                objParam.Add("@prodpurplan_stockstatus", ItemMasterModel.prodpurplan_stockstatus);
                objParam.Add("@prodpurplan_remarkbypm", ItemMasterModel.prodpurplan_remarkbypm);
                objParam.Add("@prodpurplan_grvat", ItemMasterModel.prodpurplan_grvat);
                objParam.Add("@prodpurplan_skufocus", ItemMasterModel.prodpurplan_skufocus);
                objParam.Add("@stmas_donotpur", ItemMasterModel.stmas_donotpur);
                objParam.Add("@stmas_donotsale", ItemMasterModel.stmas_donotsale);
                objParam.Add("@stmas_ginactive", ItemMasterModel.stmas_ginactive);
                objParam.Add("@stmas_custconfirm", ItemMasterModel.stmas_custconfirm);
                //objParam.Add("@prodpurplan_lifecycleaction", ItemMasterModel.prodpurplan_lifecycleaction);
                objParam.Add("@prodpurplan_lifecyclereviewdate", ItemMasterModel.prodpurplan_lifecyclereviewdate);
                //objParam.Add("@prodpurplan_certificationstatus", ItemMasterModel.prodpurplan_certificationstatus);
                objParam.Add("@prodpurplan_supersessionbarcode", ItemMasterModel.prodpurplan_supersessionbarcode);
                //objParam.Add("@prodpurplan_relationshiptype", ItemMasterModel.prodpurplan_relationshiptype);
                //objParam.Add("@prodpurplan_lockcode", ItemMasterModel.prodpurplan_lockcode);
                objParam.Add("@prodpurplan_plantype", ItemMasterModel.prodpurplan_plantype);
                objParam.Add("@prodpurplan_sourcetype", ItemMasterModel.prodpurplan_sourcetype);
                objParam.Add("@prodpurplan_manualsafetystock", ItemMasterModel.prodpurplan_manualsafetystock);
                objParam.Add("@prodpurplan_moq", ItemMasterModel.prodpurplan_moq);
                objParam.Add("@prodpurplan_leadtimesupplier", ItemMasterModel.prodpurplan_leadtimesupplier);
                objParam.Add("@prodpurplan_leadtimeitem", ItemMasterModel.prodpurplan_leadtimeitem);
                objParam.Add("@prodpurplan_minqtyconst", ItemMasterModel.prodpurplan_minqtyconst);
                objParam.Add("@prodpurplan_maxqtyconst", ItemMasterModel.prodpurplan_maxqtyconst);
                objParam.Add("@prodpurplan_purchase", ItemMasterModel.prodpurplan_purchase);
                objParam.Add("@prodpurplan_purcon", ItemMasterModel.prodpurplan_purcon);
                objParam.Add("@prodpurplan_prefsuppliercode", ItemMasterModel.prodpurplan_prefsuppliercode);
                objParam.Add("@prodpurplan_prefsupplierdisc", ItemMasterModel.prodpurplan_prefsupplierdisc);
                objParam.Add("@prodpurplan_discgroup", ItemMasterModel.prodpurplan_discgroup);
                objParam.Add("@prodpurplan_purdiscgroup", ItemMasterModel.prodpurplan_purdiscgroup);
                objParam.Add("@prodpurplan_salediscgroup", ItemMasterModel.prodpurplan_salediscgroup);
                objParam.Add("@prodpurplan_transferunit", ItemMasterModel.prodpurplan_transferunit);
                objParam.Add("@prodpurplan_minqtywarehouse", ItemMasterModel.prodpurplan_minqtywarehouse);
                objParam.Add("@prodpurplan_maxqtywarehouse", ItemMasterModel.prodpurplan_maxqtywarehouse);
                objParam.Add("@prodpurplan_updatedby", ItemMasterModel.prodpurplan_updatedby);
                objParam.Add("@prodpurplan_updatedby2", ItemMasterModel.prodpurplan_updatedby2);
                objParam.Add("@authorize", ItemMasterModel.authorize);
                objParam.Add("@process_id", ItemMasterModel.process_id);

                Connection();
                VSK_Data.Open();
                List<ItemMasterModel> ItemMaster_Update = SqlMapper.Query<ItemMasterModel>(VSK_Data, "SP_ItemMaster_Update_v1_20210923_new", objParam,commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                //List<ItemMasterModel> ItemMaster_Update = SqlMapper.Query<ItemMasterModel>(VSK_Data, "SP_ItemMaster_Update_v1", objParam,commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return ItemMaster_Update.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-PROG-ITEMMASTER-001 :  ItemMaster_Update_UAT
        public List<ItemMasterUATModel> ItemMaster_Update_UAT(ItemMasterUATModel ItemMasterUATModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@stmas_code", ItemMasterUATModel.stmas_code);
                objParam.Add("@prodpurplan_cartype", ItemMasterUATModel.prodpurplan_cartype);
                objParam.Add("@prodpurplan_usagepercar", ItemMasterUATModel.prodpurplan_usagepercar);
                objParam.Add("@prodpurplan_serviceyear", ItemMasterUATModel.prodpurplan_serviceyear);
                objParam.Add("@stmas_spcodes", ItemMasterUATModel.stmas_spcodes);
                objParam.Add("@stmas_codeoem", ItemMasterUATModel.stmas_codeoem);
                objParam.Add("@stmas_gdimension", ItemMasterUATModel.stmas_gdimension);
                objParam.Add("@prodpurplan_carbrand", ItemMasterUATModel.prodpurplan_carbrand);
                objParam.Add("@prodpurplan_carmodel", ItemMasterUATModel.prodpurplan_carmodel);
                objParam.Add("@stmas_cargeneration", ItemMasterUATModel.stmas_cargeneration);
                objParam.Add("@stmas_matchinno", ItemMasterUATModel.stmas_matchinno);
                objParam.Add("@stmas_bodyno", ItemMasterUATModel.stmas_bodyno);
                objParam.Add("@stmas_carengine", ItemMasterUATModel.stmas_carengine);
                objParam.Add("@stmas_carbody", ItemMasterUATModel.stmas_carbody);
                objParam.Add("@stmas_carbodycode", ItemMasterUATModel.stmas_carbodycode);
                objParam.Add("@stmas_carfyear", ItemMasterUATModel.stmas_carfyear);
                objParam.Add("@stmas_cartoyear", ItemMasterUATModel.stmas_cartoyear);
                objParam.Add("@stmas_gdescrip", ItemMasterUATModel.stmas_gdescrip);
                objParam.Add("@prodrepplan_vsf_stockstatus", ItemMasterUATModel.prodrepplan_vsf_stockstatus);
                objParam.Add("@prodrepplan_vsf_minqty", ItemMasterUATModel.prodrepplan_vsf_minqty);
                objParam.Add("@prodrepplan_vsf_maxqty", ItemMasterUATModel.prodrepplan_vsf_maxqty);
                objParam.Add("@prodrepplan_lks_stockstatus", ItemMasterUATModel.prodrepplan_lks_stockstatus);
                objParam.Add("@prodrepplan_lks_minqty", ItemMasterUATModel.prodrepplan_lks_minqty);
                objParam.Add("@prodrepplan_lks_maxqty", ItemMasterUATModel.prodrepplan_lks_maxqty);
                objParam.Add("@prodrepplan_klh_stockstatus", ItemMasterUATModel.prodrepplan_klh_stockstatus);
                objParam.Add("@prodrepplan_klh_minqty", ItemMasterUATModel.prodrepplan_klh_minqty);
                objParam.Add("@prodrepplan_klh_maxqty", ItemMasterUATModel.prodrepplan_klh_maxqty);
                objParam.Add("@prodrepplan_llk_stockstatus", ItemMasterUATModel.prodrepplan_llk_stockstatus);
                objParam.Add("@prodrepplan_llk_minqty", ItemMasterUATModel.prodrepplan_llk_minqty);
                objParam.Add("@prodrepplan_llk_maxqty", ItemMasterUATModel.prodrepplan_llk_maxqty);
                objParam.Add("@prodrepplan_nwm_stockstatus", ItemMasterUATModel.prodrepplan_nwm_stockstatus);
                objParam.Add("@prodrepplan_nwm_minqty", ItemMasterUATModel.prodrepplan_nwm_minqty);
                objParam.Add("@prodrepplan_nwm_maxqty", ItemMasterUATModel.prodrepplan_nwm_maxqty);
                objParam.Add("@prodpurplan_productsize", ItemMasterUATModel.prodpurplan_productsize);
                objParam.Add("@prodpurplan_productqtyperpack", ItemMasterUATModel.prodpurplan_productqtyperpack);
                objParam.Add("@prodpurplan_maxdiscountpercent", ItemMasterUATModel.prodpurplan_maxdiscountpercent);
                objParam.Add("@prodpurplan_minmarginpercent", ItemMasterUATModel.prodpurplan_minmarginpercent);
                //objParam.Add("@prodpurplan_stdmargin", ItemMasterModel.prodpurplan_stdmargin);
                objParam.Add("@prodpurplan_vatdiscmargin", ItemMasterUATModel.prodpurplan_vatdiscmargin);
                objParam.Add("@prodpurplan_stockstatus", ItemMasterUATModel.prodpurplan_stockstatus);
                objParam.Add("@prodpurplan_remarkbypm", ItemMasterUATModel.prodpurplan_remarkbypm);
                objParam.Add("@prodpurplan_skufocus", ItemMasterUATModel.prodpurplan_skufocus);
                objParam.Add("@stmas_donotpur", ItemMasterUATModel.stmas_donotpur);
                objParam.Add("@stmas_donotsale", ItemMasterUATModel.stmas_donotsale);
                objParam.Add("@stmas_ginactive", ItemMasterUATModel.stmas_ginactive);
                objParam.Add("@stmas_custconfirm", ItemMasterUATModel.stmas_custconfirm);
                //objParam.Add("@prodpurplan_lifecycleaction", ItemMasterUATModel.prodpurplan_lifecycleaction);
                objParam.Add("@prodpurplan_lifecyclereviewdate", ItemMasterUATModel.prodpurplan_lifecyclereviewdate);
                //objParam.Add("@prodpurplan_certificationstatus", ItemMasterUATModel.prodpurplan_certificationstatus);
                objParam.Add("@prodpurplan_supersessionbarcode", ItemMasterUATModel.prodpurplan_supersessionbarcode);
                //objParam.Add("@prodpurplan_relationshiptype", ItemMasterUATModel.prodpurplan_relationshiptype);
                //objParam.Add("@prodpurplan_lockcode", ItemMasterUATModel.prodpurplan_lockcode);
                objParam.Add("@prodpurplan_plantype", ItemMasterUATModel.prodpurplan_plantype);
                objParam.Add("@prodpurplan_sourcetype", ItemMasterUATModel.prodpurplan_sourcetype);
                objParam.Add("@prodpurplan_manualsafetystock", ItemMasterUATModel.prodpurplan_manualsafetystock);
                objParam.Add("@prodpurplan_moq", ItemMasterUATModel.prodpurplan_moq);
                objParam.Add("@prodpurplan_leadtimesupplier", ItemMasterUATModel.prodpurplan_leadtimesupplier);
                objParam.Add("@prodpurplan_leadtimeitem", ItemMasterUATModel.prodpurplan_leadtimeitem);
                objParam.Add("@prodpurplan_minqtyconst", ItemMasterUATModel.prodpurplan_minqtyconst);
                objParam.Add("@prodpurplan_maxqtyconst", ItemMasterUATModel.prodpurplan_maxqtyconst);
                objParam.Add("@prodpurplan_purchase", ItemMasterUATModel.prodpurplan_purchase);
                objParam.Add("@prodpurplan_purcon", ItemMasterUATModel.prodpurplan_purcon);
                objParam.Add("@prodpurplan_prefsuppliercode", ItemMasterUATModel.prodpurplan_prefsuppliercode);
                objParam.Add("@prodpurplan_prefsupplierdisc", ItemMasterUATModel.prodpurplan_prefsupplierdisc);
                objParam.Add("@prodpurplan_discgroup", ItemMasterUATModel.prodpurplan_discgroup);
                objParam.Add("@prodpurplan_purdiscgroup", ItemMasterUATModel.prodpurplan_purdiscgroup);
                objParam.Add("@prodpurplan_salediscgroup", ItemMasterUATModel.prodpurplan_salediscgroup);
                objParam.Add("@prodpurplan_transferunit", ItemMasterUATModel.prodpurplan_transferunit);
                objParam.Add("@prodpurplan_minqtywarehouse", ItemMasterUATModel.prodpurplan_minqtywarehouse);
                objParam.Add("@prodpurplan_maxqtywarehouse", ItemMasterUATModel.prodpurplan_maxqtywarehouse);
                objParam.Add("@prodpurplan_updatedby", ItemMasterUATModel.prodpurplan_updatedby);
                objParam.Add("@prodpurplan_updatedby2", ItemMasterUATModel.prodpurplan_updatedby2);

                Connection();
                VSK_Data.Open();
                List<ItemMasterUATModel> ItemMaster_Update = SqlMapper.Query<ItemMasterUATModel>(VSK_Data, "SP_ItemMaster_Update_v1_UAT", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return ItemMaster_Update.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        public List<ApmasModel> apmas_get(ApmasModel ApmasModel)
        {
            try
            {
                string SQLQuery = "SELECT rtrim(code) as code, rtrim(lname) as lname FROM dbo.apmas"; Connection();

                Connection();
                VSK_Data.Open();
                List<ApmasModel> RequestModelList = VSK_Data.Query<ApmasModel>(SQLQuery, commandTimeout: 600).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ResponseSelect2Model> Gcode_Select2_Get(GcodeModel GcodeModel)
        {

            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", GcodeModel.code);
                objParam.Add("@gname", GcodeModel.gname);
                objParam.Add("@codechr", GcodeModel.codechr);
                objParam.Add("@ctype", GcodeModel.ctype);

                Connection();
                VSK_Data.Open();
                List<ResponseSelect2Model> RequestModelList = SqlMapper.Query<ResponseSelect2Model>(VSK_Data, "SP_Gcode_Select2_Get", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<StockStatusHistoryModel> StockStatus_Get(string item_code)
        {
            try
            {
                string SQLQuery = "SELECT * FROM dbo.itmi_stockstatus_history WHERE product_code = '" + item_code + "' ORDER BY review_date DESC";

                Connection();
                VSK_Data.Open();
                List<StockStatusHistoryModel> RequestModelList = VSK_Data.Query<StockStatusHistoryModel>(SQLQuery, commandTimeout: 600).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<vGRMinDateModel> vGRMinDate_Get(string item_code)
        {
            try
            {
                string SQLQuery = "SELECT TOP 1 * FROM dbo.View_GR_MinDate WHERE stkcod = '" + item_code + "'";

                Connection();
                VSK_Data.Open();
                List<vGRMinDateModel> RequestModelList = VSK_Data.Query<vGRMinDateModel>(SQLQuery, commandTimeout: 600).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<vGRMaxDateModel> vGRMaxDate_Get(string item_code)
        {
            try
            {
                string SQLQuery = "SELECT TOP 1 * FROM dbo.View_GR_MaxDate WHERE stkcod = '" + item_code + "'";

                Connection();
                VSK_Data.Open();
                List<vGRMaxDateModel> RequestModelList = VSK_Data.Query<vGRMaxDateModel>(SQLQuery, commandTimeout: 600).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<GoodPriceModel> GoodPrice_Get(string item_code)
        {
            try
            {
                string SQLQuery = "SELECT RTRIM(gunit) as gunit" +
                    ",prqty" +
                    ",qtysmall" +
                    ",gprice" +
                    ",gpriceA" +
                    ",gpriceB" +
                    ",gpriceC" +
                    ",gpriceD" +
                    ",gpriceE" +
                    ",gpriceF" +
                    ",RTRIM(goutput) as goutput" +
                    ",gpricepur" +
                    " FROM dbo.goodprice WHERE code = '" + item_code + "'" +
                    " ORDER BY qtysmall ASC";

                Connection();
                VSK_Data.Open();
                List<GoodPriceModel> RequestModelList = VSK_Data.Query<GoodPriceModel>(SQLQuery, commandTimeout: 600).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<vGRDateModel> GRDate_Get(string item_code)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@item_code", item_code);

                Connection();
                VSK_Data.Open();
                List<vGRDateModel> RequestModelList = SqlMapper.Query<vGRDateModel>(VSK_Data, "SP_ItemMaster_GRDate_Get", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Product_ReplenishPlan_Stock_Factor_KLH_Model> Product_ReplenishPlan_Stock_Factor_KLH_Get_V1(string item_code)
        {
            try
            {

                string SQLQuery = "SELECT TOP 1 * FROM View_Product_ReplenishPlan_Stock_Factor_web WHERE code = '" + item_code + "'";

                Connection();
                VorwinsKLH.Open();
                List<Product_ReplenishPlan_Stock_Factor_KLH_Model> RequestModelList = VorwinsKLH.Query<Product_ReplenishPlan_Stock_Factor_KLH_Model>(SQLQuery, commandTimeout: 600).ToList();
                VorwinsKLH.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<Select2Model> ItemMaster_Select2_Get(string lov_type, string search)
        {
            try
            {
                string SQLQuery = "SELECT RTRIM(lov_code) as id" +
                    ", RTRIM(lov1) as text " +
                    "FROM dbo.lov_data " +
                    "WHERE lov_group='VSK_PUR' AND lov_type='" + lov_type +"'" +
                    "AND  lov1 LIKE '%" + search + "%'" +
                    "ORDER BY lov_code ASC";
                Connection();
                VSK_Data.Open();
                List<Select2Model> _ResponseData = VSK_Data.Query<Select2Model>(SQLQuery, commandTimeout: 600).ToList();
                VSK_Data.Close();
                return _ResponseData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<ItemMasterLogsModel> ItemMaster_ErrorLog_Get(string process_id)
        {
            try
            {

                string SQLQuery = "SELECT * FROM dbo.itmi_import_updatedata_logs where process_id='" + process_id + "' AND tablename='Error'";

                Connection();
                VSK_Data.Open();
                List<ItemMasterLogsModel> RequestModelList = VSK_Data.Query<ItemMasterLogsModel>(SQLQuery, commandTimeout: 600).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<ExportDimensionModel> ItemMaster_Dimension_Get(string item_code)
        {
            try
            {

                string SQLQuery = "SELECT * FROM Export_Dimension where Export_Dimension.Code='" + item_code + "' ORDER BY Export_Dimension.Date DESC LIMIT 1";

                Connection();
                MariaDBConn.Open();
                List<ExportDimensionModel> RequestModelList = MariaDBConn.Query<ExportDimensionModel>(SQLQuery, commandTimeout: 600).ToList();
                MariaDBConn.Close();
                return RequestModelList.ToList();

                //Connection();
                //MariaDBConn.Open();
                //List<DimensionExportModel> RequestModelList = SqlMapper.Query<DimensionExportModel>(MariaDBConn, "SP_EXPORT_DIMENSION", objParam, commandType: CommandType.StoredProcedure).ToList();
                //MariaDBConn.Close();
                //return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}