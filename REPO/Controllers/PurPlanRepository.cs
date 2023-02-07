using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using MySql.Data.MySqlClient;
using REPO.Models;

namespace REPO.Controllers
{
    public class PurPlanRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public MySqlConnection con;
        public SqlConnection mscon;

        private void Connection()
        {
            string myconstr = ConfigurationManager.ConnectionStrings["MySqlConn"].ToString();
            con = new MySqlConnection(myconstr);

            string msconstr = ConfigurationManager.ConnectionStrings["MsSqlConn"].ToString();
            mscon = new SqlConnection(msconstr);
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public List<PurPlanModel> PurPlan_Get(PurPlanModel PurPlanModel)
        {
            try
            {
                string SQLQuery = string.Empty;

                SQLQuery = "SELECT code,barcode,spcodes,itemname,CHRCODE,code1_gnamechr,MinQty,MaxQty,StockSettingProposal,Planing_Type,";
                SQLQuery += "Source_Type,PurchaseCondition,MOQ,StockingClass,OL_Ranking,InvoiceFreCode_Suggest,InvoiceFreCodeDesc_Suggest,";
                SQLQuery += "InvoiceFreCode,InvoiceFreCodeDesc,CountOfCustomersDistinct,CountOfCustomersDistinctOpt1,SumOfSalesAmount,";
                SQLQuery += "CountInvoiceAllBranch,Team,prodgroup,StockStatus,StockStatus_Kfrank,StockStatus_Suggest,ItemAged,";
                SQLQuery += "count_customer,count_invoice,ManualSafetyStockQty,LeadTimeSupplier,LeadTimeItem,CountOfCustomersDistinct_Pre12M,";
                SQLQuery += "CountOfCustomersDistinct_Pre3M,insert_date, StockStatusReviewDate,StockStatusChangeUser,RemarkByPM,Comment ";
                SQLQuery += "FROM Product_PurPlan_Stock_Factor ";
                SQLQuery += "WHERE code != '' ";

                if (PurPlanModel.code == "0" && PurPlanModel.CHRCODE == "0" && PurPlanModel.spcodes == "0" && PurPlanModel.barcode == "0")
                {
                    SQLQuery += "ORDER BY StockStatusReviewDate DESC LIMIT 0";
                }
                else {

                    if (PurPlanModel.code != null && PurPlanModel.code != "0")
                    {
                        SQLQuery += "AND code = '" + PurPlanModel.code + "' ";
                    }

                    if (PurPlanModel.CHRCODE != null && PurPlanModel.CHRCODE != "0")
                    {
                        SQLQuery += "AND CHRCODE = '" + PurPlanModel.CHRCODE + "' ";
                    }

                    if (PurPlanModel.spcodes != null && PurPlanModel.spcodes != "0")
                    {
                        SQLQuery += "AND spcodes = '" + PurPlanModel.spcodes + "' ";
                    }

                    if (PurPlanModel.barcode != null && PurPlanModel.barcode != "0")
                    {
                        SQLQuery += "AND barcode = '" + PurPlanModel.barcode + "' ";
                    }

                    SQLQuery += "ORDER BY StockStatusReviewDate DESC LIMIT 500";
                }

                Connection();
                con.Open();
                List<PurPlanModel> _ResponseData = con.Query<PurPlanModel>(SQLQuery).ToList();
                con.Close();

                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<InventoryCodeModel> InventoryCode_Get()
        {
            try
            {
                string SQLQuery = string.Empty;

                SQLQuery = "SELECT CAST(invcode as CHAR) AS invcode,insert_date ";
                SQLQuery += "FROM web_purplan_inventorycode ";

                Connection();
                con.Open();
                List<InventoryCodeModel> _ResponseData = con.Query<InventoryCodeModel>(SQLQuery).ToList();
                con.Close();

                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<InvfreCodeModel> InvfreCode_Get()
        {
            try
            {
                string SQLQuery = string.Empty;

                SQLQuery = "SELECT CAST(invfrecode as CHAR) AS invfrecode ,movements,period,description,customerminimum,CAST(invcode as CHAR) AS invcode,insert_date ";
                SQLQuery += "FROM web_purplan_invfrecode ";

                Connection();
                con.Open();
                List<InvfreCodeModel> _ResponseData = con.Query<InvfreCodeModel>(SQLQuery).ToList();
                con.Close();

                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public List<PurPlanModel> Product_PurPlan_Stock_Factor_Get(string item_code)
        //{
        //    try
        //    {
        //        string SQLQuery = string.Empty;

        //        SQLQuery = "SELECT code, barcode, spcodes, itemname, StockStatus, InvoiceFreCode, InvoiceFreCodeDesc ";
        //        SQLQuery += "FROM dbo.Product_PurPlan_Stock_Factor$ ";
        //        SQLQuery += "WHERE code ='" + item_code + "'";

        //        Connection();
        //        mscon.Open();
        //        List<PurPlanModel> _ResponseData = mscon.Query<PurPlanModel>(SQLQuery).ToList();
        //        mscon.Close();

        //        return _ResponseData.ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void ChangeStockStatus_Update(string chk_stockstatus, string chk_invfrecode, string invcode, string invfrecode, DateTime date_mod, string fname, string item_code, PurPlanModel PurPlanModel)
        //{
        //    try
        //    {
        //        if (chk_stockstatus != invcode)
        //        {

        //            string update_changestockstatus = string.Empty;

        //            update_changestockstatus = "UPDATE Product_PurPlan_Stock_Factor SET ";
        //            update_changestockstatus += "StockStatusReviewDate = '" + date_mod + "', ";
        //            update_changestockstatus += "StockStatusChangeUser = '" + fname + "' ";
        //            update_changestockstatus += "WHERE code ='" + item_code + "'";

        //            Connection();
        //            con.Open();
        //            con.Query(update_changestockstatus);
        //            con.Close();

        //            string update_inv = string.Empty;

        //            update_inv = "UPDATE dbo.Product_PurPlan_Stock_Factor$ SET ";
        //            update_inv += "StockStatusReviewDate = '" + date_mod + "', ";
        //            update_inv += "StockStatusChangeUser = '" + fname + "' ";
        //            update_inv += "WHERE code ='" + item_code + "'";

        //            Connection();
        //            mscon.Open();
        //            mscon.Query(update_inv);
        //            mscon.Close();

        //            string comment_log2 = string.Empty;
        //            comment_log2 = fname + " change stockstatus " + item_code + " from " +  chk_stockstatus + " to " + invcode;

        //            string insert_log2 = string.Empty;
        //            insert_log2 = "INSERT INTO logs(timestamp, name, comment) VALUES('" + date_mod + "','"+ fname + "','" + comment_log2 + "')";

        //            Connection();
        //            con.Open();
        //            con.Query(insert_log2);
        //            con.Close();

        //        }

        //        if (chk_invfrecode != invfrecode)
        //        {

        //            string comment_log3 = fname + " change stockstatus " + item_code + " from " + chk_invfrecode + " to " + invfrecode;

        //            string insert_log3 = string.Empty;

        //            insert_log3 = "INSERT INTO logs(timestamp, name, comment) VALUES('" + date_mod + "','" + fname + "','" + comment_log3 + "')";

        //        }

        //        string mssql_update_inv = string.Empty;

        //        mssql_update_inv = "update dbo.Product_PurPlan_Stock_Factor$ set Planing_Type='"+ PurPlanModel.Planing_Type + "', Source_Type='" + PurPlanModel.Source_Type + "', ";
        //        mssql_update_inv += "StockStatus='" + PurPlanModel.invcode + "', PurchaseCondition='" + PurPlanModel.PurchaseCondition + "', [MinQty(E)Constant]='" + PurPlanModel.MinQty + "', [MaxQty(D)Constant]=?, ";
        //        mssql_update_inv += "MOQ=?, StockingClass=?, OL_Ranking=?, StockSettingProposal=?, ManualSafetyStockQty=?, ";
        //        mssql_update_inv += "LeadTimeItem=?, LeadTimeSupplier=?, InvoiceFreCode=?, InvoiceFreCodeDesc=?, Comment=? where code=?";

        //        Connection();
        //        mscon.Open();
        //        mscon.Query(mssql_update_inv);
        //        mscon.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

    }
}