using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Controllers;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomCustomerViewModel
    {

        public List<Models.Customers> Customers { get; set; }
    }
}