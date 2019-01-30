using System.Web.Mvc;
using TesteBackendT4W.Models;
using System.Collections.Generic;

namespace TesteBackendT4W.Controllers
{
    public class HotelController : Controller
    {
        /// <summary>
        /// Get a specific hotel by id
        /// </summary>
        /// <param name="id"></param>
        // GET: Hotel/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {

            List<HotelData> hotels = System.Web.HttpContext.Current.Session["HOTELS"] as List<HotelData>;

            HotelData hotelData = hotels.Find(x => x.Id == id);
            

            return View(hotelData);
        }
            
        
    }
}
