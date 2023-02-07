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
    public class StmasRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public MySqlConnection con;
        public SqlConnection mscon;

        private void Connection()
        {
            string myconstr = ConfigurationManager.ConnectionStrings["MySqlConn"].ToString();
            con = new MySqlConnection(myconstr);

            string msconstr = ConfigurationManager.ConnectionStrings["MsSqlConn"].ToString();
            mscon = new SqlConnection(msconstr);
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public List<StmasModel> Stmas_Get(string item_code)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@item_code", item_code);
                
                Connection();
                mscon.Open();
                List<StmasModel> RequestModelList = SqlMapper.Query<StmasModel>(mscon, "SP_ACC_STMAS_GET", objParam, commandType: CommandType.StoredProcedure).ToList();
                mscon.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}