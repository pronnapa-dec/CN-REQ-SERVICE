using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class MasterDataCode5Controller : ApiController
    {

        #region VSK-ITMI-IMPORT_MASTERDATACODE5-01 :  ItemMaster_ImportMasterDataCode5_Tran_Create
        [Route("v1/ItemMaster_ImportMasterDataCode5_Tran_Create")]
        [HttpPost]
        public ResponseModel ItemMaster_ImportMasterDataCode5_Tran_Create([FromBody] IEnumerable<ImportMasterDataCode5TranModel> ImportMasterDataCode5TranModel)
        {
            try
            {
                List<ImportMasterDataCode5TranModel> ImportUpdateDataArrayModelList = new List<ImportMasterDataCode5TranModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in ImportMasterDataCode5TranModel)
                {
                    ImportMasterDataCode5TranModel ImportUpdateDataArrayModel_data = new ImportMasterDataCode5TranModel();
                    ImportUpdateDataArrayModel_data.temp_id = ImportUpdateDataItem.temp_id;
                    ImportUpdateDataArrayModel_data.trans_id = ImportUpdateDataItem.trans_id;
                    ImportUpdateDataArrayModel_data.item = ImportUpdateDataItem.item; 
                    ImportUpdateDataArrayModel_data.c5_code = ImportUpdateDataItem.c5_code;
                    ImportUpdateDataArrayModel_data.c5_gname = ImportUpdateDataItem.c5_gname;
                    ImportUpdateDataArrayModel_data.carbrand_code = ImportUpdateDataItem.carbrand_code;
                    ImportUpdateDataArrayModel_data.carbrand_name = ImportUpdateDataItem.carbrand_name;
                    ImportUpdateDataArrayModel_data.carmodel_code = ImportUpdateDataItem.carmodel_code;
                    ImportUpdateDataArrayModel_data.carmodel_name = ImportUpdateDataItem.carmodel_name;
                    ImportUpdateDataArrayModel_data.carFmyear = ImportUpdateDataItem.carFmyear;
                    ImportUpdateDataArrayModel_data.carToyear = ImportUpdateDataItem.carToyear;
                    ImportUpdateDataArrayModel_data.carGeneration = ImportUpdateDataItem.carGeneration;
                    ImportUpdateDataArrayModel_data.cartype = ImportUpdateDataItem.cartype;
                    ImportUpdateDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;
                    ImportUpdateDataArrayModel_data.created_by2 = ImportUpdateDataItem.created_by2;

                    ImportUpdateDataArrayModelList.Add(ImportUpdateDataArrayModel_data);

                    i++;
                }

                MasterDataCode5Repository MasterDataCode5Repository = new MasterDataCode5Repository();
                MasterDataCode5Repository.ItemMaster_ImportMasterDataCode5_Tran_Create(ImportUpdateDataArrayModelList);

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


        #region VSK-ITMI-IMPORT_MASTERDATACODE5-02 :  ItemMaster_ImportMasterDataCode5_Create
        [Route("v1/ItemMaster_ImportMasterDataCode5_Create")]
        [HttpPost]
        public ResponseModel ItemMaster_ImportMasterDataCode5_Create([FromBody] ImportUpdateDataModel ImportUpdateDataModel)
        {
            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterDataCode5Repository MasterDataCode5Repository = new MasterDataCode5Repository();
                List<ImportUpdateDataModel> ItemMaster_ImportMasterDataCode5_Create = MasterDataCode5Repository.ItemMaster_ImportMasterDataCode5_Create(ImportUpdateDataModel);

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


        #region VSK-ITMI-IMPORT_MASTERDATACODE5-03 :  ItemMaster_ImportMasterDataCode5_TemplateGet
        [Route("v1/ItemMaster_ImportMasterDataCode5_TemplateGet")]
        [HttpGet]
        public ResponseModel ItemMaster_ImportMasterDataCode5_TemplateGet([FromUri] string temp_id, string created_by, string created_by2)
        {
            try
            {
                MasterDataCode5Repository MasterDataCode5Repository = new MasterDataCode5Repository();
                List<ImportMasterDataCode5TranModel> ItemMaster_ImportMasterDataCode5_TemplateGet = MasterDataCode5Repository.ItemMaster_ImportMasterDataCode5_TemplateGet(temp_id, created_by, created_by2);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ItemMaster_ImportMasterDataCode5_TemplateGet;
                _ResponseModel.length = ItemMaster_ImportMasterDataCode5_TemplateGet.Count();
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


        #region VSK-ITMI-IMPORT_MASTERDATACODE5-04 :  ItemMaster_ImportMasterDataCode5_CalcStatus
        [Route("v1/ItemMaster_ImportMasterDataCode5_CalcStatus")]
        [HttpGet]
        public ResponseModel ItemMaster_ImportMasterDataCode5_CalcStatus([FromUri] string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                MasterDataCode5Repository MasterDataCode5Repository = new MasterDataCode5Repository();
                List<ImportUpdateDataModel> ItemMaster_ImportMasterDataCode5_CalcStatus = MasterDataCode5Repository.ItemMaster_ImportMasterDataCode5_CalcStatus(temp_id, updated_by, updated_by2);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ItemMaster_ImportMasterDataCode5_CalcStatus;
                _ResponseModel.length = ItemMaster_ImportMasterDataCode5_CalcStatus.Count();
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


        #region VSK-ITMI-IMPORT_MASTERDATACODE5-05 :  ItemMaster_ImportMasterDataCode5_Update
        [Route("v1/ItemMaster_ImportMasterDataCode5_Update")]
        [HttpGet]
        public ResponseModel ItemMaster_ImportMasterDataCode5_Update([FromUri] string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                MasterDataCode5Repository MasterDataCode5Repository = new MasterDataCode5Repository();
                MasterDataCode5Repository.ItemMaster_ImportMasterDataCode5_Update(temp_id, updated_by, updated_by2);

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