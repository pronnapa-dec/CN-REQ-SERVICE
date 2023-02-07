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
    public class ItemMasterLovRepository
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

        public List<LovModel> itemmaster_lov_get(string lov_group, string lov_type, string lov_code)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@lov_group", lov_group);
                objParam.Add("@lov_type", lov_type);
                objParam.Add("@lov_code", lov_code);
                
                Connection();
                VSK_Data.Open();
                List<LovModel> RequestModelList = SqlMapper.Query<LovModel>(VSK_Data, "SP_ItemMaster_Lov_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<ProductDivisionModel> itemmaster_productdivision_get(ProductDivisionModel ProductDivisionModel)
        {
            try
            {
                string SQLQuery = "SELECT [Product Division] as ProductDivision FROM ProductDivision$";

                Connection();
                VSK_Data.Open();
                List<ProductDivisionModel> RequestModelList = VSK_Data.Query<ProductDivisionModel>(SQLQuery).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<MainCategoryModel> itemmaster_maincategory_get(MainCategoryModel MainCategoryModel)
        {
            try
            {
                string SQLQuery = "SELECT [Main Category] as MainCategory FROM MainCategory$";

                Connection();
                VSK_Data.Open();
                List<MainCategoryModel> RequestModelList = VSK_Data.Query<MainCategoryModel>(SQLQuery).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SubCategoryModel> itemmaster_subcategory_get(SubCategoryModel SubCategoryModel)
        {
            try
            {
                string SQLQuery = "SELECT [Sub Category] as SubCategory FROM SubCategory$";

                Connection();
                VSK_Data.Open();
                List<SubCategoryModel> RequestModelList = VSK_Data.Query<SubCategoryModel>(SQLQuery).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<gcodeaModel> gcodea_get(gcodeaModel gcodeaModel)
        {
            try
            {
                string SQLQuery = "SELECT rtrim(gname) as gname, rtrim(codechr) as codechr FROM dbo.gcode_a"; Connection();

                Connection();
                VSK_Data.Open();
                List<gcodeaModel> RequestModelList = VSK_Data.Query<gcodeaModel>(SQLQuery).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region VSK-PROG-ItemMaster-002 :  ItemMaster_gcodea_Select2_Get
        public List<gcodeaModel> ItemMaster_gcodea_Select2_Get(string search)
        {
            try
            {
                string SQLQuery = "SELECT RTRIM(codechr) as id" +
                    ", RTRIM(gname) as text " +
                    "FROM dbo.gcode_a " +
                    "WHERE codechr LIKE '" + search + "%'" +
                    //"WHERE codechr LIKE '%" + search + "%'" +
                    "ORDER BY codechr ASC";
                Connection();
                VSK_Data.Open();
                List<gcodeaModel> _ResponseData = VSK_Data.Query<gcodeaModel>(SQLQuery).ToList();
                VSK_Data.Close();
                return _ResponseData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        public List<gcodecModel> gcodec_get(gcodecModel gcodecModel)
        {
            try
            {
                string SQLQuery = "SELECT rtrim(gname) as gname FROM dbo.gcode_c"; Connection();

                Connection();
                VSK_Data.Open();
                List<gcodecModel> RequestModelList = VSK_Data.Query<gcodecModel>(SQLQuery).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LovModel> itemmaster_lov_role_get(string auth_username)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@auth_username", auth_username);

                Connection();
                VSK_Data.Open();
                List<LovModel> RequestModelList = SqlMapper.Query<LovModel>(VSK_Data, "SP_ItemMaster_Lov_Role_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}