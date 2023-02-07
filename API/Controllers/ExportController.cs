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

        #region  ITEMMASTER-EXPORT-GOODPRICE-01  : ItemMaster_Goodprice_Get
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
        #endregion


        #region  ACC-ITEMMASTER-EXPORT-02  : Log_Import_UpdateData_Export
        public FileStreamResult Log_Import_UpdateData_Export(string temp_id)
        {

            CultureInfo cultureinfo = new CultureInfo("th-TH");

            ExportRepository ExportRepository = new ExportRepository();
            List<LogImportUpdataDataModel> Log_Import_UpdateData_Export = ExportRepository.Log_Import_UpdateData_Export(temp_id);

            StringBuilder sb = new StringBuilder();
            MemoryStream memStream;
            int startColum = 1;
            int row_no = 1;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Export_File_ImportData");
                worksheet.Cells[startColum, 1].Value = "#";
                worksheet.Cells[startColum, 2].Value = "รหัสสินค้า";
                worksheet.Cells[startColum, 3].Value = "ชื่อสินค้า";
                worksheet.Cells[startColum, 4].Value = "Car Type";
                worksheet.Cells[startColum, 5].Value = "Usage/Car";
                worksheet.Cells[startColum, 6].Value = "Service Year";
                worksheet.Cells[startColum, 7].Value = "ปริมาณ (ลิตร)";
                worksheet.Cells[startColum, 8].Value = "จำนวน (ชิ้น/ลัง)";
                worksheet.Cells[startColum, 9].Value = "ส่วนลดสูงสุด (%)";
                worksheet.Cells[startColum, 10].Value = "กำไรต่ำสุด (%)";
                worksheet.Cells[startColum, 11].Value = "VAT ของส่วนลด/กำไร";
                worksheet.Cells[startColum, 12].Value = "Stock Status";
                worksheet.Cells[startColum, 13].Value = "Remark by PM";
                worksheet.Cells[startColum, 14].Value = "SKU Focus";
                worksheet.Cells[startColum, 15].Value = "ห้ามซื้อ";
                worksheet.Cells[startColum, 16].Value = "ห้ามขาย";
                worksheet.Cells[startColum, 17].Value = "Inactive";
                worksheet.Cells[startColum, 18].Value = "เฉพาะรับลูกค้า";
                worksheet.Cells[startColum, 19].Value = "Life Cycle Action";
                worksheet.Cells[startColum, 20].Value = "Life Cycle Review Date";
                worksheet.Cells[startColum, 21].Value = "Certification Status";
                worksheet.Cells[startColum, 22].Value = "Supersession Barcode";
                worksheet.Cells[startColum, 23].Value = "Relationship Type";
                worksheet.Cells[startColum, 24].Value = "Lock Code";
                worksheet.Cells[startColum, 25].Value = "Planing Type";
                worksheet.Cells[startColum, 26].Value = "Source Type";
                worksheet.Cells[startColum, 27].Value = "Manual Safety Stock";
                worksheet.Cells[startColum, 28].Value = "MOQ";
                worksheet.Cells[startColum, 29].Value = "Lead Time - Supplier";
                worksheet.Cells[startColum, 30].Value = "Lead Time - Item";
                worksheet.Cells[startColum, 31].Value = "Minimum QTY";
                worksheet.Cells[startColum, 32].Value = "Maximum QTY";
                worksheet.Cells[startColum, 33].Value = "Purchase";
                worksheet.Cells[startColum, 34].Value = "Purchase Condition";
                worksheet.Cells[startColum, 35].Value = "Prefer Supplier Code";
                worksheet.Cells[startColum, 36].Value = "Prefer Supplier Name";
                worksheet.Cells[startColum, 37].Value = "Prefer Supplier Discount";
                worksheet.Cells[startColum, 38].Value = "Discount Group";
                worksheet.Cells[startColum, 39].Value = "Purchase Discount Group";
                worksheet.Cells[startColum, 40].Value = "Sales Discount Group";
                worksheet.Cells[startColum, 41].Value = "Transfer Unit";
                worksheet.Cells[startColum, 42].Value = "Minimum QTY Warehouse";
                worksheet.Cells[startColum, 43].Value = "Maximum QTY Warehouse";
                worksheet.Cells[startColum, 44].Value = "LOG_STMAS";
                worksheet.Cells[startColum, 45].Value = "LOG_PURCHASEPLAN";
                worksheet.Cells[startColum, 46].Value = "ผู้อัปเดตข้อมูล";
                worksheet.Cells[startColum, 47].Value = "วันที่อัปเดตข้อมูล";

                foreach (LogImportUpdataDataModel LogImportDataList in Log_Import_UpdateData_Export)
                {

                    //if (GoodPriceList.record_status == 1)
                    //{
                    startColum++;
                    worksheet.Cells[startColum, 1].Value = row_no;
                    worksheet.Cells[startColum, 2].Value = LogImportDataList.code;
                    worksheet.Cells[startColum, 3].Value = LogImportDataList.name;
                    worksheet.Cells[startColum, 4].Value = LogImportDataList.cartype;
                    worksheet.Cells[startColum, 5].Value = LogImportDataList.usagepercar;
                    worksheet.Cells[startColum, 6].Value = LogImportDataList.serviceyear;
                    worksheet.Cells[startColum, 7].Value = LogImportDataList.productsize;
                    worksheet.Cells[startColum, 8].Value = LogImportDataList.productqtyperpack;
                    worksheet.Cells[startColum, 9].Value = LogImportDataList.maxdiscountpercent;
                    worksheet.Cells[startColum, 10].Value = LogImportDataList.minmarginpercent;
                    worksheet.Cells[startColum, 11].Value = LogImportDataList.vatdiscmargin;
                    worksheet.Cells[startColum, 12].Value = LogImportDataList.stockstatus;
                    worksheet.Cells[startColum, 13].Value = LogImportDataList.remarkbypm;
                    worksheet.Cells[startColum, 14].Value = LogImportDataList.skufocus;
                    worksheet.Cells[startColum, 15].Value = LogImportDataList.donotpur;
                    worksheet.Cells[startColum, 16].Value = LogImportDataList.donotsale;
                    worksheet.Cells[startColum, 17].Value = LogImportDataList.ginactive;
                    worksheet.Cells[startColum, 18].Value = LogImportDataList.custconfirm;
                    worksheet.Cells[startColum, 19].Value = LogImportDataList.lifecycleaction;
                    worksheet.Cells[startColum, 20].Value = LogImportDataList.lifecyclereviewdate;
                    worksheet.Cells[startColum, 21].Value = LogImportDataList.certificationstatus;
                    worksheet.Cells[startColum, 22].Value = LogImportDataList.supersessionbarcode;
                    worksheet.Cells[startColum, 23].Value = LogImportDataList.relationshiptype;
                    worksheet.Cells[startColum, 24].Value = LogImportDataList.lockcode;
                    worksheet.Cells[startColum, 25].Value = LogImportDataList.planing_type;
                    worksheet.Cells[startColum, 26].Value = LogImportDataList.source_type;
                    worksheet.Cells[startColum, 27].Value = LogImportDataList.manualsafetystock;
                    worksheet.Cells[startColum, 28].Value = LogImportDataList.moq;
                    worksheet.Cells[startColum, 29].Value = LogImportDataList.leadtimesupplier;
                    worksheet.Cells[startColum, 30].Value = LogImportDataList.leadtimeitem;
                    worksheet.Cells[startColum, 31].Value = LogImportDataList.minqtyconst;
                    worksheet.Cells[startColum, 32].Value = LogImportDataList.maxqtyconst;
                    worksheet.Cells[startColum, 33].Value = LogImportDataList.purchase;
                    worksheet.Cells[startColum, 34].Value = LogImportDataList.purcon;
                    worksheet.Cells[startColum, 35].Value = LogImportDataList.prefsuppliercode;
                    worksheet.Cells[startColum, 36].Value = LogImportDataList.prefsuppliername;
                    worksheet.Cells[startColum, 37].Value = LogImportDataList.prefsupplierdisc;
                    worksheet.Cells[startColum, 38].Value = LogImportDataList.discgroup;
                    worksheet.Cells[startColum, 39].Value = LogImportDataList.purdiscgroup;
                    worksheet.Cells[startColum, 40].Value = LogImportDataList.salediscgroup;
                    worksheet.Cells[startColum, 41].Value = LogImportDataList.transferunit;
                    worksheet.Cells[startColum, 42].Value = LogImportDataList.minqtywarehouse;
                    worksheet.Cells[startColum, 43].Value = LogImportDataList.maxqtywarehouse;
                    worksheet.Cells[startColum, 44].Value = LogImportDataList.log_stmas;
                    worksheet.Cells[startColum, 45].Value = LogImportDataList.log_productplan;
                    worksheet.Cells[startColum, 46].Value = LogImportDataList.created_by2;
                    worksheet.Cells[startColum, 47].Value = LogImportDataList.created_date;

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
            var fileName = "Export_File_ImportData.xlsx";

            return File(memStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }
        #endregion


        #region  ACC-ITEMMASTER-EXPORT-03  : Log_Import_CommonPrice_Export
        public FileStreamResult Log_Import_CommonPrice_Export(string temp_id)
        {

            CultureInfo cultureinfo = new CultureInfo("th-TH");

            ExportRepository ExportRepository = new ExportRepository();
            List<LogImportCommonPriceModel> Log_Import_CommonPrice_Export = ExportRepository.Log_Import_CommonPrice_Export(temp_id);

            StringBuilder sb = new StringBuilder();
            MemoryStream memStream;
            int startColum = 1;
            int row_no = 1;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Export_File_Import_CommonPrice");
                worksheet.Cells[startColum, 1].Value = "#";
                worksheet.Cells[startColum, 2].Value = "รหัสสินค้า";
                worksheet.Cells[startColum, 3].Value = "ชื่อสินค้า";
                worksheet.Cells[startColum, 4].Value = "สาขา";
                worksheet.Cells[startColum, 5].Value = "ราคาตั้งซื้อ";
                worksheet.Cells[startColum, 6].Value = "ราคาตั้งขาย";
                worksheet.Cells[startColum, 7].Value = "ราคาขาย A";
                worksheet.Cells[startColum, 8].Value = "ราคาขาย B";
                worksheet.Cells[startColum, 9].Value = "ราคาขาย C";
                worksheet.Cells[startColum, 10].Value = "ราคาขาย D";
                worksheet.Cells[startColum, 11].Value = "ราคาขาย E";
                worksheet.Cells[startColum, 12].Value = "ราคาขาย F";
                worksheet.Cells[startColum, 13].Value = "ส่วนลดราคาขาย A";
                worksheet.Cells[startColum, 14].Value = "ส่วนลดราคาขาย B";
                worksheet.Cells[startColum, 15].Value = "ส่วนลดราคาขาย C";
                worksheet.Cells[startColum, 16].Value = "ส่วนลดราคาขาย D";
                worksheet.Cells[startColum, 17].Value = "ส่วนลดราคาขาย E";
                worksheet.Cells[startColum, 18].Value = "ส่วนลดราคาขาย F";
                worksheet.Cells[startColum, 19].Value = "LOG_STMAS";
                worksheet.Cells[startColum, 20].Value = "ผู้อัปเดตข้อมูล";
                worksheet.Cells[startColum, 21].Value = "วันที่อัปเดตข้อมูล";

                foreach (LogImportCommonPriceModel LogImportCommonPriceList in Log_Import_CommonPrice_Export)
                {

                    //if (GoodPriceList.record_status == 1)
                    //{
                    startColum++;
                    worksheet.Cells[startColum, 1].Value = row_no;
                    worksheet.Cells[startColum, 2].Value = LogImportCommonPriceList.code;
                    worksheet.Cells[startColum, 3].Value = LogImportCommonPriceList.name;
                    worksheet.Cells[startColum, 4].Value = LogImportCommonPriceList.branch;
                    worksheet.Cells[startColum, 5].Value = LogImportCommonPriceList.gpricepur;
                    worksheet.Cells[startColum, 6].Value = LogImportCommonPriceList.gprice;
                    worksheet.Cells[startColum, 7].Value = LogImportCommonPriceList.gpricea;
                    worksheet.Cells[startColum, 8].Value = LogImportCommonPriceList.gpriceb;
                    worksheet.Cells[startColum, 9].Value = LogImportCommonPriceList.gpricec;
                    worksheet.Cells[startColum, 10].Value = LogImportCommonPriceList.gpriced;
                    worksheet.Cells[startColum, 11].Value = LogImportCommonPriceList.gpricee;
                    worksheet.Cells[startColum, 12].Value = LogImportCommonPriceList.gpricef;
                    worksheet.Cells[startColum, 13].Value = LogImportCommonPriceList.gpera;
                    worksheet.Cells[startColum, 14].Value = LogImportCommonPriceList.gperb;
                    worksheet.Cells[startColum, 15].Value = LogImportCommonPriceList.gperc;
                    worksheet.Cells[startColum, 16].Value = LogImportCommonPriceList.gperd;
                    worksheet.Cells[startColum, 17].Value = LogImportCommonPriceList.gpere;
                    worksheet.Cells[startColum, 18].Value = LogImportCommonPriceList.gperf;
                    worksheet.Cells[startColum, 19].Value = LogImportCommonPriceList.log_stmas;
                    worksheet.Cells[startColum, 20].Value = LogImportCommonPriceList.created_by2;
                    worksheet.Cells[startColum, 21].Value = LogImportCommonPriceList.created_date;

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
            var fileName = "Export_File_Import_CommonPrice.xlsx";

            return File(memStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }
        #endregion


        #region  DIMENSION-EXPORT-04  : Dimension_Export
        public FileStreamResult Dimension_Export(DimensionExportModel DimensionExportModel)
        {

            CultureInfo cultureinfo = new CultureInfo("th-TH");

            ExportRepository ExportRepository = new ExportRepository();
            List<DimensionExportModel> Dimension_Export = ExportRepository.Dimension_Export(DimensionExportModel);

            StringBuilder sb = new StringBuilder();
            MemoryStream memStream;
            int startColum = 1;
            int row_no = 1;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Export_Dimension");
                worksheet.Cells[startColum, 1].Value = "#";
                worksheet.Cells[startColum, 2].Value = "วันที่";
                worksheet.Cells[startColum, 3].Value = "บาร์โค้ด";
                worksheet.Cells[startColum, 4].Value = "รหัสสินค้า";
                worksheet.Cells[startColum, 5].Value = "ชื่อสินค้า";
                worksheet.Cells[startColum, 6].Value = "สถานที่เก็บสินค้า";
                worksheet.Cells[startColum, 7].Value = "จำนวน";
                worksheet.Cells[startColum, 8].Value = "หน่วยนับ";
                worksheet.Cells[startColum, 9].Value = "ความกว้าง";
                worksheet.Cells[startColum, 10].Value = "ความยาว";
                worksheet.Cells[startColum, 11].Value = "ความสูง";
                worksheet.Cells[startColum, 12].Value = "น้ำหนัก";
                worksheet.Cells[startColum, 13].Value = "บรรจุภัณฑ์";
                worksheet.Cells[startColum, 14].Value = "อายุการจัดเก็บ";
                worksheet.Cells[startColum, 15].Value = "ระวังแตก";
                worksheet.Cells[startColum, 16].Value = "จัดเก็บพิเศษ";
                worksheet.Cells[startColum, 17].Value = "เคมีภัณฑ์";
                worksheet.Cells[startColum, 18].Value = "ขนาดใหญ่พิเศษ";
                worksheet.Cells[startColum, 19].Value = "วันที่และเวลาที่บันทึกข้อมูล";
                worksheet.Cells[startColum, 19].Value = "วันที่และเวลาที่บันทึกข้อมูล";

                foreach (DimensionExportModel DimensionList in Dimension_Export)
                {
                    startColum++;
                    worksheet.Cells[startColum, 1].Value = row_no;
                    //worksheet.Cells[startColum, 2].Value = DimensionList.Date;
                    worksheet.Cells[startColum, 2].Value = GetExcelDecimalValueForDate(Convert.ToDateTime(DimensionList.Date));
                    worksheet.Cells[startColum, 2].Style.Numberformat.Format = "dd/mm/yyyy";
                    worksheet.Cells[startColum, 3].Value = DimensionList.Barcode;
                    worksheet.Cells[startColum, 4].Value = DimensionList.Code;
                    worksheet.Cells[startColum, 5].Value = DimensionList.Itemname;
                    worksheet.Cells[startColum, 6].Value = DimensionList.Location;
                    worksheet.Cells[startColum, 7].Value = DimensionList.uom_qty;
                    worksheet.Cells[startColum, 8].Value = DimensionList.UOM;
                    worksheet.Cells[startColum, 9].Value = DimensionList.width;
                    worksheet.Cells[startColum, 10].Value = DimensionList.length;
                    worksheet.Cells[startColum, 11].Value = DimensionList.height;
                    worksheet.Cells[startColum, 12].Value = DimensionList.weight;
                    //worksheet.Cells[startColum, 13].Value = DimensionList.packing;
                    worksheet.Cells[startColum, 13].Value = DimensionList.packing2;
                    worksheet.Cells[startColum, 14].Value = DimensionList.exp;
                    worksheet.Cells[startColum, 15].Value = DimensionList.careful;
                    worksheet.Cells[startColum, 16].Value = DimensionList.special;
                    worksheet.Cells[startColum, 17].Value = DimensionList.chem;
                    worksheet.Cells[startColum, 18].Value = DimensionList.bigsize;
                    //worksheet.Cells[startColum, 19].Value = DimensionList.created_datetime;
                    worksheet.Cells[startColum, 19].Value = Convert.ToDateTime(DimensionList.created_datetime.ToString()).ToOADate();
                    //worksheet.Cells[startColum, 19].Value = GetExcelDecimalValueForDateTime(Convert.ToDateTime(DimensionList.created_datetime));
                    worksheet.Cells[startColum, 19].Style.Numberformat.Format = "dd/mm/yyyy HH:mm:ss";
                    row_no++;
                }

                worksheet.Cells.AutoFitColumns();
                memStream = new MemoryStream(package.GetAsByteArray());

            }
            var fileName = "Export_Dimension.xlsx";

            return File(memStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }
        #endregion
    }
}
