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
    public class ImportPriceListRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection MIS_SERVICE;
        public SqlConnection VSK_Data;

        private void Connection()
        {
            string STR_MIS_SERVICE = ConfigurationManager.ConnectionStrings["MIS_SERVICE"].ToString();
            MIS_SERVICE = new SqlConnection(STR_MIS_SERVICE);

            string STR_VSK_Data = ConfigurationManager.ConnectionStrings["VSK_Data"].ToString();
            VSK_Data = new SqlConnection(STR_VSK_Data);
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion


        #region VSK-IMPORT-PRICELIST-01 :  ImportUpdateData_Stmas_List_Get
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


        #region VSK-IMPORT-PRICELIST-02 :  ImportPriceList_Tran_Create
        public void ImportPriceList_Tran_Create(List<ImportPriceListTranModel> ImportPriceListTranModel)
        {
            try
            {
                foreach (var ImportPriceListArrayData in ImportPriceListTranModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@temp_id", ImportPriceListArrayData.temp_id);
                    objParam.Add("@item", ImportPriceListArrayData.item);
                    objParam.Add("@spcodes", ImportPriceListArrayData.spcodes);
                    objParam.Add("@carbrand", ImportPriceListArrayData.carbrand);
                    objParam.Add("@goem", ImportPriceListArrayData.goem);
                    objParam.Add("@itemname_en", ImportPriceListArrayData.itemname_en);
                    objParam.Add("@itemname_th", ImportPriceListArrayData.itemname_th);
                    objParam.Add("@gprice", ImportPriceListArrayData.gprice);
                    objParam.Add("@price_effectdate", ImportPriceListArrayData.price_effectdate == DateTime.MinValue ? null : ImportPriceListArrayData.price_effectdate.ToString());
                    objParam.Add("@created_by", ImportPriceListArrayData.created_by);

                    Connection();
                    VSK_Data.Open();
                    VSK_Data.Execute("SP_Import_PriceList_Tran_Create", objParam, commandType: CommandType.StoredProcedure);
                    VSK_Data.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-IMPORT-PRICELIST-03 :  ImportPriceList_Create
        public List<ImportPriceListModel> ImportPriceList_Create(ImportPriceListModel ImportPriceListModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", ImportPriceListModel.temp_id);
                objParam.Add("@countitem_all", ImportPriceListModel.countitem_all);
                objParam.Add("@created_by", ImportPriceListModel.created_by);

                Connection();
                VSK_Data.Open();
                List<ImportPriceListModel> ImportUpdateData_Create = SqlMapper.Query<ImportPriceListModel>(VSK_Data, "SP_Import_PriceList_Create", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return ImportUpdateData_Create.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-IMPORT-PRICELIST-04 :  ImportPriceList_TemplateGet
        public List<ImportPriceListTranModel> ImportPriceList_TemplateGet(string temp_id, string created_by)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@created_by", created_by);

                Connection();
                VSK_Data.Open();
                List<ImportPriceListTranModel> RequestModelList = SqlMapper.Query<ImportPriceListTranModel>(VSK_Data, "SP_Import_PriceList_Template_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-IMPORT-PRICELIST-05 :  ImportPriceList_CalcStatus
        public List<ImportPriceListModel> ImportPriceList_CalcStatus(string temp_id, string updated_by)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@updated_by", updated_by);

                Connection();
                VSK_Data.Open();
                List<ImportPriceListModel> RequestModelList = SqlMapper.Query<ImportPriceListModel>(VSK_Data, "SP_Import_PriceList_CalcStatus", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-IMPORT-PRICELIST-06 :  ImportPriceList_Update
        public void ImportPriceList_Update(string temp_id, string updated_by)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@updated_by", updated_by);

                Connection();
                VSK_Data.Open();
                VSK_Data.Execute("SP_Import_PriceList_Update", objParam, commandType: CommandType.StoredProcedure);
                VSK_Data.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}