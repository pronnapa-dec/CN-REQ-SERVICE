using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{

    public class LogController : ApiController
    {
        [Route("v1/log_import_updatedata_list_get")]
        [HttpGet]
        public ResponseModel log_import_updatedata_list_get([FromUri] string username)
        {
            try
            {
                LogRepository LogRepository = new LogRepository();
                List<ImportUpdateDataModel> log_import_updatedata_list_get = LogRepository.log_import_updatedata_list_get(username);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = log_import_updatedata_list_get;
                _ResponseModel.length = log_import_updatedata_list_get.Count();
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


        [Route("v1/log_import_commonprice_list_get")]
        [HttpGet]
        public ResponseModel log_import_commonprice_list_get([FromUri] string username)
        {
            try
            {
                LogRepository LogRepository = new LogRepository();
                List<ImportCommonPriceModel> log_import_commonprice_list_get = LogRepository.log_import_commonprice_list_get(username);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = log_import_commonprice_list_get;
                _ResponseModel.length = log_import_commonprice_list_get.Count();
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
