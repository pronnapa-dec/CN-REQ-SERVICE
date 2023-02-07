using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    public class PurPlanController : ApiController
    {
        // GET: api/PurPlan
        [Route("api/PurPlan_Get")]
        [HttpGet]
        public ResponseModel PurPlan_Get([FromUri]PurPlanModel PurPlanModel)
        {

            try
            {
                PurPlanRepository PurPlanRepository = new PurPlanRepository();

                List<PurPlanModel> PurPlan_Get = PurPlanRepository.PurPlan_Get(PurPlanModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PurPlan_Get;
                _ResponseModel.length = PurPlan_Get.Count();
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

        // GET: api/PurPlan
        [Route("api/InventoryCode_Get")]
        [HttpGet]
        public ResponseModel InventoryCode_Get()
        {
            try
            {
                PurPlanRepository PurPlanRepository = new PurPlanRepository();

                List<InventoryCodeModel> InventoryCode_Get = PurPlanRepository.InventoryCode_Get();

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = InventoryCode_Get;
                _ResponseModel.length = InventoryCode_Get.Count();
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

        // GET: api/PurPlan
        [Route("api/InvfreCode_Get")]
        [HttpGet]
        public ResponseModel InvfreCode_Get()
        {
            try
            {
                PurPlanRepository PurPlanRepository = new PurPlanRepository();

                List<InvfreCodeModel> InvfreCode_Get = PurPlanRepository.InvfreCode_Get();

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = InvfreCode_Get;
                _ResponseModel.length = InvfreCode_Get.Count();
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

        /*
        // GET: api/Product_PurPlan_Stock_Factor_Get
        [Route("api/Product_PurPlan_Stock_Factor_Get")]
        [HttpGet]
        public ResponseModel Product_PurPlan_Stock_Factor_Get(string item_code)
        {
            try
            {
                PurPlanRepository PurPlanRepository = new PurPlanRepository();

                List<PurPlanModel> Product_PurPlan_Stock_Factor_Get = PurPlanRepository.Product_PurPlan_Stock_Factor_Get(item_code);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Product_PurPlan_Stock_Factor_Get;
                _ResponseModel.length = Product_PurPlan_Stock_Factor_Get.Count();
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
        */
    }
}
