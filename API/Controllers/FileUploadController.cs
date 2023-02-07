using REPO.Models;
using System;
using System.Web.Mvc;
using System.Web;
using System.IO;
using System.Configuration;

namespace API.Controllers
{
    public class FileUploadController : Controller
    {
        public ResponseModel FileUpload(HttpPostedFileBase postedFile)
        {
            try
            {
                if (postedFile != null)
                {
                    string path = ConfigurationManager.AppSettings["PathUpload"]; ;

                    ResponseModel _ResponseModel = new ResponseModel();

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    DateTime serverDate = DateTime.Now;
                    string currentDateString = string.Format("{0}", serverDate.ToString("ssffffff"));

                    postedFile.SaveAs(path + currentDateString + '_' + Path.GetFileName(postedFile.FileName));

                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.status = "Success";

                    return _ResponseModel;

                }
                else
                {
                    ResponseModel _ResponseModel = new ResponseModel();
                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.status = "Error";

                    return _ResponseModel;
                }

            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
    }
}
