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
    public class CnBranchRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public MySqlConnection con;
        public SqlConnection mscon;
        public SqlConnection mscon_ISS;
        public SqlConnection mscon_uat;
        public SqlConnection mscon_vsk;
        public SqlConnection mscon_cn_uat;
        public SqlConnection mscon_vsk_cn;
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

        #region Cn_Branch_Item_Get
        public List<stmas_modal> Cn_Branch_Item_Get(string branch_id, string item_master)
        {

            try
            {

                //string SQLQuery = "SELECT TOP 10 RTRIM(code) AS id, CONCAT(RTRIM(code),' / ',RTRIM(CHRCODE),' / ',RTRIM(name),' / ',RTRIM(gbarcode),' / ',RTRIM(SPCODES)) as text, AvgSalecost, UOM , name FROM dbo.stmas as stmas WHERE '" + item_master + "' != '' AND  (RTRIM(gbarcode) LIKE '%" + item_master + "%' OR RTRIM(name) LIKE '%" + item_master + "%' OR RTRIM(code) LIKE '%" + item_master + "%' OR RTRIM(SPCODES) LIKE '%" + item_master + "%')";
                string SQLQuery = "SELECT TOP 10 code, RTRIM(gbarcode) AS gbarcode, CONCAT(RTRIM(code),' - ',RTRIM(name)) as text, AvgSalecost, RTRIM(UOM) as UOM , RTRIM(name) as name, RTRIM(SPCODES) as SPCODES FROM dbo.stmas as stmas WHERE '" + item_master + "' != '' AND  (RTRIM(gbarcode) LIKE '%" + item_master + "%' OR RTRIM(name) LIKE '%" + item_master + "%' OR RTRIM(code) LIKE '%" + item_master + "%' OR RTRIM(SPCODES) LIKE '%" + item_master + "%')";

                Connection();
                List<stmas_modal> RequestModelList;

                if (branch_id == "VSK")
                {
                    mscon_vsk.Open();
                    RequestModelList = mscon_vsk.Query<stmas_modal>(SQLQuery).ToList();
                    mscon_vsk.Close();
                }
                else if (branch_id == "VSF")
                {
                    mscon_vsf.Open();
                    RequestModelList = mscon_vsf.Query<stmas_modal>(SQLQuery).ToList();
                    mscon_vsf.Close();
                }
                else if (branch_id == "KLH")
                {

                    mscon_klh.Open();
                    RequestModelList = mscon_klh.Query<stmas_modal>(SQLQuery).ToList();
                    mscon_klh.Close();

                }
                else if (branch_id == "LLK")
                {
                    mscon_llk.Open();
                    RequestModelList = mscon_llk.Query<stmas_modal>(SQLQuery).ToList();
                    mscon_llk.Close();

                }
                else if (branch_id == "NWM")
                {
                    mscon_nwm.Open();
                    RequestModelList = mscon_nwm.Query<stmas_modal>(SQLQuery).ToList();
                    mscon_nwm.Close();
                }
                else
                {
                    mscon_lks.Open();
                    RequestModelList = mscon_lks.Query<stmas_modal>(SQLQuery).ToList();
                    mscon_lks.Close();

                }

                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Cn_Branch_Emmas_Get
        public List<emmas_modal> Cn_Branch_Emmas_Get(string branch_id, string emmas)
        {

            try
            {

                string SQLQuery = "SELECT TOP 10 RTRIM(code) as code, RTRIM(lname) as lname, RTRIM(code) as id , CONCAT(RTRIM(code), ' - ', RTRIM(lname)) as text FROM emmas WHERE '" + emmas + "' != '' AND (RTRIM(code) LIKE '%" + emmas + "%' OR RTRIM(lname) LIKE '%" + emmas + "%')";

                Connection();
                List<emmas_modal> RequestModelList;

                if (branch_id == "VSK")
                {
                    mscon_vsk.Open();
                    RequestModelList = mscon_vsk.Query<emmas_modal>(SQLQuery).ToList();
                    mscon_vsk.Close();
                }
                else if (branch_id == "VSF")
                {
                    mscon_vsf.Open();
                    RequestModelList = mscon_vsf.Query<emmas_modal>(SQLQuery).ToList();
                    mscon_vsf.Close();
                }
                else if (branch_id == "KLH")
                {

                    mscon_klh.Open();
                    RequestModelList = mscon_klh.Query<emmas_modal>(SQLQuery).ToList();
                    mscon_klh.Close();

                }
                else if (branch_id == "LLK")
                {
                    mscon_llk.Open();
                    RequestModelList = mscon_llk.Query<emmas_modal>(SQLQuery).ToList();
                    mscon_llk.Close();

                }
                else if (branch_id == "NWM")
                {
                    mscon_nwm.Open();
                    RequestModelList = mscon_nwm.Query<emmas_modal>(SQLQuery).ToList();
                    mscon_nwm.Close();
                }
                else
                {
                    mscon_lks.Open();
                    RequestModelList = mscon_lks.Query<emmas_modal>(SQLQuery).ToList();
                    mscon_lks.Close();

                }

                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Cn_Branch_Salefile_Get
        public List<salefile_modal> Cn_Branch_salefile_Get(string branch_id, string number)
        {

            try
            {

                string SQLQuery = "SELECT TOP 1 RTRIM(number) as number, invdate, startdate, RTRIM(invcode) as invcode , RTRIM(invname) as invname , RTRIM(item) as item FROM [dbo].[salefile] as saletra WHERE saletra.number = '" + number + "'";

                Connection();
                List<salefile_modal> RequestModelList;

                if (branch_id == "VSK")
                {
                    mscon_vsk.Open();
                    RequestModelList = mscon_vsk.Query<salefile_modal>(SQLQuery).ToList();
                    mscon_vsk.Close();
                }
                else if (branch_id == "VSF")
                {
                    mscon_vsf.Open();
                    RequestModelList = mscon_vsf.Query<salefile_modal>(SQLQuery).ToList();
                    mscon_vsf.Close();
                }
                else if (branch_id == "KLH")
                {

                    mscon_klh.Open();
                    RequestModelList = mscon_klh.Query<salefile_modal>(SQLQuery).ToList();
                    mscon_klh.Close();

                }
                else if (branch_id == "LLK")
                {
                    mscon_llk.Open();
                    RequestModelList = mscon_llk.Query<salefile_modal>(SQLQuery).ToList();
                    mscon_llk.Close();

                }
                else if (branch_id == "NWM")
                {
                    mscon_nwm.Open();
                    RequestModelList = mscon_nwm.Query<salefile_modal>(SQLQuery).ToList();
                    mscon_nwm.Close();
                }
                else
                {
                    mscon_lks.Open();
                    RequestModelList = mscon_lks.Query<salefile_modal>(SQLQuery).ToList();
                    mscon_lks.Close();

                }

                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Cn_Branch_Saletra_Get
        public List<saletra_modal> Cn_Branch_saletra_Get(string branch_id, string number)
        {

            try
            {

                string SQLQuery = "SELECT number, stkcod, stkname, gbarcode, stkunit, spcodes, stktype, empcod, empname, trnqty, startdate, whdiscode  FROM [dbo].[saletra] as saletra WHERE saletra.number = '" + number + "'";

                Connection();
                List<saletra_modal> RequestModelList;

                if (branch_id == "VSK")
                {
                    mscon_vsk.Open();
                    RequestModelList = mscon_vsk.Query<saletra_modal>(SQLQuery).ToList();
                    mscon_vsk.Close();
                }
                else if (branch_id == "VSF")
                {
                    mscon_vsf.Open();
                    RequestModelList = mscon_vsf.Query<saletra_modal>(SQLQuery).ToList();
                    mscon_vsf.Close();
                }
                else if (branch_id == "KLH")
                {

                    mscon_klh.Open();
                    RequestModelList = mscon_klh.Query<saletra_modal>(SQLQuery).ToList();
                    mscon_klh.Close();

                }
                else if (branch_id == "LLK")
                {
                    mscon_llk.Open();
                    RequestModelList = mscon_llk.Query<saletra_modal>(SQLQuery).ToList();
                    mscon_llk.Close();

                }
                else if (branch_id == "NWM")
                {
                    mscon_nwm.Open();
                    RequestModelList = mscon_nwm.Query<saletra_modal>(SQLQuery).ToList();
                    mscon_nwm.Close();
                }
                else
                {
                    mscon_lks.Open();
                    RequestModelList = mscon_lks.Query<saletra_modal>(SQLQuery).ToList();
                    mscon_lks.Close();

                }

                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Cn_Branch_Pre_Job_Create
        public void Cn_Branch_Pre_Job_Create(CnBranchModel CnBranchModel)
        {
            try

            {
                DynamicParameters objParam = new DynamicParameters();

                string salefile_datetime = CnBranchModel.salefile_datetime == DateTime.MinValue ? null : CnBranchModel.salefile_datetime.ToString("yyyy-MM-dd HH:mm");

                objParam.Add("@cn_pre_job_branch", CnBranchModel.cn_pre_job_branch);
                objParam.Add("@salefile_number", CnBranchModel.salefile_number);
                objParam.Add("@salefile_invcode", CnBranchModel.salefile_invcode);
                objParam.Add("@salefile_datetime", salefile_datetime);
                objParam.Add("@cn_pre_job_item_barcode", CnBranchModel.cn_pre_job_item_barcode);
                objParam.Add("@cn_pre_job_item_name", CnBranchModel.cn_pre_job_item_name);
                objParam.Add("@cn_pre_job_item_spcode", CnBranchModel.cn_pre_job_item_spcode);
                objParam.Add("@cn_pre_job_qty", CnBranchModel.cn_pre_job_qty);
                objParam.Add("@cn_pre_job_type", CnBranchModel.cn_pre_job_type);
                objParam.Add("@cn_pre_job_comment", CnBranchModel.cn_pre_job_comment);
                objParam.Add("@cn_pre_job_detail_remark", CnBranchModel.cn_pre_job_detail_remark);
                objParam.Add("@created_by", CnBranchModel.created_by);
                objParam.Add("@record_status", CnBranchModel.record_status);
                objParam.Add("@pMessage", CnBranchModel.pMessage);

                Connection();
                mscon_vsk_cn.Open();
                mscon_vsk_cn.Execute("SP_CnBranch_Pre_Job_Create", objParam, commandType: CommandType.StoredProcedure);
                mscon_vsk_cn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Pre_Job_Get
        public List<CnBranchModel> Cn_Branch_Pre_Job_Get(CnBranchModel CnBranchModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_pre_job_id", CnBranchModel.cn_pre_job_id);
                objParam.Add("@cn_pre_job_datetime_start", CnBranchModel.cn_pre_job_datetime_start);
                objParam.Add("@cn_pre_job_datetime_end", CnBranchModel.cn_pre_job_datetime_end);
                objParam.Add("@salefile_number", CnBranchModel.salefile_number);
                objParam.Add("@salefile_invcode", CnBranchModel.salefile_invcode);
                objParam.Add("@cn_pre_job_branch", CnBranchModel.cn_pre_job_branch);
                objParam.Add("@cn_pre_job_item_barcode", CnBranchModel.cn_pre_job_item_barcode);
                objParam.Add("@cn_pre_job_type", CnBranchModel.cn_pre_job_type);
                objParam.Add("@cn_pre_job_comment", CnBranchModel.cn_pre_job_comment);
                objParam.Add("@created_by", CnBranchModel.created_by);
                objParam.Add("@record_status", CnBranchModel.record_status);
                objParam.Add("@Mode", CnBranchModel.Mode);
                objParam.Add("@cn_pre_job_assige", CnBranchModel.cn_pre_job_assige);
                objParam.Add("@cn_pre_job_status", CnBranchModel.cn_pre_job_status);
                objParam.Add("@cn_pre_job_detail_item_condition", CnBranchModel.cn_pre_job_detail_item_condition);
                objParam.Add("@cn_pre_job_jobno", CnBranchModel.cn_pre_job_jobno);

                Connection();
                mscon_vsk_cn.Open();
                List<CnBranchModel> CnVList = SqlMapper.Query<CnBranchModel>(mscon_vsk_cn, "SP_CnBranch_Pre_Job_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon_vsk_cn.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Lov_Get
        public List<CnBranch_Lov> Cn_Branch_Lov_Get(CnBranch_Lov CnBranch_Lov)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@lov_type", CnBranch_Lov.lov_type);

                Connection();
                mscon_vsk_cn.Open();
                List<CnBranch_Lov> CnVList = SqlMapper.Query<CnBranch_Lov>(mscon_vsk_cn, "SP_Cn_Branch_Lov_Data", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                mscon_vsk_cn.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Pre_Job_Detail_Get
        public List<CnBranch_HistoryModel> Cn_Branch_Pre_Job_Detail_Get(CnBranch_HistoryModel CnBranch_HistoryModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                objParam.Add("@cn_branch_pre_job_id", CnBranch_HistoryModel.cn_branch_pre_job_id);
                objParam.Add("@record_status", CnBranch_HistoryModel.record_status);


                Connection();
                mscon_vsk_cn.Open();
                List<CnBranch_HistoryModel> CnVList = SqlMapper.Query<CnBranch_HistoryModel>(mscon_vsk_cn, "SP_CnBranch_Pre_Job_Detail_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon_vsk_cn.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Pre_Job_Detail_Create
        public void Cn_Branch_Pre_Job_Detail_Create(CnBranch_HistoryModel CnBranch_HistoryModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@cn_branch_pre_job_id", CnBranch_HistoryModel.cn_branch_pre_job_id);
                objParam.Add("@cn_pre_job_detail_assige", CnBranch_HistoryModel.cn_pre_job_detail_assige);
                objParam.Add("@cn_pre_job_detail_driver", CnBranch_HistoryModel.cn_pre_job_detail_driver);
                objParam.Add("@cn_pre_job_detail_status", CnBranch_HistoryModel.cn_pre_job_detail_status);
                objParam.Add("@cn_pre_job_detail_comment", CnBranch_HistoryModel.cn_pre_job_detail_comment);
                objParam.Add("@cn_pre_job_detail_item_condition", CnBranch_HistoryModel.cn_pre_job_detail_item_condition);
                objParam.Add("@cn_pre_job_detail_pickup_date", CnBranch_HistoryModel.cn_pre_job_detail_pickup_date);
                objParam.Add("@cn_pre_job_detail_remark", CnBranch_HistoryModel.cn_pre_job_detail_remark);
                objParam.Add("@cn_pre_job_remark_trp", CnBranch_HistoryModel.cn_pre_job_remark_trp);
                objParam.Add("@created_by", CnBranch_HistoryModel.created_by);
                objParam.Add("@record_status", CnBranch_HistoryModel.record_status);
                objParam.Add("@pMessage", CnBranch_HistoryModel.pMessage);

                Connection();
                mscon_vsk_cn.Open();
                mscon_vsk_cn.Execute("SP_CnBranch_Pre_Job_Detail_Create", objParam, commandType: CommandType.StoredProcedure);
                mscon_vsk_cn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}