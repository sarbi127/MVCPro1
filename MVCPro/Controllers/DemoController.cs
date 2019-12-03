using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCPro.Models;

namespace MVCPro.Controllers
{
    public class DemoController : Controller
    {
        //public string Index(int id, string name)
        //{
        //   // return View();
        //    return HtmlEncoder.Default.Encode($"Demo index id:{id} name{name}");
        //}

        public IActionResult Index(int salary, string name)
        {
           var model = new Person()
            {
                Name = name,
                Salary = salary
            };

            return View(model);

        }
    }
}
