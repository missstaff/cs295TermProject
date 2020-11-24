using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StephenKingFanSite.Models
{
    public class Forum
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 2, ErrorMessage = "Post topic must be between 2 and 60 characters")]
        [Required]
        public string Topic { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Post must between 5 and 1000 characters long.")]
        public string Comments { get; set; }

        [Required]
        public string Name { get; set; }
       
        [Required]
        public DateTime Date { get; set; }


        //Navigation Properties//
        public ICollection<User> Users { get; set; }
      
    }
}
