using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Customers> Customers { get; internal set; }
        public Movie Movie { get; internal set; }
        public List<Movie> Movies { get; set; }

     
    }
}