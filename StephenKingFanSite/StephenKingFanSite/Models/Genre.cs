using System.Collections.Generic;

namespace StephenKingFanSite.Models
{
    public class Genre
    {

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        

        //Navigation Properties//
        public ICollection<Movie> Movies { get; set; }
        public ICollection<Novel> Novels { get; set; }
    }
}
