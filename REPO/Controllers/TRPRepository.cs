using Dapper;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace REPO.Controllers
{
    public class TRPRepository : Controller
    {

       
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_TRP;
        public SqlConnection VSK_ACC;
        public SqlConnection VSK_TMS;

        private void Connection()
        {
            VSK_TRP = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_TRP"].ToString());
            VSK_ACC = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_ACC"].ToString());
            VSK_TMS = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_TMS"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//

        public void TRP_TMS_Sync_Add(List<TMS_JOBModel> TMS_JOBModel)
        {
            try
            {
                foreach (var TMS_JOBData in TMS_JOBModel)
                {
                    DynamicParameters objParam = new DynamicParameters();
                    objParam.Add("@tms_job_date", TMS_JOBData.tms_job_date);
                    objParam.Add("@tms_job_route", TMS_JOBData.tms_job_route);
                    objParam.Add("@tms_job_plate", TMS_JOBData.tms_job_plate);
                    objParam.Add("@tms_job_name", TMS_JOBData.tms_job_name);
                    objParam.Add("@tms_job_no", TMS_JOBData.tms_job_no);
                    objParam.Add("@tms_job_cus_name", TMS_JOBData.tms_job_cus_name);
                    objParam.Add("@tms_job_created_date", TMS_JOBData.tms_job_created_date);
                    objParam.Add("@tms_job_delivery_date", TMS_JOBData.tms_job_delivery_date);

                    Connection();
                    VSK_TRP.Open();
                    VSK_TRP.Execute("SP_TRP_TMS_Sync_Add", objParam, commandType: CommandType.StoredProcedure);
                    VSK_TRP.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void TRP_TMS_Sync_Delete()
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                Connection();
                VSK_TRP.Open();
                VSK_TRP.Execute("SP_TRP_TMS_Sync_Delete", objParam, commandType: CommandType.StoredProcedure);
                VSK_TRP.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<SalefileModel> TRP_Salefile_GET(string number)
        {
            try
            {
                string SQLQuery = "SELECT TOP 1 * FROM salefile WHERE number = '" + number + "' ";
                Connection();
                VSK_ACC.Open();
                List<SalefileModel> _ResponseData = VSK_ACC.Query<SalefileModel>(SQLQuery).ToList();
                VSK_ACC.Close();
                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void TRP_TMS_JOB_Add(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@tran_id", TMS_JOB_ITEMModel.tran_id);
                objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);
                objParam.Add("@job_invoice_no", TMS_JOB_ITEMModel.job_invoice_no);
                objParam.Add("@job_invoice_date", TMS_JOB_ITEMModel.job_invoice_date);
                objParam.Add("@job_pk_no", TMS_JOB_ITEMModel.job_pk_no);
                objParam.Add("@job_qty", TMS_JOB_ITEMModel.job_qty);
                objParam.Add("@invnet", TMS_JOB_ITEMModel.invnet);
                objParam.Add("@invcode", TMS_JOB_ITEMModel.invcode);
                objParam.Add("@job_delivery_name", TMS_JOB_ITEMModel.job_delivery_name);
                objParam.Add("@job_delivery_addr", TMS_JOB_ITEMModel.job_delivery_addr);
                objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
                objParam.Add("@route_name", TMS_JOB_ITEMModel.route_name);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@driver_fullname", TMS_JOB_ITEMModel.driver_fullname);
                objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);
                objParam.Add("@plate_name", TMS_JOB_ITEMModel.plate_name);
                objParam.Add("@created_by", TMS_JOB_ITEMModel.created_by);
                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_TMS_Job_Item_Add", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void TRP_TMS_JOB_Upload_Add(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_TMS_Job_Item_Upload_Add", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<TMS_JOB_EXPORTModel> TRP_TMS_JOB_EXPRESS_Add(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@tran_id", TMS_JOB_ITEMModel.tran_id);
                objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);
                objParam.Add("@job_invoice_no", TMS_JOB_ITEMModel.job_invoice_no);
                objParam.Add("@job_invoice_date", TMS_JOB_ITEMModel.job_invoice_date);
                objParam.Add("@job_pk_no", TMS_JOB_ITEMModel.job_pk_no);
                objParam.Add("@job_qty", TMS_JOB_ITEMModel.job_qty);
                objParam.Add("@invnet", TMS_JOB_ITEMModel.invnet);
                objParam.Add("@invcode", TMS_JOB_ITEMModel.invcode);
                objParam.Add("@job_delivery_name", TMS_JOB_ITEMModel.job_delivery_name);
                objParam.Add("@job_delivery_addr", TMS_JOB_ITEMModel.job_delivery_addr);
                objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
                objParam.Add("@route_name", TMS_JOB_ITEMModel.route_name);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@driver_fullname", TMS_JOB_ITEMModel.driver_fullname);
                objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);
                objParam.Add("@plate_name", TMS_JOB_ITEMModel.plate_name);
                objParam.Add("@created_by", TMS_JOB_ITEMModel.created_by);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_EXPORTModel> TRP_TMS_JOB_EXPRESS_LIST = SqlMapper.Query<TMS_JOB_EXPORTModel>(VSK_TMS, "SP_TMS_Job_Express_Item_Add", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TMS.Close();

                return TRP_TMS_JOB_EXPRESS_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<TMS_JOB_EXPORTModel> TMS_Job_Item_Get(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);
                objParam.Add("@job_invoice_no", TMS_JOB_ITEMModel.job_invoice_no);
                objParam.Add("@job_invoice_date", TMS_JOB_ITEMModel.job_invoice_date);
                objParam.Add("@job_pk_no", TMS_JOB_ITEMModel.job_pk_no);
                objParam.Add("@job_qty", TMS_JOB_ITEMModel.job_qty);
                objParam.Add("@invnet", TMS_JOB_ITEMModel.invnet);
                objParam.Add("@invcode", TMS_JOB_ITEMModel.invcode);
                objParam.Add("@job_delivery_name", TMS_JOB_ITEMModel.job_delivery_name);
                objParam.Add("@job_delivery_addr", TMS_JOB_ITEMModel.job_delivery_addr);
                objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
                objParam.Add("@route_name", TMS_JOB_ITEMModel.route_name);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@driver_fullname", TMS_JOB_ITEMModel.driver_fullname);
                objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);
                objParam.Add("@plate_name", TMS_JOB_ITEMModel.plate_name);
                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_EXPORTModel> TMS_JOB_ITEMList = SqlMapper.Query<TMS_JOB_EXPORTModel>(VSK_TMS, "SP_TMS_Job_Item_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return TMS_JOB_ITEMList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<TMS_JOB_ITEMModel> TMS_Job_Item_List(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);
                objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);
                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TMS_Job_Item_List = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_Job_Item_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return TMS_Job_Item_List.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<TMS_JOB_ITEMModel> TMS_Job_Express_Item_List(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TMS_Job_Item_List = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_Job_Express_Item_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return TMS_Job_Item_List.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<TMS_JOB_ITEMModel> TMS_Job_Route_Search(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();


               // objParam.Add("@job_start_date", TMS_JOB_ITEMModel.job_start_date == DateTime.MinValue ? null : TMS_JOB_ITEMModel.job_start_date.ToString());
               // objParam.Add("@job_end_date", TMS_JOB_ITEMModel.job_end_date == DateTime.MinValue ? null : TMS_JOB_ITEMModel.job_end_date.ToString());

                objParam.Add("@job_start_date", TMS_JOB_ITEMModel.job_start_date);
                objParam.Add("@job_end_date", TMS_JOB_ITEMModel.job_end_date);
                objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);
                objParam.Add("@mode", TMS_JOB_ITEMModel.mode);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TMS_Job_Route_Search = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_Job_Route_Search", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return TMS_Job_Route_Search.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<TMS_JOB_ITEMModel> TMS_Job_Search(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();


                //objParam.Add("@job_start_date", TMS_JOB_ITEMModel.job_start_date == DateTime.MinValue ? null : TMS_JOB_ITEMModel.job_start_date.ToString());
                //objParam.Add("@job_end_date", TMS_JOB_ITEMModel.job_end_date == DateTime.MinValue ? null : TMS_JOB_ITEMModel.job_end_date.ToString());

                objParam.Add("@job_start_date", TMS_JOB_ITEMModel.job_start_date);
                objParam.Add("@job_end_date", TMS_JOB_ITEMModel.job_end_date);
                objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);
                objParam.Add("@mode", TMS_JOB_ITEMModel.mode);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> SP_TMS_Job_Search = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_Job_Search", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return SP_TMS_Job_Search.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<TMS_JOB_ITEMModel> TMS_Job_Express_Item_Sync_Get()
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> SP_TMS_Job_Search = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_Job_Express_Item_Sync_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return SP_TMS_Job_Search.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void TMS_Job_Express_Item_Sync_Add(List<TMS_JOB_IMPORTModel> TMS_JOB_IMPORTModel)
        {
            try
            {
                foreach (var TMS_JOB_IMPORTData in TMS_JOB_IMPORTModel)
                {
                    DynamicParameters objParam = new DynamicParameters();
                    objParam.Add("@createDate", TMS_JOB_IMPORTData.createDate);
                    objParam.Add("@currentStatusDate", TMS_JOB_IMPORTData.currentStatusDate);
                    objParam.Add("@description", TMS_JOB_IMPORTData.description);
                    objParam.Add("@dimension", TMS_JOB_IMPORTData.dimension);
                    objParam.Add("@distributionCenter", TMS_JOB_IMPORTData.distributionCenter);
                    objParam.Add("@driver", TMS_JOB_IMPORTData.driver);
                    objParam.Add("@endMile", TMS_JOB_IMPORTData.endMile);
                    objParam.Add("@expDeliveryDate", TMS_JOB_IMPORTData.expDeliveryDate);
                    objParam.Add("@manifestCode", TMS_JOB_IMPORTData.manifestCode);
                    objParam.Add("@manifestType", TMS_JOB_IMPORTData.manifestType);
                    objParam.Add("@merchantName", TMS_JOB_IMPORTData.merchantName);
                    objParam.Add("@phoneNumber", TMS_JOB_IMPORTData.phoneNumber);
                    objParam.Add("@projectName", TMS_JOB_IMPORTData.projectName);
                    objParam.Add("@qty", TMS_JOB_IMPORTData.qty);
                    objParam.Add("@recipientAddress", TMS_JOB_IMPORTData.recipientAddress);
                    objParam.Add("@recipientName", TMS_JOB_IMPORTData.recipientName);
                    objParam.Add("@recipientPostalCode", TMS_JOB_IMPORTData.recipientPostalCode);
                    objParam.Add("@recipientProvince", TMS_JOB_IMPORTData.recipientProvince);
                    objParam.Add("@routeLineName", TMS_JOB_IMPORTData.routeLineName);
                    objParam.Add("@shippingDate", TMS_JOB_IMPORTData.shippingDate);
                    objParam.Add("@shippingNoteNumber", TMS_JOB_IMPORTData.shippingNoteNumber);
                    objParam.Add("@startMile", TMS_JOB_IMPORTData.startMile);
                    objParam.Add("@status", TMS_JOB_IMPORTData.status);
                    objParam.Add("@statusId", TMS_JOB_IMPORTData.statusId);
                    objParam.Add("@totalDeliveryAttempts", TMS_JOB_IMPORTData.totalDeliveryAttempts);
                    objParam.Add("@totalDistance", TMS_JOB_IMPORTData.totalDistance);
                    objParam.Add("@totalMile", TMS_JOB_IMPORTData.totalMile);
                    objParam.Add("@vehicle", TMS_JOB_IMPORTData.vehicle);
                    objParam.Add("@vehicleAddOn", TMS_JOB_IMPORTData.vehicleAddOn);
                    objParam.Add("@weight", TMS_JOB_IMPORTData.weight);

                    Connection();
                    VSK_TMS.Open();
                    VSK_TMS.Execute("SP_TMS_Job_Express_Item_Sync_Add", objParam, commandType: CommandType.StoredProcedure);
                    VSK_TMS.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void TMS_Job_Express_PPT_Sync_Add(List<TMS_JOB_IMPORTModel> TMS_JOB_IMPORTModel)
        {
            try
            {
                foreach (var TMS_JOB_IMPORTData in TMS_JOB_IMPORTModel)
                {
                    DynamicParameters objParam = new DynamicParameters();
                    objParam.Add("@createDate", TMS_JOB_IMPORTData.createDate);
                    objParam.Add("@currentStatusDate", TMS_JOB_IMPORTData.currentStatusDate);
                    objParam.Add("@description", TMS_JOB_IMPORTData.description);
                    objParam.Add("@dimension", TMS_JOB_IMPORTData.dimension);
                    objParam.Add("@distributionCenter", TMS_JOB_IMPORTData.distributionCenter);
                    objParam.Add("@driver", TMS_JOB_IMPORTData.driver);
                    objParam.Add("@endMile", TMS_JOB_IMPORTData.endMile);
                    objParam.Add("@expDeliveryDate", TMS_JOB_IMPORTData.expDeliveryDate);
                    objParam.Add("@manifestCode", TMS_JOB_IMPORTData.manifestCode);
                    objParam.Add("@manifestType", TMS_JOB_IMPORTData.manifestType);
                    objParam.Add("@merchantName", TMS_JOB_IMPORTData.merchantName);
                    objParam.Add("@phoneNumber", TMS_JOB_IMPORTData.phoneNumber);
                    objParam.Add("@projectName", TMS_JOB_IMPORTData.projectName);
                    objParam.Add("@qty", TMS_JOB_IMPORTData.qty);
                    objParam.Add("@recipientAddress", TMS_JOB_IMPORTData.recipientAddress);
                    objParam.Add("@recipientName", TMS_JOB_IMPORTData.recipientName);
                    objParam.Add("@recipientPostalCode", TMS_JOB_IMPORTData.recipientPostalCode);
                    objParam.Add("@recipientProvince", TMS_JOB_IMPORTData.recipientProvince);
                    objParam.Add("@routeLineName", TMS_JOB_IMPORTData.routeLineName);
                    objParam.Add("@shippingDate", TMS_JOB_IMPORTData.shippingDate);
                    objParam.Add("@shippingNoteNumber", TMS_JOB_IMPORTData.shippingNoteNumber);
                    objParam.Add("@startMile", TMS_JOB_IMPORTData.startMile);
                    objParam.Add("@status", TMS_JOB_IMPORTData.status);
                    objParam.Add("@statusId", TMS_JOB_IMPORTData.statusId);
                    objParam.Add("@totalDeliveryAttempts", TMS_JOB_IMPORTData.totalDeliveryAttempts);
                    objParam.Add("@totalDistance", TMS_JOB_IMPORTData.totalDistance);
                    objParam.Add("@totalMile", TMS_JOB_IMPORTData.totalMile);
                    objParam.Add("@vehicle", TMS_JOB_IMPORTData.vehicle);
                    objParam.Add("@vehicleAddOn", TMS_JOB_IMPORTData.vehicleAddOn);
                    objParam.Add("@weight", TMS_JOB_IMPORTData.weight);

                    Connection();
                    VSK_TMS.Open();
                    VSK_TMS.Execute("SP_TMS_Job_Express_PPT_Sync_Add", objParam, commandType: CommandType.StoredProcedure);
                    VSK_TMS.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<PKToTMSModel> TMS_Job_PKToTMS_Search(string job_start_date, string job_end_date, double toption,string mode)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                /*
                objParam.Add("@job_start_date", job_start_date == DateTime.MinValue ? null : job_start_date.ToString());
                objParam.Add("@job_end_date", job_end_date == DateTime.MinValue ? null : job_end_date.ToString());
                */
                objParam.Add("@job_start_date", job_start_date);
                objParam.Add("@job_end_date", job_end_date);
                objParam.Add("@toption", toption);
                objParam.Add("@mode", mode);

                Connection();
                VSK_TMS.Open();
                List<PKToTMSModel> SP_TMS_Job_Search = SqlMapper.Query<PKToTMSModel>(VSK_TMS, "SP_TMS_Job_PKToTMS_Search", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return SP_TMS_Job_Search.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}