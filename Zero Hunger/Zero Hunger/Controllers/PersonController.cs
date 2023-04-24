using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger.Models;

namespace Zero_Hunger.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult List()
        {
            Student s1 = new Student()
            {
                Name = "fatema",
                Id = "123",
                DoB = "1.1.2000",

            };

           /* string[] names=new string[3];
            names[0] = "names1";
            names[1] = "id";
            names[2] = "DoB";
            ViewBag.Names = names;*/

            return View(s1);

        }
    }
}