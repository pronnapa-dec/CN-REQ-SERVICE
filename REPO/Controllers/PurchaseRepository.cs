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
    public class PurchaseRepository
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

        public List<CustomePRModel> Custome_PR_Get(string pono_e)
        {

            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@pono_e", pono_e);

                Connection();
                MIS_SERVICE.Open();
                List<CustomePRModel> RequestModelList = SqlMapper.Query<CustomePRModel>(MIS_SERVICE, "SP_Custome_PR_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
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