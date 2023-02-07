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
    public class SamasRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public MySqlConnection con;
        public SqlConnection sacon;

        private void Connection()
        {
            string myconstr = ConfigurationManager.ConnectionStrings["MySqlConn"].ToString();
            con = new MySqlConnection(myconstr);

            string saconstr = ConfigurationManager.ConnectionStrings["VSK_SA"].ToString();
            sacon = new SqlConnection(saconstr);
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        #region sale_master_get
        public List<SamasModal> Sale_Master_Get(SamasModal SamasModal)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@Mode", SamasModal.mode);

                Connection();
                sacon.Open();
                List<SamasModal> RequestModelList = SqlMapper.Query<SamasModal>(sacon, "SP_SA_Samas_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                sacon.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region sale_master_create
        public List<sa_Ressale_Model> Sale_Master_create(SamasModal SamasModal)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", SamasModal.code);
                objParam.Add("@stel", SamasModal.stel);
                objParam.Add("@sdescript", SamasModal.sdescript);
                objParam.Add("@salegroup", SamasModal.salegroup);
                objParam.Add("@lname", SamasModal.lname);
                objParam.Add("@record_status", SamasModal.record_status);
                objParam.Add("@Branch", SamasModal.Branch);
                objParam.Add("@created_by", SamasModal.created_by);
                objParam.Add("@pMessage", SamasModal.pMessage);

                Connection();
                sacon.Open();
                List<sa_Ressale_Model> Sale_Master_Create = SqlMapper.Query<sa_Ressale_Model>(sacon, "SP_SA_Samas_Create", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                sacon.Close();
                return Sale_Master_Create.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region sale_group_get
        public List<SamasModal> SaleGroup_Get(string Mode, string code)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@Mode", Mode);
                objParam.Add("@code", code);

                Connection();
                sacon.Open();
                List<SamasModal> RequestModelList = SqlMapper.Query<SamasModal>(sacon, "SP_SA_Salegroup_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                sacon.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region sale_branch_get
        public List<SalebranchModal> sale_branch_get()
        {
            try
            {
                string SQLQuery = "SELECT lov_id, lov_group, lov_type, parent_lov_id, lov_code, lov1, lov2 FROM [dbo].[lov_data] WHERE lov_type='Branch'";
                Connection();
                sacon.Open();
                List<SalebranchModal> RequestModelList = sacon.Query<SalebranchModal>(SQLQuery).ToList();
                sacon.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region sale_master_update
        public List<SamasModal> Sale_Master_Update(SamasModal SamasModal)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", SamasModal.code);
                objParam.Add("@stel", SamasModal.stel);
                objParam.Add("@sdescript", SamasModal.sdescript);
                objParam.Add("@salegroup", SamasModal.salegroup);
                objParam.Add("@lname", SamasModal.lname);
                objParam.Add("@record_status", SamasModal.record_status);
                objParam.Add("@Branch", SamasModal.Branch);
                objParam.Add("@updated_by", SamasModal.updated_by);
                objParam.Add("@mode", SamasModal.mode);

                Connection();
                sacon.Open();
                List<SamasModal> Sale_Master_Update = SqlMapper.Query<SamasModal>(sacon, "SP_SA_Samas_Update", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                sacon.Close();
                return Sale_Master_Update.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}