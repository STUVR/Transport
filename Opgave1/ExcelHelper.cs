using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class ExcelHelper
    {
        public static void CreateExcel(List<Opgave> opgaveList)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;

            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;

            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Columns.ColumnWidth = 20;
            xlWorkSheet.Cells[1, 1] = "ID";
            xlWorkSheet.Cells[1, 2] = "Tekst";
            xlWorkSheet.Cells[1, 3] = "Dato";
            xlWorkSheet.Cells[1, 4] = "Container";
            xlWorkSheet.Cells[1, 5] = "Nuværende Position";
            xlWorkSheet.Cells[1, 6] = "Destination";
            xlWorkSheet.Cells[1, 7] = "Kunde";
            xlWorkSheet.Cells[1, 8] = "Kunde Id";

            for (int i = 0; i < opgaveList.Count; i++)
            {


                xlWorkSheet.Cells[i + 2 , 1] = opgaveList[i].Id;

                xlWorkSheet.Cells[i + 2, 2] = opgaveList[i].Tekst;
                xlWorkSheet.Cells[i + 2, 3] = opgaveList[i].Dato;
               
                xlWorkSheet.Cells[i +2, 4] = opgaveList[i].ContainerId;
                xlWorkSheet.Cells[i +2, 5] = opgaveList[i].NuværendePosition;
                xlWorkSheet.Cells[i + 2, 6] = opgaveList[i].Destination;
                xlWorkSheet.Cells[i +2 , 7] = opgaveList[i].KundeObject?.Navn ?? "";
                xlWorkSheet.Cells[i + 2, 8] = opgaveList[i].KundeObject?.KundeNr ?? null;
            }
                
            xlWorkBook.SaveAs("C:\\excel\\csharp-Excel.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xlWorkBook.Close(true, misValue, misValue);

            xlApp.Quit();
            
            Marshal.ReleaseComObject(xlWorkSheet);

            Marshal.ReleaseComObject(xlWorkBook);

            Marshal.ReleaseComObject(xlApp);

            Console.WriteLine("Excel file created , you can find the file C:\\excel\\csharp-Excel.xls");
         }
    }
}
