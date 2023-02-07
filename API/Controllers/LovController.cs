using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class ItemMasterLovController : ApiController
    {
        [Route("v1/itemmaster_lov_get")]
        [HttpGet]
        public ResponseModel itemmaster_lov_get([FromUri] string lov_group, string lov_type = "", string lov_code = "")
        {
            try
            {
                ItemMasterLovRepository AccurateRepository = new ItemMasterLovRepository();
                List<LovModel> itemmaster_lov_get = AccurateRepository.itemmaster_lov_get(lov_group, lov_type, lov_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = itemmaster_lov_get;
                _ResponseModel.length = itemmaster_lov_get.Count();
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



        [Route("v1/itemmaster_productdivision_get")]
        [HttpGet]
        public ResponseModel itemmaster_productdivision_get([FromUri] ProductDivisionModel ProductDivisionModel)
        {
            try
            {
                ItemMasterLovRepository ItemMasterLovRepository = new ItemMasterLovRepository();
                List<ProductDivisionModel> itemmaster_productdivision_get = ItemMasterLovRepository.itemmaster_productdivision_get(ProductDivisionModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = itemmaster_productdivision_get;
                _ResponseModel.length = itemmaster_productdivision_get.Count();
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


        [Route("v1/itemmaster_maincategory_get")]
        [HttpGet]
        public ResponseModel itemmaster_maincategory_get([FromUri] MainCategoryModel MainCategoryModel)
        {
            try
            {
                ItemMasterLovRepository ItemMasterLovRepository = new ItemMasterLovRepository();
                List<MainCategoryModel> itemmaster_maincategory_get = ItemMasterLovRepository.itemmaster_maincategory_get(MainCategoryModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = itemmaster_maincategory_get;
                _ResponseModel.length = itemmaster_maincategory_get.Count();
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


        [Route("v1/itemmaster_subcategory_get")]
        [HttpGet]
        public ResponseModel itemmaster_subcategory_get([FromUri] SubCategoryModel SubCategoryModel)
        {
            try
            {
                ItemMasterLovRepository ItemMasterLovRepository = new ItemMasterLovRepository();
                List<SubCategoryModel> itemmaster_subcategory_get = ItemMasterLovRepository.itemmaster_subcategory_get(SubCategoryModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = itemmaster_subcategory_get;
                _ResponseModel.length = itemmaster_subcategory_get.Count();
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

        [Route("v1/gcodea_get")]
        [HttpGet]
        public ResponseModel gcodea_get([FromUri] gcodeaModel gcodeaModel)
        {
            try
            {
                ItemMasterLovRepository ItemMasterLovRepository = new ItemMasterLovRepository();
                List<gcodeaModel> gcodea_get = ItemMasterLovRepository.gcodea_get(gcodeaModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = gcodea_get;
                _ResponseModel.length = gcodea_get.Count();
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

        #region VSK-PROG-ITM-002 :  ItemMaster_gcodea_Select2_Get
        [Route("v1/itemmaster_gcodea_select2_get")]
        [HttpGet]
        public ResponseModel ItemMaster_gcodea_Select2_Get([FromUri] string search = "")
        {
            try
            {
                ItemMasterLovRepository ItemMasterLovRepository = new ItemMasterLovRepository();
                List<gcodeaModel> ACCPayment_ChequeName_Select2_Get = ItemMasterLovRepository.ItemMaster_gcodea_Select2_Get(search);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ACCPayment_ChequeName_Select2_Get;
                _ResponseModel.length = ACCPayment_ChequeName_Select2_Get.Count();
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


        [Route("v1/gcodec_get")]
        [HttpGet]
        public ResponseModel gcodec_get([FromUri] gcodecModel gcodecModel)
        {
            try
            {
                ItemMasterLovRepository ItemMasterLovRepository = new ItemMasterLovRepository();
                List<gcodecModel> gcodec_get = ItemMasterLovRepository.gcodec_get(gcodecModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = gcodec_get;
                _ResponseModel.length = gcodec_get.Count();
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

        [Route("v1/itemmaster_lov_role_get")]
        [HttpGet]
        public ResponseModel itemmaster_lov_role_get([FromUri] string auth_username = "")
        {
            try
            {
                ItemMasterLovRepository AccurateRepository = new ItemMasterLovRepository();
                List<LovModel> itemmaster_lov_role_get = AccurateRepository.itemmaster_lov_role_get(auth_username);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = itemmaster_lov_role_get;
                _ResponseModel.length = itemmaster_lov_role_get.Count();
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
