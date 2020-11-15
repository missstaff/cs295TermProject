using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StephenKingFanSite.Models
{
    public class Novel
    {
        public int ID { get; set; }
        /*[Required(ErrorMessage = "Please enter a title.")]
       [Range(1, 50, ErrorMessage = "Book title must be between 1 and 50 characters long.")]*/
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime PulicationDate { get; set; }
        public string Genre { get; set; }
        public Genre Genres { get; set; }
        //public int Rating { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
