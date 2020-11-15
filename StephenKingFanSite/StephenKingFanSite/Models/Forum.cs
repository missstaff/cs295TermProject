using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StephenKingFanSite.Models
{
    public class Forum
    {
        //see Brian about validation not working correctly?
        public int ID { get; set; }

        /*[Required(ErrorMessage = "Please enter a Post Topic.")]
        [Range(2, 50, ErrorMessage = "Topic should be between 2 and 50 characters long.")]*/
        public string Topic { get; set; }

        /*[Required(ErrorMessage = "Please enter your comments.")]
        [Range(5, 1000, ErrorMessage = "Post must between 5 and 1000 characters long.")]*/
        public string Comments { get; set; }

        /*[Required(ErrorMessage = "Please enter your user name.")]
        [Range(2, 25, ErrorMessage = "User name must between 2 and 25 characters long.")]*/
        public string Name { get; set; }
      

        public DateTime Date { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
