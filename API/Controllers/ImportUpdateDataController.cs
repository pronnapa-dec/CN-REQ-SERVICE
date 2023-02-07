using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class ImportUpdateDataController : ApiController
    {

        #region VSK-ITMI-IMPORT-UPDATEDATA-01 :  ImportUpdateData_Stmas_List_Get
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


        #region VSK-ITMI-IMPORT-UPDATEDATA-02 :  ImportUpdateData_Tran_Create
        [Route("v1/ImportUpdateData_Tran_Create")]
        [HttpPost]
        public ResponseModel ImportUpdateData_Tran_Create([FromBody] IEnumerable<ImportUpdateDataTranModel> ImportUpdateDataTranModel)
        {
            try
            {
                List<ImportUpdateDataTranModel> ImportUpdateDataArrayModelList = new List<ImportUpdateDataTranModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in ImportUpdateDataTranModel)
                {
                    ImportUpdateDataTranModel ImportUpdateDataArrayModel_data = new ImportUpdateDataTranModel();
                    ImportUpdateDataArrayModel_data.auth = ImportUpdateDataItem.auth;
                    ImportUpdateDataArrayModel_data.temp_id = ImportUpdateDataItem.temp_id;
                    ImportUpdateDataArrayModel_data.item = ImportUpdateDataItem.item;
                    ImportUpdateDataArrayModel_data.code = ImportUpdateDataItem.code;
                    ImportUpdateDataArrayModel_data.cartype = ImportUpdateDataItem.cartype;
                    ImportUpdateDataArrayModel_data.usagepercar = ImportUpdateDataItem.usagepercar;
                    ImportUpdateDataArrayModel_data.serviceyear = ImportUpdateDataItem.serviceyear;
                    ImportUpdateDataArrayModel_data.productqtyperpack = ImportUpdateDataItem.productqtyperpack;
                    ImportUpdateDataArrayModel_data.productsize = ImportUpdateDataItem.productsize;
                    ImportUpdateDataArrayModel_data.maxdiscountpercent = ImportUpdateDataItem.maxdiscountpercent;
                    ImportUpdateDataArrayModel_data.minmarginpercent = ImportUpdateDataItem.minmarginpercent;
                    ImportUpdateDataArrayModel_data.vatdiscmargin = ImportUpdateDataItem.vatdiscmargin;
                    ImportUpdateDataArrayModel_data.stockstatus = ImportUpdateDataItem.stockstatus;
                    ImportUpdateDataArrayModel_data.remarkbypm = ImportUpdateDataItem.remarkbypm;
                    ImportUpdateDataArrayModel_data.skufocus = ImportUpdateDataItem.skufocus;
                    ImportUpdateDataArrayModel_data.donotpur = ImportUpdateDataItem.donotpur;
                    ImportUpdateDataArrayModel_data.donotsale = ImportUpdateDataItem.donotsale;
                    ImportUpdateDataArrayModel_data.ginactive = ImportUpdateDataItem.ginactive;
                    ImportUpdateDataArrayModel_data.custconfirm = ImportUpdateDataItem.custconfirm;
                    ImportUpdateDataArrayModel_data.lifecycleaction = ImportUpdateDataItem.lifecycleaction;
                    ImportUpdateDataArrayModel_data.lifecyclereviewdate = ImportUpdateDataItem.lifecyclereviewdate;
                    ImportUpdateDataArrayModel_data.certificationstatus = ImportUpdateDataItem.certificationstatus;
                    ImportUpdateDataArrayModel_data.lockcode = ImportUpdateDataItem.lockcode;
                    ImportUpdateDataArrayModel_data.supersessionbarcode = ImportUpdateDataItem.supersessionbarcode;
                    ImportUpdateDataArrayModel_data.relationshiptype = ImportUpdateDataItem.relationshiptype;
                    ImportUpdateDataArrayModel_data.planing_type = ImportUpdateDataItem.planing_type;
                    ImportUpdateDataArrayModel_data.source_type = ImportUpdateDataItem.source_type;
                    ImportUpdateDataArrayModel_data.manualsafetystock = ImportUpdateDataItem.manualsafetystock;
                    ImportUpdateDataArrayModel_data.moq = ImportUpdateDataItem.moq;
                    ImportUpdateDataArrayModel_data.leadtimesupplier = ImportUpdateDataItem.leadtimesupplier;
                    ImportUpdateDataArrayModel_data.leadtimeitem = ImportUpdateDataItem.leadtimeitem;
                    ImportUpdateDataArrayModel_data.minqtyconst = ImportUpdateDataItem.minqtyconst;
                    ImportUpdateDataArrayModel_data.maxqtyconst = ImportUpdateDataItem.maxqtyconst;
                    ImportUpdateDataArrayModel_data.purchase = ImportUpdateDataItem.purchase;
                    ImportUpdateDataArrayModel_data.purcon = ImportUpdateDataItem.purcon;
                    ImportUpdateDataArrayModel_data.prefsuppliercode = ImportUpdateDataItem.prefsuppliercode;
                    ImportUpdateDataArrayModel_data.prefsupplierdisc = ImportUpdateDataItem.prefsupplierdisc;
                    ImportUpdateDataArrayModel_data.discgroup = ImportUpdateDataItem.discgroup;
                    ImportUpdateDataArrayModel_data.purdiscgroup = ImportUpdateDataItem.purdiscgroup;
                    ImportUpdateDataArrayModel_data.salediscgroup = ImportUpdateDataItem.salediscgroup;
                    ImportUpdateDataArrayModel_data.transferunit = ImportUpdateDataItem.transferunit;
                    ImportUpdateDataArrayModel_data.minqtywarehouse = ImportUpdateDataItem.minqtywarehouse;
                    ImportUpdateDataArrayModel_data.maxqtywarehouse = ImportUpdateDataItem.maxqtywarehouse;
                    ImportUpdateDataArrayModel_data.spcodes = ImportUpdateDataItem.spcodes;
                    ImportUpdateDataArrayModel_data.codeoem = ImportUpdateDataItem.codeoem;
                    ImportUpdateDataArrayModel_data.gdimension = ImportUpdateDataItem.gdimension;
                    ImportUpdateDataArrayModel_data.carbrand = ImportUpdateDataItem.carbrand;
                    ImportUpdateDataArrayModel_data.carmodel = ImportUpdateDataItem.carmodel;
                    ImportUpdateDataArrayModel_data.cargeneration = ImportUpdateDataItem.cargeneration;
                    ImportUpdateDataArrayModel_data.matchinno = ImportUpdateDataItem.matchinno;
                    ImportUpdateDataArrayModel_data.bodyno = ImportUpdateDataItem.bodyno;
                    ImportUpdateDataArrayModel_data.carengine = ImportUpdateDataItem.carengine;
                    ImportUpdateDataArrayModel_data.carbody = ImportUpdateDataItem.carbody;
                    ImportUpdateDataArrayModel_data.carbodycode = ImportUpdateDataItem.carbodycode;
                    ImportUpdateDataArrayModel_data.carfmyear = ImportUpdateDataItem.carfmyear;
                    ImportUpdateDataArrayModel_data.cartoyear = ImportUpdateDataItem.cartoyear;
                    ImportUpdateDataArrayModel_data.gdescript = ImportUpdateDataItem.gdescript;
                    ImportUpdateDataArrayModel_data.stdmargin = ImportUpdateDataItem.stdmargin;
                    ImportUpdateDataArrayModel_data.grvat = ImportUpdateDataItem.grvat;
                    ImportUpdateDataArrayModel_data.gnamechr = ImportUpdateDataItem.gnamechr;
                    ImportUpdateDataArrayModel_data.gmodel = ImportUpdateDataItem.gmodel;
                    ImportUpdateDataArrayModel_data.type = ImportUpdateDataItem.type;
                    ImportUpdateDataArrayModel_data.gused = ImportUpdateDataItem.gused;
                    ImportUpdateDataArrayModel_data.goem = ImportUpdateDataItem.goem;
                    ImportUpdateDataArrayModel_data.latestreviewdate = ImportUpdateDataItem.latestreviewdate;
                    ImportUpdateDataArrayModel_data.nextreviewdate = ImportUpdateDataItem.nextreviewdate;
                    ImportUpdateDataArrayModel_data.reviewtimes = ImportUpdateDataItem.reviewtimes;
                    ImportUpdateDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;
                    ImportUpdateDataArrayModel_data.created_by2 = ImportUpdateDataItem.created_by2;

                    ImportUpdateDataArrayModelList.Add(ImportUpdateDataArrayModel_data);

                    i++;
                }

                ImportUpdateDataRepository ImportUpdateDataRepository = new ImportUpdateDataRepository();
                ImportUpdateDataRepository.ImportUpdateData_Tran_Create(ImportUpdateDataArrayModelList);

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


        #region VSK-ITMI-IMPORT-UPDATEDATA-02 :  ImportUpdateData_Tran_Create_UAT
        [Route("v1/ImportUpdateData_Tran_Create_UAT")]
        [HttpPost]
        public ResponseModel ImportUpdateData_Tran_Create_UAT([FromBody] IEnumerable<ImportUpdateDataTranModel> ImportUpdateDataTranModel)
        {
            try
            {
                List<ImportUpdateDataTranModel> ImportUpdateDataArrayModelList = new List<ImportUpdateDataTranModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in ImportUpdateDataTranModel)
                {
                    ImportUpdateDataTranModel ImportUpdateDataArrayModel_data = new ImportUpdateDataTranModel();
                    ImportUpdateDataArrayModel_data.auth = ImportUpdateDataItem.auth;
                    ImportUpdateDataArrayModel_data.temp_id = ImportUpdateDataItem.temp_id;
                    ImportUpdateDataArrayModel_data.item = ImportUpdateDataItem.item;
                    ImportUpdateDataArrayModel_data.code = ImportUpdateDataItem.code;
                    ImportUpdateDataArrayModel_data.cartype = ImportUpdateDataItem.cartype;
                    ImportUpdateDataArrayModel_data.usagepercar = ImportUpdateDataItem.usagepercar;
                    ImportUpdateDataArrayModel_data.serviceyear = ImportUpdateDataItem.serviceyear;
                    ImportUpdateDataArrayModel_data.productqtyperpack = ImportUpdateDataItem.productqtyperpack;
                    ImportUpdateDataArrayModel_data.productsize = ImportUpdateDataItem.productsize;
                    ImportUpdateDataArrayModel_data.maxdiscountpercent = ImportUpdateDataItem.maxdiscountpercent;
                    ImportUpdateDataArrayModel_data.minmarginpercent = ImportUpdateDataItem.minmarginpercent;
                    ImportUpdateDataArrayModel_data.vatdiscmargin = ImportUpdateDataItem.vatdiscmargin;
                    ImportUpdateDataArrayModel_data.stockstatus = ImportUpdateDataItem.stockstatus;
                    ImportUpdateDataArrayModel_data.remarkbypm = ImportUpdateDataItem.remarkbypm;
                    ImportUpdateDataArrayModel_data.skufocus = ImportUpdateDataItem.skufocus;
                    ImportUpdateDataArrayModel_data.donotpur = ImportUpdateDataItem.donotpur;
                    ImportUpdateDataArrayModel_data.donotsale = ImportUpdateDataItem.donotsale;
                    ImportUpdateDataArrayModel_data.ginactive = ImportUpdateDataItem.ginactive;
                    ImportUpdateDataArrayModel_data.custconfirm = ImportUpdateDataItem.custconfirm;
                    ImportUpdateDataArrayModel_data.lifecycleaction = ImportUpdateDataItem.lifecycleaction;
                    ImportUpdateDataArrayModel_data.lifecyclereviewdate = ImportUpdateDataItem.lifecyclereviewdate;
                    ImportUpdateDataArrayModel_data.certificationstatus = ImportUpdateDataItem.certificationstatus;
                    ImportUpdateDataArrayModel_data.lockcode = ImportUpdateDataItem.lockcode;
                    ImportUpdateDataArrayModel_data.supersessionbarcode = ImportUpdateDataItem.supersessionbarcode;
                    ImportUpdateDataArrayModel_data.relationshiptype = ImportUpdateDataItem.relationshiptype;
                    ImportUpdateDataArrayModel_data.planing_type = ImportUpdateDataItem.planing_type;
                    ImportUpdateDataArrayModel_data.source_type = ImportUpdateDataItem.source_type;
                    ImportUpdateDataArrayModel_data.manualsafetystock = ImportUpdateDataItem.manualsafetystock;
                    ImportUpdateDataArrayModel_data.moq = ImportUpdateDataItem.moq;
                    ImportUpdateDataArrayModel_data.leadtimesupplier = ImportUpdateDataItem.leadtimesupplier;
                    ImportUpdateDataArrayModel_data.leadtimeitem = ImportUpdateDataItem.leadtimeitem;
                    ImportUpdateDataArrayModel_data.minqtyconst = ImportUpdateDataItem.minqtyconst;
                    ImportUpdateDataArrayModel_data.maxqtyconst = ImportUpdateDataItem.maxqtyconst;
                    ImportUpdateDataArrayModel_data.purchase = ImportUpdateDataItem.purchase;
                    ImportUpdateDataArrayModel_data.purcon = ImportUpdateDataItem.purcon;
                    ImportUpdateDataArrayModel_data.prefsuppliercode = ImportUpdateDataItem.prefsuppliercode;
                    ImportUpdateDataArrayModel_data.prefsupplierdisc = ImportUpdateDataItem.prefsupplierdisc;
                    ImportUpdateDataArrayModel_data.discgroup = ImportUpdateDataItem.discgroup;
                    ImportUpdateDataArrayModel_data.purdiscgroup = ImportUpdateDataItem.purdiscgroup;
                    ImportUpdateDataArrayModel_data.salediscgroup = ImportUpdateDataItem.salediscgroup;
                    ImportUpdateDataArrayModel_data.transferunit = ImportUpdateDataItem.transferunit;
                    ImportUpdateDataArrayModel_data.minqtywarehouse = ImportUpdateDataItem.minqtywarehouse;
                    ImportUpdateDataArrayModel_data.maxqtywarehouse = ImportUpdateDataItem.maxqtywarehouse;
                    ImportUpdateDataArrayModel_data.spcodes = ImportUpdateDataItem.spcodes;
                    ImportUpdateDataArrayModel_data.codeoem = ImportUpdateDataItem.codeoem;
                    ImportUpdateDataArrayModel_data.gdimension = ImportUpdateDataItem.gdimension;
                    ImportUpdateDataArrayModel_data.carbrand = ImportUpdateDataItem.carbrand;
                    ImportUpdateDataArrayModel_data.carmodel = ImportUpdateDataItem.carmodel;
                    ImportUpdateDataArrayModel_data.cargeneration = ImportUpdateDataItem.cargeneration;
                    ImportUpdateDataArrayModel_data.matchinno = ImportUpdateDataItem.matchinno;
                    ImportUpdateDataArrayModel_data.bodyno = ImportUpdateDataItem.bodyno;
                    ImportUpdateDataArrayModel_data.carengine = ImportUpdateDataItem.carengine;
                    ImportUpdateDataArrayModel_data.carbody = ImportUpdateDataItem.carbody;
                    ImportUpdateDataArrayModel_data.carbodycode = ImportUpdateDataItem.carbodycode;
                    ImportUpdateDataArrayModel_data.carfmyear = ImportUpdateDataItem.carfmyear;
                    ImportUpdateDataArrayModel_data.cartoyear = ImportUpdateDataItem.cartoyear;
                    ImportUpdateDataArrayModel_data.gdescript = ImportUpdateDataItem.gdescript;
                    ImportUpdateDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;
                    ImportUpdateDataArrayModel_data.created_by2 = ImportUpdateDataItem.created_by2;

                    ImportUpdateDataArrayModelList.Add(ImportUpdateDataArrayModel_data);

                    i++;
                }

                ImportUpdateDataRepository ImportUpdateDataRepository = new ImportUpdateDataRepository();
                ImportUpdateDataRepository.ImportUpdateData_Tran_Create_UAT(ImportUpdateDataArrayModelList);

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


        #region VSK-ITMI-IMPORT-UPDATEDATA-03 :  ImportUpdateData_Create
        [Route("v1/ImportUpdateData_Create")]
        [HttpPost]
        public ResponseModel ImportUpdatePrice_Create([FromBody] ImportUpdateDataModel ImportUpdateDataModel)
        {
            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ImportUpdateDataRepository ImportUpdateDataRepository = new ImportUpdateDataRepository();
                List<ImportUpdateDataModel> ImportUpdateData_Create = ImportUpdateDataRepository.ImportUpdateData_Create(ImportUpdateDataModel);

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


        #region VSK-ITMI-IMPORT-UPDATEDATA-04 :  ItemMaster_ImportUpdateData_TemplateGet
        [Route("v1/ItemMaster_ImportUpdateData_TemplateGet")]
        [HttpGet]
        public ResponseModel ItemMaster_ImportUpdateData_TemplateGet([FromUri] string temp_id, string created_by, string created_by2)
        {
            try
            {
                ImportUpdateDataRepository ImportUpdateDataRepository = new ImportUpdateDataRepository();
                List<ImportUpdateDataTranModel> ItemMaster_ImportUpdateData_TemplateGet = ImportUpdateDataRepository.ItemMaster_ImportUpdateData_TemplateGet(temp_id, created_by, created_by2);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ItemMaster_ImportUpdateData_TemplateGet;
                _ResponseModel.length = ItemMaster_ImportUpdateData_TemplateGet.Count();
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


        #region VSK-ITMI-IMPORT-UPDATEDATA-05 :  ItemMaster_ImportUpdateData_CalcStatus
        [Route("v1/ItemMaster_ImportUpdateData_CalcStatus")]
        [HttpGet]
        public ResponseModel ItemMaster_ImportUpdateData_CalcStatus([FromUri] string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                ImportUpdateDataRepository ImportUpdateDataRepository = new ImportUpdateDataRepository();
                List<ImportUpdateDataModel> ItemMaster_ImportUpdateData_CalcStatus = ImportUpdateDataRepository.ItemMaster_ImportUpdateData_CalcStatus(temp_id, updated_by, updated_by2);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ItemMaster_ImportUpdateData_CalcStatus;
                _ResponseModel.length = ItemMaster_ImportUpdateData_CalcStatus.Count();
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


        #region VSK-ITMI-IMPORT-UPDATEDATA-06 :  ItemMaster_ImportUpdateData_Update
        [Route("v1/ItemMaster_ImportUpdateData_Update")]
        [HttpGet]
        public ResponseModel ItemMaster_ImportUpdateData_Update([FromUri] string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                ImportUpdateDataRepository ImportUpdateDataRepository = new ImportUpdateDataRepository();
                ImportUpdateDataRepository.ItemMaster_ImportUpdateData_Update(temp_id, updated_by, updated_by2);

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


        #region VSK-ITMI-IMPORT-UPDATEDATA-06 :  ItemMaster_ImportUpdateData_Update_UAT
        [Route("v1/ItemMaster_ImportUpdateData_Update_UAT")]
        [HttpGet]
        public ResponseModel ItemMaster_ImportUpdateData_Update_UAT([FromUri] string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                ImportUpdateDataRepository ImportUpdateDataRepository = new ImportUpdateDataRepository();
                ImportUpdateDataRepository.ItemMaster_ImportUpdateData_Update_UAT(temp_id, updated_by, updated_by2);

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