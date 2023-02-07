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
    public class LogRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_Data;
        public SqlConnection VSK_Data_Test;

        private void Connection()
        {
            string STR_VSK_Data = ConfigurationManager.ConnectionStrings["VSK_Data"].ToString();
            VSK_Data = new SqlConnection(STR_VSK_Data);

            string STR_VSK_Data_Test = ConfigurationManager.ConnectionStrings["VSK_Data_Test"].ToString();
            VSK_Data_Test = new SqlConnection(STR_VSK_Data_Test);
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public List<ImportUpdateDataModel> log_import_updatedata_list_get(string username)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@username", username);

                Connection();
                VSK_Data.Open();
                List<ImportUpdateDataModel> RequestModelList = SqlMapper.Query<ImportUpdateDataModel>(VSK_Data, "SP_Log_Import_UpdateData_List_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<ImportCommonPriceModel> log_import_commonprice_list_get(string username)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@username", username);

                Connection();
                VSK_Data_Test.Open();
                List<ImportCommonPriceModel> RequestModelList = SqlMapper.Query<ImportCommonPriceModel>(VSK_Data_Test, "SP_Log_Import_CommonPrice_List_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data_Test.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}