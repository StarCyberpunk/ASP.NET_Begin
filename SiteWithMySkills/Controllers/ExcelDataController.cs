using SiteWithMySkills.Models;
using Microsoft.AspNetCore.Mvc;
using SiteWithMySkills.Domain;

namespace SiteWithMySkills.Controllers
{
    public class ExcelDataController : Controller
    {
        IWebHostEnvironment _appEnvironment;
        private readonly DataManager datamanager;
        public ExcelDataController(DataManager da, IWebHostEnvironment appEnvironment)
        {
            this.datamanager = da;
            _appEnvironment = appEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowNew(int year, int month)
        {
            Weaters W = new Weaters();
            W.month = month;
            W.year = year;
            W.weathersYearMonth = datamanager.DataItems.GetFullDataWeather(year, month);
            return View(W );
        }

        public IActionResult Add()
        {
            return View();
        }
       
        public async Task<IActionResult> AddFile(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                string path = "DataWeather/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
               datamanager.DataItems.UpdateDataFromExcelWeather(path);

            }

            return RedirectToAction("Add");
        }
    }
}
