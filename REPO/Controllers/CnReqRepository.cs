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
    public class CnReqRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection mscon;

        private void Connection()
        {
            string msconstr = ConfigurationManager.ConnectionStrings["VSK_CN"].ToString();
            mscon = new SqlConnection(msconstr);
        }

        //-------------------End Connection_SQL ------------------------//
        #endregion


        #region Cn_Req_Saletra_Get
        public List<CnReqSaletraModel> Cn_Req_Saletra_Get(string cn_req_salefile_number)
        {

            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_salefile_number", cn_req_salefile_number);

                Connection();
                mscon.Open();
                List<CnReqSaletraModel> CnReqList = SqlMapper.Query<CnReqSaletraModel>(mscon, "SP_v2_CN_REQ_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnReqList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Cn_Req_Job_Daily_Get
        public List<CnReqModel> Cn_Req_Job_Daily_Get()
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                Connection();
                mscon.Open();
                List<CnReqModel> CnVList = SqlMapper.Query<CnReqModel>(mscon, "SP_v2_CN_REQ_DAILY_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Job_Create
        public void Cn_Req_Job_Create(CnReqModel CnReqModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_salefile_number", CnReqModel.cn_req_salefile_number);
                objParam.Add("@cn_req_salefile_stkcod", CnReqModel.cn_req_salefile_stkcod);
                objParam.Add("@cn_req_job_qty", CnReqModel.cn_req_job_qty);
                objParam.Add("@cn_req_job_cause", CnReqModel.cn_req_job_cause);
                objParam.Add("@cn_req_job_assige", CnReqModel.cn_req_job_assige);
                objParam.Add("@cn_req_job_source", CnReqModel.cn_req_job_source);
                objParam.Add("@cn_req_job_note", CnReqModel.cn_req_job_note);
                objParam.Add("@created_by", CnReqModel.created_by);
                objParam.Add("@record_status", CnReqModel.record_status);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_REQ_CREATE", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Job_Search_Get
        public List<CnReqModel> Cn_Req_Job_Search_Get(CnReqModel CnReqModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@cn_req_job_startdate", CnReqModel.cn_req_job_startdate);
                objParam.Add("@cn_req_job_enddate", CnReqModel.cn_req_job_enddate);
                objParam.Add("@cn_req_job_jobno", CnReqModel.cn_req_job_jobno);
                objParam.Add("@number", CnReqModel.number);
                objParam.Add("@invpo", CnReqModel.invpo);
                objParam.Add("@empcod", CnReqModel.empcod);
                objParam.Add("@empname", CnReqModel.empname);
                objParam.Add("@gbarcode", CnReqModel.gbarcode);
                objParam.Add("@PKuser", CnReqModel.PKuser);
                objParam.Add("@cn_req_job_cause", CnReqModel.cn_req_job_cause);
                objParam.Add("@cn_req_job_lastassige", CnReqModel.cn_req_job_lastassige);
                objParam.Add("@created_by", CnReqModel.created_by);
                objParam.Add("@saleperson", CnReqModel.saleperson);
                objParam.Add("@record_status", CnReqModel.record_status);

                Connection();
                mscon.Open();
                List<CnReqModel> CnVList = SqlMapper.Query<CnReqModel>(mscon, "SP_v2_CN_REQ_SEARCH_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Source_Update
        public void Cn_Req_Source_Update(CnReqSourceModel CnReqSourceModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqSourceModel.cn_req_job_jobno);
                objParam.Add("@cn_req_job_source", CnReqSourceModel.cn_req_job_source);
                objParam.Add("@created_by", CnReqSourceModel.created_by);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_REQ_SOURCE", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Assige_Update
        public void Cn_Req_Assige_Update(CnReqAssigeModel CnReqAssigeModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_no", CnReqAssigeModel.cn_req_job_jobno);
                objParam.Add("@cn_req_job_assige", CnReqAssigeModel.cn_req_job_assige);
                objParam.Add("@cn_req_job_note", CnReqAssigeModel.cn_req_job_note);
                objParam.Add("@created_by", CnReqAssigeModel.created_by);
                objParam.Add("@record_status", CnReqAssigeModel.record_status);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_REQ_ASSIGE", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Driver_Update
        public void Cn_Req_Driver_Update(CnReqDriverModel CnReqDriverModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_no", CnReqDriverModel.cn_req_job_jobno);
                objParam.Add("@cn_req_job_lastdriver", CnReqDriverModel.cn_req_job_lastdriver);
                objParam.Add("@cn_req_job_driver_code", CnReqDriverModel.cn_req_job_driver_code);
                objParam.Add("@cn_req_job_driver_name", CnReqDriverModel.cn_req_job_driver_name);
                objParam.Add("@cn_req_job_driver_tel", CnReqDriverModel.cn_req_job_driver_tel);
                objParam.Add("@cn_req_job_received_date", CnReqDriverModel.cn_req_job_received_date);
                objParam.Add("@cn_req_job_note", CnReqDriverModel.cn_req_job_note);
                objParam.Add("@created_by", CnReqDriverModel.created_by);
                objParam.Add("@record_status", CnReqDriverModel.record_status);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_REQ_DRIVER", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Condition_Update
        public void Cn_Req_Condition_Update(CnReqConditionModel CnReqConditionModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_no", CnReqConditionModel.cn_req_job_jobno);
                objParam.Add("@cn_req_job_item_condition", CnReqConditionModel.cn_req_job_item_condition);
                objParam.Add("@cn_req_job_note", CnReqConditionModel.cn_req_job_note);
                objParam.Add("@created_by", CnReqConditionModel.created_by);
                objParam.Add("@record_status", CnReqConditionModel.record_status);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_REQ_CONDITION", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Status_Update
        public void Cn_Req_Status_Update(CnReqStatusModel CnReqStatusModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_no", CnReqStatusModel.cn_req_job_jobno);
                objParam.Add("@cn_req_job_note", CnReqStatusModel.cn_req_job_note);
                objParam.Add("@created_by", CnReqStatusModel.created_by);
                objParam.Add("@record_status", CnReqStatusModel.record_status);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_REQ_STATUS", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Source_Get
        public List<CnReqSourceModel> Cn_Req_Source_Get(CnReqSourceModel CnReqSourceModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqSourceModel.cn_req_job_jobno);

                Connection();
                mscon.Open();
                List<CnReqSourceModel> CnVList = SqlMapper.Query<CnReqSourceModel>(mscon, "SP_v2_CN_REQ_SOURCE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Status_Get
        public List<CnReqStatusModel> Cn_Req_Status_Get(CnReqStatusModel CnReqStatusModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqStatusModel.cn_req_job_jobno);

                Connection();
                mscon.Open();
                List<CnReqStatusModel> CnVList = SqlMapper.Query<CnReqStatusModel>(mscon, "SP_v2_CN_REQ_STATUS_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Driver_Get
        public List<CnReqDriverModel> Cn_Req_Driver_Get(CnReqDriverModel CnReqDriverModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqDriverModel.cn_req_job_jobno);

                Connection();
                mscon.Open();
                List<CnReqDriverModel> CnVList = SqlMapper.Query<CnReqDriverModel>(mscon, "SP_v2_CN_REQ_DRIVER_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Condition_Get
        public List<CnReqConditionModel> Cn_Req_Condition_Get(CnReqConditionModel CnReqConditionModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqConditionModel.cn_req_job_jobno);

                Connection();
                mscon.Open();
                List<CnReqConditionModel> CnVList = SqlMapper.Query<CnReqConditionModel>(mscon, "SP_v2_CN_REQ_CONDITION_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Assige_Get
        public List<CnReqAssigeModel> Cn_Req_Assige_Get(CnReqAssigeModel CnReqAssigeModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqAssigeModel.cn_req_job_jobno);

                Connection();
                mscon.Open();
                List<CnReqAssigeModel> CnVList = SqlMapper.Query<CnReqAssigeModel>(mscon, "SP_v2_CN_REQ_ASSIGE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }

}