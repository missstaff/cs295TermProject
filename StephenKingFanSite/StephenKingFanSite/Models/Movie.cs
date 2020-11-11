using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StephenKingFanSite.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime PremiereDate { get; set; }

        public string Genre { get; set; }
        public Genre Genres { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
