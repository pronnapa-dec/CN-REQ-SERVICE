using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace API.Controllers
{
    public class TRPController : ApiController
    {
        [Route("v1/TRP_TMS_Sync_Add")]
        [HttpPost]
        public ResponseModel TRP_TMS_Sync_Add(List<TMS_JOBModel> TMS_JOBModel)
        {
            try
            {
                TRPRepository TRPRepository = new TRPRepository();

                TRPRepository.TRP_TMS_Sync_Delete();

                List<TMS_JOBModel> TMS_JOBModelList = new List<TMS_JOBModel>();

                foreach (var TMS_JOBItem in TMS_JOBModel)
                {
                    TMS_JOBModel TMS_JOBModel_data = new TMS_JOBModel();

                    TMS_JOBModel_data.tms_job_date = TMS_JOBItem.tms_job_date;
                    TMS_JOBModel_data.tms_job_route = TMS_JOBItem.tms_job_route;
                    TMS_JOBModel_data.tms_job_plate = TMS_JOBItem.tms_job_plate;
                    TMS_JOBModel_data.tms_job_name = TMS_JOBItem.tms_job_name;
                    TMS_JOBModel_data.tms_job_no = TMS_JOBItem.tms_job_no;
                    TMS_JOBModel_data.tms_job_cus_name = TMS_JOBItem.tms_job_cus_name;
                    TMS_JOBModel_data.tms_job_created_date = TMS_JOBItem.tms_job_created_date;
                    TMS_JOBModel_data.tms_job_delivery_date = TMS_JOBItem.tms_job_delivery_date;

                    TMS_JOBModelList.Add(TMS_JOBModel_data);

                }

                TRPRepository.TRP_TMS_Sync_Add(TMS_JOBModelList);

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

        [Route("v1/trp_salefile_get")]
        [HttpGet]
        public ResponseModel TRP_Salefile_GET([FromUri] string number)
        {
            try
            {
                TRPRepository TRPRepository = new TRPRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<SalefileModel> TRP_Salefile_GET = TRPRepository.TRP_Salefile_GET(number);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = TRP_Salefile_GET;
                _ResponseModel.length = TRP_Salefile_GET.Count();
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

        [Route("v1/trp_tms_job_add")]
        [HttpPut]
        public ResponseModel TRP_TMS_JOB_Add([FromBody] TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {

            try
            {

                TRPRepository TRPRepository = new TRPRepository();

                TRPRepository.TRP_TMS_JOB_Add(TMS_JOB_ITEMModel);

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

        [Route("v1/trp_tms_job_upload_add")]
        [HttpPut]
        public ResponseModel TRP_TMS_JOB_Upload_Add([FromBody] TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {

            try
            {

                TRPRepository TRPRepository = new TRPRepository();

                TRPRepository.TRP_TMS_JOB_Upload_Add(TMS_JOB_ITEMModel);

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

        [Route("v1/trp_tms_job_express_add")]
        [HttpPut]
        public ResponseModel TRP_TMS_JOB_EXPRESS_Add([FromBody] TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {

            try
            {

                TRPRepository TRPRepository = new TRPRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<TMS_JOB_EXPORTModel> TRP_TMS_JOB_EXPRESS_Add = TRPRepository.TRP_TMS_JOB_EXPRESS_Add(TMS_JOB_ITEMModel);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = TRP_TMS_JOB_EXPRESS_Add;
                _ResponseModel.length = TRP_TMS_JOB_EXPRESS_Add.Count();
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

        [Route("v1/trp_tms_job_get")]
        [HttpGet]
        public ResponseModel TMS_Job_Item_Get([FromUri] TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                TRPRepository TRPRepository = new TRPRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<TMS_JOB_EXPORTModel> TMS_Job_Item_Get = TRPRepository.TMS_Job_Item_Get(TMS_JOB_ITEMModel);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = TMS_Job_Item_Get;
                _ResponseModel.length = TMS_Job_Item_Get.Count();
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

        [Route("v1/trp_tms_job_list")]
        [HttpGet]
        public ResponseModel TMS_Job_Item_List([FromUri] TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                TRPRepository TRPRepository = new TRPRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<TMS_JOB_ITEMModel> TMS_Job_Item_List = TRPRepository.TMS_Job_Item_List(TMS_JOB_ITEMModel);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = TMS_Job_Item_List;
                _ResponseModel.length = TMS_Job_Item_List.Count();
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

        [Route("v1/trp_tms_job_express_list")]
        [HttpGet]
        public ResponseModel TMS_Job_Express_Item_List([FromUri] TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                TRPRepository TRPRepository = new TRPRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<TMS_JOB_ITEMModel> TMS_Job_Express_Item_List = TRPRepository.TMS_Job_Express_Item_List(TMS_JOB_ITEMModel);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = TMS_Job_Express_Item_List;
                _ResponseModel.length = TMS_Job_Express_Item_List.Count();
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

        [Route("v1/trp_tms_job_route_search")]
        [HttpGet]
        public ResponseModel TMS_Job_Route_Search([FromUri] TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                TRPRepository TRPRepository = new TRPRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<TMS_JOB_ITEMModel> TMS_Job_Route_Search = TRPRepository.TMS_Job_Route_Search(TMS_JOB_ITEMModel);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = TMS_Job_Route_Search;
                _ResponseModel.length = TMS_Job_Route_Search.Count();
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

        [Route("v1/trp_tms_job_search")]
        [HttpGet]
        public ResponseModel TMS_Job_Search([FromUri] TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                TRPRepository TRPRepository = new TRPRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<TMS_JOB_ITEMModel> TMS_Job_Search = TRPRepository.TMS_Job_Search(TMS_JOB_ITEMModel);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = TMS_Job_Search;
                _ResponseModel.length = TMS_Job_Search.Count();
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

        [Route("v1/trp_tms_job_express_sync_get")]
        [HttpGet]
        public ResponseModel TMS_Job_Express_Item_Sync_Get()
        {
            try
            {
                TRPRepository TRPRepository = new TRPRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<TMS_JOB_ITEMModel> TMS_Job_Express_Item_Sync_Get = TRPRepository.TMS_Job_Express_Item_Sync_Get();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = TMS_Job_Express_Item_Sync_Get;
                _ResponseModel.length = TMS_Job_Express_Item_Sync_Get.Count();
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

        [Route("v1/trp_tms_job_express_sync_add")]
        [HttpPost]
        public ResponseModel TMS_Job_Express_Item_Sync_Add(List<TMS_JOB_IMPORTModel> TMS_JOB_IMPORTModel)
        {
            try
            {
                TRPRepository TRPRepository = new TRPRepository();

               // List<TMS_JOB_IMPORTModel> TMS_JOB_IMPORTList = new List<TMS_JOB_IMPORTModel>();            

                TRPRepository.TMS_Job_Express_Item_Sync_Add(TMS_JOB_IMPORTModel);

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

        [Route("v1/trp_tms_job_express_ppt_sync_add")]
        [HttpPost]
        public ResponseModel TMS_Job_Express_PPT_Sync_Add(List<TMS_JOB_IMPORTModel> TMS_JOB_IMPORTModel)
        {
            try
            {
                TRPRepository TRPRepository = new TRPRepository();

                // List<TMS_JOB_IMPORTModel> TMS_JOB_IMPORTList = new List<TMS_JOB_IMPORTModel>();            

                TRPRepository.TMS_Job_Express_PPT_Sync_Add(TMS_JOB_IMPORTModel);

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

        [Route("v1/trp_tms_job_pktotms_search")]
        [HttpGet]
        public ResponseModel TMS_Job_PKToTMS_Search([FromUri] string job_start_date, string job_end_date, double toption, string mode)
        {
            try
            {
                TRPRepository TRPRepository = new TRPRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<PKToTMSModel> TMS_Job_PKToTMS_Search = TRPRepository.TMS_Job_PKToTMS_Search(job_start_date, job_end_date, toption, mode);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = TMS_Job_PKToTMS_Search;
                _ResponseModel.length = TMS_Job_PKToTMS_Search.Count();
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

    }
}
