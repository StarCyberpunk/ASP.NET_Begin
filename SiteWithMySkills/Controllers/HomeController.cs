using Microsoft.AspNetCore.Mvc;
using SiteWithMySkills.Domain;
using SiteWithMySkills.Models;
using System.Diagnostics;

namespace SiteWithMySkills.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataManager datamanager;
        public HomeController(ILogger<HomeController> logger, DataManager datamanager)
        {
            _logger = logger;
            this.datamanager = datamanager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> SendMessage(string name,string email,string message)
        {
            Message m = new Message {id=Guid.NewGuid(), Name = name, Email = email, Messages = message };
            datamanager.DataItems.SendMessage(m);
            return RedirectToAction("Index");
        }
    }
}