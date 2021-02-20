using Momenty.Web.Business.Services;
using Momenty.Web.Business.Services.Interfaces;
using System.Web.Mvc;

namespace Momenty.Web.Controllers
{
    public class ScrapeController : Controller
    {
        public JsonResult Test()
        {
            IScrapeService scraper = new ScrapeService();

            return Json(scraper.ScrapeFunds(), JsonRequestBehavior.AllowGet);
        }

    }
}