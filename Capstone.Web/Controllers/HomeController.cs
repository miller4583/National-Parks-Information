using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.Models;
using Capstone.Web.Dal;

namespace Capstone.Web.Controllers
{
    public class HomeController : Controller
    {
        private IParkDAL dal;
        private ISurveyDAL sDAL;

        public HomeController(IParkDAL theDal, ISurveyDAL otherDal)
        {
            this.dal = theDal;
            this.sDAL = otherDal;
        }


        // GET: Home Page <--list of Parks
        public ActionResult Home()
        {
            List<Park> model = new List<Park>();
            //add dal that gets list of parks and puts into model
            model = dal.GetAllParks();

            return View("Home", model);
        }
        
        //Get: Deatil Page <--one park by the park code/id
        public ActionResult Detail(string parkID)
        {
            Park p = new Park();
            p = dal.GetPark(parkID);
            return View("Detail", p);
        }
        

        public ActionResult TakeSurvey()
        {
            
            return View("TakeSurvey");
        }


        [HttpPost]
        public ActionResult TakeSurvey(Survey s)
        {
            if (!ModelState.IsValid)
            {
                return View("TakeSurvey", s);
            }
            else
            {
                sDAL.InsertSurvey(s);
                return RedirectToAction("Favorites");
            }
        }

        public ActionResult Favorites()
        {
            //get list of surveys from DB
            List<Survey> surList = sDAL.GetAllSurveys();
            return View("Favorites", surList);
        }
    }
}