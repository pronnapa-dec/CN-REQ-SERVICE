using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    public class GoodpriceController : ApiController
    {
        [Route("api/Goodprice_Get")]
        [HttpGet]
        public ResponseModel Goodprice_Get([FromUri]string item_code)
        {
            try
            {
                GoodpriceRepository AccurateRepository = new GoodpriceRepository();
                List<GoodpriceModel> Goodprice_Get = AccurateRepository.Goodprice_Get(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Goodprice_Get;
                _ResponseModel.length = Goodprice_Get.Count();
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
