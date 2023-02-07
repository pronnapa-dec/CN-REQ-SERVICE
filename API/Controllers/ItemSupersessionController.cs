using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class ItemSupersessionController : ApiController
    {
        #region Item_SS_Head_Get
        [Route("v1/item_suppersession_Head_Get")]
        [HttpGet]
        public ResponseModel Item_SS_Head_Get([FromUri] ItemSS_search_Modal ItemSS_search_Modal)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemSupersessionRepository ItemSupersessionRepository = new ItemSupersessionRepository();

                List<ItemSS_Modal> Item_SS_Head_Get = ItemSupersessionRepository.Item_SS_Head_Get(ItemSS_search_Modal);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Item_SS_Head_Get;
                _ResponseModel.length = Item_SS_Head_Get.Count();
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

        #region Item_SS_Detail_Get
        [Route("v1/item_suppersession_Detail_Get")]
        [HttpGet]
        public ResponseModel Item_SS_Deatil_Get([FromUri] ItemSS_search_Modal ItemSS_search_Modal)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemSupersessionRepository ItemSupersessionRepository = new ItemSupersessionRepository();

                List<ItemSS_Modal> Item_SS_Deatil_Get = ItemSupersessionRepository.Item_SS_Deatil_Get(ItemSS_search_Modal);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Item_SS_Deatil_Get;
                _ResponseModel.length = Item_SS_Deatil_Get.Count();
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

        #region Item_SS_Create
        [Route("v1/item_suppersession_Create")]
        [HttpPut]
        public ResponseModel Item_SS_Create([FromBody] ItemSS_Modal ItemSS_Modal)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemSupersessionRepository ItemSupersessionRepository = new ItemSupersessionRepository();

                ItemSupersessionRepository.Item_SS_Create(ItemSS_Modal);

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

        #region Item_SS_Detail_Create
        [Route("v1/item_suppersession_Detail_Create")]
        [HttpPut]
        public ResponseModel Item_SS_Detail_Create([FromBody] ItemSS_Modal ItemSS_Modal)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemSupersessionRepository ItemSupersessionRepository = new ItemSupersessionRepository();

                ItemSupersessionRepository.Item_SS_Detail_Create(ItemSS_Modal);

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

        #region Item_SS_Update
        [Route("v1/item_suppersession_Update")]
        [HttpPut]
        public ResponseModel Item_SS_Update([FromBody] ItemSS_Modal ItemSS_Modal)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemSupersessionRepository ItemSupersessionRepository = new ItemSupersessionRepository();

                ItemSupersessionRepository.Item_SS_Update(ItemSS_Modal);

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

        #region Item_SS_Item_Get
        [Route("v1/item_suppersession_item_Get")]
        [HttpGet]
        public ResponseModel Item_SS_Item_Get([FromUri] string item_master)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemSupersessionRepository ItemSupersessionRepository = new ItemSupersessionRepository();

                List<ItemSS_stmas_modal> Item_SS_Item_Get = ItemSupersessionRepository.Item_SS_Item_Get(item_master);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Item_SS_Item_Get;
                _ResponseModel.length = Item_SS_Item_Get.Count();
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

        #region Item_SS_Head_Item_Get
        [Route("v1/item_suppersession_Head_item_Get")]
        [HttpGet]
        public ResponseModel Item_SS_Head_Item_Get([FromUri] string item_master)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemSupersessionRepository ItemSupersessionRepository = new ItemSupersessionRepository();

                List<ItemSS_stmas_modal> Item_SS_Head_Item_Get = ItemSupersessionRepository.Item_SS_Head_Item_Get(item_master);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Item_SS_Head_Item_Get;
                _ResponseModel.length = Item_SS_Head_Item_Get.Count();
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

        #region Item_History_Get
        [Route("v1/item_suppersession_history_Get")]
        [HttpGet]
        public ResponseModel Item_History_Get([FromUri] ItemSS_search_Modal ItemSS_search_Modal)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemSupersessionRepository ItemSupersessionRepository = new ItemSupersessionRepository();

                List<ItemSS_History_Modal> Item_History_Get = ItemSupersessionRepository.Item_History_Get(ItemSS_search_Modal);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Item_History_Get;
                _ResponseModel.length = Item_History_Get.Count();
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
