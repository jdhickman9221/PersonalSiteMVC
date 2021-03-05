using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalSite.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resume()
        {


            return View();
        }
        public ActionResult Portfolio()
        {


            return View();
        }


        public ActionResult Contact()
        {


            return View();
        }
        public ActionResult Classmates()
        {


            return View();
        }
        public ActionResult PortfolioDescription()
        {


            return View();
        }

        public ActionResult SimpleCalculator(double? number1, double? number2, string function)
        {
            if (number1 != null && number2 != null)
            //this above is saying if it is NOT null and DOES have value then activate switch.
            {
                switch (function)
                {
                    case "Add":
                        ViewBag.Answer = $"The result of your calculation is {number1 + number2}";
                        break;
                    case "Subtract":
                        ViewBag.Answer = $"The result of your calculation is {number1 - number2}";
                        break;
                    case "Multiply":
                        ViewBag.Answer = $"The result of your calculation is {number1 * number2}";
                        break;
                    case "Divide":
                        if (number2 != 0)
                        {
                            ViewBag.Answer = $"The result of your calculation is {number1 / number2}";
                            break;
                        }
                        else
                        {
                            ViewBag.Answer = $"Sorry, as hard as I try, I cannot divide by Zero.";
                            break;
                        }
                    default:
                        ViewBag.Answer = $"Not enough information was provided.";
                        break;
                }
            }
            else
            {
                ViewBag.Answer = "This calculator requires 2 valid values";
            }

            return View();
        }//end simple calculator

        public ActionResult WaterLab(double? gallons)//made double nullable.
        {
            double lbPerGal = 8.33;
            if (gallons != null)
            {

                ViewBag.Answer = $"Your total water weight is: {gallons * lbPerGal} pounds!";
            }

            else

            {
                ViewBag.Answer = "Sorry that wasn't correct input.";
            }


            return View();
        }//end waterlab
        public ActionResult MadLib(string country, string adjective, string animal, string verb, string place, string liquid)
        {

            if (string.IsNullOrEmpty(country) || string.IsNullOrEmpty(adjective) || string.IsNullOrEmpty(animal) || string.IsNullOrEmpty(verb) || string.IsNullOrEmpty(place) || string.IsNullOrEmpty(liquid))
            {

                ViewBag.MadLib = "Please fill out all areas to get your MadLib!";
            }
            else
            {
                ViewBag.MadLib = $"If you are traveling in {country} and find yourself having to cross a piranha-filled river, here is how to do it safely. Piranhas are more {adjective} during the day, so cross the river at night. Avoid areas with netted {animal} traps! Piranhas may be waiting there looking to {verb} them! Piranhas are attracted to fresh {liquid} and will migrate to it as often as possible. Whatever you do, if you have an open wound, try to find another way to get back to the {place}!";
            }
            return View();
        }//end MadLib
        public ActionResult TempConverter(double? userTemp, string function)//make it nullible
        {
            // let display = userTemp * 9 / 5 + 32;
            if (userTemp != null)
            {
                switch (function)
                {
                    case "Fahrenheit":
                        double? converted = (userTemp / 5) * 9 + 32;
                        ViewBag.convert = $"Your temperature is {converted} Fahrenheit!";
                        break;


                    case "Celcius":
                        double? converted1 = (userTemp - 32) / 1.8;
                        ViewBag.convert = $"Your temperature is {converted1} Fahrenheit!";

                        break;

                    default:
                        ViewBag.convert = "Invalid input.";
                        break;
                }
            }
            else
            {
                ViewBag.convert = "Invalid input.";
            }


            return View();
        }

    }//end class
}//end namespace
