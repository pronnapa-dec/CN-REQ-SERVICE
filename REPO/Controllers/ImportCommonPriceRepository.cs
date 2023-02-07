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
    public class ImportCommonPriceRepository
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

            string STR_VSK_Data = ConfigurationManager.ConnectionStrings["VSK_Data"].ToString();
            VSK_Data = new SqlConnection(STR_VSK_Data);

            //string STR_VSK_Data = ConfigurationManager.ConnectionStrings["VSK_Data"].ToString();
            //VSK_Data = new SqlConnection(STR_VSK_Data);
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion


        #region VSK-ITMI-IMPORT-COMMONPRICE-01 :  ImportCommonPrice_Create
        public List<ImportCommonPriceModel> ImportCommonPrice_Create(ImportCommonPriceModel ImportCommonPriceModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", ImportCommonPriceModel.temp_id);
                objParam.Add("@countitem_all", ImportCommonPriceModel.countitem_all);
                objParam.Add("@created_by", ImportCommonPriceModel.created_by);
                objParam.Add("@created_by2", ImportCommonPriceModel.created_by2);

                Connection();
                VSK_Data.Open();
                List<ImportCommonPriceModel> ImportCommonPrice_Create = SqlMapper.Query<ImportCommonPriceModel>(VSK_Data, "SP_ItemMaster_ImportCommonPrice_Create", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return ImportCommonPrice_Create.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-ITMI-IMPORT-COMMONPRICE-02 :  ImportCommonPrice_Tran_Create
        public void ImportCommonPrice_Tran_Create(List<ImportCommonPriceTranModel> ImportCommonPriceTranModel)
        {
            try
            {
                foreach (var ImportCommonPriceArrayData in ImportCommonPriceTranModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@temp_id", ImportCommonPriceArrayData.temp_id);
                    objParam.Add("@item", ImportCommonPriceArrayData.item);
                    objParam.Add("@code", ImportCommonPriceArrayData.code);
                    objParam.Add("@branch", ImportCommonPriceArrayData.branch);
                    //objParam.Add("@gprice_current", ImportCommonPriceArrayData.gprice_current);
                    objParam.Add("@gprice", ImportCommonPriceArrayData.gprice);
                    objParam.Add("@gpricea", ImportCommonPriceArrayData.gpricea);
                    objParam.Add("@gpriceb", ImportCommonPriceArrayData.gpriceb);
                    objParam.Add("@gpricec", ImportCommonPriceArrayData.gpricec);
                    objParam.Add("@gpriced", ImportCommonPriceArrayData.gpriced);
                    objParam.Add("@gpricee", ImportCommonPriceArrayData.gpricee);
                    objParam.Add("@gpricef", ImportCommonPriceArrayData.gpricef);
                    objParam.Add("@gpera", ImportCommonPriceArrayData.gpera);
                    objParam.Add("@gperb", ImportCommonPriceArrayData.gperb);
                    objParam.Add("@gperc", ImportCommonPriceArrayData.gperc);
                    objParam.Add("@gperd", ImportCommonPriceArrayData.gperd);
                    objParam.Add("@gpere", ImportCommonPriceArrayData.gpere);
                    objParam.Add("@gperf", ImportCommonPriceArrayData.gperf);
                    objParam.Add("@created_by", ImportCommonPriceArrayData.created_by);
                    objParam.Add("@created_by2", ImportCommonPriceArrayData.created_by2);

                    Connection();
                    VSK_Data.Open();
                    VSK_Data.Execute("SP_ItemMaster_ImportCommonPrice_Tran_Create", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);
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


        #region VSK-ITMI-IMPORT-COMMONPRICE-03 :  ItemMaster_ImportCommonPrice_TemplateGet
        public List<ImportCommonPriceTranModel> ItemMaster_ImportCommonPrice_TemplateGet(string temp_id, string created_by, string created_by2)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@created_by", created_by);
                objParam.Add("@created_by2", created_by2);

                Connection();
                VSK_Data.Open();
                List<ImportCommonPriceTranModel> RequestModelList = SqlMapper.Query<ImportCommonPriceTranModel>(VSK_Data, "SP_ItemMaster_ImportCommonPrice_Template_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-ITMI-IMPORT-COMMONPRICE-04 :  ItemMaster_ImportCommonPrice_CalcStatus
        public List<ImportCommonPriceModel> ItemMaster_ImportCommonPrice_CalcStatus(string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@updated_by", updated_by);
                objParam.Add("@updated_by2", updated_by2);

                Connection();
                VSK_Data.Open();
                List<ImportCommonPriceModel> RequestModelList = SqlMapper.Query<ImportCommonPriceModel>(VSK_Data, "SP_ItemMaster_ImportCommonPrice_CalcStatus", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-ITMI-IMPORT-COMMONPRICE-05 :  ItemMaster_ImportCommonPrice_Update
        public void ItemMaster_ImportCommonPrice_Update(string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@updated_by", updated_by);
                objParam.Add("@updated_by2", updated_by2);

                Connection();
                VSK_Data.Open();
                VSK_Data.Execute("SP_ItemMaster_ImportCommonPrice_Update", objParam, commandType: CommandType.StoredProcedure);
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