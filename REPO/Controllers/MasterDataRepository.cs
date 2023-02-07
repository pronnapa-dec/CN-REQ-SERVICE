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
    public class MasterDataRepository
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

        public List<EmmasModel> MasterData_Customer_List_Get(EmmasModel EmmasModel)
        {

            try
            {
                DynamicParameters objParam = new DynamicParameters();

                //objParam.Add("@search_item_gbarcode", search_item_gbarcode);

                Connection();
                VSK_Data.Open();
                List<EmmasModel> MasterData_Customer_List_Get = SqlMapper.Query<EmmasModel>(VSK_Data, "SP_MasterData_Customer_List_Get_v1", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return MasterData_Customer_List_Get.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}