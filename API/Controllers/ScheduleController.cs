using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class ScheduleController : ApiController
    {
        #region SCHD-01 : Schedule_Daily
        [Route("api/Schedule/Schedule_Daily")]
        [HttpGet]
        public ResponseModel Schedule_Daily()
        //public ResponseModel Schedule_Daily([FromUri] StmasModel StmasModel)
        {
            ScheduleRepository ScheduleRepository = new ScheduleRepository();
            ScheduleRepository.Schedule_Daily();

            ResponseModel _ResponseModel = new ResponseModel();

            _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            //_ResponseModel.data = Schedule_Daily;
            //_ResponseModel.length = Schedule_Daily.Count();
            _ResponseModel.status = "Success";

            return _ResponseModel;
        }
        #endregion

    }
}
