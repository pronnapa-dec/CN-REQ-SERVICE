using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using System.Text;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Data;
using System.ComponentModel;
using OfficeOpenXml;
using System.Collections;

namespace API.Controllers
{
    public class ExportController : Controller //ApiController Return ค่าออกมาเป็น JSON แต่ Controller Return ออกมาเป็นไฟล์
    {

        private static decimal GetExcelDecimalValueForDate(DateTime date)
        {
            DateTime start = new DateTime(1900, 1, 1);
            TimeSpan diff = date - start;
            return diff.Days + 2;
        }

        //#region  ITEMMASTER-EXPORT-GOODPRICE-01  : ItemMaster_Goodprice_Get
        public FileStreamResult ItemMaster_Goodprice_Get(ExportGoodPriceModel ExportGoodPriceModel)
        {

            CultureInfo cultureinfo = new CultureInfo("th-TH");

            ExportRepository ExportRepository = new ExportRepository();
            List<ExportGoodPriceModel> ItemMaster_Goodprice_Get = ExportRepository.ItemMaster_Goodprice_Get(ExportGoodPriceModel);

            StringBuilder sb = new StringBuilder();
            MemoryStream memStream;
            int startColum = 1;
            int row_no = 1;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("UnitPrice_list");
                worksheet.Cells[startColum, 1].Value = "#";
                worksheet.Cells[startColum, 2].Value = "รหัสสินค้า";
                worksheet.Cells[startColum, 3].Value = "ชื่อสินค้า";
                worksheet.Cells[startColum, 4].Value = "หน่วยนับ";
                worksheet.Cells[startColum, 5].Value = "จำนวน";
                worksheet.Cells[startColum, 6].Value = "ชื่อหน่วยนับ";
                worksheet.Cells[startColum, 7].Value = "ตัว x หน่วยย่อย";
                worksheet.Cells[startColum, 8].Value = "ราคาตั้งซื้อ";
                worksheet.Cells[startColum, 9].Value = "ราคาตั้งขาย";
                worksheet.Cells[startColum, 10].Value = "ราคา A";
                worksheet.Cells[startColum, 11].Value = "ราคา B";
                worksheet.Cells[startColum, 12].Value = "ราคา C";
                worksheet.Cells[startColum, 13].Value = "ราคา D";
                worksheet.Cells[startColum, 14].Value = "ราคา E";
                worksheet.Cells[startColum, 15].Value = "ราคา F";

                foreach (ExportGoodPriceModel GoodPriceList in ItemMaster_Goodprice_Get)
                {

                    //if (GoodPriceList.record_status == 1)
                    //{
                    startColum++;
                    worksheet.Cells[startColum, 1].Value = row_no;
                    worksheet.Cells[startColum, 2].Value = GoodPriceList.code;
                    worksheet.Cells[startColum, 3].Value = GoodPriceList.itemname;
                    worksheet.Cells[startColum, 4].Value = GoodPriceList.goutput;
                    worksheet.Cells[startColum, 5].Value = GoodPriceList.prqty;
                    worksheet.Cells[startColum, 6].Value = GoodPriceList.gunit;
                    worksheet.Cells[startColum, 7].Value = GoodPriceList.qtysmall;
                    worksheet.Cells[startColum, 8].Value = GoodPriceList.gpricepur;
                    worksheet.Cells[startColum, 9].Value = GoodPriceList.gprice;
                    worksheet.Cells[startColum, 10].Value = GoodPriceList.gpriceA;
                    worksheet.Cells[startColum, 11].Value = GoodPriceList.gpriceB;
                    worksheet.Cells[startColum, 12].Value = GoodPriceList.gpriceC;
                    worksheet.Cells[startColum, 13].Value = GoodPriceList.gpriceD;
                    worksheet.Cells[startColum, 14].Value = GoodPriceList.gpriceE;
                    worksheet.Cells[startColum, 15].Value = GoodPriceList.gpriceF;

                    //worksheet.Cells[startColum, 3].Value = GoodPriceList.bill_invcode;
                    //worksheet.Cells[startColum, 13].Value = (GoodPriceList.bill_toption == "1" ? "รับเอง" : GoodPriceList.bill_toption == "2" ? "มอเตอร์ไซต์" : GoodPriceList.bill_toption == "3" ? "ขนส่ง" : "-");
                    //worksheet.Cells[startColum, 2].Value = GetExcelDecimalValueForDate(Convert.ToDateTime(GoodPriceList.bill_invdate));
                    //worksheet.Cells[startColum, 2].Style.Numberformat.Format = "dd/mm/yyyy";
                    //worksheet.Cells[startColum, 17].Value = GoodPriceList.created_date;
                    //worksheet.Cells[startColum, 17].Style.Numberformat.Format = "dd/mm/yyyy hh:mm:ss";
                    row_no++;
                    //}
                }

                worksheet.Cells.AutoFitColumns();
                memStream = new MemoryStream(package.GetAsByteArray());

            }
            var fileName = "UnitPrice_list.xlsx";

            return File(memStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }
        //#endregion
    }
}
