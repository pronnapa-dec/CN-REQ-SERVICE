using REPO.Models;
using REPO.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Data;
using System.ComponentModel;
using OfficeOpenXml;
using System.Collections;
using System.Web.Http;

namespace API.Controllers
{
    public class PurExportController : Controller
    {


        private static decimal GetExcelDecimalValueForDate(DateTime date)
        {
            DateTime start = new DateTime(1900, 1, 1);
            TimeSpan diff = date - start;
            return diff.Days + 2;
        }

        public FileStreamResult Pur_Pod_Export(PkPoIVModel PkPoIVModel)
        {

            CultureInfo cultureinfo = new CultureInfo("th-TH");

            PurRepository PurRepository = new PurRepository();
            List<PkPoIVModel> Pur_Pod_Export = PurRepository.PR_POD_IV_GR_bySale(PkPoIVModel);

            StringBuilder sb = new StringBuilder();
            MemoryStream memStream;
            int startColum = 1;
            //int row_no = 1;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Pur_Pod_Export");
                worksheet.Cells[startColum, 1].Value = "ITEM CODE";
                worksheet.Cells[startColum, 2].Value = "STK CODE";
                worksheet.Cells[startColum, 3].Value = "GBARCODE";
                worksheet.Cells[startColum, 4].Value = "ITEM NAME";
                worksheet.Cells[startColum, 5].Value = "PO NO";
                worksheet.Cells[startColum, 6].Value = "PO/CUS. CODE";
                worksheet.Cells[startColum, 7].Value = "PO QTY";
                worksheet.Cells[startColum, 8].Value = "VENDOR CODE";
                worksheet.Cells[startColum, 9].Value = "VENDOR NAME";
                worksheet.Cells[startColum, 10].Value = "BUYER PO USER";
                worksheet.Cells[startColum, 11].Value = "SEND DATE(EST.)";
                worksheet.Cells[startColum, 12].Value = "RECEIVE DATE(EST.)";
                worksheet.Cells[startColum, 13].Value = "GR NO";
                worksheet.Cells[startColum, 14].Value = "GR DATE";
                worksheet.Cells[startColum, 15].Value = "GR QTY";
                worksheet.Cells[startColum, 16].Value = "PO QTY PENDING";
                worksheet.Cells[startColum, 17].Value = "STATUS";
                worksheet.Cells[startColum, 18].Value = "REMARK";

                foreach (PkPoIVModel Pur_Pod_List in Pur_Pod_Export)
                {
                    startColum++;
                    worksheet.Cells[startColum, 1].Value = Pur_Pod_List.item_code;
                    worksheet.Cells[startColum, 2].Value = Pur_Pod_List.stkcod;
                    worksheet.Cells[startColum, 3].Value = Pur_Pod_List.item_spcodes;
                    worksheet.Cells[startColum, 4].Value = Pur_Pod_List.item_name;
                    worksheet.Cells[startColum, 5].Value = Pur_Pod_List.PO_no;
                    worksheet.Cells[startColum, 6].Value = GetExcelDecimalValueForDate(Convert.ToDateTime(Pur_Pod_List.POdate));
                    worksheet.Cells[startColum, 6].Style.Numberformat.Format = "dd/mm/yyyy";
                    worksheet.Cells[startColum, 7].Value = Pur_Pod_List.PO_qty;
                    worksheet.Cells[startColum, 8].Value = Pur_Pod_List.Vendor_code;
                    worksheet.Cells[startColum, 9].Value = Pur_Pod_List.Vendor_name;
                    worksheet.Cells[startColum, 10].Value = Pur_Pod_List.Buyer_Po_User;
                    worksheet.Cells[startColum, 11].Value = GetExcelDecimalValueForDate(Convert.ToDateTime(Pur_Pod_List.podatesend));
                    worksheet.Cells[startColum, 11].Style.Numberformat.Format = "dd/mm/yyyy";

                    //if (Pur_Pod_List.pr_receive_date.ToString() != "0001-01-01T00:00:00")
                    //{
                    //    worksheet.Cells[startColum, 12].Value = "";
                    //}
                    //else
                    //{
                    //    worksheet.Cells[startColum, 12].Value = GetExcelDecimalValueForDate(Convert.ToDateTime(Pur_Pod_List.pr_receive_date));
                    //    worksheet.Cells[startColum, 12].Style.Numberformat.Format = "dd/mm/yyyy";

                    //}

                    if (GetExcelDecimalValueForDate(Convert.ToDateTime(Pur_Pod_List.pr_receive_date)).ToString() == "-693593")
                    {
                        worksheet.Cells[startColum, 12].Value = "";
                    }
                    else
                    {
                        worksheet.Cells[startColum, 12].Value = GetExcelDecimalValueForDate(Convert.ToDateTime(Pur_Pod_List.pr_receive_date));
                        worksheet.Cells[startColum, 12].Style.Numberformat.Format = "dd/mm/yyyy";
                    }
                    worksheet.Cells[startColum, 13].Value = Pur_Pod_List.GR_no;

                    if (GetExcelDecimalValueForDate(Convert.ToDateTime(Pur_Pod_List.GR_date)).ToString() == "-693593")
                    {
                        worksheet.Cells[startColum, 14].Value = "";
                    } else  {
                        worksheet.Cells[startColum, 14].Value = GetExcelDecimalValueForDate(Convert.ToDateTime(Pur_Pod_List.GR_date));
                        worksheet.Cells[startColum, 14].Style.Numberformat.Format = "dd/mm/yyyy";
                    }

                    worksheet.Cells[startColum, 15].Value = Pur_Pod_List.GR_qty;
                    worksheet.Cells[startColum, 16].Value = Pur_Pod_List.PO_qty_pending;

                    if (Pur_Pod_List.pr_receive_type == "1")  {
                        worksheet.Cells[startColum, 17].Value = "PENDING";

                    } else if (Pur_Pod_List.pr_receive_type == "2"){
                        worksheet.Cells[startColum, 17].Value = "BACKORDER";
                    } else {
                        worksheet.Cells[startColum, 17].Value = "";
                    }
                    worksheet.Cells[startColum, 18].Value = Pur_Pod_List.pr_receive_comment;
                }

                worksheet.Cells.AutoFitColumns();
                memStream = new MemoryStream(package.GetAsByteArray());

            }
            var fileName = "PR_Export_" + DateTime.Now.ToString("ddmmyyyyhhmm") + ".xlsx";

            return File(memStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }


    }
}
