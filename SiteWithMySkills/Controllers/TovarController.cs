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
        public IActionResult Edit(Guid id)
        {
            ViewBag.id = id;
            return View();
        }
        public async Task<IActionResult> AddNewTovarInBD(IFormCollection formitems)
        {
            
            var name = formitems["name"];
            var price = formitems["price"].ToString();
            var opicanie = formitems["opicanie"];
            var img = formitems.Files[0];
            if (img.FileName != null)
            {
                Tovar temp = new Tovar { id = Guid.NewGuid(), Name = name, Price = price.ToString(), Opisanie = opicanie, Img = img.FileName, IdType = 0 };
                string path = "/images/Tovars/" + img.FileName;
               
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await img.CopyToAsync(fileStream);
                }
                datamanager.TovarsItems.SaveTovarItem(temp);
            }
            
            return RedirectToAction("AddNew");
        }
        
    }
}
