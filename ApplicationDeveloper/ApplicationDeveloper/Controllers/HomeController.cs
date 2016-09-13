using ApplicationDeveloper.Models;
using System;
using System.Web.Mvc;

namespace ApplicationDeveloper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult About(float Pickachu, float squitle, float bull)
        {
            
          
            float data1 = Pickachu;
            float data2 = squitle;
            float data3 = bull;
            float result = 0;
            float pricep = 6;
            float prices = 5;
            float priceb = 5;
            string spunky = "";
         


            float max = Math.Max(data1, Math.Max(data2, data3));
            float min = Math.Min(data1, Math.Min(data2, data3));

            ///Here we are cheking all values for 0
            if (data1 == 0 && data2 == 0 && data3 == 0)
            {
                result = 0;
            }
            ///Here we are calcauting price os single picakchu
            if (data1 != 0 && data2 == 0 && data3 == 0)
            {
                result = data1 * pricep;
            }
            ///Here we are calauting price of single squirtle
            if (data2 != 0 && data1 == 0 && data3 == 0)
            {
                result = data1 * prices;
            }

            ///Here we are calting price of single blubazor
            if (data3 != 0 && data2 == 0 && data1 == 0)
            {
                result = data3 * priceb;
            }
            ///We need to calcate for two pokemon with discount 
            
            /// Here charmder value is 0
            if (data1 >= 1 && data2 >= 1 && data3 == 0)
            {
                float max1 = Math.Max(data1, data2);
                float min1 = Math.Min(data1, data2);

                float sub1 = max1 - min1;
                float temp1;
                float temp2;
                float temp3;
                float Varun = 0;

                temp1 = (min1 * pricep) + (min1 * prices);


                temp2 = temp1 * 10 / 100;
                temp3 = temp1 - temp2;
                if (data1 > data2)
                {
                    Varun = sub1 * pricep;
                }
                else if (data2 > data1)
                {
                    Varun = sub1 * prices;
                }

                result = temp3 + Varun;
            }
            ///Here pickachu values is 0
            if (data3 >= 1 && data2 >= 1 && data1 == 0)
            {
                float max1 = Math.Max(data3, data2);
                float min1 = Math.Min(data3, data2);

                float sub1 = max1 - min1;
                float temp1;
                float temp2;
                float temp3;
                float Varun = 0;

                temp1 = (min1 * priceb) + (min1 * prices);


                temp2 = temp1 * 10 / 100;
                temp3 = temp1 - temp2;
                if (data3 > data2)
                {
                    Varun = sub1 * priceb;
                }
                else if (data2 > data3)
                {
                    Varun = sub1 * prices;
                }

                result = temp3 + Varun;
            }
            ///Here squirtle value is 0
            if (data3 >= 1 && data1 >= 1 && data2 == 0)
            {
                float max1 = Math.Max(data3, data1);
                float min1 = Math.Min(data3, data1);

                float sub1 = max1 - min1;
                float temp1;
                float temp2;
                float temp3;
                float Varun = 0;

                temp1 = (min1 * priceb) + (min1 * pricep);


                temp2 = temp1 * 10 / 100;
                temp3 = temp1 - temp2;
                if (data3 > data1)
                {
                    Varun = sub1 * priceb;
                }
                else if (data1 > data3)
                {
                    Varun = sub1 * pricep;
                }

                    
                    result = temp3 + Varun;
               


            }

            ///Here we are caluting for 3 pokemon discount
            /// 

            if (data1>=1 && data2>=1 && data3 >=1)
            {
                float temp1;
                float temp2;
                float temp3;
                float temp4;
                float temp5;
                float temp6;
                
                temp1 = (min*pricep) + (min*prices) + (min*priceb);
                temp2 = temp1* 20  /100;
                temp6 = temp1 - temp2;


                temp3 = data1 - min;
                temp4 = data2 - min;
                temp5 = data3 - min;


                temp3 = temp3*pricep;
                temp4 = temp4*prices;
                temp5 = temp5*priceb;
                result = temp6 + temp3 + temp4 + temp5;
             
            }



            var poke = new pokemon
            {
                answer = result,


            };


            return View(poke);
          
         
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}