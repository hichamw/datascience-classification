using System.IO;
using System.Text;
using NPOI.XSSF.UserModel;

namespace ConsoleApp1
{
    public class DataLoader
    {

        public void Load(string inputPath, string inputSheet, string outputPath)
        {
            XSSFWorkbook workbook = new XSSFWorkbook(new FileStream(inputPath, FileMode.Open));
            XSSFSheet sheet = workbook.GetSheet(inputSheet) as XSSFSheet;
            var csv = new StringBuilder();

            for (int row = 6; row < 1006; row++)
            {
                var line = "";
                
                for (int cell = 1; cell < 22; cell++)
                {
                    if (row == 6)
                    {
                        line += sheet.GetRow(row).GetCell(cell).StringCellValue + ',';
                    }
                    else
                    { 
                        line += sheet.GetRow(row).GetCell(cell).NumericCellValue.ToString() + ',';
                    }
                }
                csv.AppendLine(line);
            }
            File.WriteAllText(outputPath, csv.ToString());

        }
    }
}