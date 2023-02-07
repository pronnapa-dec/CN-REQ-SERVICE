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
    public class IVCRepository : Controller
    {


        //-------------------Start Connection_SQL ------------------------//
        //public SqlConnection VSK_TRP;
        //public SqlConnection VSK_ACC;

        public SqlConnection VSK_TMS;

        private void Connection()
        {
            //VSK_TRP = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_TRP"].ToString());
            //VSK_ACC = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_ACC"].ToString());
            VSK_TMS = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_TMS"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//


        #region Zone_Get
        public List<Zone_Model> Zone_Get(Zone_Model Zone_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                //objParam.Add("@cn_pre_job_id", Cn_HistoryModel.cn_pre_job_id);
                objParam.Add("@record_status", Zone_Model.record_status);
                objParam.Add("@mode", Zone_Model.mode);


                Connection();
                VSK_TMS.Open();
                List<Zone_Model> CnVList = SqlMapper.Query<Zone_Model>(VSK_TMS, "SP_Zone_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Route_Get
        public List<Zone_Model> Route_Get(Zone_Model Zone_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                //objParam.Add("@cn_pre_job_id", Cn_HistoryModel.cn_pre_job_id);
                objParam.Add("@zone_id", Zone_Model.parent_lov_id);
                objParam.Add("@lov_id", Zone_Model.lov_id);


                Connection();
                VSK_TMS.Open();
                List<Zone_Model> CnVList = SqlMapper.Query<Zone_Model>(VSK_TMS, "SP_Route_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Delivery_Zone_Add
        public void Create_Delivery_Zone(Devilery_Zone_Model Devilery_Zone)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");


                objParam.Add("@lov_zone_code", Devilery_Zone.lov_zone_code);
                objParam.Add("@lov_route_code", Devilery_Zone.lov_route_code);
                objParam.Add("@name", Devilery_Zone.name);
                objParam.Add("@opening", Devilery_Zone.opening);
                objParam.Add("@closetime", Devilery_Zone.closetime);
                objParam.Add("@note", Devilery_Zone.note);
                objParam.Add("@record_status", Devilery_Zone.record_status);
                objParam.Add("@created_by", Devilery_Zone.created_by);
                objParam.Add("@pMessage", Devilery_Zone.pMessage);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Devilery_Zone_Add", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Delivery_Zone_Get
        public List<Devilery_Zone_Model> Delivery_Zone_Get(Devilery_Zone_Model Devilery_Zone_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@id", Devilery_Zone_Model.id);
                objParam.Add("@lov_zone_code", Devilery_Zone_Model.lov_zone_code);
                objParam.Add("@lov_route_code", Devilery_Zone_Model.lov_route_code);
                objParam.Add("@name", Devilery_Zone_Model.name);
                objParam.Add("@record_status", Devilery_Zone_Model.record_status);
                objParam.Add("@mode", Devilery_Zone_Model.mode);


                Connection();
                VSK_TMS.Open();
                List<Devilery_Zone_Model> CnVList = SqlMapper.Query<Devilery_Zone_Model>(VSK_TMS, "SP_Devilery_Zone_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Delivery_Zone_Update
        public void Delivery_Zone_Update(Devilery_Zone_Model Devilery_Zone)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@id", Devilery_Zone.id);
                objParam.Add("@lov_zone_code", Devilery_Zone.lov_zone_code);
                objParam.Add("@lov_route_code", Devilery_Zone.lov_route_code);
                objParam.Add("@name", Devilery_Zone.name);
                objParam.Add("@opening", Devilery_Zone.opening);
                objParam.Add("@closetime", Devilery_Zone.closetime);
                objParam.Add("@note", Devilery_Zone.note);
                objParam.Add("@record_status", Devilery_Zone.record_status);
                objParam.Add("@updated_by", Devilery_Zone.updated_by);
                objParam.Add("@pMessage", Devilery_Zone.pMessage);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Devilery_Zone_Update", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Delivery_Zone_Delete
        public void Delivery_Zone_Delete(Devilery_Zone_Delete_Model Devilery_Zone_Delete_Model)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@id", Devilery_Zone_Delete_Model.id);
                objParam.Add("@record_status", Devilery_Zone_Delete_Model.record_status);
                objParam.Add("@updated_by", Devilery_Zone_Delete_Model.updated_by);
                objParam.Add("@pMessage", Devilery_Zone_Delete_Model.pMessage);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Devilery_Zone_Delete", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_Setup_Add

        public void Customer_Setup_Add(Customer_Setup_Model Customer_model)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@emmas_code", Customer_model.emmas_code);
                objParam.Add("@ecate", Customer_model.ecate);
                objParam.Add("@etran", Customer_model.etran);
                objParam.Add("@eaddress", Customer_model.eaddress);
                objParam.Add("@etumbol", Customer_model.etumbol);
                objParam.Add("@eamphur", Customer_model.eamphur);
                objParam.Add("@eprovinc", Customer_model.eprovinc);
                objParam.Add("@ezip", Customer_model.ezip);
                objParam.Add("@etel", Customer_model.etel);
                objParam.Add("@etel_ext", Customer_model.etel_ext);
                objParam.Add("@emobile", Customer_model.emobile);
                objParam.Add("@efax", Customer_model.efax);
                objParam.Add("@eemail", Customer_model.eemail);
                objParam.Add("@edefault", Customer_model.edefault);
                objParam.Add("@record_status", Customer_model.record_status);
                objParam.Add("@created_by", Customer_model.created_by);
                objParam.Add("@pMessage", Customer_model.pMessage);

                // kung เพิ่ม 3 field 2021/01/18
                objParam.Add("@location_name", Customer_model.location_name);
                objParam.Add("@route", Customer_model.route);
                objParam.Add("@subroute", Customer_model.subroute);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Customer_Setup_Add", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_Setup_Get
        public List<Customer_Setup_Model> Customer_Setup_Get(Customer_Setup_Model Customer_Setup_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@id", Customer_Setup_Model.id);
                objParam.Add("@emmas_code", Customer_Setup_Model.emmas_code);
                objParam.Add("@record_status", Customer_Setup_Model.record_status);
                objParam.Add("@Mode", Customer_Setup_Model.mode);

                Connection();
                VSK_TMS.Open();
                List<Customer_Setup_Model> CnVList = SqlMapper.Query<Customer_Setup_Model>(VSK_TMS, "SP_Customer_Setup_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_Setup_Update
        public void Customer_Setup_Update(Customer_Setup_Model Customer_model)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@id", Customer_model.id);
                objParam.Add("@emmas_code", Customer_model.emmas_code);
                objParam.Add("@ecate", Customer_model.ecate);
                objParam.Add("@etran", Customer_model.etran);
                objParam.Add("@eaddress", Customer_model.eaddress);
                objParam.Add("@etumbol", Customer_model.etumbol);
                objParam.Add("@eamphur", Customer_model.eamphur);
                objParam.Add("@eprovinc", Customer_model.eprovinc);
                objParam.Add("@ezip", Customer_model.ezip);
                objParam.Add("@etel", Customer_model.etel);
                objParam.Add("@etel_ext", Customer_model.etel_ext);
                objParam.Add("@emobile", Customer_model.emobile);
                objParam.Add("@efax", Customer_model.efax);
                objParam.Add("@eemail", Customer_model.eemail);
                objParam.Add("@edefault", Customer_model.edefault);
                objParam.Add("@record_status", Customer_model.record_status);
                objParam.Add("@updated_by", Customer_model.updated_by);
                objParam.Add("@pMessage", Customer_model.pMessage);

                // kung เพิ่ม 3 field 2021/01/18
                objParam.Add("@location_name", Customer_model.location_name);
                objParam.Add("@route", Customer_model.route);
                objParam.Add("@subroute", Customer_model.subroute);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Customer_Setup_Update", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_Setup_Delete
        public void Customer_Setup_Delete(Customer_Setup_Model Customer_Setup_Model)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@id", Customer_Setup_Model.id);
                objParam.Add("@record_status", Customer_Setup_Model.record_status);
                objParam.Add("@updated_by", Customer_Setup_Model.updated_by);
                objParam.Add("@pMessage", Customer_Setup_Model.pMessage);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Customer_Setup_Delete", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_Setup_Trp_Add
        public void Customer_Setup_Trp_Add(Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@emmas_addr_id", Customer_Setup_Trp_Model.emmas_addr_id);
                objParam.Add("@emmas_code", Customer_Setup_Trp_Model.emmas_code);
                objParam.Add("@tdefault", Customer_Setup_Trp_Model.tdefault);
                objParam.Add("@vendor_id", Customer_Setup_Trp_Model.vendor_id);
                objParam.Add("@lov_deliverycost_code", Customer_Setup_Trp_Model.lov_deliverycost_code);
                objParam.Add("@record_status", Customer_Setup_Trp_Model.record_status);
                objParam.Add("@created_by", Customer_Setup_Trp_Model.created_by);
                objParam.Add("@pMessage", Customer_Setup_Trp_Model.pMessage);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Customer_Setup_Trp_Add", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_Setup_Trp_Get
        public List<Customer_Setup_Trp_Model> Customer_Setup_Trp_Get(Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@id", Customer_Setup_Trp_Model.id);
                objParam.Add("@emmas_code", Customer_Setup_Trp_Model.emmas_code);
                objParam.Add("@vendor_id", Customer_Setup_Trp_Model.vendor_id);
                objParam.Add("@emmas_addr_id", Customer_Setup_Trp_Model.emmas_addr_id);
                objParam.Add("@lov_deliverycost_code", Customer_Setup_Trp_Model.lov_deliverycost_code);
                objParam.Add("@record_status", Customer_Setup_Trp_Model.record_status);
                objParam.Add("@Mode", Customer_Setup_Trp_Model.mode);

                Connection();
                VSK_TMS.Open();
                List<Customer_Setup_Trp_Model> CnVList = SqlMapper.Query<Customer_Setup_Trp_Model>(VSK_TMS, "SP_Customer_Setup_Trp_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_Setup_Trp_Update
        public void Customer_Setup_Trp_Update(Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@id", Customer_Setup_Trp_Model.id);
                objParam.Add("@emmas_addr_id", Customer_Setup_Trp_Model.emmas_addr_id);
                objParam.Add("@emmas_code", Customer_Setup_Trp_Model.emmas_code);
                objParam.Add("@tdefault", Customer_Setup_Trp_Model.tdefault);
                objParam.Add("@vendor_id", Customer_Setup_Trp_Model.vendor_id);
                objParam.Add("@lov_deliverycost_code", Customer_Setup_Trp_Model.lov_deliverycost_code);
                objParam.Add("@record_status", Customer_Setup_Trp_Model.record_status);
                objParam.Add("@updated_by", Customer_Setup_Trp_Model.updated_by);
                objParam.Add("@pMessage", Customer_Setup_Trp_Model.pMessage);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Customer_Setup_Trp_Update", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_Setup_Trp_Delete
        public void Customer_Setup_Trp_Delete(Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@id", Customer_Setup_Trp_Model.id);
                objParam.Add("@record_status", Customer_Setup_Trp_Model.record_status);
                objParam.Add("@updated_by", Customer_Setup_Trp_Model.updated_by);
                objParam.Add("@pMessage", Customer_Setup_Trp_Model.pMessage);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Customer_Setup_Trp_Delete", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Packing_Job_Add
        public void Packing_Job_Add(Packing_Job_Model Packing_Job_Model)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@vendor_id", Packing_Job_Model.vendor_id);
                objParam.Add("@lov_deliverycost_code", Packing_Job_Model.lov_deliverycost_code);
                objParam.Add("@@emmas_code", Packing_Job_Model.@emmas_code);
                objParam.Add("@emmas_sender_name", Packing_Job_Model.emmas_sender_name);
                objParam.Add("@emmas_addr_id", Packing_Job_Model.emmas_addr_id);
                objParam.Add("@packing_delivery_name", Packing_Job_Model.packing_delivery_name);
                objParam.Add("@packing_delivery_addr", Packing_Job_Model.packing_delivery_addr);
                objParam.Add("@packing_ref_code", Packing_Job_Model.packing_ref_code);
                objParam.Add("@salefile_number", Packing_Job_Model.salefile_number);
                objParam.Add("@salefile_name", Packing_Job_Model.salefile_name);
                objParam.Add("@salefile_invcode", Packing_Job_Model.salefile_invcode);
                objParam.Add("@salefile_invpo", Packing_Job_Model.salefile_invpo);
                objParam.Add("@salefile_userid", Packing_Job_Model.salefile_userid);
                objParam.Add("@salefile_startdate", Packing_Job_Model.salefile_startdate);
                objParam.Add("@salefile_evcode", Packing_Job_Model.salefile_evcode);
                objParam.Add("@salefile_evname", Packing_Job_Model.salefile_evname);
                objParam.Add("@salefile_evadd", Packing_Job_Model.salefile_evadd);
                objParam.Add("@salefile_tsno", Packing_Job_Model.salefile_tsno);
                objParam.Add("@salefile_item", Packing_Job_Model.salefile_item);
                objParam.Add("@record_status", Packing_Job_Model.record_status);
                objParam.Add("@created_by", Packing_Job_Model.created_by);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Packing_Job_Add", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Packing_Job_Get
        public List<Packing_Job_Model> Packing_Job_Get(Packing_Job_Model Packing_Job_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@id", Packing_Job_Model.id);
                objParam.Add("@emmas_code", Packing_Job_Model.emmas_code);
                objParam.Add("@vendor_id", Packing_Job_Model.vendor_id);
                objParam.Add("@emmas_addr_id", Packing_Job_Model.emmas_addr_id);
                objParam.Add("@packing_job_no", Packing_Job_Model.packing_job_no);
                objParam.Add("@packing_job_start_date", Packing_Job_Model.packing_job_start_date);
                objParam.Add("@packing_job_end_date", Packing_Job_Model.packing_job_end_date);
                objParam.Add("@packing_ref_code", Packing_Job_Model.packing_ref_code);
                objParam.Add("@packing_delivery_name", Packing_Job_Model.packing_delivery_name);
                objParam.Add("@mode", Packing_Job_Model.mode);
                objParam.Add("@record_status", Packing_Job_Model.record_status);
                objParam.Add("@created_by", Packing_Job_Model.created_by);
                objParam.Add("@updated_by", Packing_Job_Model.updated_by);


                Connection();
                VSK_TMS.Open();
                List<Packing_Job_Model> CnVList = SqlMapper.Query<Packing_Job_Model>(VSK_TMS, "SP_Packing_Job_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Packing_Job_Update
        public void Packing_Job_Update(Packing_Job_Update_Model Packing_Job_Update_Model)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@id", Packing_Job_Update_Model.id);
                objParam.Add("@emmas_code", Packing_Job_Update_Model.emmas_code);
                objParam.Add("@vendor_id", Packing_Job_Update_Model.vendor_id);
                objParam.Add("@lov_deliverycost_code", Packing_Job_Update_Model.lov_deliverycost_code);
                objParam.Add("@emmas_sender_name", Packing_Job_Update_Model.emmas_sender_name);
                objParam.Add("@emmas_addr_id", Packing_Job_Update_Model.emmas_addr_id);
                objParam.Add("@packing_delivery_name", Packing_Job_Update_Model.packing_delivery_name);
                objParam.Add("@packing_delivery_addr", Packing_Job_Update_Model.packing_delivery_addr);
                objParam.Add("@packing_delivery_tumbol", Packing_Job_Update_Model.packing_delivery_tumbol);
                objParam.Add("@packing_delivery_amphur", Packing_Job_Update_Model.packing_delivery_amphur);
                objParam.Add("@packing_delivery_provinc", Packing_Job_Update_Model.packing_delivery_provinc);
                objParam.Add("@packing_delivery_zip", Packing_Job_Update_Model.packing_delivery_zip);
                objParam.Add("@packing_ref_code", Packing_Job_Update_Model.packing_ref_code);
                objParam.Add("@record_status", Packing_Job_Update_Model.record_status);
                objParam.Add("@updated_by", Packing_Job_Update_Model.updated_by);

                //objParam.Add("@pMessage", Packing_Job_Model.pMessage);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Packing_Job_Update", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Packing_Job_Delete
        public void Packing_Job_Delete(Packing_Job_Delete_Model Packing_Job_Delete_Model)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@id", Packing_Job_Delete_Model.id);
                objParam.Add("@record_status", Packing_Job_Delete_Model.record_status);
                objParam.Add("@updated_by", Packing_Job_Delete_Model.updated_by);
                //objParam.Add("@pMessage", Packing_Job_Model.pMessage);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Packing_Job_Delete", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Packing_Job_Box_Get
        public List<Box_Modal> Packing_Job_Box_Get(Box_Modal Box_Modal)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@id", Box_Modal.id);
                objParam.Add("@packing_job_no", Box_Modal.packing_job_no);
                objParam.Add("@packing_job_id", Box_Modal.packing_job_id);
                objParam.Add("@record_status", Box_Modal.record_status);

                Connection();
                VSK_TMS.Open();
                List<Box_Modal> CnVList = SqlMapper.Query<Box_Modal>(VSK_TMS, "SP_Packing_Job_Box_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Packing_Job_Box_Add
        public void Packing_Job_Box_Add(Box_Modal Box_Modal)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@packing_job_id", Box_Modal.packing_job_id);
                objParam.Add("@packing_job_no", Box_Modal.packing_job_no);
                objParam.Add("@lov_packing_box", Box_Modal.lov_packing_box);
                objParam.Add("@packing_box_qty", Box_Modal.packing_box_qty);
                objParam.Add("@record_status", Box_Modal.record_status);
                objParam.Add("@created_by", Box_Modal.created_by);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Packing_Job_Box_Add", objParam, commandTimeout: 300, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Packing_Job_Chk
        public List<Packing_Job_Invoice_Model> Packing_Job_Chk(Packing_Job_Invoice_Model Packing_Job_Invoice_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", Packing_Job_Invoice_Model.mode);
                objParam.Add("@salefile_number", Packing_Job_Invoice_Model.salefile_number);
                objParam.Add("@record_status", Packing_Job_Invoice_Model.record_status);

                Connection();
                VSK_TMS.Open();
                List<Packing_Job_Invoice_Model> CnVList = SqlMapper.Query<Packing_Job_Invoice_Model>(VSK_TMS, "SP_Packing_Job_Chk", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Packing_Job_Invoice_Get
        public List<Packing_Job_Invoice_Model> Packing_Job_Invoice_Get(Packing_Job_Invoice_Model Packing_Job_Invoice_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@id", Packing_Job_Invoice_Model.id);
                objParam.Add("@packing_job_id", Packing_Job_Invoice_Model.packing_job_id);
                objParam.Add("@packing_job_no", Packing_Job_Invoice_Model.packing_job_no);
                objParam.Add("@salefile_number", Packing_Job_Invoice_Model.salefile_number);
                objParam.Add("@salefile_invcode", Packing_Job_Invoice_Model.salefile_invcode);
                objParam.Add("@record_status", Packing_Job_Invoice_Model.record_status);
                objParam.Add("@created_by", Packing_Job_Invoice_Model.created_by);
                objParam.Add("@Mode", Packing_Job_Invoice_Model.mode);

                Connection();
                VSK_TMS.Open();
                List<Packing_Job_Invoice_Model> CnVList = SqlMapper.Query<Packing_Job_Invoice_Model>(VSK_TMS, "SP_Packing_Job_Invoice_Get", objParam, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Packing_Job_List
        public List<Packing_Job_Model> Packing_Job_List(Packing_Job_Model Packing_Job_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@id", Packing_Job_Model.id);
                objParam.Add("@emmas_code", Packing_Job_Model.emmas_code);
                objParam.Add("@vendor_id", Packing_Job_Model.vendor_id);
                objParam.Add("@emmas_addr_id", Packing_Job_Model.emmas_addr_id);
                objParam.Add("@packing_job_no", Packing_Job_Model.packing_job_no);
                objParam.Add("@packing_ref_code", Packing_Job_Model.packing_ref_code);
                objParam.Add("@packing_delivery_name", Packing_Job_Model.packing_delivery_name);
                objParam.Add("@mode", Packing_Job_Model.mode);
                objParam.Add("@record_status", Packing_Job_Model.record_status);
                objParam.Add("@created_by", Packing_Job_Model.created_by);
                objParam.Add("@updated_by", Packing_Job_Model.updated_by);


                Connection();
                VSK_TMS.Open();
                List<Packing_Job_Model> CnVList = SqlMapper.Query<Packing_Job_Model>(VSK_TMS, "SP_Packing_Job_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Packing_Job_Invoice_Add 
        public void Packing_Job_Invoice_Add(Packing_Job_Invoice_Model Packing_Job_Invoice_Model)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@packing_job_id", Packing_Job_Invoice_Model.packing_job_id);
                objParam.Add("@packing_job_no", Packing_Job_Invoice_Model.packing_job_no);
                objParam.Add("@salefile_number", Packing_Job_Invoice_Model.salefile_number);
                objParam.Add("@salefile_name", Packing_Job_Invoice_Model.salefile_name);
                objParam.Add("@salefile_invcode", Packing_Job_Invoice_Model.salefile_invcode);
                objParam.Add("@salefile_invpo", Packing_Job_Invoice_Model.salefile_invpo);
                objParam.Add("@salefile_userid", Packing_Job_Invoice_Model.salefile_userid);
                objParam.Add("@salefile_startdate", Packing_Job_Invoice_Model.salefile_startdate);
                objParam.Add("@salefile_evcode", Packing_Job_Invoice_Model.salefile_evcode);
                objParam.Add("@salefile_evname", Packing_Job_Invoice_Model.salefile_evname);
                objParam.Add("@salefile_evadd", Packing_Job_Invoice_Model.salefile_evadd);
                objParam.Add("@salefile_tsno", Packing_Job_Invoice_Model.salefile_tsno);
                objParam.Add("@salefile_item", Packing_Job_Invoice_Model.salefile_item);
                objParam.Add("@record_status", Packing_Job_Invoice_Model.record_status);
                objParam.Add("@created_by", Packing_Job_Invoice_Model.created_by);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Packing_Job_Invoice_Add", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Packing_Job_Invoice_Update 
        public void Packing_Job_Invoice_Update(Packing_Job_Invoice_Model Packing_Job_Invoice_Model)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@packing_job_id", Packing_Job_Invoice_Model.packing_job_id);
                objParam.Add("@packing_job_no", Packing_Job_Invoice_Model.packing_job_no);
                objParam.Add("@salefile_number", Packing_Job_Invoice_Model.salefile_number);
                objParam.Add("@salefile_name", Packing_Job_Invoice_Model.salefile_name);
                objParam.Add("@salefile_invcode", Packing_Job_Invoice_Model.salefile_invcode);
                objParam.Add("@salefile_invpo", Packing_Job_Invoice_Model.salefile_invpo);
                objParam.Add("@salefile_userid", Packing_Job_Invoice_Model.salefile_userid);
                objParam.Add("@salefile_startdate", Packing_Job_Invoice_Model.salefile_startdate);
                objParam.Add("@salefile_evcode", Packing_Job_Invoice_Model.salefile_evcode);
                objParam.Add("@salefile_evname", Packing_Job_Invoice_Model.salefile_evname);
                objParam.Add("@salefile_evadd", Packing_Job_Invoice_Model.salefile_evadd);
                objParam.Add("@salefile_tsno", Packing_Job_Invoice_Model.salefile_tsno);
                objParam.Add("@salefile_item", Packing_Job_Invoice_Model.salefile_item);
                objParam.Add("@record_status", Packing_Job_Invoice_Model.record_status);
                objParam.Add("@updated_by", Packing_Job_Invoice_Model.updated_by);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Packing_Job_Invoice_Update", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Packing_Job_Invoice_Delete
        public void Packing_Job_Invoice_Delete(Packing_Job_Invoice_Model Packing_Job_Invoice_Model)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@id", Packing_Job_Invoice_Model.id);
                objParam.Add("@record_status", Packing_Job_Invoice_Model.record_status);
                objParam.Add("@updated_by", Packing_Job_Invoice_Model.updated_by);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_Packing_Job_Invoice_Delete", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}