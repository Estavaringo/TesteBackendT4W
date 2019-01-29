using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TesteBackendT4W.Models;
using TesteBackendT4W.Models.api;

namespace TesteBackendT4W.Controllers
{
    public class BookHotelController : Controller
    {

        private static readonly HttpClient _httpClient = new HttpClient();
        private static readonly string address = "https://pp.cangooroo.net/ws/rest/hotel.svc/Search";


        // GET: BookHotel
        [HttpGet]
        public ActionResult Index()
        {
            try
            {

                BookHotelModelView bookHotelModelView = new BookHotelModelView();


                bookHotelModelView.Destination = new List<SelectListItem>
                {
                    new SelectListItem() { Text = "MIAMI", Value = "1003944" },
                    new SelectListItem() { Text = "ORLANDO", Value = "1010106" }
                };

                bookHotelModelView.MainPaxCountryCodeNationality = "BR";

                return View(bookHotelModelView);
            }
            catch
            {
                return View("Error");
            }
        }

        // POST: BookHotel/Consult
        [HttpPost]
        public ActionResult Consult(BookHotelRequest request)
        {
            try
            {



                return View();
            }
            catch
            {
                return View("Error");
            }
        }


    }
}
