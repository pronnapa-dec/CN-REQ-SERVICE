using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class CustomerMasterController : ApiController
    {

        [Route("api/MasterDataCustomer")]
        [HttpGet]
        public ResponseModel MasterDataCustomer([FromUri] string mode)
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<MasterDataCustomerModel> MasterDataCustomer = CustomerMasterRepository.MasterDataCustomer(mode);

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MasterDataCustomer;
                _ResponseModel.length = MasterDataCustomer.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("api/CustomerMaster_List")]
        [HttpGet]
        public ResponseModel CustomerMaster_List([FromUri] CustomerProfileModel CustomerProfileModel)
        {
            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<CustomerProfileModel> CustomerMaster_List = CustomerMasterRepository.CustomerMaster_List(CustomerProfileModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CustomerMaster_List;
                _ResponseModel.length = CustomerMaster_List.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("api/CustomerMaster_Detail")]
        [HttpGet]
        public ResponseModel CustomerMaster_Detail([FromUri] string code)
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<CustomerModel> CustomerMaster_Detail = CustomerMasterRepository.CustomerMaster_Detail(code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CustomerMaster_Detail;
                _ResponseModel.length = CustomerMaster_Detail.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("api/CustomerMaster_187_Update")]
        [HttpPut]
        public ResponseModel CustomerMaster_187_Update([FromBody] CustomerProfileMasterModel CustomerProfileMasterModel)
        {

            try
            {
                //CultureInfo cultureinfo = new CultureInfo("en-US");

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<CustomerProfileMasterModel> CustomerMaster_187_Update = CustomerMasterRepository.CustomerMaster_187_Update(CustomerProfileMasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CustomerMaster_187_Update;
                _ResponseModel.length = CustomerMaster_187_Update.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("api/CustomerMaster_186_Update")]
        [HttpPut]
        public ResponseModel CustomerMaster_186_Update([FromBody] CustomerProfileMasterModel CustomerProfileMasterModel)
        {

            try
            {
                //CultureInfo cultureinfo = new CultureInfo("en-US");

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<CustomerProfileMasterModel> CustomerMaster_186_Update = CustomerMasterRepository.CustomerMaster_186_Update(CustomerProfileMasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CustomerMaster_186_Update;
                _ResponseModel.length = CustomerMaster_186_Update.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("api/Customer_Contact_Get")]
        [HttpGet]
        public ResponseModel Customer_Contact_Get([FromUri] string item_code)
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<CustomerContactModel> Customer_Contact_Get = CustomerMasterRepository.Customer_Contact_Get(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Customer_Contact_Get;
                _ResponseModel.length = Customer_Contact_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        #region Customer_Contact_Create
        [Route("api/Customer_Contact_Create")]
        [HttpPut]
        public ResponseModel Customer_Contact_Create([FromBody] CustomerContactModel CustomerContactModel)
        {

            try
            {

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<CustomerContactModel> Customer_Contact_Create = CustomerMasterRepository.Customer_Contact_Create(CustomerContactModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Customer_Contact_Create;
                _ResponseModel.length = Customer_Contact_Create.Count();
                _ResponseModel.status = "Success";


                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        //[Route("api/saletarget_get")]
        //[HttpGet]
        //public ResponseModel Saletarget_Get([FromUri] string code, string year)
        //{
        //    try
        //    {
        //        CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
        //        List<SaletargetrModel> Saletarget_Get = CustomerMasterRepository.Saletarget_Get(code, year);
        //        ResponseModel _ResponseModel = new ResponseModel();
        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.data = Saletarget_Get;
        //        _ResponseModel.length = Saletarget_Get.Count();
        //        _ResponseModel.status = "Success";

        //        return _ResponseModel;
        //    }
        //    catch (Exception ex)
        //    {
        //        ResponseModel _ResponseModel = new ResponseModel();
        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.status = "Error";
        //        _ResponseModel.error_message = ex.Message.ToString();
        //        _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
        //        _ResponseModel.error_source = ex.Source.ToString();

        //        return _ResponseModel;
        //    }

        //}

        //P SOMO
        [Route("api/MasterCustomer_Lov_Get")]
        [HttpGet]
        public ResponseModel MasterCustomer_Lov_Get([FromUri] string lov_group = "", string lov_type = "", string lov_code = "")
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<LovModel> MasterCustomer_Lov_Get = CustomerMasterRepository.MasterCustomer_Lov_Get(lov_group, lov_type, lov_code);

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MasterCustomer_Lov_Get;
                _ResponseModel.length = MasterCustomer_Lov_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }


        #region CustomerProfile_Detail186_Get
        [Route("api/CustomerProfile_Detail186_Get")]
        [HttpGet]
        public ResponseModel CustomerProfile_Detail186_Get([FromUri] string code)
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<CustomerProfileMasterModel> CustomerProfile_Detail186_Get = CustomerMasterRepository.CustomerProfile_Detail186_Get(code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CustomerProfile_Detail186_Get;
                _ResponseModel.length = CustomerProfile_Detail186_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region CustomerProfile_Detail187_Get
        [Route("api/CustomerProfile_Detail187_Get")]
        [HttpGet]
        public ResponseModel CustomerProfile_Detail187_Get([FromUri] string code)
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<CustomerProfileMasterModel> CustomerProfile_Detail187_Get = CustomerMasterRepository.CustomerProfile_Detail187_Get(code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CustomerProfile_Detail187_Get;
                _ResponseModel.length = CustomerProfile_Detail187_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region SP_Customer_Profile_SaleTarget187_Get
        [Route("api/Customer_Profile_SaleTarget187_Get")]
        [HttpGet]
        public ResponseModel Customer_Profile_SaleTarget187_Get([FromUri] string code, string target_year)
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<SaletargetrModel> Customer_Profile_SaleTarget187_Get = CustomerMasterRepository.Customer_Profile_SaleTarget187_Get(code, target_year);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Customer_Profile_SaleTarget187_Get;
                _ResponseModel.length = Customer_Profile_SaleTarget187_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region Customer_Profile_SaleTarget187_Create
        [Route("api/Customer_Profile_SaleTarget187_Update")]
        [HttpPut]
        public ResponseModel Customer_Profile_SaleTarget187_Update([FromBody] SaletargetrModel SaletargetrModel)
        {

            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<SaletargetrModel> Customer_Profile_SaleTarget187_Create = CustomerMasterRepository.Customer_Profile_SaleTarget187_Update(SaletargetrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Customer_Profile_SaleTarget187_Create;
                _ResponseModel.length = Customer_Profile_SaleTarget187_Create.Count();
                _ResponseModel.status = "Success";


                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region Customer_Address187_List
        [Route("api/Customer_Address187_List")]
        [HttpGet]
        public ResponseModel Customer_Address187_List([FromUri] string emmas_code, string mode)
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<Customer_Addredd_187_Modal> Customer_Address187_List = CustomerMasterRepository.Customer_Address187_List(emmas_code, mode);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Customer_Address187_List;
                _ResponseModel.length = Customer_Address187_List.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region Customer_Address187_Create
        [Route("api/Customer_Address187_Create")]
        [HttpPut]
        public ResponseModel Customer_Address187_Create([FromBody] Customer_Addredd_187_Modal Customer_Addredd_187_Modal)
        {

            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<Customer_Addredd_187_Modal> Customer_Address187_Create = CustomerMasterRepository.Customer_Address187_Create(Customer_Addredd_187_Modal);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Customer_Address187_Create;
                _ResponseModel.length = Customer_Address187_Create.Count();
                _ResponseModel.status = "Success";


                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region Customer_Address187_Update
        [Route("api/Customer_Address187_Update")]
        [HttpPut]
        public ResponseModel Customer_Address187_Update([FromBody] Customer_Addredd_187_Modal Customer_Addredd_187_Modal)
        {

            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<Customer_Addredd_187_Modal> Customer_Address187_Update = CustomerMasterRepository.Customer_Address187_Update(Customer_Addredd_187_Modal);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Customer_Address187_Update;
                _ResponseModel.length = Customer_Address187_Update.Count();
                _ResponseModel.status = "Success";


                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region Customer_Address187_Get
        [Route("api/Customer_Address187_Get")]
        [HttpGet]
        public ResponseModel Customer_Address187_Get([FromUri] Customer_Addredd_187_Modal Customer_Addredd_187_Modal)
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<Customer_Addredd_187_Modal> Customer_Address187_Get = CustomerMasterRepository.Customer_Address187_Get(Customer_Addredd_187_Modal);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Customer_Address187_Get;
                _ResponseModel.length = Customer_Address187_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region Customer_Address187_Delete
        [Route("api/Customer_Address187_Delete")]
        [HttpPut]
        public ResponseModel Customer_Address187_Delete([FromBody] Customer_Addredd_187_Modal Customer_Addredd_187_Modal)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                CustomerMasterRepository.Customer_Address187_Delete(Customer_Addredd_187_Modal);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion
        
        #region CustomerProfile_Detail189_Get
        [Route("api/CustomerProfile_Detail189_Get")]
        [HttpGet]
        public ResponseModel CustomerProfile_Detail189_Get([FromUri] string code)
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<CustomerProfileMTBModel> CustomerProfile_Detail189_Get = CustomerMasterRepository.CustomerProfile_Detail189_Get(code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CustomerProfile_Detail189_Get;
                _ResponseModel.length = CustomerProfile_Detail189_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        //P SOMO

        //start kung add new function (2022/01/14)
        #region Province
        [Route("api/Glb_Province_List_Get")]
        [HttpGet]
        public ResponseModel Province_Get([FromUri] Province_Modal Province_Modal)
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<Province_Modal> Province_Get = CustomerMasterRepository.Province_Get(Province_Modal);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Province_Get;
                _ResponseModel.length = Province_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region Amphur
        [Route("api/Glb_Amphur_List_Get")]
        [HttpGet]
        public ResponseModel Amphur_Get([FromUri] Amphur_Modal Amphur_Modal)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<Amphur_Modal> Amphur_Get = CustomerMasterRepository.Amphur_Get(Amphur_Modal);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Amphur_Get;
                _ResponseModel.length = Amphur_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region District
        [Route("api/Glb_District_List_Get")]
        [HttpGet]
        public ResponseModel District_Get([FromUri] District_Modal District_Modal)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<District_Modal> District_Get = CustomerMasterRepository.District_Get(District_Modal);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = District_Get;
                _ResponseModel.length = District_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        [Route("api/CustomerSetupRouteGet")]
        [HttpGet]
        public ResponseModel Customer_Setup_Route_Get()
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<Lov_Modal> Customer_Setup_Route_Get = CustomerMasterRepository.Customer_Setup_Route_Get();

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Customer_Setup_Route_Get;
                _ResponseModel.length = Customer_Setup_Route_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("api/CustomerSetupSubrouteGet")]
        [HttpGet]
        public ResponseModel Customer_Setup_Subroute_Get(string parent_lov_id)
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<Lov_Modal> Customer_Setup_Subroute_Get = CustomerMasterRepository.Customer_Setup_Subroute_Get(parent_lov_id);

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Customer_Setup_Subroute_Get;
                _ResponseModel.length = Customer_Setup_Subroute_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("api/Priority_Type_Lov_Get")]
        [HttpGet]
        public ResponseModel Priority_Type_Lov_Get()
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<Lov_Modal> Priority_Type_Lov_Get = CustomerMasterRepository.Priority_Type_Lov_Get();
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Priority_Type_Lov_Get;
                _ResponseModel.length = Priority_Type_Lov_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("api/TRP_Vendor_Lov_Get")]
        [HttpGet]
        public ResponseModel TRP_Vendor_Lov_Get()
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<Lov_Modal> TRP_Vendor_Lov_Get = CustomerMasterRepository.TRP_Vendor_Lov_Get();
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = TRP_Vendor_Lov_Get;
                _ResponseModel.length = TRP_Vendor_Lov_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        #region TRP_Vendor_Create
        [Route("api/TRP_Vendor_Create")]
        [HttpPost]
        public ResponseModel TRP_Vendor_Create([FromBody] Devilery_Zone_Model Devilery_Zone_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                CustomerMasterRepository.TRP_Vendor_Create(Devilery_Zone_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region TRP_Vendor_Update
        [Route("api/TRP_Vendor_Update")]
        [HttpPut]
        public ResponseModel TRP_Vendor_Update([FromBody] Devilery_Zone_Model Devilery_Zone_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                CustomerMasterRepository.TRP_Vendor_Update(Devilery_Zone_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region TRP_Vendor_Delete
        [Route("api/TRP_Vendor_Delete")]
        [HttpPut]
        public ResponseModel TRP_Vendor_Delete([FromBody] Devilery_Zone_Model Devilery_Zone_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                CustomerMasterRepository.TRP_Vendor_Delete(Devilery_Zone_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region TRP_Vendor_Get
        [Route("api/TRP_Vendor_Get")]
        [HttpGet]
        public ResponseModel TRP_Vendor_Get([FromUri] Devilery_Zone_Model Devilery_Zone_Model)
        {

            try
            {

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<Devilery_Zone_Model> TRP_Vendor_Get = CustomerMasterRepository.TRP_Vendor_Get(Devilery_Zone_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = TRP_Vendor_Get;
                _ResponseModel.length = TRP_Vendor_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region Customer_TRP_Vendor_Add
        [Route("api/Customer_TRP_Vendor_Add")]
        [HttpPost]
        public ResponseModel Customer_TRP_Vendor_Add([FromBody] Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                CustomerMasterRepository.Customer_TRP_Vendor_Add(Customer_Setup_Trp_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region Customer_TRP_Vendor_Update
        [Route("api/Customer_TRP_Vendor_Update")]
        [HttpPut]
        public ResponseModel Customer_TRP_Vendor_Update([FromBody] Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                CustomerMasterRepository.Customer_TRP_Vendor_Update(Customer_Setup_Trp_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region Customer_TRP_Vendor_Delete
        [Route("api/Customer_TRP_Vendor_Delete")]
        [HttpPut]
        public ResponseModel Customer_TRP_Vendor_Delete([FromBody] Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                CustomerMasterRepository.Customer_TRP_Vendor_Delete(Customer_Setup_Trp_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region Customer_TRP_Vendor_Get
        [Route("api/Customer_TRP_Vendor_Get")]
        [HttpGet]
        public ResponseModel Customer_TRP_Vendor_Get([FromUri] Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
        {

            try
            {

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<Customer_Setup_Trp_Model> Customer_Setup_Trp_Get = CustomerMasterRepository.Customer_TRP_Vendor_Get(Customer_Setup_Trp_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Customer_Setup_Trp_Get;
                _ResponseModel.length = Customer_Setup_Trp_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion
        //end kung add new function (2022/01/14)

        #region Customer_Owner_Create
        [Route("api/Customer_Owner_Create")]
        [HttpPut]
        public ResponseModel Customer_Owner_Create([FromBody] CustomerOwnerModel CustomerOwnerModel)
        {

            try
            {

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<CustomerOwnerModel> Customer_Owner_Create = CustomerMasterRepository.Customer_Owner_Create(CustomerOwnerModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Customer_Owner_Create;
                _ResponseModel.length = Customer_Owner_Create.Count();
                _ResponseModel.status = "Success";


                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region Customer_Owner_Get
        [Route("api/Customer_Owner_Get")]
        [HttpGet]
        public ResponseModel Customer_Owner_Get([FromUri] string item_code)
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<CustomerOwnerModel> Customer_Owner_Get = CustomerMasterRepository.Customer_Owner_Get(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Customer_Owner_Get;
                _ResponseModel.length = Customer_Owner_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion


        #region Customer_BankAccount_Create
        [Route("api/Customer_BankAccount_Create")]
        [HttpPut]
        public ResponseModel Customer_BankAccount_Create([FromBody] CustomerBankAccountModel CustomerBankAccountModel)
        {

            try
            {

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<CustomerBankAccountModel> Customer_BankAccount_Create = CustomerMasterRepository.Customer_BankAccount_Create(CustomerBankAccountModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Customer_BankAccount_Create;
                _ResponseModel.length = Customer_BankAccount_Create.Count();
                _ResponseModel.status = "Success";


                return _ResponseModel;

            }
            catch (Exception ex)
            {

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion

        #region Customer_Owner_Get
        [Route("api/Customer_BankAccount_Get")]
        [HttpGet]
        public ResponseModel Customer_BankAccount_Get([FromUri] string item_code)
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<CustomerBankAccountModel> Customer_BankAccount_Get = CustomerMasterRepository.Customer_BankAccount_Get(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Customer_BankAccount_Get;
                _ResponseModel.length = Customer_BankAccount_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        #endregion
    }
}
