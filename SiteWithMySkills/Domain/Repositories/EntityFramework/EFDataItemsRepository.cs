using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System;
using SiteWithMySkills.Domain.Repositories.Abstract;
using SiteWithMySkills.Models;
using NPOI.HSSF.UserModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SiteWithMySkills.Domain.Repositories.EntityFramework
{
    public class EFDataItemsRepository : IDataRepository
    {
        private readonly AppDbContext context;
        public EFDataItemsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public string GetCellValueWeather(ICell cell)
        {
            if (cell == null)
            {
                return string.Empty;
            }

            switch (cell.CellType)
            {
                case CellType.Blank:
                    return string.Empty;
                case CellType.Boolean:
                    return cell.BooleanCellValue.ToString();
                case CellType.Error:
                    return cell.ErrorCellValue.ToString();
                case CellType.Numeric:
                case CellType.Unknown:
                default:
                    return cell.ToString();
                case CellType.String:
                    return cell.StringCellValue;
                case CellType.Formula:
                    try
                    {
                        HSSFFormulaEvaluator e = new HSSFFormulaEvaluator(cell.Sheet.Workbook);

                        e.EvaluateInCell(cell);
                        return cell.ToString();
                    }
                    catch
                    {
                        return cell.NumericCellValue.ToString();
                    }
            }
        }

        public List<Weather> GetDataFromDBWeather(int year, int month)
        {
            List<Weather> temp = new List<Weather>();
            
                IQueryable<Weather> weathers = context.Weathers.Where(p => p.Year == year.ToString());
                /*weathers = weathers.Where(p => p.Year == year.ToString());*/
                weathers = weathers.Where(p => p.Month == month.ToString());
                weathers = weathers.OrderBy(p => p.Date).ThenBy(p => p.Time);

                temp = weathers.ToList();
                return temp;
            
        }

        public void GetDataFromExcelWeather(string filePath)
        {
            IWorkbook Workbook;
            DataTable table = new DataTable();

            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    // XSSFWorkbook подходит для формата XLSX, HSSFWorkbook подходит для формата XLS
                    string fileExt = Path.GetExtension(filePath).ToLower();
                    if (fileExt == ".xls")
                    {
                        Workbook = new HSSFWorkbook(fileStream);
                    }
                    else if (fileExt == ".xlsx")
                    {
                        Workbook = new XSSFWorkbook(fileStream);
                    }
                    else
                    {
                        Workbook = null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
                for (int she = 0; she < Workbook.NumberOfSheets; she++)
                {
                    // Находим на первом листе
                    ISheet sheet = Workbook.GetSheetAt(she);

                    // Первая строка - это строка заголовка

                    for (int i = 4; i <= sheet.LastRowNum; i++)
                    {

                        IRow headerRow = sheet.GetRow(i);
                        int cellCount = headerRow.LastCellNum;// Номер первой строки и столбца
                                                              // Общее количество столбцов
                        IRow row = sheet.GetRow(i);
                        DataRow dataRow = table.NewRow();

                        List<string> vs = new List<string>();

                        if (row != null)
                        {

                            for (int z = row.FirstCellNum; z < cellCount; z++)
                            {
                                if (row.GetCell(z) != null)
                                {
                                    vs.Add(GetCellValueWeather(row.GetCell(z)));
                                }
                            }
                            if (vs.Count < 12) { vs.Add(""); }
                        }

                        Weather weather = new Weather(vs);
                        context.Weathers.Add(weather);

                    }

                }
                context.SaveChanges();

            

        }

        public void UpdateDataFromExcelWeather(string filePath)
        {
            GetDataFromExcelWeather(filePath);
        }
        public List<Weather> GetFullDataWeather(int year, int month)
        {
            List<Weather> Weathers = new List<Weather>();
            if (context.Weathers.ToList().Count != 0)

                {
                    Weathers = GetDataFromDBWeather(year, month);

                }
                else
                {

                    var names = Directory.GetFiles(@"DataWeather\");
                    for (int i = 0; i < names.Length; i++)
                    {
                        GetDataFromExcelWeather(string.Format(names[i]));
                    }
                    Weathers = GetDataFromDBWeather(year, month);

                }

            return Weathers;
        }

        public void SendMessage(Message msg)
        {
            context.MessageItems.Add(msg);
            context.SaveChanges();
        }
    }
}
