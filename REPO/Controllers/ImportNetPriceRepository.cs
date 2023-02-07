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
    public class ImportNetPriceRepository
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

        #region VSK-ITMI-IMPORT-01 :  ImportNetPrice_Create
        public void ImportNetPrice_Create(List<ImportNetPriceModel> ImportNetPriceModel)
        {
            try
            {
                foreach (var ImportNetPriceArrayData in ImportNetPriceModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@item", ImportNetPriceArrayData.item);
                    objParam.Add("@code", ImportNetPriceArrayData.code);
                    objParam.Add("@qty_a", ImportNetPriceArrayData.qty_a);
                    objParam.Add("@qty_b", ImportNetPriceArrayData.qty_b);
                    objParam.Add("@qtysmall", ImportNetPriceArrayData.qtysmall);
                    objParam.Add("@UOM", ImportNetPriceArrayData.UOM);
                    objParam.Add("@prod_net", ImportNetPriceArrayData.prod_net);
                    objParam.Add("@created_by", ImportNetPriceArrayData.created_by);

                    Connection();
                    VSK_Data.Open();
                    VSK_Data.Execute("SP_ItemMaster_ImportNetPrice_Create", objParam, commandType: CommandType.StoredProcedure);
                    //List<ImportNetPriceModel> ImportNetPrice_Create = SqlMapper.Query<ImportNetPriceModel>(VSK_Data, "SP_ACC_PayinList_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                    VSK_Data.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}