using System.Linq;
using System.Web.Mvc;
using DataAccessLayer.Concrete;
using SocialContentWebSite.Models;

namespace MvcProjeKampi.Controllers
{
    public class StatisticsController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var model = new StatisticsModel();

            model.CategoryCount = context.Categories.Count();
            model.Heading = context.Headings.Count(x => x.Category.CategoryName == "Yazılım");
            model.HeadingMax = context.Headings.Max(x => x.Category.CategoryName);
            model.Writer = context.Writers.Count(x => x.WriterName.Contains("a"));

            var question5 = context.Categories.Count(x => x.CategoryStatus == true);
            var question6 = context.Categories.Count(x => x.CategoryStatus == false);
            model.StatusDifference = (question5 - question6);

            return View(model);
        }
    }
}