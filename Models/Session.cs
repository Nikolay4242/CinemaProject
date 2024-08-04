using System;

namespace CinemaProject.Models
{
    public class Session
    {
        public DateTime Date { get; set; }
        public string Time { get; set; } = string.Empty;
        public string MovieTitle { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
