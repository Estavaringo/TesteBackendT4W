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
        private static readonly string url = "https://pp.cangooroo.net/";


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


        // POST: BookHotel/Search
        [HttpPost]
        public ActionResult Search(BookHotelModelView bookHotelModelView)
        {
            try
            {
            
                //validate the model received by the form (if it's not validated in view)
                if(!ModelState.IsValid){
                
                    return View("Index", bookHotelModelView);
                    
                }
                
                //create request
                BookHotelRequest bookHotelRequest = new BookHotelRequest(bookHotelModelView);

                //get response
                BookHotelResponse bookHotelResponse =  await searchHotelRoomAsync(bookHotelRequest);


                //orders by total selling price
                bookHotelResponse.Hotels.Sort((x, y) => x.Rooms.TotalSellingPrice.Value.CompareTo(y.Rooms.TotalSellingPrice.Value));
                
                
                //returns the list to be viewed
                return View("Search", bookHotelResponse);

                
            }
            catch
            {
                return View("Error");
            }
        }
        
        [NonAction]
        public static async BookHotelResponse searchHotelRoomAsync(BookHotelRequest request)
        {
            _htppClient.baseAddress = new Uri(url);
            
            // Add an Accept header for JSON format
            _htppClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            
            //send POST request
            HttpResponseMessage response = await _htppClient.PostAsJsonAsync("ws/rest/hotel.svc/Search", request);
            
            if (response.IsSuccessStatusCode)
            {
                // Parse and returns the response body.
                return response.Content.ReadAsAsync<IEnumerable<bookHotelResponse>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
            }
            
            else
            {
                //request failed
                return RedirectToAction("Index");
            }
        
        }
        

    }
}
