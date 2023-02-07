using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using MySql.Data.MySqlClient;
using REPO.Models;

namespace REPO.Controllers
{
    public class ImportUpdateDataRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection MIS_SERVICE;
        public SqlConnection VSK_Data;
        public SqlConnection VSK_Data_Test;

        private void Connection()
        {
            string STR_MIS_SERVICE = ConfigurationManager.ConnectionStrings["MIS_SERVICE"].ToString();
            MIS_SERVICE = new SqlConnection(STR_MIS_SERVICE);

            string STR_VSK_Data_Test = ConfigurationManager.ConnectionStrings["VSK_Data_Test"].ToString();
            VSK_Data_Test = new SqlConnection(STR_VSK_Data_Test);

            string STR_VSK_Data = ConfigurationManager.ConnectionStrings["VSK_Data"].ToString();
            VSK_Data = new SqlConnection(STR_VSK_Data);
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion


        #region VSK-ITMI-IMPORT-UPDATEDATA-01 :  ImportUpdateData_Stmas_List_Get
        public List<StmasModel> importupdatedata_stmas_list_get(StmasModel StmasModel)
        {
            try
            {
                string SQLQuery = "SELECT RTRIM(code) as code, RTRIM(name) as name FROM dbo.stmas";

                Connection();
                VSK_Data.Open();
                List<StmasModel> RequestModelList = VSK_Data.Query<StmasModel>(SQLQuery).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-ITMI-IMPORT-UPDATEDATA-02 :  ImportUpdateData_Tran_Create
        public void ImportUpdateData_Tran_Create(List<ImportUpdateDataTranModel> ImportUpdateDataTranModel)
        {
            try
            {
                foreach (var ImportUpdateDataArrayData in ImportUpdateDataTranModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@auth", ImportUpdateDataArrayData.auth);
                    objParam.Add("@temp_id", ImportUpdateDataArrayData.temp_id);
                    objParam.Add("@item", ImportUpdateDataArrayData.item);
                    objParam.Add("@code", ImportUpdateDataArrayData.code);
                    objParam.Add("@cartype", ImportUpdateDataArrayData.cartype);
                    objParam.Add("@usagepercar", ImportUpdateDataArrayData.usagepercar);
                    objParam.Add("@serviceyear", ImportUpdateDataArrayData.serviceyear);
                    objParam.Add("@productqtyperpack", ImportUpdateDataArrayData.productqtyperpack);
                    objParam.Add("@productsize", ImportUpdateDataArrayData.productsize);
                    objParam.Add("@maxdiscountpercent", ImportUpdateDataArrayData.maxdiscountpercent);
                    objParam.Add("@minmarginpercent", ImportUpdateDataArrayData.minmarginpercent);
                    objParam.Add("@vatdiscmargin", ImportUpdateDataArrayData.vatdiscmargin);
                    objParam.Add("@stockstatus", ImportUpdateDataArrayData.stockstatus);
                    objParam.Add("@remarkbypm", ImportUpdateDataArrayData.remarkbypm);
                    objParam.Add("@skufocus", ImportUpdateDataArrayData.skufocus);
                    objParam.Add("@donotpur", ImportUpdateDataArrayData.donotpur);
                    objParam.Add("@donotsale", ImportUpdateDataArrayData.donotsale);
                    objParam.Add("@ginactive", ImportUpdateDataArrayData.ginactive);
                    objParam.Add("@custconfirm", ImportUpdateDataArrayData.custconfirm);
                    objParam.Add("@lifecycleaction", ImportUpdateDataArrayData.lifecycleaction);
                    //objParam.Add("@lifecyclereviewdate", ImportUpdateDataArrayData.lifecyclereviewdate);
                    objParam.Add("@lifecyclereviewdate", ImportUpdateDataArrayData.lifecyclereviewdate == DateTime.MinValue ? null : ImportUpdateDataArrayData.lifecyclereviewdate.ToString());
                    objParam.Add("@certificationstatus", ImportUpdateDataArrayData.certificationstatus);
                    objParam.Add("@lockcode", ImportUpdateDataArrayData.lockcode);
                    objParam.Add("@supersessionbarcode", ImportUpdateDataArrayData.supersessionbarcode);
                    objParam.Add("@relationshiptype", ImportUpdateDataArrayData.relationshiptype);
                    objParam.Add("@planing_type", ImportUpdateDataArrayData.planing_type);
                    objParam.Add("@source_type", ImportUpdateDataArrayData.source_type);
                    objParam.Add("@manualsafetystock", ImportUpdateDataArrayData.manualsafetystock);
                    objParam.Add("@moq", ImportUpdateDataArrayData.moq);
                    objParam.Add("@leadtimesupplier", ImportUpdateDataArrayData.leadtimesupplier);
                    objParam.Add("@leadtimeitem", ImportUpdateDataArrayData.leadtimeitem);
                    objParam.Add("@minqtyconst", ImportUpdateDataArrayData.minqtyconst);
                    objParam.Add("@maxqtyconst", ImportUpdateDataArrayData.maxqtyconst);
                    objParam.Add("@purchase", ImportUpdateDataArrayData.purchase);
                    objParam.Add("@purcon", ImportUpdateDataArrayData.purcon);
                    objParam.Add("@prefsuppliercode", ImportUpdateDataArrayData.prefsuppliercode);
                    objParam.Add("@prefsupplierdisc", ImportUpdateDataArrayData.prefsupplierdisc);
                    objParam.Add("@discgroup", ImportUpdateDataArrayData.discgroup);
                    objParam.Add("@purdiscgroup", ImportUpdateDataArrayData.purdiscgroup);
                    objParam.Add("@salediscgroup", ImportUpdateDataArrayData.salediscgroup);
                    objParam.Add("@transferunit", ImportUpdateDataArrayData.transferunit);
                    objParam.Add("@minqtywarehouse", ImportUpdateDataArrayData.minqtywarehouse);
                    objParam.Add("@maxqtywarehouse", ImportUpdateDataArrayData.maxqtywarehouse);
                    objParam.Add("@spcodes", ImportUpdateDataArrayData.spcodes);
                    objParam.Add("@codeoem", ImportUpdateDataArrayData.codeoem);
                    objParam.Add("@gdimension", ImportUpdateDataArrayData.gdimension);
                    objParam.Add("@carbrand", ImportUpdateDataArrayData.carbrand);
                    objParam.Add("@carmodel", ImportUpdateDataArrayData.carmodel);
                    objParam.Add("@cargeneration", ImportUpdateDataArrayData.cargeneration);
                    objParam.Add("@matchinno", ImportUpdateDataArrayData.matchinno);
                    objParam.Add("@bodyno", ImportUpdateDataArrayData.bodyno);
                    objParam.Add("@carengine", ImportUpdateDataArrayData.carengine);
                    objParam.Add("@carbody", ImportUpdateDataArrayData.carbody);
                    objParam.Add("@carbodycode", ImportUpdateDataArrayData.carbodycode);
                    objParam.Add("@carfmyear", ImportUpdateDataArrayData.carfmyear);
                    objParam.Add("@cartoyear", ImportUpdateDataArrayData.cartoyear);
                    objParam.Add("@gdescript", ImportUpdateDataArrayData.gdescript);
                    objParam.Add("@stdmargin", ImportUpdateDataArrayData.stdmargin);
                    objParam.Add("@grvat", ImportUpdateDataArrayData.grvat);
                    objParam.Add("@gnamechr", ImportUpdateDataArrayData.gnamechr);
                    objParam.Add("@gmodel", ImportUpdateDataArrayData.gmodel);
                    objParam.Add("@type", ImportUpdateDataArrayData.type);
                    objParam.Add("@gused", ImportUpdateDataArrayData.gused);
                    objParam.Add("@goem", ImportUpdateDataArrayData.goem);
                    objParam.Add("@latestreviewdate", ImportUpdateDataArrayData.latestreviewdate);
                    objParam.Add("@nextreviewdate", ImportUpdateDataArrayData.nextreviewdate);
                    objParam.Add("@reviewtimes", ImportUpdateDataArrayData.reviewtimes);
                    objParam.Add("@created_by", ImportUpdateDataArrayData.created_by);
                    objParam.Add("@created_by2", ImportUpdateDataArrayData.created_by2);

                    Connection();
                    VSK_Data.Open();
                    VSK_Data.Execute("SP_ItemMaster_ImportUpdateData_Tran_Create", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);
                    //VSK_Data.Execute("SP_ItemMaster_ImportUpdateData_Tran_Create_20211104_new", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);
                    VSK_Data.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-ITMI-IMPORT-UPDATEDATA-02 :  ImportUpdateData_Tran_Create_UAT
        public void ImportUpdateData_Tran_Create_UAT(List<ImportUpdateDataTranModel> ImportUpdateDataTranModel)
        {
            try
            {
                foreach (var ImportUpdateDataArrayData in ImportUpdateDataTranModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@auth", ImportUpdateDataArrayData.auth);
                    objParam.Add("@temp_id", ImportUpdateDataArrayData.temp_id);
                    objParam.Add("@item", ImportUpdateDataArrayData.item);
                    objParam.Add("@code", ImportUpdateDataArrayData.code);
                    objParam.Add("@cartype", ImportUpdateDataArrayData.cartype);
                    objParam.Add("@usagepercar", ImportUpdateDataArrayData.usagepercar);
                    objParam.Add("@serviceyear", ImportUpdateDataArrayData.serviceyear);
                    objParam.Add("@productqtyperpack", ImportUpdateDataArrayData.productqtyperpack);
                    objParam.Add("@productsize", ImportUpdateDataArrayData.productsize);
                    objParam.Add("@maxdiscountpercent", ImportUpdateDataArrayData.maxdiscountpercent);
                    objParam.Add("@minmarginpercent", ImportUpdateDataArrayData.minmarginpercent);
                    objParam.Add("@vatdiscmargin", ImportUpdateDataArrayData.vatdiscmargin);
                    objParam.Add("@stockstatus", ImportUpdateDataArrayData.stockstatus);
                    objParam.Add("@remarkbypm", ImportUpdateDataArrayData.remarkbypm);
                    objParam.Add("@skufocus", ImportUpdateDataArrayData.skufocus);
                    objParam.Add("@donotpur", ImportUpdateDataArrayData.donotpur);
                    objParam.Add("@donotsale", ImportUpdateDataArrayData.donotsale);
                    objParam.Add("@ginactive", ImportUpdateDataArrayData.ginactive);
                    objParam.Add("@custconfirm", ImportUpdateDataArrayData.custconfirm);
                    objParam.Add("@lifecycleaction", ImportUpdateDataArrayData.lifecycleaction);
                    //objParam.Add("@lifecyclereviewdate", ImportUpdateDataArrayData.lifecyclereviewdate);
                    objParam.Add("@lifecyclereviewdate", ImportUpdateDataArrayData.lifecyclereviewdate == DateTime.MinValue ? null : ImportUpdateDataArrayData.lifecyclereviewdate.ToString());
                    objParam.Add("@certificationstatus", ImportUpdateDataArrayData.certificationstatus);
                    objParam.Add("@lockcode", ImportUpdateDataArrayData.lockcode);
                    objParam.Add("@supersessionbarcode", ImportUpdateDataArrayData.supersessionbarcode);
                    objParam.Add("@relationshiptype", ImportUpdateDataArrayData.relationshiptype);
                    objParam.Add("@planing_type", ImportUpdateDataArrayData.planing_type);
                    objParam.Add("@source_type", ImportUpdateDataArrayData.source_type);
                    objParam.Add("@manualsafetystock", ImportUpdateDataArrayData.manualsafetystock);
                    objParam.Add("@moq", ImportUpdateDataArrayData.moq);
                    objParam.Add("@leadtimesupplier", ImportUpdateDataArrayData.leadtimesupplier);
                    objParam.Add("@leadtimeitem", ImportUpdateDataArrayData.leadtimeitem);
                    objParam.Add("@minqtyconst", ImportUpdateDataArrayData.minqtyconst);
                    objParam.Add("@maxqtyconst", ImportUpdateDataArrayData.maxqtyconst);
                    objParam.Add("@purchase", ImportUpdateDataArrayData.purchase);
                    objParam.Add("@purcon", ImportUpdateDataArrayData.purcon);
                    objParam.Add("@prefsuppliercode", ImportUpdateDataArrayData.prefsuppliercode);
                    objParam.Add("@prefsupplierdisc", ImportUpdateDataArrayData.prefsupplierdisc);
                    objParam.Add("@discgroup", ImportUpdateDataArrayData.discgroup);
                    objParam.Add("@purdiscgroup", ImportUpdateDataArrayData.purdiscgroup);
                    objParam.Add("@salediscgroup", ImportUpdateDataArrayData.salediscgroup);
                    objParam.Add("@transferunit", ImportUpdateDataArrayData.transferunit);
                    objParam.Add("@minqtywarehouse", ImportUpdateDataArrayData.minqtywarehouse);
                    objParam.Add("@maxqtywarehouse", ImportUpdateDataArrayData.maxqtywarehouse);
                    objParam.Add("@spcodes", ImportUpdateDataArrayData.spcodes);
                    objParam.Add("@codeoem", ImportUpdateDataArrayData.codeoem);
                    objParam.Add("@gdimension", ImportUpdateDataArrayData.gdimension);
                    objParam.Add("@carbrand", ImportUpdateDataArrayData.carbrand);
                    objParam.Add("@carmodel", ImportUpdateDataArrayData.carmodel);
                    objParam.Add("@cargeneration", ImportUpdateDataArrayData.cargeneration);
                    objParam.Add("@matchinno", ImportUpdateDataArrayData.matchinno);
                    objParam.Add("@bodyno", ImportUpdateDataArrayData.bodyno);
                    objParam.Add("@carengine", ImportUpdateDataArrayData.carengine);
                    objParam.Add("@carbody", ImportUpdateDataArrayData.carbody);
                    objParam.Add("@carbodycode", ImportUpdateDataArrayData.carbodycode);
                    objParam.Add("@carfmyear", ImportUpdateDataArrayData.carfmyear);
                    objParam.Add("@cartoyear", ImportUpdateDataArrayData.cartoyear);
                    objParam.Add("@gdescript", ImportUpdateDataArrayData.gdescript);
                    objParam.Add("@created_by", ImportUpdateDataArrayData.created_by);
                    objParam.Add("@created_by2", ImportUpdateDataArrayData.created_by2);

                    Connection();
                    VSK_Data.Open();
                    VSK_Data.Execute("SP_ItemMaster_ImportUpdateData_Tran_Create_UAT", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);
                    //List<ImportNetPriceModel> ImportNetPrice_Create = SqlMapper.Query<ImportNetPriceModel>(VSK_Data_Test, "SP_ACC_PayinList_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                    VSK_Data.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-ITMI-IMPORT-UPDATEDATA-03 :  ImportUpdateData_Create
        public List<ImportUpdateDataModel> ImportUpdateData_Create(ImportUpdateDataModel ImportUpdateDataModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", ImportUpdateDataModel.temp_id);
                objParam.Add("@countitem_all", ImportUpdateDataModel.countitem_all);
                objParam.Add("@created_by", ImportUpdateDataModel.created_by);
                objParam.Add("@created_by2", ImportUpdateDataModel.created_by2);

                Connection();
                VSK_Data.Open();
                List<ImportUpdateDataModel> ImportUpdateData_Create = SqlMapper.Query<ImportUpdateDataModel>(VSK_Data, "SP_ItemMaster_ImportUpdateData_Create", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return ImportUpdateData_Create.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-ITMI-IMPORT-UPDATEDATA-04 :  ItemMaster_ImportUpdateData_TemplateGet
        public List<ImportUpdateDataTranModel> ItemMaster_ImportUpdateData_TemplateGet(string temp_id, string created_by, string created_by2)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@created_by", created_by);
                objParam.Add("@created_by2", created_by2);

                Connection();
                VSK_Data.Open();
                List<ImportUpdateDataTranModel> RequestModelList = SqlMapper.Query<ImportUpdateDataTranModel>(VSK_Data, "SP_ItemMaster_ImportUpdateData_Template_Get", objParam, commandTimeout: 2400, commandType: CommandType.StoredProcedure).ToList();
                //List<ImportUpdateDataTranModel> RequestModelList = SqlMapper.Query<ImportUpdateDataTranModel>(VSK_Data, "SP_ItemMaster_ImportUpdateData_Template_Get_20211027_new", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-ITMI-IMPORT-UPDATEDATA-05 :  ItemMaster_ImportUpdateData_CalcStatus
        public List<ImportUpdateDataModel> ItemMaster_ImportUpdateData_CalcStatus(string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@updated_by", updated_by);
                objParam.Add("@updated_by2", updated_by2);

                Connection();
                VSK_Data.Open();
                List<ImportUpdateDataModel> RequestModelList = SqlMapper.Query<ImportUpdateDataModel>(VSK_Data, "SP_ItemMaster_ImportUpdateData_CalcStatus", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-ITMI-IMPORT-UPDATEDATA-06 :  ItemMaster_ImportUpdateData_Update
        public void ItemMaster_ImportUpdateData_Update(string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@updated_by", updated_by);
                objParam.Add("@updated_by2", updated_by2);

                Connection();
                VSK_Data.Open();
                VSK_Data.Execute("SP_ItemMaster_ImportUpdateData_Update", objParam, commandType: CommandType.StoredProcedure, commandTimeout: 600);
                //VSK_Data.Execute("SP_ItemMaster_ImportUpdateData_Update_20210923_new", objParam, commandType: CommandType.StoredProcedure, commandTimeout: 600);
                VSK_Data.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-ITMI-IMPORT-UPDATEDATA-06 :  ItemMaster_ImportUpdateData_Update_UAT
        public void ItemMaster_ImportUpdateData_Update_UAT(string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@updated_by", updated_by);
                objParam.Add("@updated_by2", updated_by2);

                Connection();
                VSK_Data.Open();
                VSK_Data.Execute("SP_ItemMaster_ImportUpdateData_Update_UAT", objParam, commandType: CommandType.StoredProcedure, commandTimeout: 600);
                //List<ImportUpdateDataModel> RequestModelList = SqlMapper.Query<ImportUpdateDataModel>(VSK_Data, "SP_ItemMaster_ImportUpdateData_Update", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                //return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}