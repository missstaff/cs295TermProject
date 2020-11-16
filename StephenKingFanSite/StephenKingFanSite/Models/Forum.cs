using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StephenKingFanSite.Models
{
    public class Forum
    {//Validation not working correctly talk to Brian//
        public int ID { get; set; }

        [Required]
        /*[Range(2, 50, ErrorMessage = "Topic should be between 2 and 50 characters long.")]*/
        public string Topic { get; set; }

        [Required]
        /*[Range(5, 1000, ErrorMessage = "Post must between 5 and 1000 characters long.")]*/
        public string Comments { get; set; }

        [Required]
        public string Name { get; set; }
        //do i need to do this to get names in user table//
         /*private string name;
        public string Name 
        {
            get { return name; }   // get method
            set { name = value; }  // set method 
        }*/
       
        [Required]
        public DateTime Date { get; set; }


        //Navigation Properties//
        public ICollection<User> Users { get; set; }
      
    }
}
