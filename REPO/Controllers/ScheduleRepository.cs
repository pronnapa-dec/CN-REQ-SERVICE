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
    public class ScheduleRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection MIS_SERVICE;
        public SqlConnection VSK_Data;
        public SqlConnection VorwinsKLH;

        private void Connection()
        {
            string STR_MIS_SERVICE = ConfigurationManager.ConnectionStrings["MIS_SERVICE"].ToString();
            MIS_SERVICE = new SqlConnection(STR_MIS_SERVICE);

            string STR_VSK_Data = ConfigurationManager.ConnectionStrings["VSK_Data"].ToString();
            VSK_Data = new SqlConnection(STR_VSK_Data);

            string STR_VorwinsKLH = ConfigurationManager.ConnectionStrings["VorwinsKLH"].ToString();
            VorwinsKLH = new SqlConnection(STR_VorwinsKLH);
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        #region SCHD-01 :  Schedule_Daily
        public void Schedule_Daily()
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                Connection();
                VSK_Data.Open();
                VSK_Data.Execute("SP_ItemMaster_ImportUpdateData_Tran_Create", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);
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