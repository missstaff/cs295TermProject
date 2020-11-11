using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StephenKingFanSite.Models
{
    public class Novel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime PulicationDate { get; set; }
        public string Genre { get; set; }
        public Genre Genres { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
