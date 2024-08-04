using System;
using System.Collections.Generic;

namespace CinemaProject.Models
{
    public class Movie
    {
        public string Title { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<Session> Sessions { get; set; } = new List<Session>();
    }
}
