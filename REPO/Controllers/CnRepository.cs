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
    public class CnRepository11
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


        #region Cn_Pre_Job_Create

        public void Cn_Pre_Job_Create(CnModel CnModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@salefile_number", CnModel.salefile_number);
                objParam.Add("@salefile_invcode", CnModel.salefile_invcode);
                objParam.Add("@saletra_item_barcode", CnModel.saletra_item_barcode);
                objParam.Add("@cn_pre_job_qty", CnModel.cn_pre_job_qty);
                objParam.Add("@cn_pre_job_type", CnModel.cn_pre_job_type);
                objParam.Add("@cn_pre_job_comment", CnModel.cn_pre_job_comment);
                objParam.Add("@cn_pre_job_detail_remark", CnModel.cn_pre_job_detail_remark);
                objParam.Add("@created_by", CnModel.created_by);
                objParam.Add("@record_status", CnModel.record_status);
                objParam.Add("@pMessage", CnModel.pMessage);

                Connection();
                mscon.Open();
                mscon.Execute("SP_Cn_Pre_Job_Create", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Pre_Job_Detail_Create

        public void Cn_Pre_Job_Detail_Create(Cn_HistoryModel Cn_HistoryModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@cn_pre_job_id", Cn_HistoryModel.cn_pre_job_id);
                objParam.Add("@cn_pre_job_detail_assige", Cn_HistoryModel.cn_pre_job_detail_assige);
                objParam.Add("@cn_pre_job_detail_driver", Cn_HistoryModel.cn_pre_job_detail_driver);
                objParam.Add("@cn_pre_job_detail_status", Cn_HistoryModel.cn_pre_job_detail_status);
                objParam.Add("@cn_pre_job_detail_comment", Cn_HistoryModel.cn_pre_job_detail_comment);
                objParam.Add("@cn_pre_job_detail_item_condition", Cn_HistoryModel.cn_pre_job_detail_item_condition);
                objParam.Add("@cn_pre_job_detail_pickup_date", Cn_HistoryModel.cn_pre_job_detail_pickup_date);
                objParam.Add("@cn_pre_job_detail_remark", Cn_HistoryModel.cn_pre_job_detail_remark);
                objParam.Add("@cn_pre_job_remark_trp", Cn_HistoryModel.cn_pre_job_remark_trp);
                objParam.Add("@cn_pre_job_assige", Cn_HistoryModel.cn_pre_job_assige);
                objParam.Add("@created_by", Cn_HistoryModel.created_by);
                objParam.Add("@record_status", Cn_HistoryModel.record_status);
                objParam.Add("@pMessage", Cn_HistoryModel.pMessage);

                Connection();
                mscon.Open();
                mscon.Execute("SP_Cn_Pre_Job_Detail_Create", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Pre_Job_Get
        public List<CnModel> Cn_Pre_Job_Get(CnModel CnModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                string cn_pre_job_datetime_start = CnModel.cn_pre_job_datetime_start == DateTime.MinValue ? null : CnModel.cn_pre_job_datetime_start.ToString("yyyy-MM-dd HH:mm");
                string cn_pre_job_datetime_end = CnModel.cn_pre_job_datetime_end == DateTime.MinValue ? null : CnModel.cn_pre_job_datetime_end.ToString("yyyy-MM-dd HH:mm");


                objParam.Add("@cn_pre_job_id", CnModel.cn_pre_job_id);
                objParam.Add("@cn_pre_job_datetime_start", cn_pre_job_datetime_start);
                objParam.Add("@cn_pre_job_datetime_end", cn_pre_job_datetime_end);
                objParam.Add("@salefile_number", CnModel.salefile_number);
                objParam.Add("@salefile_invcode", CnModel.salefile_invcode);
                objParam.Add("@saletra_item_barcode", CnModel.saletra_item_barcode);
                objParam.Add("@cn_pre_job_type", CnModel.cn_pre_job_type);
                objParam.Add("@cn_pre_job_comment", CnModel.cn_pre_job_comment);
                objParam.Add("@created_by", CnModel.created_by);
                objParam.Add("@record_status", CnModel.record_status);
                objParam.Add("@Mode", CnModel.Mode);
                objParam.Add("@cn_pre_job_status", CnModel.cn_pre_job_status);
                objParam.Add("@cn_pre_job_detail_item_condition", CnModel.cn_pre_job_detail_item_condition);
                objParam.Add("@cn_pre_job_jobno", CnModel.cn_pre_job_jobno);

                Connection();
                mscon.Open();
                List<CnModel> CnVList = SqlMapper.Query<CnModel>(mscon, "SP_Cn_Pre_Job_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Pre_Job_Detail_Get
        public List<Cn_HistoryModel> Cn_Pre_Job_Detail_Get(Cn_HistoryModel Cn_HistoryModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                objParam.Add("@cn_pre_job_id", Cn_HistoryModel.cn_pre_job_id);
                objParam.Add("@record_status", Cn_HistoryModel.record_status);


                Connection();
                mscon.Open();
                List<Cn_HistoryModel> CnVList = SqlMapper.Query<Cn_HistoryModel>(mscon, "SP_Cn_Pre_Job_Detail_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region BF_Cn_On_Job_Get
        public List<CnOnjobGet> BF_Cn_On_Job_Get(CnOnjobGet CnOnjobGet)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                string cn_pre_job_datetime_start = CnOnjobGet.cn_pre_job_datetime_start == DateTime.MinValue ? null : CnOnjobGet.cn_pre_job_datetime_start.ToString("yyyy-MM-dd HH:mm");
                string cn_pre_job_datetime_end = CnOnjobGet.cn_pre_job_datetime_end == DateTime.MinValue ? null : CnOnjobGet.cn_pre_job_datetime_end.ToString("yyyy-MM-dd HH:mm");


                objParam.Add("@cn_pre_job_id", CnOnjobGet.cn_pre_job_id);
                objParam.Add("@cn_pre_job_datetime_start", cn_pre_job_datetime_start);
                objParam.Add("@cn_pre_job_datetime_end", cn_pre_job_datetime_end);
                objParam.Add("@salefile_number", CnOnjobGet.salefile_number);
                objParam.Add("@salefile_invcode", CnOnjobGet.salefile_invcode);
                objParam.Add("@saletra_item_barcode", CnOnjobGet.saletra_item_barcode);
                objParam.Add("@cn_pre_job_type", CnOnjobGet.cn_pre_job_type);
                objParam.Add("@cn_pre_job_comment", CnOnjobGet.cn_pre_job_comment);
                objParam.Add("@created_by", CnOnjobGet.created_by);
                objParam.Add("@record_status", CnOnjobGet.record_status);
                objParam.Add("@Mode", CnOnjobGet.Mode);
                objParam.Add("@cn_pre_job_status", CnOnjobGet.cn_pre_job_status);
                objParam.Add("@cn_pre_job_jobno", CnOnjobGet.cn_pre_job_jobno);

                Connection();
                mscon.Open();
                List<CnOnjobGet> CnVList = SqlMapper.Query<CnOnjobGet>(mscon, "SP_BF_Cn_On_Job_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Job_Create

        public void Cn_Job_Create(CnOnjob CnOnjob)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@cn_pre_job_id", CnOnjob.cn_pre_job_id);
                objParam.Add("@cn_on_job_assige", CnOnjob.cn_on_job_assige);
                objParam.Add("@cn_on_job_status", CnOnjob.cn_on_job_status);
                objParam.Add("@cn_pre_job_jobno", CnOnjob.cn_pre_job_jobno);
                //objParam.Add("@cn_on_job_datetime", CnOnjob.cn_on_job_datetime);
                objParam.Add("@cn_on_job_detail_remark", CnOnjob.cn_on_job_detail_remark);
                objParam.Add("@cn_on_job_type", CnOnjob.cn_on_job_type);
                objParam.Add("@cn_on_jobno", CnOnjob.cn_on_jobno);
                objParam.Add("@created_by", CnOnjob.created_by);
                objParam.Add("@record_status", CnOnjob.record_status);
                objParam.Add("@pMessage", CnOnjob.pMessage);

                Connection();
                mscon.Open();
                mscon.Execute("SP_Cn_On_Job_Create", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_On_Job_Get
        public List<CnOnjob> Cn_On_Job_Get(CnOnjob CnOnjob)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                string cn_on_job_datetime_start = CnOnjob.cn_on_job_datetime_start == DateTime.MinValue ? null : CnOnjob.cn_on_job_datetime_start.ToString("yyyy-MM-dd HH:mm");
                string cn_on_job_datetime_end = CnOnjob.cn_on_job_datetime_end == DateTime.MinValue ? null : CnOnjob.cn_on_job_datetime_end.ToString("yyyy-MM-dd HH:mm");

                objParam.Add("@cn_pre_job_id", CnOnjob.cn_pre_job_id);
                objParam.Add("@cn_on_job_datetime_start", cn_on_job_datetime_start);
                objParam.Add("@cn_on_job_datetime_end", cn_on_job_datetime_end);
                objParam.Add("@cn_on_jobno", CnOnjob.@cn_on_jobno);
                objParam.Add("@cn_on_job_assige", CnOnjob.@cn_on_job_assige);
                objParam.Add("@cn_on_job_status", CnOnjob.@cn_on_job_status);
                objParam.Add("@cn_pre_job_jobno", CnOnjob.@cn_pre_job_jobno);
                objParam.Add("@created_by", CnOnjob.@created_by);
                objParam.Add("@record_status", CnOnjob.record_status);
                objParam.Add("@Mode", CnOnjob.Mode);

                Connection();
                mscon.Open();
                List<CnOnjob> CnVList = SqlMapper.Query<CnOnjob>(mscon, "SP_Cn_On_Job_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_On_Job_Detail_Get
        public List<CnOnjob_His> Cn_On_Job_Detail_Get(CnOnjob_His CnOnjob_His)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                objParam.Add("@cn_on_job_id", CnOnjob_His.cn_on_job_id);
                objParam.Add("@record_status", CnOnjob_His.record_status);


                Connection();
                mscon.Open();
                List<CnOnjob_His> CnVList = SqlMapper.Query<CnOnjob_His>(mscon, "SP_Cn_On_Job_Detail_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Lov_Get
        public List<Cn_Lov> Cn_Lov_Get(Cn_Lov Cn_Lov)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                Connection();
                mscon.Open();
                List<Cn_Lov> CnVList = SqlMapper.Query<Cn_Lov>(mscon, "SP_Cn_Lov_Data", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_On_Job_Claim_Get
        public List<CnOnjob> Cn_On_Job_Claim_Get(CnOnjob CnOnjob)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_pre_job_id", CnOnjob.cn_pre_job_id);
                objParam.Add("@record_status", CnOnjob.record_status);
                objParam.Add("@Mode", CnOnjob.Mode);

                Connection();
                mscon.Open();
                List<CnOnjob> CnVList = SqlMapper.Query<CnOnjob>(mscon, "SP_Cn_On_Job_Claim_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_On_Job_EO_Get
        public List<CnOnjob> Cn_On_Job_EO_Get(CnOnjob CnOnjob)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_pre_job_id", CnOnjob.cn_pre_job_id);
                objParam.Add("@record_status", CnOnjob.record_status);
                objParam.Add("@Mode", CnOnjob.Mode);

                Connection();
                mscon.Open();
                List<CnOnjob> CnVList = SqlMapper.Query<CnOnjob>(mscon, "SP_Cn_On_job_EO_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_On_Job_Detail_Create

        public void Cn_On_Job_Detail_Create(CnOnjob_His CnOnjob_His)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");
                objParam.Add("@@cn_on_job_id", CnOnjob_His.cn_on_job_id);
                objParam.Add("@@cn_on_job_detail_assige", CnOnjob_His.cn_on_job_detail_assige);
                objParam.Add("@@cn_on_job_detail_status", CnOnjob_His.cn_on_job_detail_status);
                objParam.Add("@@cn_on_job_detail_remark", CnOnjob_His.cn_on_job_detail_remark);
                objParam.Add("@@cn_on_job_detail_damage", CnOnjob_His.cn_on_job_detail_damage);
                //objParam.Add("@@cn_on_job_detail_datetime", CnOnjob_His.cn_on_job_detail_datetime);
                objParam.Add("@created_by", CnOnjob_His.created_by);
                objParam.Add("@record_status", CnOnjob_His.record_status);
                objParam.Add("@pMessage", CnOnjob_His.pMessage);

                Connection();
                mscon.Open();
                mscon.Execute("SP_Cn_On_job_Detail_Create", objParam, commandType: CommandType.StoredProcedure);
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