using NPOI.SS.UserModel;
using SiteWithMySkills.Models;

namespace SiteWithMySkills.Domain.Repositories.Abstract
{
    public interface IDataRepository
    {
        public List<Weather> GetDataFromDBWeather(int year, int month);
        public void GetDataFromExcelWeather(string filePath);
        public void UpdateDataFromExcelWeather(string filePath);
        public string GetCellValueWeather(ICell cell);
        public List<Weather> GetFullDataWeather(int year, int month);
        public void SendMessage(Message msg);
            }
}
