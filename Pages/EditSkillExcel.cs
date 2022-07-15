using MARSQA2.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OfficeOpenXml;
using System.IO;
using DataTable = System.Data.DataTable;
using OfficeOpenXml.Style;

namespace MARSQA2.Pages
{
    public class EditSkillExcel : Commondriver
    {
        
        public void EditExcel()
        {
            string filename = "MARS Project.xlsx";
            ExcelPackage ExcelPkg = new ExcelPackage();
            ExcelWorksheet wsSheet1 = ExcelPkg.Workbook.Worksheets.Add("Sheet1");

            string filePath = Directory.GetParent(@"../../../").FullName
                + Path.DirectorySeparatorChar + "DataReader"
                + Path.DirectorySeparatorChar + filename;
            

            int recordIndex = 2;


            wsSheet1.Cells[recordIndex, 1].Value = "Test Analyst";
            
            wsSheet1.Column(1).AutoFit();
            

            wsSheet1.Protection.IsProtected = false;
            wsSheet1.Protection.AllowSelectLockedCells = false;
            ExcelPkg.SaveAs(filePath);

        }

        public string readdataExcel()
        {
            DataReaderExcel reader = new DataReaderExcel();
            DataTable dt = reader.readData();
            return dt.Rows[0][0].ToString();
        }
       
    }
    
}
