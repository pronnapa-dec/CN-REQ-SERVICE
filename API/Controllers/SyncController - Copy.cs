using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    public class SamasController : ApiController
    {
        #region SaleMasterGet
        [Route("v1/SaleMasterGet")]
        [HttpGet]
        public ResponseModel Sale_Master_Get([FromUri] SamasModal SamasModal)
        {
            try
            {
                SamasRepository SamasRepository = new SamasRepository();
                List<SamasModal> Sale_Master_Get = SamasRepository.Sale_Master_Get(SamasModal);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Sale_Master_Get;
                _ResponseModel.length = Sale_Master_Get.Count();
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

        #region SaleMasterGet
        [Route("v1/SaleGroupGet")]
        [HttpGet]
        public ResponseModel SaleGroup_Get([FromUri] string Mode, string code)
        {
            try
            {
                SamasRepository SamasRepository = new SamasRepository();
                List<SamasModal> SaleGroup_Get = SamasRepository.SaleGroup_Get(Mode, code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = SaleGroup_Get;
                _ResponseModel.length = SaleGroup_Get.Count();
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

        #region sale_branch_get
        [Route("v1/SaleBranchGet")]
        [HttpGet]
        public ResponseModel sale_branch_get()
        {
            try
            {
                SamasRepository SamasRepository = new SamasRepository();

                List<SalebranchModal> sale_branch_get = SamasRepository.sale_branch_get();

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = sale_branch_get;
                _ResponseModel.length = sale_branch_get.Count();
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

        #region SaleMasterCreate
        [Route("v1/SaleMasterCreate")]
        [HttpPost]
        public ResponseModel Sale_Master_create([FromBody] SamasModal SamasModal)
        {
            try
            {

                SamasRepository SamasRepository = new SamasRepository();
                List<sa_Ressale_Model> Sale_Master_create = SamasRepository.Sale_Master_create(SamasModal);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Sale_Master_create;
                _ResponseModel.length = Sale_Master_create.Count();
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

        #region SaleMasterUpdate
        [Route("v1/SaleMasterUpdate")]
        [HttpPost]
        public ResponseModel Sale_Master_Update([FromBody] SamasModal SamasModal)
        {
            try
            {

                SamasRepository SamasRepository = new SamasRepository();
                List<SamasModal> Sale_Master_Update = SamasRepository.Sale_Master_Update(SamasModal);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Sale_Master_Update;
                _ResponseModel.length = Sale_Master_Update.Count();
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
