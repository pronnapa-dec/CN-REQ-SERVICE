using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class ImportNetPriceController : ApiController
    {
        #region VSK-ITMI-IMPORT-01 :  ImportNetPrice_Create
        [Route("v1/ImportNetPrice_Create")]
        [HttpPost]
        public ResponseModel ImportNetPrice_Create([FromBody] IEnumerable<ImportNetPriceModel> ImportNetPriceModel)
        {
            try
            {
                List<ImportNetPriceModel> ImportNetPriceArrayModelList = new List<ImportNetPriceModel>();

                int i = 1;

                foreach (var ImportNetPriceItem in ImportNetPriceModel)
                {

                    ImportNetPriceModel ImportNetPriceArrayModel_data = new ImportNetPriceModel();
                    ImportNetPriceArrayModel_data.item = ImportNetPriceItem.item;
                    ImportNetPriceArrayModel_data.code = ImportNetPriceItem.code;
                    ImportNetPriceArrayModel_data.qty_a = ImportNetPriceItem.qty_a;
                    ImportNetPriceArrayModel_data.qty_b = ImportNetPriceItem.qty_b;
                    ImportNetPriceArrayModel_data.qtysmall = ImportNetPriceItem.qtysmall;
                    ImportNetPriceArrayModel_data.UOM = ImportNetPriceItem.UOM;
                    ImportNetPriceArrayModel_data.prod_net = ImportNetPriceItem.prod_net;

                    ImportNetPriceArrayModelList.Add(ImportNetPriceArrayModel_data);

                    i++;
                }

                ImportNetPriceRepository ImportNetPriceRepository = new ImportNetPriceRepository();
                ImportNetPriceRepository.ImportNetPrice_Create(ImportNetPriceArrayModelList);

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

    }
}
