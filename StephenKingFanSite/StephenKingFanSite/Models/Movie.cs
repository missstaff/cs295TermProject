using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StephenKingFanSite.Models
{
    public class Movie
    //see Brian about validation not working correctly?
    {//Validation kind of working??//
        public int ID { get; set; }

        [Required]
        /*[Range(1, 50, ErrorMessage = "Book title must be between 1 and 50 characters long.")]*/
        public string Title { get; set; }

        public string Director { get; set; }

        [Required]
        public DateTime PremiereDate { get; set; }

        public string Genre { get; set; }

        [Required]
        [Range(0, 5)]
        public int Rating { get; set; }


        //Navigation Properties//
        public ICollection<Genre> Genres { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
