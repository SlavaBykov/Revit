using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace PipeManager.ExcelLogic
{
    class RunExcel
    {
        private Excel.Application excelApp;
        private Excel.Window excelWindow;
        private Excel.Workbook workbook;
        private Excel.Worksheet sheet;
        private Excel.Range exels;

        public RunExcel() {

            excelApp = new Excel.Application();
            excelApp.Visible = true;
            //количество страниц в книге
            excelApp.SheetsInNewWorkbook = 1;
            Excel.Workbook workbook = excelApp.Workbooks.Add(); ;
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1); ;
            exels  = worksheet.get_Range("B2", "C5");
            exels.Merge(Type.Missing);
            exels.Borders.ColorIndex = 3;
            exels.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            exels.Borders.Weight = Excel.XlBorderWeight.xlThick;

            exels = worksheet.Range["A1", System.Type.Missing];
            exels.EntireColumn.ColumnWidth = 7;

            exels = worksheet.Range["B1", System.Type.Missing];
            exels.EntireColumn.ColumnWidth = 5;

            exels = worksheet.Range["C1", System.Type.Missing];
            exels.EntireColumn.ColumnWidth = 8;

            exels = worksheet.Range["D1", System.Type.Missing];
            exels.EntireColumn.ColumnWidth = 7;

            exels = worksheet.Range["E1", System.Type.Missing];
            exels.EntireColumn.ColumnWidth = 93;



        }

       
    }
}
