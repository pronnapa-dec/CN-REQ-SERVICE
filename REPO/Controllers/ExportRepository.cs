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
    public class ExportRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection MIS_SERVICE;
        public SqlConnection VSK_Data;
        public SqlConnection VSK_Data_Test;
        public MySqlConnection MariaDBConn;

        private void Connection()
        {
            string STR_MIS_SERVICE = ConfigurationManager.ConnectionStrings["MIS_SERVICE"].ToString();
            MIS_SERVICE = new SqlConnection(STR_MIS_SERVICE);

            string STR_VSK_Data = ConfigurationManager.ConnectionStrings["VSK_Data"].ToString();
            VSK_Data = new SqlConnection(STR_VSK_Data);

            string STR_VSK_Data_Test = ConfigurationManager.ConnectionStrings["VSK_Data_Test"].ToString();
            VSK_Data_Test = new SqlConnection(STR_VSK_Data_Test);

            string STR_VSK_Barcode = ConfigurationManager.ConnectionStrings["MariaDBConn"].ToString();
            MariaDBConn = new MySqlConnection(STR_VSK_Barcode);
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        #region  ACC-ITEMMASTER-EXPORT-01  : ACC_ItemMaster_Goodprice_Get
        public List<ExportGoodPriceModel> ItemMaster_Goodprice_Get(ExportGoodPriceModel ExportGoodPriceModel)
        {
            try
            {

                //string bill_invdate = BillModel.bill_invdate == DateTime.MinValue ? null : BillModel.bill_invdate.ToString();

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", ExportGoodPriceModel.code);

                Connection();
                VSK_Data.Open();
                List<ExportGoodPriceModel> RequestModelList = SqlMapper.Query<ExportGoodPriceModel>(VSK_Data, "SP_ItemMaster_Export_GoodPrice", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region  ACC-ITEMMASTER-EXPORT-02  : Log_Import_UpdateData_Export
        public List<LogImportUpdataDataModel> Log_Import_UpdateData_Export(string temp_id)
        {
            try
            {
                //string bill_invdate = BillModel.bill_invdate == DateTime.MinValue ? null : BillModel.bill_invdate.ToString();

                DynamicParameters objParam = new DynamicParameters();

                //objParam.Add("@temp_id", LogImportUpdataDataModel.temp_id);
                objParam.Add("@temp_id", temp_id);

                Connection();
                VSK_Data.Open();
                List<LogImportUpdataDataModel> RequestModelList = SqlMapper.Query<LogImportUpdataDataModel>(VSK_Data, "SP_Log_Import_UpdateData_Export", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region  ACC-ITEMMASTER-EXPORT-03  : Log_Import_CommonPrice_Export
        public List<LogImportCommonPriceModel> Log_Import_CommonPrice_Export(string temp_id)
        {
            try
            {
                //string bill_invdate = BillModel.bill_invdate == DateTime.MinValue ? null : BillModel.bill_invdate.ToString();

                DynamicParameters objParam = new DynamicParameters();

                //objParam.Add("@temp_id", LogImportUpdataDataModel.temp_id);
                objParam.Add("@temp_id", temp_id);

                Connection();
                VSK_Data_Test.Open();
                List<LogImportCommonPriceModel> RequestModelList = SqlMapper.Query<LogImportCommonPriceModel>(VSK_Data_Test, "SP_Log_Import_CommonPrice_Export", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data_Test.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region  DIMENSION-04  : Dimension_Export
        public List<DimensionExportModel> Dimension_Export(DimensionExportModel DimensionExportModel)
        {
            try
            {
                //string bill_invdate = BillModel.bill_invdate == DateTime.MinValue ? null : BillModel.bill_invdate.ToString();

                DynamicParameters objParam = new DynamicParameters();

                Connection();
                MariaDBConn.Open();
                List<DimensionExportModel> RequestModelList = SqlMapper.Query<DimensionExportModel>(MariaDBConn, "SP_EXPORT_DIMENSION", objParam, commandType: CommandType.StoredProcedure).ToList();
                MariaDBConn.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion



    }
}