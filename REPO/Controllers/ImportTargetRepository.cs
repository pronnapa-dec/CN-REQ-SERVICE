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
    public class ImportCustomerTargetRepository
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


        #region VSK-IMPORT-CUSTOMER-TARGET-01 :  ImportUpdateData_Tran_Create
        public void ImportCustomerTarget_Tran_Create(List<ImportCustomerTargetTranModel> ImportCustomerTargetTranModel)
        {
            try
            {
                foreach (var ImportCustomerTargetArrayData in ImportCustomerTargetTranModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@temp_id", ImportCustomerTargetArrayData.temp_id);
                    objParam.Add("@item", ImportCustomerTargetArrayData.item);
                    objParam.Add("@code", ImportCustomerTargetArrayData.code);
                    objParam.Add("@year", ImportCustomerTargetArrayData.year);
                    objParam.Add("@targetgroup", ImportCustomerTargetArrayData.targetgroup);
                    objParam.Add("@M01", ImportCustomerTargetArrayData.M01);
                    objParam.Add("@M02", ImportCustomerTargetArrayData.M02);
                    objParam.Add("@M03", ImportCustomerTargetArrayData.M03);
                    objParam.Add("@M04", ImportCustomerTargetArrayData.M04);
                    objParam.Add("@M05", ImportCustomerTargetArrayData.M05);
                    objParam.Add("@M06", ImportCustomerTargetArrayData.M06);
                    objParam.Add("@M07", ImportCustomerTargetArrayData.M07);
                    objParam.Add("@M08", ImportCustomerTargetArrayData.M08);
                    objParam.Add("@M09", ImportCustomerTargetArrayData.M09);
                    objParam.Add("@M10", ImportCustomerTargetArrayData.M10);
                    objParam.Add("@M11", ImportCustomerTargetArrayData.M11);
                    objParam.Add("@M12", ImportCustomerTargetArrayData.M12);
                    objParam.Add("@created_by", ImportCustomerTargetArrayData.created_by);
                    objParam.Add("@created_by2", ImportCustomerTargetArrayData.created_by2);


                    Connection();
                    VSK_Data.Open();
                    VSK_Data.Execute("SP_MasterData_ImportCustomerTarget_Tran_Create", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);
                    VSK_Data.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-IMPORT-CUSTOMER-TARGET-02 :  ImportCustomerTarget_Create
        public List<ImportUpdateDataModel> ImportCustomerTarget_Create(ImportUpdateDataModel ImportUpdateDataModel)
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
                List<ImportUpdateDataModel> ImportCustomerTarget_Create = SqlMapper.Query<ImportUpdateDataModel>(VSK_Data, "SP_MasterData_ImportCustomerTarget_Create", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return ImportCustomerTarget_Create.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-IMPORT-CUSTOMER-TARGET-03 :  ImportCustomerTarget_TemplateGet
        public List<ImportCustomerTargetTranModel> ImportCustomerTarget_TemplateGet(string temp_id, string created_by, string created_by2)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@created_by", created_by);
                objParam.Add("@created_by2", created_by2);

                Connection();
                VSK_Data.Open();
                List<ImportCustomerTargetTranModel> RequestModelList = SqlMapper.Query<ImportCustomerTargetTranModel>(VSK_Data, "SP_MasterData_ImportCustomerTarget_Template_Get", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-IMPORT-CUSTOMER-TARGET-04 :  ImportCustomerTarget_CalcStatus
        public List<ImportCustomerTargetModel> ImportCustomerTarget_CalcStatus(string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@updated_by", updated_by);
                objParam.Add("@updated_by2", updated_by2);

                Connection();
                VSK_Data.Open();
                List<ImportCustomerTargetModel> RequestModelList = SqlMapper.Query<ImportCustomerTargetModel>(VSK_Data, "SP_MasterData_ImportCustomerTarget_CalcStatus", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-IMPORT-CUSTOMER-TARGET-05 :  ImportCustomerTarget_Update
        public void ImportCustomerTarget_Update(string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@updated_by", updated_by);
                objParam.Add("@updated_by2", updated_by2);

                Connection();
                VSK_Data.Open();
                VSK_Data.Execute("SP_MasterData_ImportCustomerTarget_Update", objParam, commandType: CommandType.StoredProcedure, commandTimeout: 600);
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