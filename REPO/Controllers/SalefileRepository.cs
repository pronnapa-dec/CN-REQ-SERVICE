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
    public class SalefileRepository
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

        public List<SalefileModel> Salefile_Get_v1(SalefileModel SalefileModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@number", SalefileModel.number);

                Connection();
                MIS_SERVICE.Open();
                List<SalefileModel> RequestModelList = SqlMapper.Query<SalefileModel>(MIS_SERVICE, "SP_Salefile_Get_v1", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS_SERVICE.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SaletraModel> Saletra_Get_v1(SaletraModel SaletraModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@number", SaletraModel.number);

                Connection();
                MIS_SERVICE.Open();
                List<SaletraModel> RequestModelList = SqlMapper.Query<SaletraModel>(MIS_SERVICE, "SP_Saletra_Get_v1", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS_SERVICE.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}