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
    public class SyncRepository
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

        #region SYNC-ITMI-01 :  ItemMaster_Information_Sync
        public List<StmasModel> ItemMaster_Information_Sync(StmasModel StmasModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                Connection();
                VSK_Data.Open();
                List<StmasModel> ItemMaster_Information_Sync = SqlMapper.Query<StmasModel>(VSK_Data, "SP_ItemMaster_Information_Sync", objParam, commandTimeout: 1200, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return ItemMaster_Information_Sync.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region SYNC-ITMI-02 :  Schedule_Daily
        public List<StmasModel> Schedule_Daily(StmasModel StmasModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                Connection();
                VSK_Data.Open();
                List<StmasModel> Schedule_Daily = SqlMapper.Query<StmasModel>(VSK_Data, "SP_Schedule", objParam, commandTimeout: 1200, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return Schedule_Daily.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region SYNC-ITMI-03 :  ItemMaster_CommonPrice_Daily_Sync
        public List<StmasModel> ItemMaster_CommonPrice_Daily_Sync(StmasModel StmasModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                Connection();
                VSK_Data.Open();
                List<StmasModel> ItemMaster_CommonPrice_Daily_Sync = SqlMapper.Query<StmasModel>(VSK_Data, "SP_ItemMaster_Information_Sync_test_commonprice", objParam, commandTimeout: 1200, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return ItemMaster_CommonPrice_Daily_Sync.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}