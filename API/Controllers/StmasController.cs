using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    public class StmasController : ApiController
    {
        [Route("api/Stmas_Get")]
        [HttpGet]
        public ResponseModel Stmas_Get([FromUri]string item_code)
        {
            try
            {
                StmasRepository AccurateRepository = new StmasRepository();
                List<StmasModel> Stmas_Get = AccurateRepository.Stmas_Get(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Stmas_Get;
                _ResponseModel.length = Stmas_Get.Count();
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
