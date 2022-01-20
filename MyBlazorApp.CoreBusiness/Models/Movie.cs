using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlazorApp.CoreBusiness.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string YearReleased { get; set; }
        public string ImageLink { get; set; }
        public string Description { get; set; }
    }
}
