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
    public class CustomerMasterRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection MIS_SERVICE;
        public SqlConnection VSK_Data;
        public SqlConnection VSK_ACC;
        public SqlConnection VSK_TRP;
        public SqlConnection ACC189_PRODUCTION_VSKMTB;
        public SqlConnection ACC249_PRODUCTION_VORSWIN;
        public SqlConnection ACC186_PRODUCTION_VSKDATA;
        public SqlConnection MIS187_PRODUCTION_SA;
        public SqlConnection MIS187_PRODUCTION_ACC;
        public SqlConnection MIS186_PRODUCTION_ACC;
        public SqlConnection MIS247_DEV_VSKData;

        private void Connection()
        {
            string STR_MIS_SERVICE = ConfigurationManager.ConnectionStrings["MIS_SERVICE"].ToString();
            MIS_SERVICE = new SqlConnection(STR_MIS_SERVICE);

            string STR_VSK_Data = ConfigurationManager.ConnectionStrings["VSK_Data"].ToString();
            VSK_Data = new SqlConnection(STR_VSK_Data);

            string STR_VSK_ACC = ConfigurationManager.ConnectionStrings["VSK_ACC"].ToString();
            VSK_ACC = new SqlConnection(STR_VSK_ACC);

            string STR_VSK_TRP = ConfigurationManager.ConnectionStrings["VSK_TMS"].ToString();
            VSK_TRP = new SqlConnection(STR_VSK_TRP);

            string STR_ACC189_PRODUCTION_VSKMTB = ConfigurationManager.ConnectionStrings["ACC189_PRODUCTION_VSKMTB"].ToString();
            ACC189_PRODUCTION_VSKMTB = new SqlConnection(STR_ACC189_PRODUCTION_VSKMTB);

            string STR_ACC249_PRODUCTION_VORSWIN = ConfigurationManager.ConnectionStrings["ACC249_PRODUCTION_VORSWIN"].ToString();
            ACC249_PRODUCTION_VORSWIN = new SqlConnection(STR_ACC249_PRODUCTION_VORSWIN);

            string STR_ACC186_PRODUCTION_VSKDATA = ConfigurationManager.ConnectionStrings["ACC186_PRODUCTION_VSKDATA"].ToString();
            ACC186_PRODUCTION_VSKDATA = new SqlConnection(STR_ACC186_PRODUCTION_VSKDATA);

            string STR_MIS187_PRODUCTION_SA = ConfigurationManager.ConnectionStrings["MIS187_PRODUCTION_SA"].ToString();
            MIS187_PRODUCTION_SA = new SqlConnection(STR_MIS187_PRODUCTION_SA);

            string STR_MIS186_PRODUCTION_ACC = ConfigurationManager.ConnectionStrings["ACC186_PRODUCTION_ACC"].ToString();
            MIS186_PRODUCTION_ACC = new SqlConnection(STR_MIS186_PRODUCTION_ACC);

            string STR_MIS187_PRODUCTION_ACC = ConfigurationManager.ConnectionStrings["MIS187_PRODUCTION_ACC"].ToString();
            MIS187_PRODUCTION_ACC = new SqlConnection(STR_MIS187_PRODUCTION_ACC);

            string STR_MIS247_DEV_VSKData = ConfigurationManager.ConnectionStrings["MIS247_DEV_VSKData"].ToString();
            MIS247_DEV_VSKData = new SqlConnection(STR_MIS247_DEV_VSKData);

        }
        //-------------------End Connection_SQL ------------------------//
        #endregion



        public List<MasterDataCustomerModel> MasterDataCustomer(string mode)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", mode);

                Connection();
                VSK_Data.Open();
                List<MasterDataCustomerModel> List = SqlMapper.Query<MasterDataCustomerModel>(VSK_Data, "SP_MasterData_CustomerProfile", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return List.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CustomerProfileModel> CustomerMaster_List(CustomerProfileModel CustomerProfileModel)
        {

            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@salechannel", CustomerProfileModel.salechannel);

                Connection();
                ACC186_PRODUCTION_VSKDATA.Open();
                List<CustomerProfileModel> CustomerMaster_List_Get = SqlMapper.Query<CustomerProfileModel>(ACC186_PRODUCTION_VSKDATA, "SP_Customer_Profile_List", objParam, commandType: CommandType.StoredProcedure).ToList();
                ACC186_PRODUCTION_VSKDATA.Close();
                return CustomerMaster_List_Get.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<CustomerModel> CustomerMaster_Detail(string code)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", code);

                Connection();
                VSK_Data.Open();
                List<CustomerModel> RequestModelList = SqlMapper.Query<CustomerModel>(VSK_Data, "SP_Customer_Detail_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CustomerProfileMasterModel> CustomerMaster_187_Update(CustomerProfileMasterModel CustomerProfileMasterModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@emmas_code", CustomerProfileMasterModel.emmas_code);
                //objParam.Add("@salegrch_grouprank", CustomerProfileMasterModel.salegrch_grouprank);
                objParam.Add("@emmas_etel", CustomerProfileMasterModel.emmas_etel);
                objParam.Add("@emmas_efax", CustomerProfileMasterModel.emmas_efax);
                objParam.Add("@emmas_etran", CustomerProfileMasterModel.emmas_etran);
                objParam.Add("@emmas_edescript", CustomerProfileMasterModel.emmas_edescript);
                objParam.Add("@emmas_eregdate", CustomerProfileMasterModel.emmas_eregdate);
                objParam.Add("@emmas_eOwn3", CustomerProfileMasterModel.emmas_eOwn3);
                //objParam.Add("@emmas_eOwn0", CustomerProfileMasterModel.emmas_eOwn0);
                //objParam.Add("@salegrch_idcardno", CustomerProfileMasterModel.salegrch_idcardno);

                //objParam.Add("@emmas_eaddress", CustomerProfileMasterModel.emmas_eaddress);
                objParam.Add("@salegrch_customer_houseno", CustomerProfileMasterModel.salegrch_customer_houseno);
                objParam.Add("@salegrch_customer_villageno", CustomerProfileMasterModel.salegrch_customer_villageno);
                objParam.Add("@salegrch_customer_village", CustomerProfileMasterModel.salegrch_customer_village);
                objParam.Add("@salegrch_customer_lane", CustomerProfileMasterModel.salegrch_customer_lane);
                objParam.Add("@salegrch_customer_streetname", CustomerProfileMasterModel.salegrch_customer_streetname);
                objParam.Add("@emmas_etumbol", CustomerProfileMasterModel.emmas_etumbol);
                objParam.Add("@emmas_eamphur", CustomerProfileMasterModel.emmas_eamphur);
                objParam.Add("@emmas_eprovinc", CustomerProfileMasterModel.emmas_eprovinc);
                objParam.Add("@emmas_ezip", CustomerProfileMasterModel.emmas_ezip);

                //objParam.Add("@salegrch_eaddress2", CustomerProfileMasterModel.salegrch_eaddress2);
                objParam.Add("@salegrch_customer_houseno2", CustomerProfileMasterModel.salegrch_customer_houseno);
                objParam.Add("@salegrch_customer_villageno2", CustomerProfileMasterModel.salegrch_customer_villageno);
                objParam.Add("@salegrch_customer_village2", CustomerProfileMasterModel.salegrch_customer_village);
                objParam.Add("@salegrch_customer_lane2", CustomerProfileMasterModel.salegrch_customer_lane);
                objParam.Add("@salegrch_customer_streetname2", CustomerProfileMasterModel.salegrch_customer_streetname);
                objParam.Add("@salegrch_etumbol2", CustomerProfileMasterModel.salegrch_etumbol2);
                objParam.Add("@salegrch_eamphur2", CustomerProfileMasterModel.salegrch_eamphur2);
                objParam.Add("@salegrch_eprovinc2", CustomerProfileMasterModel.salegrch_eprovinc2);
                objParam.Add("@salegrch_ezip2", CustomerProfileMasterModel.salegrch_ezip2);

                objParam.Add("@emmas_etrans", CustomerProfileMasterModel.emmas_etrans);
                objParam.Add("@salegrch_delivery_stdtime", CustomerProfileMasterModel.salegrch_delivery_stdtime);
                objParam.Add("@salegrch_banklist", CustomerProfileMasterModel.salegrch_banklist);
                objParam.Add("@created_by", CustomerProfileMasterModel.created_by);

                Connection();
                MIS247_DEV_VSKData.Open();
                List<CustomerProfileMasterModel> CustomerMaster_Update = SqlMapper.Query<CustomerProfileMasterModel>(MIS247_DEV_VSKData, "SP_Customer_Profile_Update", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                MIS247_DEV_VSKData.Close();
                return CustomerMaster_Update.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CustomerProfileMasterModel> CustomerMaster_186_Update(CustomerProfileMasterModel CustomerProfileMasterModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@emmas_code", CustomerProfileMasterModel.emmas_code);
                objParam.Add("@emmas_etel", CustomerProfileMasterModel.emmas_etel);
                objParam.Add("@emmas_etran", CustomerProfileMasterModel.emmas_etran);
                objParam.Add("@emmas_efax", CustomerProfileMasterModel.emmas_efax);
                objParam.Add("@emmas_eOwn3", CustomerProfileMasterModel.emmas_eOwn3);
                objParam.Add("@emmas_eOwn0", CustomerProfileMasterModel.emmas_eOwn0);
                objParam.Add("@emmas_eaddress", CustomerProfileMasterModel.emmas_eaddress);
                objParam.Add("@emmas_eregdate", CustomerProfileMasterModel.emmas_eregdate);
                objParam.Add("@emmas_edescript", CustomerProfileMasterModel.emmas_edescript);
                objParam.Add("@emmas_etumbol", CustomerProfileMasterModel.emmas_etumbol);
                objParam.Add("@emmas_eamphur", CustomerProfileMasterModel.emmas_eamphur);
                objParam.Add("@emmas_eprovinc", CustomerProfileMasterModel.emmas_eprovinc);
                objParam.Add("@emmas_ezip", CustomerProfileMasterModel.emmas_ezip);
                objParam.Add("@emmas_etrans", CustomerProfileMasterModel.emmas_etrans);

                objParam.Add("@salegrch_grouprank", CustomerProfileMasterModel.salegrch_grouprank);
                objParam.Add("@salegrch_idcardno", CustomerProfileMasterModel.salegrch_idcardno);
                objParam.Add("@salegrch_eaddress2", CustomerProfileMasterModel.salegrch_eaddress2);
                objParam.Add("@salegrch_etumbol2", CustomerProfileMasterModel.salegrch_etumbol2);
                objParam.Add("@salegrch_eamphur2", CustomerProfileMasterModel.salegrch_eamphur2);
                objParam.Add("@salegrch_eprovinc2", CustomerProfileMasterModel.salegrch_eprovinc2);
                objParam.Add("@salegrch_ezip2", CustomerProfileMasterModel.salegrch_ezip2);
                objParam.Add("@salegrch_delivery_stdtime", CustomerProfileMasterModel.salegrch_delivery_stdtime);


                Connection();
                ACC186_PRODUCTION_VSKDATA.Open();
                List<CustomerProfileMasterModel> CustomerMaster_186_Update = SqlMapper.Query<CustomerProfileMasterModel>(ACC186_PRODUCTION_VSKDATA, "SP_Customer_Profile_Update", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                ACC186_PRODUCTION_VSKDATA.Close();
                return CustomerMaster_186_Update.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CustomerContactModel> Customer_Contact_Get(string item_code)
        {

            try
            {

                string SQLQuery = "SELECT * FROM dbo.customer_contact WHERE code = '" + item_code + "' ORDER BY created_date ASC";

                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<CustomerContactModel> RequestModelList = MIS187_PRODUCTION_SA.Query<CustomerContactModel>(SQLQuery, commandTimeout: 600).ToList();
                MIS187_PRODUCTION_SA.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #region Customer_Contact_Create
        public List<CustomerContactModel> Customer_Contact_Create(CustomerContactModel CustomerContactModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", CustomerContactModel.code);
                objParam.Add("@contactnumber", CustomerContactModel.contactnumber);
                objParam.Add("@contactname", CustomerContactModel.contactname);
                objParam.Add("@extension", CustomerContactModel.extension);
                objParam.Add("@purpose_code", CustomerContactModel.purpose_code);
                objParam.Add("@purpose_desc", CustomerContactModel.purpose_desc);
                objParam.Add("@description", CustomerContactModel.description);
                objParam.Add("@created_by", CustomerContactModel.created_by);
                objParam.Add("@record_status", CustomerContactModel.record_status);
                objParam.Add("@pMessage", CustomerContactModel.pMessage);

                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<CustomerContactModel> Customer_Contact_Create = SqlMapper.Query<CustomerContactModel>(MIS187_PRODUCTION_SA, "SP_Customer_Contact_Create", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                MIS187_PRODUCTION_SA.Close();
                return Customer_Contact_Create.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        //public List<SaletargetrModel> Saletarget_Get(string code, string year)
        //{
        //    try
        //    {
        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@code", code);
        //        objParam.Add("@year", year);

        //        Connection();
        //        VSK_Data.Open();
        //        List<SaletargetrModel> RequestModelList = SqlMapper.Query<SaletargetrModel>(VSK_Data, "SP_Customer_Saletarget_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_Data.Close();
        //        return RequestModelList.ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //P SOMO
        public List<LovModel> MasterCustomer_Lov_Get(string lov_group, string lov_type, string lov_code)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@lov_group", lov_group);
                objParam.Add("@@lov_type", lov_type);
                objParam.Add("@@lov_code", lov_code);

                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<LovModel> MasterCustomer_Lov_Get = SqlMapper.Query<LovModel>(MIS187_PRODUCTION_SA, "SP_MasterCustomer_Lov_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS187_PRODUCTION_SA.Close();
                return MasterCustomer_Lov_Get.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region CustomerProfile_Detail186_Get
        public List<CustomerProfileMasterModel> CustomerProfile_Detail186_Get(string code)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", code);

                Connection();
                ACC186_PRODUCTION_VSKDATA.Open();
                //SOM-O 2022/01/14 - QUERY CUSTOMERMASTER FROM 192.168.1.186
                List<CustomerProfileMasterModel> CustomerProfile_Detail186_Get = SqlMapper.Query<CustomerProfileMasterModel>(ACC186_PRODUCTION_VSKDATA, "SP_CustomerProfile_186Data_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                ACC186_PRODUCTION_VSKDATA.Close();
                return CustomerProfile_Detail186_Get.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region CustomerProfile_Detail187_Get
        public List<CustomerProfileMasterModel> CustomerProfile_Detail187_Get(string code)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", code);

                Connection();
                MIS247_DEV_VSKData.Open();
                List<CustomerProfileMasterModel> CustomerProfile_Detail187_Get = SqlMapper.Query<CustomerProfileMasterModel>(MIS247_DEV_VSKData, "SP_Customer_Profile_187Data_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS247_DEV_VSKData.Close();
                return CustomerProfile_Detail187_Get.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_Profile_SaleTarget187_Get
        public List<SaletargetrModel> Customer_Profile_SaleTarget187_Get(string code, string target_year)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", code);
                objParam.Add("@target_year", target_year);

                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<SaletargetrModel> Customer_Profile_SaleTarget187_Get = SqlMapper.Query<SaletargetrModel>(MIS187_PRODUCTION_SA, "SP_Customer_Profile_SaleTarget_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS187_PRODUCTION_SA.Close();
                return Customer_Profile_SaleTarget187_Get.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_Profile_SaleTarget187_Update
        public List<SaletargetrModel> Customer_Profile_SaleTarget187_Update(SaletargetrModel SaletargetrModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@emmas_code", SaletargetrModel.emmas_code);
                objParam.Add("@saletargetcsum1_salestarget_year", SaletargetrModel.saletargetcsum1_salestarget_year);

                objParam.Add("@saletargetc_salestarget_m01_input", SaletargetrModel.saletargetc_salestarget_m01_input);
                objParam.Add("@saletargetc_salestarget_m02_input", SaletargetrModel.saletargetc_salestarget_m02_input);
                objParam.Add("@saletargetc_salestarget_m03_input", SaletargetrModel.saletargetc_salestarget_m03_input);
                objParam.Add("@saletargetc_salestarget_m04_input", SaletargetrModel.saletargetc_salestarget_m04_input);
                objParam.Add("@saletargetc_salestarget_m05_input", SaletargetrModel.saletargetc_salestarget_m05_input);
                objParam.Add("@saletargetc_salestarget_m06_input", SaletargetrModel.saletargetc_salestarget_m06_input);
                objParam.Add("@saletargetc_salestarget_m07_input", SaletargetrModel.saletargetc_salestarget_m07_input);
                objParam.Add("@saletargetc_salestarget_m08_input", SaletargetrModel.saletargetc_salestarget_m08_input);
                objParam.Add("@saletargetc_salestarget_m09_input", SaletargetrModel.saletargetc_salestarget_m09_input);
                objParam.Add("@saletargetc_salestarget_m10_input", SaletargetrModel.saletargetc_salestarget_m10_input);
                objParam.Add("@saletargetc_salestarget_m11_input", SaletargetrModel.saletargetc_salestarget_m11_input);
                objParam.Add("@saletargetc_salestarget_m12_input", SaletargetrModel.saletargetc_salestarget_m12_input);

                objParam.Add("@saletargetc_rebatestarget_q1_input", SaletargetrModel.saletargetc_rebatestarget_q1_input);
                objParam.Add("@saletargetc_rebatestarget_q2_input", SaletargetrModel.saletargetc_rebatestarget_q2_input);
                objParam.Add("@saletargetc_rebatestarget_q3_input", SaletargetrModel.saletargetc_rebatestarget_q3_input);
                objParam.Add("@saletargetc_rebatestarget_q4_input", SaletargetrModel.saletargetc_rebatestarget_q4_input);

                objParam.Add("@created_by", SaletargetrModel.created_by);



                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<SaletargetrModel> Customer_Profile_SaleTarget187_Update = SqlMapper.Query<SaletargetrModel>(MIS187_PRODUCTION_SA, "SP_Customer_Profile_SaleTarget_Update", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS187_PRODUCTION_SA.Close();
                return Customer_Profile_SaleTarget187_Update.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_Address187_List
        public List<Customer_Addredd_187_Modal> Customer_Address187_List(string @emmas_code, string mode)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@emmas_code", emmas_code);
                objParam.Add("@mode", mode);

                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<Customer_Addredd_187_Modal> Customer_Addredd_187_List = SqlMapper.Query<Customer_Addredd_187_Modal>(MIS187_PRODUCTION_SA, "SP_Customer_Profile_Address_List", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS187_PRODUCTION_SA.Close();
                return Customer_Addredd_187_List.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_Address187_Create
        public List<Customer_Addredd_187_Modal> Customer_Address187_Create(Customer_Addredd_187_Modal Customer_Addredd_187_Modal)
        {
            try 
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@emmasaddr_emmas_code", Customer_Addredd_187_Modal.emmasaddr_emmas_code);
                objParam.Add("@emmasaddr_location_name", Customer_Addredd_187_Modal.emmasaddr_location_name);
                objParam.Add("@emmasaddr_eaddress", Customer_Addredd_187_Modal.emmasaddr_eaddress);
                objParam.Add("@emmasaddr_etumbol", Customer_Addredd_187_Modal.emmasaddr_etumbol);
                objParam.Add("@emmasaddr_eamphur", Customer_Addredd_187_Modal.emmasaddr_eamphur);
                objParam.Add("@emmasaddr_eprovinc", Customer_Addredd_187_Modal.emmasaddr_eprovinc);
                objParam.Add("@emmasaddr_ezip", Customer_Addredd_187_Modal.emmasaddr_ezip);
                objParam.Add("@emmasaddr_edefault", Customer_Addredd_187_Modal.emmasaddr_edefault);
                objParam.Add("@record_status", Customer_Addredd_187_Modal.record_status);
                objParam.Add("@created_by", Customer_Addredd_187_Modal.created_by);
                objParam.Add("@pMessage", Customer_Addredd_187_Modal.pMessage);

                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<Customer_Addredd_187_Modal> Customer_Address187_Create = SqlMapper.Query<Customer_Addredd_187_Modal>(MIS187_PRODUCTION_SA, "SP_Customer_Profile_Address_Add", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS187_PRODUCTION_SA.Close();
                return Customer_Address187_Create.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_Address187_Update
        public List<Customer_Addredd_187_Modal> Customer_Address187_Update(Customer_Addredd_187_Modal Customer_Addredd_187_Modal)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@emmasaddr_id", Customer_Addredd_187_Modal.emmasaddr_id);
                objParam.Add("@emmasaddr_emmas_code", Customer_Addredd_187_Modal.emmasaddr_emmas_code);
                objParam.Add("@emmasaddr_location_name", Customer_Addredd_187_Modal.emmasaddr_location_name);
                objParam.Add("@emmasaddr_eaddress", Customer_Addredd_187_Modal.emmasaddr_eaddress);
                objParam.Add("@emmasaddr_etumbol", Customer_Addredd_187_Modal.emmasaddr_etumbol);
                objParam.Add("@emmasaddr_eamphur", Customer_Addredd_187_Modal.emmasaddr_eamphur);
                objParam.Add("@emmasaddr_eprovinc", Customer_Addredd_187_Modal.emmasaddr_eprovinc);
                objParam.Add("@emmasaddr_ezip", Customer_Addredd_187_Modal.emmasaddr_ezip);
                objParam.Add("@emmasaddr_edefault", Customer_Addredd_187_Modal.emmasaddr_edefault);
                objParam.Add("@record_status", Customer_Addredd_187_Modal.record_status);
                objParam.Add("@updated_by", Customer_Addredd_187_Modal.updated_by);
                objParam.Add("@pMessage", Customer_Addredd_187_Modal.pMessage);

                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<Customer_Addredd_187_Modal> Customer_Address187_Create = SqlMapper.Query<Customer_Addredd_187_Modal>(MIS187_PRODUCTION_SA, "SP_Customer_Profile_Address_Update", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS187_PRODUCTION_SA.Close();
                return Customer_Address187_Create.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_Address187_Get
        public List<Customer_Addredd_187_Modal> Customer_Address187_Get(Customer_Addredd_187_Modal Customer_Addredd_187_Modal)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@emmasaddr_id", Customer_Addredd_187_Modal.emmasaddr_id);
                objParam.Add("@emmas_code", Customer_Addredd_187_Modal.emmasaddr_emmas_code);
                objParam.Add("@record_status", Customer_Addredd_187_Modal.record_status);
                objParam.Add("@Mode", Customer_Addredd_187_Modal.mode);

                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<Customer_Addredd_187_Modal> Customer_Address187_Get = SqlMapper.Query<Customer_Addredd_187_Modal>(MIS187_PRODUCTION_SA, "SP_Customer_Profile_Address_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                MIS187_PRODUCTION_SA.Close();
                return Customer_Address187_Get.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_Address187_Delete
        public void Customer_Address187_Delete(Customer_Addredd_187_Modal Customer_Addredd_187_Modal)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@emmasaddr_id", Customer_Addredd_187_Modal.emmasaddr_id);
                objParam.Add("@record_status", Customer_Addredd_187_Modal.record_status);
                objParam.Add("@updated_by", Customer_Addredd_187_Modal.updated_by);
                objParam.Add("@pMessage", Customer_Addredd_187_Modal.pMessage);

                Connection();
                MIS187_PRODUCTION_SA.Open();
                MIS187_PRODUCTION_SA.Execute("SP_Customer_Profile_Address_Delete", objParam, commandType: CommandType.StoredProcedure);
                MIS187_PRODUCTION_SA.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CustomerProfile_Detail189_Get
        public List<CustomerProfileMTBModel> CustomerProfile_Detail189_Get(string code)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", code);

                Connection();
                ACC189_PRODUCTION_VSKMTB.Open();
                List<CustomerProfileMTBModel> CustomerProfile_Detail189_Get = SqlMapper.Query<CustomerProfileMTBModel>(ACC189_PRODUCTION_VSKMTB, "SP_Customer_Profile_Detail_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                ACC189_PRODUCTION_VSKMTB.Close();
                return CustomerProfile_Detail189_Get.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        //P SOMO

        //start kung add new function (2022/01/14)
        #region Province
        public List<Province_Modal> Province_Get(Province_Modal Province_Modal)
        {
            try
            {
                
                
                DynamicParameters objParam = new DynamicParameters();

                if (Province_Modal != null)
                {
                    objParam.Add("@glb_province_id", Province_Modal.glb_province_id);
                    objParam.Add("@glb_province_code", Province_Modal.glb_province_code);
                    objParam.Add("@glb_province_name", Province_Modal.glb_province_name);
                    objParam.Add("@glb_geo_code", Province_Modal.glb_geo_code);

                }

                Connection();
                MIS187_PRODUCTION_ACC.Open();
                List<Province_Modal> RequestModelList = SqlMapper.Query<Province_Modal>(MIS187_PRODUCTION_ACC, "SP_Glb_Province_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS187_PRODUCTION_ACC.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region Amphur
        public List<Amphur_Modal> Amphur_Get(Amphur_Modal Amphur_Modal)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@glb_amphur_id", Amphur_Modal.glb_amphur_id);
                objParam.Add("@glb_amphur_code", Amphur_Modal.glb_amphur_code);
                objParam.Add("@glb_amphur_name", Amphur_Modal.glb_amphur_name);
                objParam.Add("@glb_amphur_postcode", Amphur_Modal.glb_amphur_postcode);
                objParam.Add("@glb_province_Id", Amphur_Modal.glb_province_id);

                Connection();
                MIS187_PRODUCTION_ACC.Open();
                List<Amphur_Modal> Amphur_Get = SqlMapper.Query<Amphur_Modal>(MIS187_PRODUCTION_ACC, "SP_Glb_Amphur_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                MIS187_PRODUCTION_ACC.Close();
                return Amphur_Get.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region District
        public List<District_Modal> District_Get(District_Modal District_Modal)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@glb_district_id", District_Modal.glb_district_id);
                objParam.Add("@glb_district_code", District_Modal.glb_district_code);
                objParam.Add("@glb_district_name", District_Modal.glb_district_name);
                objParam.Add("@glb_amphur_id", District_Modal.glb_amphur_id);

                Connection();
                MIS187_PRODUCTION_ACC.Open();
                List<District_Modal> District_Get = SqlMapper.Query<District_Modal>(MIS187_PRODUCTION_ACC, "SP_Glb_District_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                MIS187_PRODUCTION_ACC.Close();
                return District_Get.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        public List<Lov_Modal> Customer_Setup_Route_Get()
        {
            try
            {
                string SQLQuery = "SELECT * FROM [dbo].[lov_data] WHERE lov_group='MASTER' AND lov_type='Route_No' ORDER BY created_date";

                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<Lov_Modal> RequestModelList = MIS187_PRODUCTION_SA.Query<Lov_Modal>(SQLQuery, commandTimeout: 600).ToList();
                MIS187_PRODUCTION_SA.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Lov_Modal> Customer_Setup_Subroute_Get(string parent_lov_id)
        {
            try
            {
                string SQLQuery = "SELECT * FROM [dbo].[lov_data] WHERE lov_group='MASTER' AND lov_type='SubRoute_No' AND parent_lov_id='"+ parent_lov_id + "' ORDER BY created_date";

                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<Lov_Modal> RequestModelList = MIS187_PRODUCTION_SA.Query<Lov_Modal>(SQLQuery, commandTimeout: 600).ToList();
                MIS187_PRODUCTION_SA.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Lov_Modal> Priority_Type_Lov_Get()
        {

            try
            {

                string SQLQuery = "SELECT * FROM dbo.lov_data WHERE lov_group = 'CustomerProfile' AND lov_type = 'piority_type' ORDER BY created_date ASC";

                Connection();
                ACC186_PRODUCTION_VSKDATA.Open();
                List<Lov_Modal> RequestModelList = ACC186_PRODUCTION_VSKDATA.Query<Lov_Modal>(SQLQuery, commandTimeout: 600).ToList();
                ACC186_PRODUCTION_VSKDATA.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Lov_Modal> TRP_Vendor_Lov_Get()
        {

            try
            {

                string SQLQuery = "SELECT * FROM [dbo].[lov_data] WHERE lov_group='MASTER' AND lov_type='TRP_Vendor'";

                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<Lov_Modal> RequestModelList = MIS187_PRODUCTION_SA.Query<Lov_Modal>(SQLQuery, commandTimeout: 600).ToList();
                MIS187_PRODUCTION_SA.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #region TRP_Vendor_Create
        public void TRP_Vendor_Create(Devilery_Zone_Model Devilery_Zone)
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
                MIS187_PRODUCTION_SA.Open();
                MIS187_PRODUCTION_SA.Execute("SP_TRP_Vendor_Create", objParam, commandType: CommandType.StoredProcedure);
                MIS187_PRODUCTION_SA.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region TRP_Vendor_Update
        public void TRP_Vendor_Update(Devilery_Zone_Model Devilery_Zone)
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
                MIS187_PRODUCTION_SA.Open();
                MIS187_PRODUCTION_SA.Execute("SP_Devilery_Zone_Update", objParam, commandType: CommandType.StoredProcedure);
                MIS187_PRODUCTION_SA.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region TRP_Vendor_Delete
        public void TRP_Vendor_Delete(Devilery_Zone_Model Devilery_Zone)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                //string Receive_date_est = PkPoIVModel.Receive_date_est == DateTime.MinValue ? null : PkPoIVModel.Receive_date_est.ToString("yyyy-MM-dd hh:mm");

                objParam.Add("@id", Devilery_Zone.id);
                objParam.Add("@record_status", Devilery_Zone.record_status);
                objParam.Add("@updated_by", Devilery_Zone.updated_by);
                objParam.Add("@pMessage", Devilery_Zone.pMessage);

                Connection();
                MIS187_PRODUCTION_SA.Open();
                MIS187_PRODUCTION_SA.Execute("SP_Devilery_Zone_Delete", objParam, commandType: CommandType.StoredProcedure);
                MIS187_PRODUCTION_SA.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region TRP_Vendor_Get
        public List<Devilery_Zone_Model> TRP_Vendor_Get(Devilery_Zone_Model Devilery_Zone_Model)
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
                MIS187_PRODUCTION_SA.Open();
                List<Devilery_Zone_Model> CnVList = SqlMapper.Query<Devilery_Zone_Model>(MIS187_PRODUCTION_SA, "SP_TRP_Vendor_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                MIS187_PRODUCTION_SA.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_TRP_Vendor_Add
        public void Customer_TRP_Vendor_Add(Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
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
                MIS187_PRODUCTION_SA.Open();
                MIS187_PRODUCTION_SA.Execute("SP_Customer_Setup_Trp_Add", objParam, commandType: CommandType.StoredProcedure);
                MIS187_PRODUCTION_SA.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_TRP_Vendor_Update
        public void Customer_TRP_Vendor_Update(Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
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
                MIS187_PRODUCTION_SA.Open();
                MIS187_PRODUCTION_SA.Execute("SP_Customer_Setup_Trp_Update", objParam, commandType: CommandType.StoredProcedure);
                MIS187_PRODUCTION_SA.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_TRP_Vendor_Delete
        public void Customer_TRP_Vendor_Delete(Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
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
                MIS187_PRODUCTION_SA.Open();
                MIS187_PRODUCTION_SA.Execute("SP_Customer_Setup_Trp_Delete", objParam, commandType: CommandType.StoredProcedure);
                MIS187_PRODUCTION_SA.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Customer_TRP_Vendor_Get
        public List<Customer_Setup_Trp_Model> Customer_TRP_Vendor_Get(Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
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
                MIS187_PRODUCTION_SA.Open();
                List<Customer_Setup_Trp_Model> CnVList = SqlMapper.Query<Customer_Setup_Trp_Model>(MIS187_PRODUCTION_SA, "SP_Customer_Setup_Trp_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                MIS187_PRODUCTION_SA.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        //end kung add new function (2022/01/14)


        #region Customer_Owner_Create
        public List<CustomerOwnerModel> Customer_Owner_Create(CustomerOwnerModel CustomerOwnerModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", CustomerOwnerModel.code);
                objParam.Add("@owner_name", CustomerOwnerModel.owner_name);
                objParam.Add("@owner_idno", CustomerOwnerModel.owner_idno);
                objParam.Add("@created_by", CustomerOwnerModel.created_by);
                objParam.Add("@record_status", CustomerOwnerModel.record_status);
                objParam.Add("@pMessage", CustomerOwnerModel.pMessage);

                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<CustomerOwnerModel> Customer_Owner_Create = SqlMapper.Query<CustomerOwnerModel>(MIS187_PRODUCTION_SA, "SP_Customer_Owner_Create", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                MIS187_PRODUCTION_SA.Close();
                return Customer_Owner_Create.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region Customer_Owner_Get
        public List<CustomerOwnerModel> Customer_Owner_Get(string item_code)
        {

            try
            {

                string SQLQuery = "SELECT * FROM dbo.customer_owner WHERE code = '" + item_code + "' ORDER BY created_date ASC";

                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<CustomerOwnerModel> RequestModelList = MIS187_PRODUCTION_SA.Query<CustomerOwnerModel>(SQLQuery, commandTimeout: 600).ToList();
                MIS187_PRODUCTION_SA.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion


        #region Customer_BankAccount_Create
        public List<CustomerBankAccountModel> Customer_BankAccount_Create(CustomerBankAccountModel CustomerBankAccountModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", CustomerBankAccountModel.code);
                objParam.Add("@customer_bac_bank", CustomerBankAccountModel.customer_bac_bank);
                objParam.Add("@customer_bac_bankname", CustomerBankAccountModel.customer_bac_bankname);
                objParam.Add("@customer_bac_bankno", CustomerBankAccountModel.customer_bac_bankno);
                objParam.Add("@customer_bac_type", CustomerBankAccountModel.customer_bac_type);
                objParam.Add("@customer_bac_comment", CustomerBankAccountModel.customer_bac_comment);
                objParam.Add("@created_by", CustomerBankAccountModel.created_by);
                objParam.Add("@record_status", CustomerBankAccountModel.record_status);
                objParam.Add("@pMessage", CustomerBankAccountModel.pMessage);

                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<CustomerBankAccountModel> Customer_BankAccount_Create = SqlMapper.Query<CustomerBankAccountModel>(MIS187_PRODUCTION_SA, "SP_Customer_BankAccount_Create", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                MIS187_PRODUCTION_SA.Close();
                return Customer_BankAccount_Create.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region Customer_BankAccount_Get
        public List<CustomerBankAccountModel> Customer_BankAccount_Get(string item_code)
        {

            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@item_code", item_code);

                Connection();
                MIS187_PRODUCTION_SA.Open();
                List<CustomerBankAccountModel> Customer_BankAccount_Get = SqlMapper.Query<CustomerBankAccountModel>(MIS187_PRODUCTION_SA, "SP_Customer_BankAccount_Get", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                MIS187_PRODUCTION_SA.Close();
                return Customer_BankAccount_Get.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

    }
}