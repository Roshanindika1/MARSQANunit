using MARSQA2.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OfficeOpenXml;
using System.IO;
using DataTable = System.Data.DataTable;
using OfficeOpenXml.Style;

using System.Drawing;
using System.Linq;

namespace MARSQA2.Pages
{
    public class EditSkillExcel : Commondriver
    {
        
        public void EditExcel()
        {  

            string filename = "MARS Project.xlsx";
            string filePath = Directory.GetParent(@"../../../").FullName
                + Path.DirectorySeparatorChar + "DataReader"
                + Path.DirectorySeparatorChar + filename;

            FileInfo fileInfo = new FileInfo(filePath);

            ExcelPackage package = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

            worksheet.Cells[2, 1].Value = "Test Analyst";
            worksheet.Cells[2, 3].Value = "Design";


            // save changes
            package.Save();
           
        }
        public string getTitleexcel(IWebDriver driver)
        {
            DataReaderExcel reader = new DataReaderExcel();
            DataTable dt = reader.readData();

            return dt.Rows[0][0].ToString();

        }
             
    }
    
}
