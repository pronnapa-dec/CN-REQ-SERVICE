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
    public class PurRepository
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


        #region PR_POD_IV_GR_bySale 
        public List<PkPoIVModel> PR_POD_IV_GR_bySale(PkPoIVModel PkPoIVModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                string col_POdate_start = PkPoIVModel.POdate_start == DateTime.MinValue ? null : PkPoIVModel.POdate_start.ToString("yyyy-MM-dd hh:mm"); 
                string col_POdate_end = PkPoIVModel.POdate_end == DateTime.MinValue ? null : PkPoIVModel.POdate_end.ToString("yyyy-MM-dd hh:mm"); 
                string col_Receive_date_est_start = PkPoIVModel.Receive_date_est_start == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est_start.ToString("yyyy-MM-dd hh:mm");
                string col_Receive_date_est_end = PkPoIVModel.Receive_date_est_end == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est_end.ToString("yyyy-MM-dd hh:mm");
                string col_GR_date_start = PkPoIVModel.GR_date_start == DateTime.MinValue ? null : PkPoIVModel.GR_date_start.ToString("yyyy-MM-dd hh:mm");
                string col_GR_date_end = PkPoIVModel.GR_date_end == DateTime.MinValue ? null : PkPoIVModel.GR_date_end.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@PO_no", PkPoIVModel.PO_no);
                objParam.Add("@item_code", PkPoIVModel.item_code);
                objParam.Add("@item_name", PkPoIVModel.item_name);
                objParam.Add("@item_spcodes", PkPoIVModel.item_spcodes);
                objParam.Add("@Sale_user", PkPoIVModel.Sale_user);
                objParam.Add("@POdate_start", col_POdate_start);
                objParam.Add("@POdate_end", col_POdate_end);
                objParam.Add("@invcustpo", PkPoIVModel.invcustpo);
                objParam.Add("@Buyer_Po_User", PkPoIVModel.Buyer_Po_User);
                objParam.Add("@receive_date_est_start", col_Receive_date_est_start);
                objParam.Add("@receive_date_est_end", col_Receive_date_est_end);
                objParam.Add("@GR_no", PkPoIVModel.GR_no);
                objParam.Add("@GR_date_start", col_GR_date_start);
                objParam.Add("@GR_date_end", col_GR_date_end);
                //objParam.Add("@stkcod", PkPoIVModel.stkcod);
                //objParam.Add("@Vendor_code", PkPoIVModel.Vendor_code);
                //objParam.Add("@Vendor_name", PkPoIVModel.Vendor_name);
                objParam.Add("@pr_receive_type", PkPoIVModel.pr_receive_type);
                objParam.Add("@PO_type", PkPoIVModel.PO_type);
                objParam.Add("@StockStatus", PkPoIVModel.StockStatus);
                objParam.Add("@PO_Panding", PkPoIVModel.PO_Panding);
                objParam.Add("@Vendor_code", PkPoIVModel.Vendor_code);
                objParam.Add("@Vendor_name", PkPoIVModel.Vendor_name);
                objParam.Add("@Mode", PkPoIVModel.Mode);
                objParam.Add("@gbarcode", PkPoIVModel.gbarcode);
               
                Connection();
                mscon.Open();
                List<PkPoIVModel> PkPoIVList = SqlMapper.Query<PkPoIVModel>(mscon, "SP_PR_POD_IV_GR_bySale_v2", objParam, commandTimeout: 210 , commandType: CommandType.StoredProcedure).ToList();
 
                mscon.Close();
                return PkPoIVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region PR_POD_IV_GR_bySale 
        public List<PkPoIVModel> PK_PO_IV_bySale_Get(PkPoIVModel PkPoIVModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                string col_POdate_start = PkPoIVModel.POdate_start == DateTime.MinValue ? null : PkPoIVModel.POdate_start.ToString("yyyy-MM-dd hh:mm");
                string col_POdate_end = PkPoIVModel.POdate_end == DateTime.MinValue ? null : PkPoIVModel.POdate_end.ToString("yyyy-MM-dd hh:mm");
                string col_Receive_date_est_start = PkPoIVModel.Receive_date_est_start == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est_start.ToString("yyyy-MM-dd hh:mm");
                string col_Receive_date_est_end = PkPoIVModel.Receive_date_est_end == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est_end.ToString("yyyy-MM-dd hh:mm");
                string col_GR_date_start = PkPoIVModel.GR_date_start == DateTime.MinValue ? null : PkPoIVModel.GR_date_start.ToString("yyyy-MM-dd hh:mm");
                string col_GR_date_end = PkPoIVModel.GR_date_end == DateTime.MinValue ? null : PkPoIVModel.GR_date_end.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@PO_no", PkPoIVModel.PO_no);
                objParam.Add("@item_code", PkPoIVModel.item_code);
                objParam.Add("@item_name", PkPoIVModel.item_name);
                objParam.Add("@item_spcodes", PkPoIVModel.item_spcodes);
                objParam.Add("@Sale_user", PkPoIVModel.Sale_user);
                objParam.Add("@POdate_start", col_POdate_start);
                objParam.Add("@POdate_end", col_POdate_end);
                objParam.Add("@invcustpo", PkPoIVModel.invcustpo);
                objParam.Add("@Buyer_Po_User", PkPoIVModel.Buyer_Po_User);
                objParam.Add("@receive_date_est_start", col_Receive_date_est_start);
                objParam.Add("@receive_date_est_end", col_Receive_date_est_end);
                objParam.Add("@GR_no", PkPoIVModel.GR_no);
                objParam.Add("@GR_date_start", col_GR_date_start);
                objParam.Add("@GR_date_end", col_GR_date_end);
                objParam.Add("@pr_receive_type", PkPoIVModel.pr_receive_type);
                objParam.Add("@WH", PkPoIVModel.WH);
                Connection();
                mscon.Open();
                List<PkPoIVModel> PkPoIVList = SqlMapper.Query<PkPoIVModel>(mscon, "SP_PR_POE_IV_GR_bySale", objParam, commandTimeout: 180, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return PkPoIVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region PR_POD_IV_GR_bySale 

        public void PK_PO_IV_bySale_Update(PkPoIVModel PkPoIVModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@PO_no", PkPoIVModel.PO_no);
                objParam.Add("@item_code", PkPoIVModel.item_code);
                objParam.Add("@GR_no", PkPoIVModel.GR_no);
                objParam.Add("@pr_receive_type", PkPoIVModel.pr_receive_type);
                objParam.Add("@pr_receive_comment", PkPoIVModel.pr_receive_comment);
                objParam.Add("@Receive_date_est", Receive_date_est);
                objParam.Add("@created_by", PkPoIVModel.created_by);

                Connection();
                mscon.Open();
                mscon.Execute("SP_PK_PO_IV_bySale_Update", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}