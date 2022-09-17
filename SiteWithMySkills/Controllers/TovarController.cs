using Microsoft.AspNetCore.Mvc;
using SiteWithMySkills.Domain;
using SiteWithMySkills.Domain.Entities;

namespace SiteWithMySkills.Controllers
{

    public class TovarController : Controller
    {
        private readonly DataManager datamanager;
        IWebHostEnvironment _appEnvironment;
        public TovarController(DataManager da, IWebHostEnvironment appEnvironment)
        {
            this.datamanager = da;
            this._appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            ViewBag.items = datamanager.TovarsItems.GetTovarsItems();

            return View();
        }
        public IActionResult AddNew()
        {
            return View();
        }
        public async Task<IActionResult> AddNewTovarInBD(IFormCollection formitems)
        {
            
            var name = formitems["name"];
            var price = formitems["price"].ToString();
            var opicanie = formitems["opicanie"];
            var img = formitems["img"];
            Tovar temp = new Tovar { id = Guid.NewGuid(), Name = name, Price = price.ToString(), Opisanie = opicanie };
            return RedirectToAction("Add");
        }
        public async Task<IActionResult> AddFile(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                string path = "wwwroot/images/Tovars/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }


            }

            return RedirectToAction("Add");

        }
    }
}
