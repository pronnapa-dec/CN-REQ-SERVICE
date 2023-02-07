using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace API.Controllers
{
    public class IVCController : ApiController
    {
        #region Zone_Get
        [Route("v1/Zone_Get")]
        [HttpGet]
        public ResponseModel Zone_Get([FromUri] Zone_Model Zone_Model)
        {

            try
            {

                IVCRepository IVCRepository = new IVCRepository();

                List<Zone_Model> Zone_Get = IVCRepository.Zone_Get(Zone_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Zone_Get;
                _ResponseModel.length = Zone_Get.Count();
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

        #region Route_Get
        [Route("v1/Route_Get")]
        [HttpGet]
        public ResponseModel Route_Get([FromUri] Zone_Model Zone_Model)
        {

            try
            {

                IVCRepository IVCRepository = new IVCRepository();

                List<Zone_Model> Route_Get = IVCRepository.Route_Get(Zone_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Route_Get;
                _ResponseModel.length = Route_Get.Count();
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

        #region Create_Delivery_Zone
        [Route("v1/Create_Delivery_Zone")]
        [HttpPost]
        public ResponseModel Create_Delivery_Zone([FromBody] Devilery_Zone_Model Devilery_Zone_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Create_Delivery_Zone(Devilery_Zone_Model);

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

        #region Delivery_Zone_Get
        [Route("v1/Delivery_Zone_Get")]
        [HttpGet]
        public ResponseModel Delivery_Zone_Get([FromUri] Devilery_Zone_Model Devilery_Zone_Model)
        {

            try
            {

                IVCRepository IVCRepository = new IVCRepository();

                List<Devilery_Zone_Model> Delivery_Zone_Get = IVCRepository.Delivery_Zone_Get(Devilery_Zone_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Delivery_Zone_Get;
                _ResponseModel.length = Delivery_Zone_Get.Count();
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

        #region Delivery_Zone_Update
        [Route("v1/Delivery_Zone_Update")]
        [HttpPut]
        public ResponseModel Delivery_Zone_Update([FromBody] Devilery_Zone_Model Devilery_Zone_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Delivery_Zone_Update(Devilery_Zone_Model);

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

        #region Delivery_Zone_Delete
        [Route("v1/Delivery_Zone_Delete")]
        [HttpPut]
        public ResponseModel Delivery_Zone_Delete([FromBody] Devilery_Zone_Delete_Model Devilery_Zone_Delete_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Delivery_Zone_Delete(Devilery_Zone_Delete_Model);

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

        #region Customer_Setup_Add
        [Route("v1/Customer_Setup_Add")]
        [HttpPost]
        public ResponseModel Customer_Setup_Add([FromBody] Customer_Setup_Model Customer_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Customer_Setup_Add(Customer_Model);

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

        #region Customer_Setup_Get
        [Route("v1/Customer_Setup_Get")]
        [HttpGet]
        public ResponseModel Customer_Setup_Get([FromUri] Customer_Setup_Model Customer_Setup_Model)
        {

            try
            {

                IVCRepository IVCRepository = new IVCRepository();

                List<Customer_Setup_Model> Delivery_Zone_Get = IVCRepository.Customer_Setup_Get(Customer_Setup_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Delivery_Zone_Get;
                _ResponseModel.length = Delivery_Zone_Get.Count();
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

        #region Customer_Setup_Delete
        [Route("v1/Customer_Setup_Delete")]
        [HttpPut]
        public ResponseModel Customer_Setup_Delete([FromBody] Customer_Setup_Model Customer_Setup_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Customer_Setup_Delete(Customer_Setup_Model);

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

        #region Customer_Setup_Trp_Add
        [Route("v1/Customer_Setup_Trp_Add")]
        [HttpPost]
        public ResponseModel Customer_Setup_Trp_Add([FromBody] Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Customer_Setup_Trp_Add(Customer_Setup_Trp_Model);

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

        #region Customer_Setup_Trp_Get
        [Route("v1/Customer_Setup_Trp_Get")]
        [HttpGet]
        public ResponseModel Customer_Setup_Trp_Get([FromUri] Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
        {

            try
            {

                IVCRepository IVCRepository = new IVCRepository();

                List<Customer_Setup_Trp_Model> Customer_Setup_Trp_Get = IVCRepository.Customer_Setup_Trp_Get(Customer_Setup_Trp_Model);

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

        #region Customer_Setup_Update
        [Route("v1/Customer_Setup_Update")]
        [HttpPut]
        public ResponseModel Customer_Setup_Update([FromBody] Customer_Setup_Model Customer_Setup_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Customer_Setup_Update(Customer_Setup_Model);

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

        #region Customer_Setup_Trp_Update
        [Route("v1/Customer_Setup_Trp_Update")]
        [HttpPut]
        public ResponseModel Customer_Setup_Trp_Update([FromBody] Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Customer_Setup_Trp_Update(Customer_Setup_Trp_Model);

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

        #region Customer_Setup_Trp_Delete
        [Route("v1/Customer_Setup_Trp_Delete")]
        [HttpPut]
        public ResponseModel Customer_Setup_Trp_Delete([FromBody] Customer_Setup_Trp_Model Customer_Setup_Trp_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Customer_Setup_Trp_Delete(Customer_Setup_Trp_Model);

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

        #region Packing_Job_Add
        [Route("v1/Packing_Job_Add")]
        [HttpPost]
        public ResponseModel Packing_Job_Add([FromBody] Packing_Job_Model Packing_Job_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Packing_Job_Add(Packing_Job_Model);

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

        #region Packing_Job_Get
        [Route("v1/Packing_Job_Get")]
        [HttpGet]
        public ResponseModel Packing_Job_Get([FromUri] Packing_Job_Model Packing_Job_Model)
        {

            try
            {

                IVCRepository IVCRepository = new IVCRepository();

                List<Packing_Job_Model> Packing_Job_Get = IVCRepository.Packing_Job_Get(Packing_Job_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Packing_Job_Get;
                _ResponseModel.length = Packing_Job_Get.Count();
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

        #region Packing_Job_Update
        [Route("v1/Packing_Job_Update")]
        [HttpPut]
        public ResponseModel Packing_Job_Update([FromBody] Packing_Job_Update_Model Packing_Job_Update_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Packing_Job_Update(Packing_Job_Update_Model);

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
        
        #region Packing_Job_Delete
        [Route("v1/Packing_Job_Delete")]
        [HttpPut]
        public ResponseModel Packing_Job_Delete([FromBody] Packing_Job_Delete_Model Packing_Job_Delete_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Packing_Job_Delete(Packing_Job_Delete_Model);

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

        #region Packing_Job_Box_Get
        [Route("v1/Packing_Job_Box_Get")]
        [HttpGet]
        public ResponseModel Packing_Job_Box_Get([FromUri] Box_Modal Box_Modal)
        {

            try
            {

                IVCRepository IVCRepository = new IVCRepository();

                List<Box_Modal> Packing_Job_Box_Get = IVCRepository.Packing_Job_Box_Get(Box_Modal);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Packing_Job_Box_Get;
                _ResponseModel.length = Packing_Job_Box_Get.Count();
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

        #region Packing_Job_Box_Add
        [Route("v1/Packing_Job_Box_Add")]
        [HttpPost]
        public ResponseModel Packing_Job_Box_Add([FromBody] Box_Modal Box_Modal)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Packing_Job_Box_Add(Box_Modal);

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

        #region Packing_Job_Chk
        [Route("v1/Packing_Job_Chk")]
        [HttpGet]
        public ResponseModel Packing_Job_Chk([FromUri] Packing_Job_Invoice_Model Packing_Job_Invoice_Model)
        {

            try
            {

                IVCRepository IVCRepository = new IVCRepository();

                List<Packing_Job_Invoice_Model> Packing_Job_Get = IVCRepository.Packing_Job_Chk(Packing_Job_Invoice_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Packing_Job_Get;
                _ResponseModel.length = Packing_Job_Get.Count();
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

        #region Packing_Job_Invoice_Get
        [Route("v1/Packing_Job_Invoice_Get")]
        [HttpGet]
        public ResponseModel Packing_Job_Invoice_Get([FromUri] Packing_Job_Invoice_Model Packing_Job_Invoice_Model)
        {

            try
            {

                IVCRepository IVCRepository = new IVCRepository();

                List<Packing_Job_Invoice_Model> Packing_Job_Invoice_Get = IVCRepository.Packing_Job_Invoice_Get(Packing_Job_Invoice_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Packing_Job_Invoice_Get;
                _ResponseModel.length = Packing_Job_Invoice_Get.Count();
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

        #region Packing_Job_List
        [Route("v1/Packing_Job_List")]
        [HttpGet]
        public ResponseModel Packing_Job_List([FromUri] Packing_Job_Model Packing_Job_Model)
        {

            try
            {

                IVCRepository IVCRepository = new IVCRepository();

                List<Packing_Job_Model> Packing_Job_List = IVCRepository.Packing_Job_List(Packing_Job_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Packing_Job_List;
                _ResponseModel.length = Packing_Job_List.Count();
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

        #region Packing_Job_Invoice_Add
        [Route("v1/Packing_Job_Invoice_Add")]
        [HttpPost]
        public ResponseModel Packing_Job_Invoice_Add([FromBody] Packing_Job_Invoice_Model Packing_Job_Invoice_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Packing_Job_Invoice_Add(Packing_Job_Invoice_Model);

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

        #region Packing_Job_Invoice_Update
        [Route("v1/Packing_Job_Invoice_Update")]
        [HttpPost]
        public ResponseModel Packing_Job_Invoice_Update([FromBody] Packing_Job_Invoice_Model Packing_Job_Invoice_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Packing_Job_Invoice_Update(Packing_Job_Invoice_Model);

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

        #region  
        [Route("v1/Packing_Job_Invoice_Delete")]
        [HttpPost]
        public ResponseModel Packing_Job_Invoice_Delete([FromBody] Packing_Job_Invoice_Model Packing_Job_Invoice_Model)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                IVCRepository IVCRepository = new IVCRepository();

                IVCRepository.Packing_Job_Invoice_Delete(Packing_Job_Invoice_Model);

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

    }
}
