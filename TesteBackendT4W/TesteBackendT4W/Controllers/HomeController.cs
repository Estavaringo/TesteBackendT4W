using System.Web.Mvc;

namespace TesteBackendT4W.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Redirect to search form
        /// </summary>
        [HttpGet]
        public ActionResult Index()
        {
            return RedirectToAction("Index","BookHotel");
        }

        
    }
}