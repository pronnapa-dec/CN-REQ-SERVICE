using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class ImportPriceListController : ApiController
    {
        #region VSK-IMPORT-PRICELIST-01 :  ImportUpdateData_Stmas_List_Get
        [Route("v1/importupdatedata_stmas_list_get")]
        [HttpGet]
        public ResponseModel importupdatedata_stmas_list_get([FromUri] StmasModel StmasModel)
        {
            try
            {
                ImportUpdateDataRepository ImportUpdateDataRepository = new ImportUpdateDataRepository();
                List<StmasModel> importupdatedata_stmas_list_get = ImportUpdateDataRepository.importupdatedata_stmas_list_get(StmasModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = importupdatedata_stmas_list_get;
                _ResponseModel.length = importupdatedata_stmas_list_get.Count();
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


        #region VSK-IMPORT-PRICELIST-02 :  ImportPriceList_Tran_Create
        [Route("v1/ImportPriceList_Tran_Create")]
        [HttpPost]
        public ResponseModel ImportPriceList_Tran_Create([FromBody] IEnumerable<ImportPriceListTranModel> ImportPriceListTranModel)
        {
            try
            {
                List<ImportPriceListTranModel> ImportPriceListArrayModelList = new List<ImportPriceListTranModel>();

                int i = 1;

                foreach (var ImportPriceListItem in ImportPriceListTranModel)
                {
                    ImportPriceListTranModel ImportPriceListArrayModel_data = new ImportPriceListTranModel();
                    ImportPriceListArrayModel_data.temp_id = ImportPriceListItem.temp_id;
                    ImportPriceListArrayModel_data.item = ImportPriceListItem.item;
                    ImportPriceListArrayModel_data.spcodes = ImportPriceListItem.spcodes;
                    ImportPriceListArrayModel_data.carbrand = ImportPriceListItem.carbrand;
                    ImportPriceListArrayModel_data.goem = ImportPriceListItem.goem;
                    ImportPriceListArrayModel_data.itemname_en = ImportPriceListItem.itemname_en;
                    ImportPriceListArrayModel_data.itemname_th = ImportPriceListItem.itemname_th;
                    ImportPriceListArrayModel_data.gprice = ImportPriceListItem.gprice;
                    ImportPriceListArrayModel_data.price_effectdate = ImportPriceListItem.price_effectdate;
                    ImportPriceListArrayModel_data.created_by = ImportPriceListItem.created_by;

                    ImportPriceListArrayModelList.Add(ImportPriceListArrayModel_data);

                    i++;
                }

                ImportPriceListRepository ImportPriceListRepository = new ImportPriceListRepository();
                ImportPriceListRepository.ImportPriceList_Tran_Create(ImportPriceListArrayModelList);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                //_ResponseModel.status = "Error";
                _ResponseModel.status = ex.ToString();

                return _ResponseModel;
            }
        }
        #endregion


        #region VSK-IMPORT-PRICELIST-03 :  ImportPriceList_Create
        [Route("v1/ImportPriceList_Create")]
        [HttpPost]
        public ResponseModel ImportPriceList_Create([FromBody] ImportPriceListModel ImportPriceListModel)
        {
            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ImportPriceListRepository ImportPriceListRepository = new ImportPriceListRepository();
                List<ImportPriceListModel> ImportPriceList_Create = ImportPriceListRepository.ImportPriceList_Create(ImportPriceListModel);

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


        #region VSK-IMPORT-PRICELIST-04 :  ImportPriceList_TemplateGet
        [Route("v1/ImportPriceList_TemplateGet")]
        [HttpGet]
        public ResponseModel ImportPriceList_TemplateGet([FromUri] string temp_id, string created_by)
        {
            try
            {
                ImportPriceListRepository ImportPriceListRepository = new ImportPriceListRepository();
                List<ImportPriceListTranModel> ImportPriceList_TemplateGet = ImportPriceListRepository.ImportPriceList_TemplateGet(temp_id, created_by);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportPriceList_TemplateGet;
                _ResponseModel.length = ImportPriceList_TemplateGet.Count();
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


        #region VSK-IMPORT-PRICELIST-05 :  ImportPriceList_CalcStatus
        [Route("v1/ImportPriceList_CalcStatus")]
        [HttpGet]
        public ResponseModel ImportPriceList_CalcStatus([FromUri] string temp_id, string updated_by)
        {
            try
            {
                ImportPriceListRepository ImportPriceListRepository = new ImportPriceListRepository();
                List<ImportPriceListModel> ImportPriceList_CalcStatus = ImportPriceListRepository.ImportPriceList_CalcStatus(temp_id, updated_by);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportPriceList_CalcStatus;
                _ResponseModel.length = ImportPriceList_CalcStatus.Count();
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


        #region VSK-IMPORT-UPDATEDATA-06 :  ImportPriceList_Update
        [Route("v1/ImportPriceList_Update")]
        [HttpGet]
        public ResponseModel ImportPriceList_Update([FromUri] string temp_id, string updated_by)
        {
            try
            {
                ImportPriceListRepository ImportPriceListRepository = new ImportPriceListRepository();
                ImportPriceListRepository.ImportPriceList_Update(temp_id, updated_by);

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