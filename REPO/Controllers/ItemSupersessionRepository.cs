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
    public class ItemSupersessionRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public MySqlConnection con;
        public SqlConnection mscon;
        public SqlConnection mscon_ISS;
        public SqlConnection mscon_vsk;
        public SqlConnection mscon_uat;
        public SqlConnection mscon_vsf;
        public SqlConnection mscon_klh;
        public SqlConnection mscon_lks;
        public SqlConnection mscon_llk;
        public SqlConnection mscon_nwm;

        private void Connection()
        {
            //string myconstr = ConfigurationManager.ConnectionStrings["MySqlConn"].ToString();
            //con = new MySqlConnection(myconstr);

            //string msconstr = ConfigurationManager.ConnectionStrings["MsSqlConn"].ToString();
            //mscon = new SqlConnection(msconstr);

            //string msconvskcnstr = ConfigurationManager.ConnectionStrings["VSK_CN"].ToString();

            string msconisscnstr = ConfigurationManager.ConnectionStrings["VSK_ISS"].ToString();
            mscon_ISS = new SqlConnection(msconisscnstr);

            string msconvskcnstr = ConfigurationManager.ConnectionStrings["VSK_UAT"].ToString();
            mscon_uat = new SqlConnection(msconvskcnstr);

            string msconvskstr = ConfigurationManager.ConnectionStrings["VSK_VSK"].ToString();
            mscon_vsk = new SqlConnection(msconvskstr);

            string msconvsfstr = ConfigurationManager.ConnectionStrings["VSK_VSF"].ToString();
            mscon_vsf = new SqlConnection(msconvsfstr);

            string msconklhstr = ConfigurationManager.ConnectionStrings["VSK_KLH"].ToString();
            mscon_klh = new SqlConnection(msconklhstr);

            string msconlksstr = ConfigurationManager.ConnectionStrings["VSK_LKS"].ToString();
            mscon_lks = new SqlConnection(msconlksstr);

            string msconllkstr = ConfigurationManager.ConnectionStrings["VSK_LLK"].ToString();
            mscon_llk = new SqlConnection(msconllkstr);

            string msconnwmstr = ConfigurationManager.ConnectionStrings["VSK_NWM"].ToString();
            mscon_nwm = new SqlConnection(msconllkstr);

        }

        //-------------------End Connection_SQL ------------------------//
        #endregion

        #region Item_SS_Item_Get
        public List<ItemSS_stmas_modal> Item_SS_Item_Get(string item_master)
        {

            try
            {

                //string SQLQuery = "SELECT TOP 10 RTRIM(code) AS id, CONCAT(RTRIM(code),' / ',RTRIM(CHRCODE),' / ',RTRIM(name),' / ',RTRIM(gbarcode),' / ',RTRIM(SPCODES)) as text, AvgSalecost, UOM , name FROM dbo.stmas as stmas WHERE '" + item_master + "' != '' AND  (RTRIM(gbarcode) LIKE '%" + item_master + "%' OR RTRIM(name) LIKE '%" + item_master + "%' OR RTRIM(code) LIKE '%" + item_master + "%' OR RTRIM(SPCODES) LIKE '%" + item_master + "%')";
                string SQLQuery = "SELECT TOP 10 code, RTRIM(gbarcode) AS gbarcode, CONCAT(RTRIM(code),' - ',RTRIM(name)) as text, AvgSalecost, RTRIM(UOM) as UOM , RTRIM(name) as name, RTRIM(SPCODES) as SPCODES, RTRIM(TYPE) as type FROM dbo.stmas as stmas WHERE '" + item_master + "' != '' AND  (RTRIM(gbarcode) LIKE '%" + item_master + "%' OR RTRIM(name) LIKE '%" + item_master + "%' OR RTRIM(code) LIKE '%" + item_master + "%' OR RTRIM(SPCODES) LIKE '%" + item_master + "%')";

                Connection();
                List<ItemSS_stmas_modal> RequestModelList;

                mscon_vsk.Open();
                RequestModelList = mscon_vsk.Query<ItemSS_stmas_modal>(SQLQuery).ToList();
                mscon_vsk.Close();

                //if (branch_id == "VSK")
                //{
                //    mscon_vsk.Open();
                //    RequestModelList = mscon_vsk.Query<ItemSS_stmas_modal>(SQLQuery).ToList();
                //    mscon_vsk.Close();
                //}
                //else if (branch_id == "VSF")
                //{
                //    mscon_vsf.Open();
                //    RequestModelList = mscon_vsf.Query<ItemSS_stmas_modal>(SQLQuery).ToList();
                //    mscon_vsf.Close();
                //}
                //else if (branch_id == "KLH")
                //{

                //    mscon_klh.Open();
                //    RequestModelList = mscon_klh.Query<ItemSS_stmas_modal>(SQLQuery).ToList();
                //    mscon_klh.Close();

                //}
                //else if (branch_id == "LLK")
                //{
                //    mscon_llk.Open();
                //    RequestModelList = mscon_llk.Query<ItemSS_stmas_modal>(SQLQuery).ToList();
                //    mscon_llk.Close();

                //}
                //else if (branch_id == "NWM")
                //{
                //    mscon_nwm.Open();
                //    RequestModelList = mscon_nwm.Query<ItemSS_stmas_modal>(SQLQuery).ToList();
                //    mscon_nwm.Close();
                //}
                //else
                //{
                //    mscon_lks.Open();
                //    RequestModelList = mscon_lks.Query<ItemSS_stmas_modal>(SQLQuery).ToList();
                //    mscon_lks.Close();

                //}

                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Item_SS_Deatil_Get
        public List<ItemSS_Modal> Item_SS_Deatil_Get(ItemSS_search_Modal ItemSS_search_Modal)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                objParam.Add("@sku", ItemSS_search_Modal.sku);
                objParam.Add("@ss_sku", ItemSS_search_Modal.ss_sku);
                objParam.Add("@gbarcode", ItemSS_search_Modal.gbarcode);
                objParam.Add("@name", ItemSS_search_Modal.name);
                objParam.Add("@record_status", ItemSS_search_Modal.record_status);
                objParam.Add("@record_id", ItemSS_search_Modal.record_id);
                objParam.Add("@is_itemsupersession", ItemSS_search_Modal.is_itemsupersession);
                objParam.Add("@mode", ItemSS_search_Modal.mode);


                Connection();
                mscon_ISS.Open();
                List<ItemSS_Modal> ISSList = SqlMapper.Query<ItemSS_Modal>(mscon_ISS, "SP_ItemSupersession_Detail_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon_ISS.Close();
                return ISSList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Item_SS_Head_Get
        public List<ItemSS_Modal> Item_SS_Head_Get(ItemSS_search_Modal ItemSS_search_Modal)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                objParam.Add("@sku", ItemSS_search_Modal.sku);
                objParam.Add("@ss_sku", ItemSS_search_Modal.ss_sku);
                objParam.Add("@mode", ItemSS_search_Modal.mode);


                Connection();
                mscon_ISS.Open();
                List<ItemSS_Modal> ISSList = SqlMapper.Query<ItemSS_Modal>(mscon_ISS, "SP_ItemSupersession_Head_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon_ISS.Close();
                return ISSList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Item_SS_Head_Item_Get
        public List<ItemSS_stmas_modal> Item_SS_Head_Item_Get(string item_master)
        {

            try
            {

                //string SQLQuery = "SELECT TOP 10 RTRIM(code) AS id, CONCAT(RTRIM(code),' / ',RTRIM(CHRCODE),' / ',RTRIM(name),' / ',RTRIM(gbarcode),' / ',RTRIM(SPCODES)) as text, AvgSalecost, UOM , name FROM dbo.stmas as stmas WHERE '" + item_master + "' != '' AND  (RTRIM(gbarcode) LIKE '%" + item_master + "%' OR RTRIM(name) LIKE '%" + item_master + "%' OR RTRIM(code) LIKE '%" + item_master + "%' OR RTRIM(SPCODES) LIKE '%" + item_master + "%')";
                string SQLQuery = "SELECT TOP 10 sku as code, record_id, supersession_id, RTRIM(gbarcode) AS gbarcode, CONCAT(RTRIM(sku),' - ',RTRIM(name)) as text , RTRIM(name) as name, RTRIM(spcode) as SPCODES, RTRIM(type) as type FROM dbo.Tbl_SuperSession_Head as stmas WHERE record_status = '1' AND '" + item_master + "' != '' AND  (RTRIM(gbarcode) LIKE '%" + item_master + "%' OR RTRIM(name) LIKE '%" + item_master + "%' OR RTRIM(sku) LIKE '%" + item_master + "%' OR RTRIM(spcode) LIKE '%" + item_master + "%')";

                Connection();
                List<ItemSS_stmas_modal> RequestModelList;

                mscon_ISS.Open();
                RequestModelList = mscon_ISS.Query<ItemSS_stmas_modal>(SQLQuery).ToList();
                mscon_ISS.Close();

                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Item_SS_Create
        public List<ItemSS_Modal> Item_SS_Create(ItemSS_Modal ItemSS_Modal)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                objParam.Add("@sku", ItemSS_Modal.sku);
                objParam.Add("@ss_sku", ItemSS_Modal.ss_sku);
                objParam.Add("@gbarcode", ItemSS_Modal.gbarcode);
                objParam.Add("@spcode", ItemSS_Modal.spcode);
                objParam.Add("@name", ItemSS_Modal.name);
                objParam.Add("@type", ItemSS_Modal.type);
                objParam.Add("@remark", ItemSS_Modal.remark);
                objParam.Add("@is_itemsupersession", ItemSS_Modal.is_itemsupersession);
                objParam.Add("@replace_itemsupersession", ItemSS_Modal.replace_itemsupersession);
                objParam.Add("@created_by", ItemSS_Modal.created_by);
                objParam.Add("@record_status", ItemSS_Modal.record_status);
                objParam.Add("@record_id", ItemSS_Modal.record_id);
                //objParam.Add("@supersession_id", ItemSS_Modal.supersession_id);
                objParam.Add("@pMessage", ItemSS_Modal.pMessage);


                Connection();
                mscon_ISS.Open();
                List<ItemSS_Modal> ISSList = SqlMapper.Query<ItemSS_Modal>(mscon_ISS, "SP_Itemsupersession_Create", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon_ISS.Close();
                return ISSList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Item_SS_Detail_Create
        public List<ItemSS_Modal> Item_SS_Detail_Create(ItemSS_Modal ItemSS_Modal)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                objParam.Add("@sku", ItemSS_Modal.sku);
                objParam.Add("@ss_sku", ItemSS_Modal.ss_sku);
                objParam.Add("@gbarcode", ItemSS_Modal.gbarcode);
                objParam.Add("@spcode", ItemSS_Modal.spcode);
                objParam.Add("@name", ItemSS_Modal.name);
                objParam.Add("@type", ItemSS_Modal.type);
                objParam.Add("@remark", ItemSS_Modal.remark);
                objParam.Add("@is_itemsupersession", ItemSS_Modal.is_itemsupersession);
                objParam.Add("@replace_itemsupersession", ItemSS_Modal.replace_itemsupersession);
                objParam.Add("@created_by", ItemSS_Modal.created_by);
                objParam.Add("@record_status", ItemSS_Modal.record_status);
                objParam.Add("@record_id", ItemSS_Modal.record_id);
                objParam.Add("@pMessage", ItemSS_Modal.pMessage);


                Connection();
                mscon_ISS.Open();
                List<ItemSS_Modal> ISSList = SqlMapper.Query<ItemSS_Modal>(mscon_ISS, "SP_Itemsupersession_Detail_Create", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon_ISS.Close();
                return ISSList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Item_SS_Update
        public List<ItemSS_Modal> Item_SS_Update(ItemSS_Modal ItemSS_Modal)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                objParam.Add("@sku", ItemSS_Modal.sku);
                objParam.Add("@ss_sku", ItemSS_Modal.ss_sku);
                objParam.Add("@gbarcode", ItemSS_Modal.gbarcode);
                objParam.Add("@spcode", ItemSS_Modal.spcode);
                objParam.Add("@name", ItemSS_Modal.name);
                objParam.Add("@type", ItemSS_Modal.type);
                objParam.Add("@remark", ItemSS_Modal.remark);
                objParam.Add("@is_itemsupersession", ItemSS_Modal.is_itemsupersession);
                objParam.Add("@replace_itemsupersession", ItemSS_Modal.replace_itemsupersession);
                objParam.Add("@created_by", ItemSS_Modal.created_by);
                objParam.Add("@record_status", ItemSS_Modal.record_status);


                Connection();
                mscon_ISS.Open();
                List<ItemSS_Modal> ISSList = SqlMapper.Query<ItemSS_Modal>(mscon_ISS, "SP_Itemsupersession_Update", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon_ISS.Close();
                return ISSList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Item_History_Get
        public List<ItemSS_History_Modal> Item_History_Get(ItemSS_search_Modal ItemSS_search_Modal)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                objParam.Add("@sku", ItemSS_search_Modal.sku);
                objParam.Add("@ss_sku", ItemSS_search_Modal.ss_sku);
                objParam.Add("@gbarcode", ItemSS_search_Modal.gbarcode);
                objParam.Add("@name", ItemSS_search_Modal.name);
                objParam.Add("@record_status", ItemSS_search_Modal.record_status);
                objParam.Add("@record_id", ItemSS_search_Modal.record_id);
                objParam.Add("@is_itemsupersession", ItemSS_search_Modal.is_itemsupersession);
                objParam.Add("@mode", ItemSS_search_Modal.mode);


                Connection();
                mscon_ISS.Open();
                List<ItemSS_History_Modal> ISSList = SqlMapper.Query<ItemSS_History_Modal>(mscon_ISS, "SP_ItemSupersession_History_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon_ISS.Close();
                return ISSList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


    }
}