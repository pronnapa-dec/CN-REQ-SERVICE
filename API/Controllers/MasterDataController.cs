using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class MasterDataController : ApiController
    {

        [Route("v1/masterdata_customer_list_get")]
        [HttpGet]
        public ResponseModel MasterData_Customer_List_Get([FromUri] EmmasModel EmmasModel)
        {
            try
            {
                MasterDataRepository MasterDataRepository = new MasterDataRepository();
                List<EmmasModel> MasterData_Customer_List_Get = MasterDataRepository.MasterData_Customer_List_Get(EmmasModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MasterData_Customer_List_Get;
                _ResponseModel.length = MasterData_Customer_List_Get.Count();
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
