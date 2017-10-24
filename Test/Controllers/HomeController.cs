using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Model model)
        {
                model.total = 0;
                string s1 = model.Depart ;
                string s2 = model.Arrive;
                bool   b1 = model.oneWay;
                ViewBag.Bool = b1; 
            if (ModelState.IsValidField("Depart") && ModelState.IsValidField("Arrive") && ModelState.IsValidField("DepartDate") && ModelState.IsValidField("Adults"))
            {
                    DateTime i1 = model.DepartDate.Value.Date;
                    if (s1 == s2)
                    {
                        ViewBag.Message = "Please Choose A Valid Destination";
                        return View();
                    }
                    else
                    {
                        if (i1 < DateTime.Now)
                        {
                        ViewBag.Message = "Please Choose A Valid Date";
                        return View();
                    }
                        else
                        {
                          return View("JourneyTime", model);
                        }
                       
                    }

                 }
                 else
                   {
                       return View();
                   }
            }
   
        public ActionResult JourneyTime()
        {
            return View();
        }

        [HttpPost]
        public ActionResult JourneyTime(Model model)
        {
            if (model.Ch1)
            {
                model.total = model.total + (model.averPrice + (model.averPrice / 3));
            }
            if (model.Ch2)
            {
                model.total += model.averPrice;
            }
            if (model.Ch3)
            {
                model.total += model.averPrice;
            }
            if (model.Ch4)
            {
                model.total += (2 * model.averPrice);
            }
            if (model.Ch5)
            {
                model.total += model.averPrice;
            }
            if (model.oneWay)
            {
                return View("Result",model);
            }
            else
            {
                if (ModelState.IsValidField("ReturnDate"))
                {
                    string s1 = model.Depart;
                    model.Depart = model.Arrive;
                    model.Arrive = s1;
                    return View("ReturnJourneyTime", model);
                }
                else
                {
                    ViewBag.Message2 = "Please Enter A  Return Date";
                    return View(model);
                }
            }

        }
        [HttpGet]
        public ActionResult Result()
        {
            return View();
        }
   
        public ActionResult ReturnJourneyTime()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ReturnJourneyTime(Model model)
        {
            if (!model.oneWay)
            {
                if (model.Ch1)
                {
                    model.total = model.total + (model.averPrice + (model.averPrice / 3));
                }
                if (model.Ch2)
                {
                    model.total += model.averPrice;
                }
                if (model.Ch3)
                {
                    model.total += model.averPrice;
                }
                if (model.Ch4)
                {
                    model.total += (2 * model.averPrice);
                }
                if (model.Ch5)
                {
                    model.total += model.averPrice;
                }
            }
             
                return View("Result",model);
        }


    }
  }