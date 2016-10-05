using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class customersController : Controller
    {
        // GET: customers
        public ActionResult Index()
        {
            var customer = new Customer();

            var Customer = new List<Models.Customers>
            {
                new Models.Customers { Name = "Eddy Grullon"},
                new Models.Customers { Name = "Channa Travieso"}
            };



            var viewModel = new RandomMovieViewModel
            {
               
                Customers = Customer
            };

            return View(viewModel);
        }
    }
}