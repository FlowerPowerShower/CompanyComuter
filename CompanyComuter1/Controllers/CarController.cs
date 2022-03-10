using CompanyComuter1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CompanyComuter1.Controllers
{
    public class CarController : Controller
    {
        // GET: Car


                
                string Baseurl = "https://caremissionapi.herokuapp.com/";
                public async Task<ActionResult> Index()
                {
                        
                    List<ApiCarModel> carInfo = new List<ApiCarModel>();
                    using (var client = new HttpClient())
                    {
                       
                        client.BaseAddress = new Uri(Baseurl);
                        client.DefaultRequestHeaders.Clear();
                        //Define request data format
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                       
                        HttpResponseMessage Res = await client.GetAsync("GetCars/");
                        
                        if (Res.IsSuccessStatusCode)
                        {
                            
                            var CarData = Res.Content.ReadAsStringAsync().Result;
                            System.Diagnostics.Debug.WriteLine(CarData);

                            carInfo = JsonConvert.DeserializeObject<List<ApiCarModel>>(CarData);
                        }

               
                        return View(carInfo);
                    }
                }
                

        

    }
            
}
