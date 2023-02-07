using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{

    public class Maincategory
    {
        public string maincategory { get; set; }
    }

    public class ItemMasterController : ApiController
    {
        [Route("v1/stmas_get")]
        [HttpGet]
        public ResponseModel Stmas_Get([FromUri] string item_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<StmasModel_v2> Stmas_Get = AccurateRepository.Stmas_Get(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Stmas_Get;
                _ResponseModel.length = Stmas_Get.Count();
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


        [Route("v1/stmas_search")]
        [HttpGet]
        public ResponseModel Stmas_Search([FromUri] string item_code = "", [FromUri] string item_name = "", [FromUri] string item_CHRCODE = "", [FromUri] string item_SPCODES = "", [FromUri] string item_gbarcode = "", [FromUri] string mode = "")
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<StmasModel> Stmas_Search = AccurateRepository.Stmas_Search(item_code, item_name, item_CHRCODE, item_SPCODES, item_gbarcode, mode);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Stmas_Search;
                _ResponseModel.length = Stmas_Search.Count();
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


        [Route("v1/product_purplan_stock_factor_list_get")]
        [HttpGet]
        public ResponseModel Product_PurPlan_Stock_Factor_List_Get([FromUri] string search_item_gbarcode = "", [FromUri] string search_item_spcodes = "", [FromUri] string search_item_code = "", [FromUri] string search_item_code1 = "", [FromUri] string search_item_code3 = "", [FromUri] string search_item_productdivision = "", [FromUri] string search_item_maincategory = "", [FromUri] string search_item_subcategory = "", [FromUri] string search_item_carmodel = "", [FromUri] string search_item_carbrand = "", [FromUri] string search_item_stockstatus = "", [FromUri] string search_item_skufocus = "", [FromUri] string search_item_code_2 = "", [FromUri] string search_item_gbarcode_2 = "", [FromUri] string search_item_spcodes_2 = "", [FromUri] string search_item_code1_2 = "", [FromUri] string search_item_code3_2 = "", string mode = "")
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<Product_PurPlan_Stock_FactorModel_V4> Product_PurPlan_Stock_Factor_List_Get = new List<Product_PurPlan_Stock_FactorModel_V4>();
                List<Product_PurPlan_Stock_FactorModel_V4> Product_PurPlan_Stock_Factor_List_data = new List<Product_PurPlan_Stock_FactorModel_V4>();
                ResponseModel _ResponseModel = new ResponseModel();

                if (search_item_productdivision != null)
                {
                    string prod_division = search_item_productdivision;
                    string[] arr_division = prod_division.Split(',');

                    foreach (String productdivision in arr_division)
                    {
                        string str_maincate = "";
                        if (search_item_maincategory != null)
                        {
                            string prod_maincate = search_item_maincategory;
                            string[] arr_maincate = prod_maincate.Split(',');

                            foreach (String maincategory in arr_maincate)
                            {
                                string str_subcate = "";
                                if (search_item_subcategory != null)
                                {
                                    string prod_subcate = search_item_subcategory;
                                    string[] arr_subcate = prod_subcate.Split(',');

                                    var foo2 = new List<string>();
                                    foo2.AddRange(arr_subcate.Where(item => item.StartsWith(maincategory.Replace(productdivision + ">", "") + ">")));
                                    str_subcate = string.Join(",", foo2);

                                    Product_PurPlan_Stock_Factor_List_Get = AccurateRepository.Product_PurPlan_Stock_Factor_List_Get(search_item_gbarcode, search_item_spcodes, search_item_code, search_item_code1, search_item_code3, productdivision, str_maincate.Replace(productdivision + ">", ""), str_subcate.Replace(maincategory.Replace(productdivision + ">", "") + ">", ""), search_item_carmodel, search_item_carbrand, search_item_stockstatus, search_item_skufocus, search_item_code_2, search_item_gbarcode_2, search_item_spcodes_2, search_item_code1_2, search_item_code3_2, mode).ToList();
                                    Product_PurPlan_Stock_Factor_List_data.AddRange(Product_PurPlan_Stock_Factor_List_Get);
                                }
                                else
                                {
                                    var foo = new List<string>();
                                    foo.AddRange(arr_maincate.Where(item => item.StartsWith(productdivision + ">")));
                                    str_maincate = string.Join(",", foo);

                                    Product_PurPlan_Stock_Factor_List_Get = AccurateRepository.Product_PurPlan_Stock_Factor_List_Get(search_item_gbarcode, search_item_spcodes, search_item_code, search_item_code1, search_item_code3, productdivision, str_maincate.Replace(productdivision + ">", ""), search_item_subcategory, search_item_carmodel, search_item_carbrand, search_item_stockstatus, search_item_skufocus, search_item_code_2, search_item_gbarcode_2, search_item_spcodes_2, search_item_code1_2, search_item_code3_2, mode).ToList();
                                    Product_PurPlan_Stock_Factor_List_data.AddRange(Product_PurPlan_Stock_Factor_List_Get);
                                }
                            }
                        }
                        else
                        {
                            Product_PurPlan_Stock_Factor_List_Get = AccurateRepository.Product_PurPlan_Stock_Factor_List_Get(search_item_gbarcode, search_item_spcodes, search_item_code, search_item_code1, search_item_code3, productdivision, search_item_maincategory, search_item_subcategory, search_item_carmodel, search_item_carbrand, search_item_stockstatus, search_item_skufocus, search_item_code_2, search_item_gbarcode_2, search_item_spcodes_2, search_item_code1_2, search_item_code3_2, mode).ToList();
                             Product_PurPlan_Stock_Factor_List_data.AddRange(Product_PurPlan_Stock_Factor_List_Get);
                        }
                    }
                }
                else
                {
                    Product_PurPlan_Stock_Factor_List_Get = AccurateRepository.Product_PurPlan_Stock_Factor_List_Get(search_item_gbarcode, search_item_spcodes, search_item_code, search_item_code1, search_item_code3, search_item_productdivision, search_item_maincategory, search_item_subcategory, search_item_carmodel, search_item_carbrand, search_item_stockstatus, search_item_skufocus, search_item_code_2, search_item_gbarcode_2, search_item_spcodes_2, search_item_code1_2, search_item_code3_2, mode).ToList();
                    Product_PurPlan_Stock_Factor_List_data.AddRange(Product_PurPlan_Stock_Factor_List_Get);
                }
                _ResponseModel.data = Product_PurPlan_Stock_Factor_List_data;
                _ResponseModel.length = Product_PurPlan_Stock_Factor_List_data.Count();
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


        [Route("v1/product_purplan_stock_factor_get")]
        [HttpGet]
        public ResponseModel Product_PurPlan_Stock_Factor_Get([FromUri] string item_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<Product_PurPlan_Stock_FactorModel> Product_PurPlan_Stock_Factor_Get = AccurateRepository.Product_PurPlan_Stock_Factor_Get(item_code);
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


        [Route("v2/product_purplan_stock_factor_get")]
        [HttpGet]
        public ResponseModel Product_PurPlan_Stock_Factor_Get_V2([FromUri] string item_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<Product_PurPlan_Stock_FactorModel_v2> Product_PurPlan_Stock_Factor_Get = AccurateRepository.Product_PurPlan_Stock_Factor_Get_v2(item_code);
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


        [Route("v3/product_purplan_stock_factor_get")]
        [HttpGet]
        public ResponseModel Product_PurPlan_Stock_Factor_Get_V3([FromUri] string item_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<Product_PurPlan_Stock_FactorModel_V3> Product_PurPlan_Stock_Factor_Get = AccurateRepository.Product_PurPlan_Stock_Factor_Get_V3(item_code);
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


        [Route("v4/product_purplan_stock_factor_get")]
        [HttpGet]
        public ResponseModel Product_PurPlan_Stock_Factor_Get_V4([FromUri] string item_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<Product_PurPlan_Stock_FactorModel_V4> Product_PurPlan_Stock_Factor_Get = AccurateRepository.Product_PurPlan_Stock_Factor_Get_V4(item_code);
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


        [Route("v1/gcode_get")]
        [HttpGet]
        public ResponseModel Gcode_Get([FromUri] GcodeModel GcodeModel)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<GcodeModel> Gcode_Get = AccurateRepository.Gcode_Get(GcodeModel);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Gcode_Get;
                _ResponseModel.length = Gcode_Get.Count();
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


        [Route("v1/barcode_get")]
        [HttpGet]
        public ResponseModel Barcode_Get([FromUri] BarcodeModel BarcodeModel)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<BarcodeModel> Barcode_Get = AccurateRepository.Barcode_Get(BarcodeModel);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Barcode_Get;
                _ResponseModel.length = Barcode_Get.Count();
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


        [Route("v1/uom_get")]
        [HttpGet]
        public ResponseModel UOM_Get([FromUri] UOMModel UOMModel)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<UOMModel> UOM_Get = AccurateRepository.UOM_Get(UOMModel);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = UOM_Get;
                _ResponseModel.length = UOM_Get.Count();
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


        [Route("v1/location_get")]
        [HttpGet]
        public ResponseModel Location_Get([FromUri] LocationModel LocationModel)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<LocationModel> Location_Get = AccurateRepository.Location_Get(LocationModel);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Location_Get;
                _ResponseModel.length = Location_Get.Count();
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


        [Route("v1/printerzone_get")]
        [HttpGet]
        public ResponseModel PrinterZone_Get([FromUri] PrinterZoneModel PrinterZoneModel)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<PrinterZoneModel> PrinterZone_Get = AccurateRepository.PrinterZone_Get(PrinterZoneModel);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PrinterZone_Get;
                _ResponseModel.length = PrinterZone_Get.Count();
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


        [Route("v1/goodprice_get")]
        [HttpGet]
        public ResponseModel Goodprice_Get([FromUri] string item_code, [FromUri] string item_gbarcode = "")
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<GoodpriceModel> Goodprice_Get = AccurateRepository.Goodprice_Get(item_code, item_gbarcode);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Goodprice_Get;
                _ResponseModel.length = Goodprice_Get.Count();
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


        [Route("v1/glocat_get")]
        [HttpGet]
        public ResponseModel Glocat_get([FromUri] string wh_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<GlocatModel> Glocat_get = AccurateRepository.Glocat_get(wh_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Glocat_get;
                _ResponseModel.length = Glocat_get.Count();
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


        [Route("v2/stmas_search_V2")]
        [HttpGet]
        public ResponseModel stmas_search_V2([FromUri] string item_code = "", [FromUri] string item_name = "", [FromUri] string item_CHRCODE = "", [FromUri] string item_SPCODES = "", [FromUri] string item_gbarcode = "", [FromUri] string mode = "")
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<StmasModel_v2> stmas_search_V2 = AccurateRepository.Stmas_Search_V2(item_code, item_name, item_CHRCODE, item_SPCODES, item_gbarcode, mode);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = stmas_search_V2;
                _ResponseModel.length = stmas_search_V2.Count();
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


        [Route("v3/stmas_search_V3")]
        [HttpGet]
        public ResponseModel stmas_search_V3([FromUri] string item_gbarcode = "", string item_spcodes = "", string item_code = "", string item_name = "", string item_code1 = "", string item_code2 = "", string item_code3 = "", string item_code4 = "", string item_code5 = "", [FromUri] string mode = "")
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<StmasModel_v2> stmas_search_V3 = AccurateRepository.stmas_search_V3(item_gbarcode, item_spcodes, item_code, item_name, item_code1, item_code2, item_code3, item_code4, item_code5, mode);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = stmas_search_V3;
                _ResponseModel.length = stmas_search_V3.Count();
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


        [Route("v4/stmas_search_V4")]
        [HttpGet]
        public ResponseModel stmas_search_V4([FromUri] string item_gbarcode = "", string item_spcodes = "", string item_code = "", string item_name = "", string item_code1 = "", string item_code3 = "", string search_item_productdivision = "", string search_item_maincategory = "", string search_item_subcategory = "", [FromUri] string mode = "")
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<StmasModel_v2> stmas_search_V4 = AccurateRepository.stmas_search_V4(item_gbarcode, item_spcodes, item_code, item_name, item_code1, item_code3, search_item_productdivision, search_item_maincategory, search_item_subcategory, mode);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = stmas_search_V4;
                _ResponseModel.length = stmas_search_V4.Count();
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


        #region VSK-PROG-ITEMMASTER-001 :  ItemMaster_Update
        [Route("v1/itemmaster_update")]
        [HttpPost]
        public ResponseModel ItemMaster_Update([FromBody] ItemMasterModel ItemMasterModel)
        {
            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();
                List<ItemMasterModel> ItemMaster_Update = ItemMasterRepository.ItemMaster_Update(ItemMasterModel);

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

        #region VSK-PROG-ITEMMASTER-001 :  ItemMaster_Update_UAT
        [Route("v1/itemmaster_update_uat")]
        [HttpPost]
        public ResponseModel ItemMaster_Update_UAT([FromBody] ItemMasterUATModel ItemMasterUATModel)
        {
            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();
                List<ItemMasterUATModel> ItemMaster_Update_UAT = ItemMasterRepository.ItemMaster_Update_UAT(ItemMasterUATModel);

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


        [Route("v1/apmas_get")]
        [HttpGet]
        public ResponseModel apmas_get([FromUri] ApmasModel ApmasModel)
        {
            try
            {
                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();
                List<ApmasModel> apmas_get = ItemMasterRepository.apmas_get(ApmasModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = apmas_get;
                _ResponseModel.length = apmas_get.Count();
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


        [Route("v1/gcode_select2_get")]
        [HttpGet]
        public ResponseModel Gcode_Select2_Get([FromUri] GcodeModel GcodeModel)
        {
            try
            {
                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();
                List<ResponseSelect2Model> Gcode_Select2_Get = ItemMasterRepository.Gcode_Select2_Get(GcodeModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Gcode_Select2_Get;
                _ResponseModel.length = Gcode_Select2_Get.Count();
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


        [Route("v1/itemmaster_stockstatus_get")]
        [HttpGet]
        public ResponseModel StockStatus_Get([FromUri] string item_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<StockStatusHistoryModel> StockStatus_Get = AccurateRepository.StockStatus_Get(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = StockStatus_Get;
                _ResponseModel.length = StockStatus_Get.Count();
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

        [Route("v1/itemmaster_vgrmindate_get")]
        [HttpGet]
        public ResponseModel vGRMinDate_Get([FromUri] string item_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<vGRMinDateModel> vGRMinDate_Get = AccurateRepository.vGRMinDate_Get(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = vGRMinDate_Get;
                _ResponseModel.length = vGRMinDate_Get.Count();
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


        [Route("v1/itemmaster_vgrmaxdate_get")]
        [HttpGet]
        public ResponseModel vGRMaxDate_Get([FromUri] string item_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<vGRMaxDateModel> vGRMaxDate_Get = AccurateRepository.vGRMaxDate_Get(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = vGRMaxDate_Get;
                _ResponseModel.length = vGRMaxDate_Get.Count();
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


        [Route("v1/itemmaster_goodprice_get")]
        [HttpGet]
        public ResponseModel GoodPrice_Get([FromUri] string item_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<GoodPriceModel> GoodPrice_Get = AccurateRepository.GoodPrice_Get(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = GoodPrice_Get;
                _ResponseModel.length = GoodPrice_Get.Count();
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

        [Route("v1/grdate_get")]
        [HttpGet]
        public ResponseModel GRDate_Get([FromUri] string item_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<vGRDateModel> GRDate_Get = AccurateRepository.GRDate_Get(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = GRDate_Get;
                _ResponseModel.length = GRDate_Get.Count();
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

        [Route("v1/product_replenishplan_klh_get")]
        [HttpGet]
        public ResponseModel Product_ReplenishPlan_Stock_Factor_KLH_Get_V1([FromUri] string item_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<Product_ReplenishPlan_Stock_Factor_KLH_Model> Product_ReplenishPlan_Stock_Factor_KLH_Get_V1 = AccurateRepository.Product_ReplenishPlan_Stock_Factor_KLH_Get_V1(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Product_ReplenishPlan_Stock_Factor_KLH_Get_V1;
                _ResponseModel.length = Product_ReplenishPlan_Stock_Factor_KLH_Get_V1.Count();
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


        [Route("v1/itemmaster_select2_get")]
        [HttpGet]
        public ResponseModel ItemMaster_Select2_Get(string lov_type, string search)
        {
            ItemMasterRepository AccurateRepository = new ItemMasterRepository();
            List<Select2Model> ItemMaster_Select2_Get = AccurateRepository.ItemMaster_Select2_Get(lov_type,search);

            ResponseModel _ResponseModel = new ResponseModel();

            _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            _ResponseModel.data = ItemMaster_Select2_Get;
            _ResponseModel.length = ItemMaster_Select2_Get.Count();
            _ResponseModel.status = "Success";

            return _ResponseModel;
        }


        [Route("v1/itemmaster_errorlog_get")]
        [HttpGet]
        public ResponseModel ItemMaster_ErrorLog_Get([FromUri] string process_id)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<ItemMasterLogsModel> ItemMaster_ErrorLog_Get = AccurateRepository.ItemMaster_ErrorLog_Get(process_id);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ItemMaster_ErrorLog_Get;
                _ResponseModel.length = ItemMaster_ErrorLog_Get.Count();
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


        [Route("v1/itemmaster_dimension_get")]
        [HttpGet]
        public ResponseModel ItemMaster_Dimension_Get([FromUri] string item_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<ExportDimensionModel> ItemMaster_Dimension_Get = AccurateRepository.ItemMaster_Dimension_Get(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ItemMaster_Dimension_Get;
                _ResponseModel.length = ItemMaster_Dimension_Get.Count();
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
