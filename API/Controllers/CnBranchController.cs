using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class CnBranchController : ApiController
    {
        #region Cn_Branch_Item_Get
        [Route("v1/Cn_Branch_Item_Get")]
        [HttpGet]
        public ResponseModel Cn_Branch_Item_Get([FromUri] string branch_id, string item_master)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRepository CnBranchRepository = new CnBranchRepository();

                List<stmas_modal> Cn_Branch_Item_Get = CnBranchRepository.Cn_Branch_Item_Get(branch_id,item_master);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_Item_Get;
                _ResponseModel.length = Cn_Branch_Item_Get.Count();
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

        #region Cn_Branch_Emmas_Get
        [Route("v1/Cn_Branch_Emmas_Get")]
        [HttpGet]
        public ResponseModel Cn_Branch_Emmas_Get([FromUri] string branch_id, string emmas)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRepository CnBranchRepository = new CnBranchRepository();

                List<emmas_modal> Cn_Branch_Emmas_Get = CnBranchRepository.Cn_Branch_Emmas_Get(branch_id, emmas);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_Emmas_Get;
                _ResponseModel.length = Cn_Branch_Emmas_Get.Count();
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

        #region Cn_Branch_Salefile_Get
        [Route("v1/salefile_get")]
        [HttpGet]
        public ResponseModel Cn_Branch_salefile_Get([FromUri] string branch_id, string number)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRepository CnBranchRepository = new CnBranchRepository();

                List<salefile_modal> Cn_Branch_salefile_Get = CnBranchRepository.Cn_Branch_salefile_Get(branch_id, number);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_salefile_Get;
                _ResponseModel.length = Cn_Branch_salefile_Get.Count();
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

        #region Cn_Branch_Saletra_Get
        [Route("v1/saletra_get")]
        [HttpGet]
        public ResponseModel Cn_Branch_saletra_Get([FromUri] string branch_id, string number)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRepository CnBranchRepository = new CnBranchRepository();

                List<saletra_modal> Cn_Branch_saletra_Get = CnBranchRepository.Cn_Branch_saletra_Get(branch_id, number);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_saletra_Get;
                _ResponseModel.length = Cn_Branch_saletra_Get.Count();
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

        #region Cn_Pre_Job_Create
        [Route("v1/Cn_Branch_Pre_Job_Create")]
        [HttpPut]
        public ResponseModel Cn_Branch_Pre_Job_Create([FromBody] CnBranchModel CnBranchModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRepository CnBranchRepository = new CnBranchRepository();

                CnBranchRepository.Cn_Branch_Pre_Job_Create(CnBranchModel);

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
        [Route("v1/Cn_Branch_Pre_Job_Get")]
        [HttpGet]
        public ResponseModel Cn_Branch_Pre_Job_Get([FromUri] CnBranchModel CnBranchModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRepository CnBranchRepository = new CnBranchRepository();

                List<CnBranchModel> Cn_Branch_Pre_Job_Get = CnBranchRepository.Cn_Branch_Pre_Job_Get(CnBranchModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_Pre_Job_Get;
                _ResponseModel.length = Cn_Branch_Pre_Job_Get.Count();
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

        #region Cn_Branch_Lov_Get
        [Route("v1/Cn_Branch_Lov_Get")]
        [HttpGet]
        public ResponseModel Cn_Branch_Lov_Get([FromUri] CnBranch_Lov CnBranch_Lov)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRepository CnBranchRepository = new CnBranchRepository();

                List<CnBranch_Lov> Cn_Branch_Lov_Get = CnBranchRepository.Cn_Branch_Lov_Get(CnBranch_Lov);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_Lov_Get;
                _ResponseModel.length = Cn_Branch_Lov_Get.Count();
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

        #region Cn_Branch_Pre_Job_Detail_Get
        [Route("v1/Cn_Branch_Pre_Job_Detail_Get")]
        [HttpGet]
        public ResponseModel Cn_Branch_Pre_Job_Detail_Get([FromUri] CnBranch_HistoryModel CnBranch_HistoryModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRepository CnBranchRepository = new CnBranchRepository();

                List<CnBranch_HistoryModel> Cn_Branch_Pre_Job_Detail_Get = CnBranchRepository.Cn_Branch_Pre_Job_Detail_Get(CnBranch_HistoryModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_Pre_Job_Detail_Get;
                _ResponseModel.length = Cn_Branch_Pre_Job_Detail_Get.Count();
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

        #region Cn_Branch_Pre_Job_Detail_Create
        [Route("v1/Cn_Branch_Pre_Job_Detail_Create")]
        [HttpPut]
        public ResponseModel Cn_Branch_Pre_Job_Detail_Create([FromBody] CnBranch_HistoryModel CnBranch_HistoryModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRepository CnBranchRepository = new CnBranchRepository();

                CnBranchRepository.Cn_Branch_Pre_Job_Detail_Create(CnBranch_HistoryModel);

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
    }
}
