using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using TesteBackendT4W.Models;
using TesteBackendT4W.Models.api;

namespace TesteBackendT4W.Controllers
{

    /// <summary>
    /// Controller that handles booking requests
    /// </summary>
    public class BookHotelController : Controller{

        private static readonly HttpClient _httpClient = new HttpClient();
        private static readonly string url = "https://pp.cangooroo.net/ws/rest/hotel.svc/Search";


        /// <summary>
        /// Open form to search for rooms
        /// </summary>
        // GET: BookHotel
        [HttpGet]
        public ActionResult Index()
        {
            try
            {
                BookHotelModelView bookHotelModelView = new BookHotelModelView();

                //possible destinations
                ViewBag.Destination = new List<SelectListItem>
                {
                    new SelectListItem() { Text = "MIAMI", Value = "1003944" },
                    new SelectListItem() { Text = "ORLANDO", Value = "1010106" }
                };

                return View(bookHotelModelView);
            }
            catch
            {
                return View("Error");
            }
        }

        /// <summary>
        /// Search for available rooms
        /// </summary>
        /// <param name="bookHotelModelView"></param>
        // POST: BookHotel/Search
        [HttpPost, ActionName("Search")]
        public async Task<ActionResult> SearchAsync(BookHotelModelView bookHotelModelView){
            try
            {

                //fixed value
                bookHotelModelView.MainPaxCountryCodeNationality = "BR";



                //**********************************************************************
                //TEMPORARY FIX
                //CHILD AGES MUST BE PASSED THROUGH A FORM AND SHOULD NOT BE A FIXED VALUE
                //*********************************************************************
                bookHotelModelView.ChildAges = new List<int>();
                for (int i = 0; i <= bookHotelModelView.NumChildren; i++)
                {
                    bookHotelModelView.ChildAges.Add(5);
                }



                //validate the model received by the form 
                if (!ModelState.IsValid){

                    //possible destinations
                    ViewBag.Destination = new List<SelectListItem>{
                        new SelectListItem() { Text = "MIAMI", Value = "1003944" },
                        new SelectListItem() { Text = "ORLANDO", Value = "1010106" }
                    };

                    return View("Index", bookHotelModelView);
                    
                }
                
                //create request
                BookHotelRequest bookHotelRequest = new BookHotelRequest(bookHotelModelView);
                

                //get response
                BookHotelResponse bookHotelResponse =  await SearchHotelRoomAsync(bookHotelRequest);


                //check if the response has any error
                if(bookHotelResponse.Error != null)
                {
                    return View("Index", bookHotelModelView);
                }


                //orders the hotels list by price
                foreach(HotelAvailable hotel in bookHotelResponse.Hotels)
                {
                    hotel.minPrice = int.MaxValue;
                    foreach (Room room in hotel.Rooms)
                    {
                        if (room.TotalSellingPrice.Value < hotel.minPrice) hotel.minPrice = room.TotalSellingPrice.Value; //sets max price for each hotel
                    }
                    
                    hotel.Rooms.Sort((x, y) => x.TotalSellingPrice.Value.CompareTo(y.TotalSellingPrice.Value));
                }
                bookHotelResponse.Hotels.Sort((x, y) => x.minPrice.CompareTo(y.minPrice));



                //returns the hotel list to be viewed
                return View("Search", bookHotelResponse);

                
            }
            catch
            {
                return View("Error");
            }
        }


        /// <summary>
        /// Calls rest API using the request parameter and returns the deserialized response
        /// </summary>
        /// <param name="request"></param>
        [NonAction]
        public async Task<BookHotelResponse> SearchHotelRoomAsync(BookHotelRequest request)
        {

            // Add an Accept header for JSON format
            _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            
            //send POST request
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(url, request);
                      

            if (response.IsSuccessStatusCode)
            {
                // Parse and returns the response body.
                return response.Content.ReadAsAsync<BookHotelResponse>().Result;  
            }
            
            else
            {
                //request failed
                throw new Exception();
            }
        
        }
        

    }
}
