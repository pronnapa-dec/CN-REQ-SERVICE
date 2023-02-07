using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class PurController : ApiController
    {
        // GET: api/PurPod_Get
        [Route("api/PR_POD_IV_GR_bySale")]
        [HttpGet]
        public ResponseModel PR_POD_IV_GR_bySale([FromUri] PkPoIVModel PkPoIVModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PurRepository PurRepository = new PurRepository();

                List<PkPoIVModel> PR_POD_IV_GR_bySale = PurRepository.PR_POD_IV_GR_bySale(PkPoIVModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PR_POD_IV_GR_bySale;
                _ResponseModel.length = PR_POD_IV_GR_bySale.Count();
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

        // GET: api/PurPod_Get
        [Route("api/PK_PO_IV_bySale_Get")]
        [HttpGet]
        public ResponseModel PK_PO_IV_bySale_Get([FromUri] PkPoIVModel PkPoIVModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PurRepository PurRepository = new PurRepository();

                List<PkPoIVModel> PK_PO_IV_bySale_Get = PurRepository.PK_PO_IV_bySale_Get(PkPoIVModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PK_PO_IV_bySale_Get;
                _ResponseModel.length = PK_PO_IV_bySale_Get.Count();
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



        [Route("api/PK_PO_IV_bySale_Update")]
        [HttpPut]
        public ResponseModel PK_PO_IV_bySale_Update([FromBody] PkPoIVModel PkPoIVModel)
        {

            try
            {
               //  CultureInfo cultureinfo = new CultureInfo("en-US");

                PurRepository PurRepository = new PurRepository();

                PurRepository.PK_PO_IV_bySale_Update(PkPoIVModel);

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
    }
}
