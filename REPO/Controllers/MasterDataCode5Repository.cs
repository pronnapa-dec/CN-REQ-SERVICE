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
    public class MasterDataCode5Repository
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


        #region VSK-ITMI-IMPORT_MASTERDATACODE5-01 :  ItemMaster_ImportMasterDataCode5_Tran_Create
        public void ItemMaster_ImportMasterDataCode5_Tran_Create(List<ImportMasterDataCode5TranModel> ImportMasterDataCode5TranModel)
        {
            try
            {
                foreach (var ImportUpdateDataArrayData in ImportMasterDataCode5TranModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@temp_id", ImportUpdateDataArrayData.temp_id);
                    objParam.Add("@item", ImportUpdateDataArrayData.item);
                    objParam.Add("@c5_code", ImportUpdateDataArrayData.c5_code);
                    objParam.Add("@c5_gname", ImportUpdateDataArrayData.c5_gname);
                    objParam.Add("@carbrand_name", ImportUpdateDataArrayData.carbrand_name);
                    objParam.Add("@carmodel_name", ImportUpdateDataArrayData.carmodel_name);
                    objParam.Add("@carFmyear", ImportUpdateDataArrayData.carFmyear);
                    objParam.Add("@carToyear", ImportUpdateDataArrayData.carToyear);
                    objParam.Add("@carGeneration", ImportUpdateDataArrayData.carGeneration);
                    objParam.Add("@cartype", ImportUpdateDataArrayData.cartype);
                    objParam.Add("@created_by", ImportUpdateDataArrayData.created_by);
                    objParam.Add("@created_by2", ImportUpdateDataArrayData.created_by2);


                    Connection();
                    VSK_Data.Open();
                    //VSK_Data.Execute("SP_ItemMaster_ImportMasterDataCode5_Tran_Create", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);
                    VSK_Data.Execute("SP_ItemMaster_ImportMasterDataCode5_Tran_Create_20211109_new", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);
                    VSK_Data.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-ITMI-IMPORT_MASTERDATACODE5-02 :  ItemMaster_ImportMasterDataCode5_Create
        public List<ImportUpdateDataModel> ItemMaster_ImportMasterDataCode5_Create(ImportUpdateDataModel ImportUpdateDataModel)
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
                List<ImportUpdateDataModel> ItemMaster_ImportMasterDataCode5_Create = SqlMapper.Query<ImportUpdateDataModel>(VSK_Data, "SP_ItemMaster_ImportMasterDataCode5_Create", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return ItemMaster_ImportMasterDataCode5_Create.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-ITMI-IMPORT_MASTERDATACODE5-03 :  ItemMaster_ImportMasterDataCode5_TemplateGet
        public List<ImportMasterDataCode5TranModel> ItemMaster_ImportMasterDataCode5_TemplateGet(string temp_id, string created_by, string created_by2)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@created_by", created_by);
                objParam.Add("@created_by2", created_by2);

                Connection();
                VSK_Data.Open();
                List<ImportMasterDataCode5TranModel> RequestModelList = SqlMapper.Query<ImportMasterDataCode5TranModel>(VSK_Data, "SP_ItemMaster_ImportMasterDataCode5_Template_Get", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-ITMI-IMPORT_MASTERDATACODE5-04 :  ItemMaster_ImportMasterDataCode5_CalcStatus
        public List<ImportUpdateDataModel> ItemMaster_ImportMasterDataCode5_CalcStatus(string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@updated_by", updated_by);
                objParam.Add("@updated_by2", updated_by2);

                Connection();
                VSK_Data.Open();
                List<ImportUpdateDataModel> RequestModelList = SqlMapper.Query<ImportUpdateDataModel>(VSK_Data, "SP_ItemMaster_ImportMasterDataCode5_CalcStatus", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region VSK-ITMI-IMPORT_MASTERDATACODE5-05 :  ItemMaster_ImportMasterDataCode5_Update
        public void ItemMaster_ImportMasterDataCode5_Update(string temp_id, string updated_by, string updated_by2)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", temp_id);
                objParam.Add("@updated_by", updated_by);
                objParam.Add("@updated_by2", updated_by2);

                Connection();
                VSK_Data.Open();
                VSK_Data.Execute("SP_ItemMaster_ImportMasterDataCode5_Update", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);
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