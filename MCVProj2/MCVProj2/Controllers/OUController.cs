using MCVProj2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCVProj2.Controllers
{
    public class OUController : Controller
    {
        // GET: OU
        public ActionResult Index()
        {
            return View();


        }
        public ActionResult TAs()
        {
            List<Student> tas = new List<Student>();
            {
                new Student()
                {
                    FirstName = "Jenn",
                    LastName = "Ha",
                    SoonerID = 8
                };
                new Student()
                {
                    FirstName = "Nhi",
                    LastName = "Ha",
                    SoonerID = 9
                };
                   
            };
            return View; 
        }
    }
}