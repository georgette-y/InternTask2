using System.Collections.Generic;
using InternTask2.Models;

namespace InternTask2.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<Product> FeaturedProducts { get; set; }
        public List<Product> LatestProducts { get; set; }
    }
}

