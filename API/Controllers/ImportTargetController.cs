using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class ImportTargetController : ApiController
    {

        #region VSK-IMPORT-CUSTOMER-TARGET-01 :  ImportCustomerTarget_Tran_Create
        [Route("v1/ImportCustomerTarget_Tran_Create")]
        [HttpPost]
        public ResponseModel ImportCustomerTarget_Tran_Create([FromBody] IEnumerable<ImportCustomerTargetTranModel> ImportCustomerTargetTranModel)
        {
            try
            {
                List<ImportCustomerTargetTranModel> ImportCustomerTargetArrayModelList = new List<ImportCustomerTargetTranModel>();

                int i = 1;

                foreach (var ImportCustomerTargetItem in ImportCustomerTargetTranModel)
                {
                    ImportCustomerTargetTranModel ImportCustomerTargetArrayModel_data = new ImportCustomerTargetTranModel();
                    ImportCustomerTargetArrayModel_data.temp_id = ImportCustomerTargetItem.temp_id;
                    ImportCustomerTargetArrayModel_data.item = ImportCustomerTargetItem.item;
                    ImportCustomerTargetArrayModel_data.code = ImportCustomerTargetItem.code;
                    ImportCustomerTargetArrayModel_data.year = ImportCustomerTargetItem.year;
                    ImportCustomerTargetArrayModel_data.targetgroup = ImportCustomerTargetItem.targetgroup;
                    ImportCustomerTargetArrayModel_data.M01 = ImportCustomerTargetItem.M01;
                    ImportCustomerTargetArrayModel_data.M02 = ImportCustomerTargetItem.M02;
                    ImportCustomerTargetArrayModel_data.M03 = ImportCustomerTargetItem.M03;
                    ImportCustomerTargetArrayModel_data.M04 = ImportCustomerTargetItem.M04;
                    ImportCustomerTargetArrayModel_data.M05 = ImportCustomerTargetItem.M05;
                    ImportCustomerTargetArrayModel_data.M06 = ImportCustomerTargetItem.M06;
                    ImportCustomerTargetArrayModel_data.M07 = ImportCustomerTargetItem.M07;
                    ImportCustomerTargetArrayModel_data.M08 = ImportCustomerTargetItem.M08;
                    ImportCustomerTargetArrayModel_data.M09 = ImportCustomerTargetItem.M09;
                    ImportCustomerTargetArrayModel_data.M10 = ImportCustomerTargetItem.M10;
                    ImportCustomerTargetArrayModel_data.M11 = ImportCustomerTargetItem.M11;
                    ImportCustomerTargetArrayModel_data.M12 = ImportCustomerTargetItem.M12;
                    ImportCustomerTargetArrayModel_data.created_by = ImportCustomerTargetItem.created_by;
                    ImportCustomerTargetArrayModel_data.created_by2 = ImportCustomerTargetItem.created_by2;


                    ImportCustomerTargetArrayModelList.Add(ImportCustomerTargetArrayModel_data);

                    i++;
                }

                ImportCustomerTargetRepository ImportCustomerTargetRepository = new ImportCustomerTargetRepository();
                ImportCustomerTargetRepository.ImportCustomerTarget_Tran_Create(ImportCustomerTargetArrayModelList);

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


        #region VSK-IMPORT-CUSTOMER-TARGET-02 :  ImportCustomerTarget_Create
        [Route("v1/ImportCustomerTarget_Create")]
        [HttpPost]
        public ResponseModel ImportCustomerTarget_Create([FromBody] ImportUpdateDataModel ImportUpdateDataModel)
        {
            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ImportCustomerTargetRepository ImportCustomerTargetRepository = new ImportCustomerTargetRepository();
                List<ImportUpdateDataModel> ImportCustomerTarget_Create = ImportCustomerTargetRepository.ImportCustomerTarget_Create(ImportUpdateDataModel);

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


        #region VSK-IMPORT-CUSTOMER-TARGET-03 :  ImportCustomerTarget_TemplateGet
        [Route("v1/ImportCustomerTarget_TemplateGet")]
        [HttpGet]
        public ResponseModel ImportCustomerTarget_TemplateGet([FromUri] string temp_id, string created_by, string created_by2)
        {
            try
            {
                ImportCustomerTargetRepository ImportCustomerTargetRepository = new ImportCustomerTargetRepository();
                List<ImportCustomerTargetTranModel> ImportUpdateData_TemplateGet = ImportCustomerTargetRepository.ImportCustomerTarget_TemplateGet(temp_id, created_by, created_by2);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportUpdateData_TemplateGet;
                _ResponseModel.length = ImportUpdateData_TemplateGet.Count();
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


        #region VSK-IMPORT-CUSTOMER-TARGET-04 :  ImportCustomerTarget_CalcStatus
        [Route("v1/ImportCustomerTarget_CalcStatus")]
        [HttpGet]
        public ResponseModel ImportCustomerTarget_CalcStatus([FromUri] string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                ImportCustomerTargetRepository ImportCustomerTargetRepository = new ImportCustomerTargetRepository();
                List<ImportCustomerTargetModel> ImportCustomerTarget_CalcStatus = ImportCustomerTargetRepository.ImportCustomerTarget_CalcStatus(temp_id, updated_by, updated_by2);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportCustomerTarget_CalcStatus;
                _ResponseModel.length = ImportCustomerTarget_CalcStatus.Count();
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


        #region VSK-IMPORT-CUSTOMER-TARGET-05 :  ImportCustomerTarget_Update
        [Route("v1/ImportCustomerTarget_Update")]
        [HttpGet]
        public ResponseModel ImportCustomerTarget_Update([FromUri] string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                ImportCustomerTargetRepository ImportCustomerTargetRepository = new ImportCustomerTargetRepository();
                ImportCustomerTargetRepository.ImportCustomerTarget_Update(temp_id, updated_by, updated_by2);

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