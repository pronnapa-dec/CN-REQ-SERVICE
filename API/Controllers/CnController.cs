using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class CnController : ApiController
    {

        #region Cn_Pre_Job_Create
        [Route("v1/Cn_Pre_Job_Create")]
        [HttpPut]
        public ResponseModel Cn_Pre_Job_Create([FromBody] CnModel CnModel)
        {

            try
            {
               //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CnRepository CnRepository = new CnRepository();

                CnRepository.Cn_Pre_Job_Create(CnModel);

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

        #region Cn_Pre_Job_Detail_Create
        [Route("v1/Cn_Pre_Job_Detail_Create")]
        [HttpPut]
        public ResponseModel Cn_Pre_Job_Detail_Create([FromBody] Cn_HistoryModel Cn_HistoryModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CnRepository CnRepository = new CnRepository();

                CnRepository.Cn_Pre_Job_Detail_Create(Cn_HistoryModel);

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

        #region Cn_Pre_Job_Get
        [Route("v1/Cn_Pre_Job_Get")]
        [HttpGet]
        public ResponseModel Cn_Pre_Job_Get([FromUri] CnModel CnModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnRepository CnRepository = new CnRepository();

                List<CnModel> Cn_Pre_Job_Get = CnRepository.Cn_Pre_Job_Get(CnModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Pre_Job_Get;
                _ResponseModel.length = Cn_Pre_Job_Get.Count();
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

        #region Cn_Pre_Job_Detail_Get
        [Route("v1/Cn_Pre_Job_Detail_Get")]
        [HttpGet]
        public ResponseModel Cn_Pre_Job_Detail_Get([FromUri] Cn_HistoryModel Cn_HistoryModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnRepository CnRepository = new CnRepository();

                List<Cn_HistoryModel> Cn_Pre_Job_Detail_Get = CnRepository.Cn_Pre_Job_Detail_Get(Cn_HistoryModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Pre_Job_Detail_Get;
                _ResponseModel.length = Cn_Pre_Job_Detail_Get.Count();
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

        #region BF_Cn_On_Job_Get
        [Route("v1/BF_Cn_On_Job_Get")]
        [HttpGet]
        public ResponseModel BF_Cn_On_Job_Get([FromUri] CnOnjobGet CnOnjobGet)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnRepository CnRepository = new CnRepository();

                List<CnOnjobGet> BF_Cn_On_Job_Get = CnRepository.BF_Cn_On_Job_Get(CnOnjobGet);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = BF_Cn_On_Job_Get;
                _ResponseModel.length = BF_Cn_On_Job_Get.Count();
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

        #region Cn_Job_Create
        [Route("v1/Cn_Job_Create")]
        [HttpPut]
        public ResponseModel Cn_Job_Create([FromBody] CnOnjob CnOnjob)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CnRepository CnRepository = new CnRepository();

                CnRepository.Cn_Job_Create(CnOnjob);

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

        #region Cn_On_Job_Get
        [Route("v1/Cn_On_Job_Get")]
        [HttpGet]
        public ResponseModel Cn_On_Job_Get([FromUri] CnOnjob CnOnjob)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnRepository CnRepository = new CnRepository();

                List<CnOnjob> Cn_On_Job_Get = CnRepository.Cn_On_Job_Get(CnOnjob);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_On_Job_Get;
                _ResponseModel.length = Cn_On_Job_Get.Count();
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

        #region Cn_On_Job_Detail_Get
        [Route("v1/Cn_On_Job_Detail_Get")]
        [HttpGet]
        public ResponseModel Cn_On_Job_Detail_Get([FromUri] CnOnjob_His CnOnjob_His)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnRepository CnRepository = new CnRepository();

                List<CnOnjob_His> Cn_On_Job_Detail_Get = CnRepository.Cn_On_Job_Detail_Get(CnOnjob_His);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_On_Job_Detail_Get;
                _ResponseModel.length = Cn_On_Job_Detail_Get.Count();
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

        #region Cn_On_Job_Detail_Create
        [Route("v1/Cn_On_Job_Detail_Create")]
        [HttpPut]
        public ResponseModel Cn_On_Job_Detail_Create([FromBody] CnOnjob_His CnOnjob_His)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CnRepository CnRepository = new CnRepository();

                CnRepository.Cn_On_Job_Detail_Create(CnOnjob_His);

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

        #region Cn_Lov_Get
        [Route("v1/Cn_Lov_Get")]
        [HttpGet]
        public ResponseModel Cn_Lov_Get([FromUri] Cn_Lov Cn_Lov)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnRepository CnRepository = new CnRepository();

                List<Cn_Lov> Cn_Lov_Get = CnRepository.Cn_Lov_Get(Cn_Lov);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Lov_Get;
                _ResponseModel.length = Cn_Lov_Get.Count();
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

        #region Cn_On_Job_Claim_Get
        [Route("v1/Cn_On_Job_Claim_Get")]
        [HttpGet]
        public ResponseModel Cn_On_Job_Claim_Get([FromUri] CnOnjob CnOnjob)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnRepository CnRepository = new CnRepository();

                List<CnOnjob> Cn_On_Job_Claim_Get = CnRepository.Cn_On_Job_Claim_Get(CnOnjob);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_On_Job_Claim_Get;
                _ResponseModel.length = Cn_On_Job_Claim_Get.Count();
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

        #region Cn_On_Job_EO_Get
        [Route("v1/Cn_On_Job_EO_Get")]
        [HttpGet]
        public ResponseModel Cn_On_Job_EO_Get([FromUri] CnOnjob CnOnjob)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnRepository CnRepository = new CnRepository();

                List<CnOnjob> Cn_On_Job_Claim_Get = CnRepository.Cn_On_Job_EO_Get(CnOnjob);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_On_Job_Claim_Get;
                _ResponseModel.length = Cn_On_Job_Claim_Get.Count();
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
