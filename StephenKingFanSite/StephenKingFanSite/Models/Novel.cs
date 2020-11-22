using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StephenKingFanSite.Models
{
    public class Novel
    {//Validation kinda working???//
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Title must be between 2 and 50 characters")]
        [Required]
        public string Title { get; set; }

        [StringLength(60, MinimumLength = 2, ErrorMessage = "Publisher name must be between 2 and 60 characters")]
        [Required]
        public string Publisher { get; set; }

        [Required]
        public DateTime PulicationDate { get; set; }

        public string Genre { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Rating must be betweeen 1 and 5")]
        public int Rating { get; set; }


        //Navaigation Properties//
        public ICollection<Genre> Genres { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
