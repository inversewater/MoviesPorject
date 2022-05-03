using System;

namespace FinalProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Released { get; set; }
        public int hours  { get; set; }
        public int minutes { get; set; }
        public int? RatingID { get; set; }
    }
}
