using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class SyncController : ApiController
    {
        #region SYNC-ITMI-01 : ItemMaster_Information_Sync
        [Route("api/SYNC/ItemMaster_Information_Sync")]
        [HttpGet]
        public ResponseModel ItemMaster_Information_Sync([FromUri] StmasModel StmasModel)
        {
            SyncRepository SyncRepository = new SyncRepository();
            List<StmasModel> ItemMaster_Information_Sync = SyncRepository.ItemMaster_Information_Sync(StmasModel);

            ResponseModel _ResponseModel = new ResponseModel();

            _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            _ResponseModel.data = ItemMaster_Information_Sync;
            _ResponseModel.length = ItemMaster_Information_Sync.Count();
            _ResponseModel.status = "Success";

            return _ResponseModel;
        }
        #endregion


        #region SYNC-ITMI-02 : Schedule_Daily
        [Route("api/SYNC/Schedule_Daily")]
        [HttpGet]
        public ResponseModel Schedule_Daily([FromUri] StmasModel StmasModel)
        {
            SyncRepository SyncRepository = new SyncRepository();
            List<StmasModel> Schedule_Daily = SyncRepository.Schedule_Daily(StmasModel);

            ResponseModel _ResponseModel = new ResponseModel();

            _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            _ResponseModel.data = Schedule_Daily;
            _ResponseModel.length = Schedule_Daily.Count();
            _ResponseModel.status = "Success";

            return _ResponseModel;
        }
        #endregion


        #region SYNC-ITMI-03 : ItemMaster_CommonPrice_Daily_Sync
        [Route("api/SYNC/ItemMaster_CommonPrice_Daily_Sync")]
        [HttpGet]
        public ResponseModel ItemMaster_CommonPrice_Daily_Sync([FromUri] StmasModel StmasModel)
        {
            SyncRepository SyncRepository = new SyncRepository();
            List<StmasModel> ItemMaster_CommonPrice_Daily_Sync = SyncRepository.ItemMaster_CommonPrice_Daily_Sync(StmasModel);

            ResponseModel _ResponseModel = new ResponseModel();

            _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            _ResponseModel.data = ItemMaster_CommonPrice_Daily_Sync;
            _ResponseModel.length = ItemMaster_CommonPrice_Daily_Sync.Count();
            _ResponseModel.status = "Success";

            return _ResponseModel;
        }
        #endregion

    }
}
