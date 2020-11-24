using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StephenKingFanSite.Models
{
    public class User
    {
        public int ID { get; set; }
        
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "User name should be between 2 and 50 characters long.")]
        public string Name { get; set; }


        //Navigation Properties//
        public ICollection<Forum> Forums { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public ICollection<Novel> Novels { get; set; }
        public ICollection<Score> Scores { get; set; }
    }
}
