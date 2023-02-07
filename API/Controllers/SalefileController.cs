using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class SalefileController : ApiController
    {
        [Route("v1/salefile_get")]
        [HttpGet]
        public ResponseModel Salefile_Get_v1([FromUri] SalefileModel SalefileModel)
        {
            try
            {
                SalefileRepository SalefileRepository = new SalefileRepository();
                List<SalefileModel> Salefile_Get = SalefileRepository.Salefile_Get_v1(SalefileModel);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Salefile_Get;
                _ResponseModel.length = Salefile_Get.Count();
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

        [Route("v1/saletra_get")]
        [HttpGet]
        public ResponseModel Saletra_Get_v1([FromUri] SaletraModel SaletraModel)
        {
            try
            {
                SalefileRepository SalefileRepository = new SalefileRepository();
                List<SaletraModel> Saletra_Get = SalefileRepository.Saletra_Get_v1(SaletraModel);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Saletra_Get;
                _ResponseModel.length = Saletra_Get.Count();
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
