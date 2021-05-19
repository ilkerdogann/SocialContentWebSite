using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System.Web.Mvc;

namespace SocialContentWebSite.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        public ActionResult Index()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }
    }
}