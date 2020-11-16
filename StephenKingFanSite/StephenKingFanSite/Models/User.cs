using System.Collections.Generic;



namespace StephenKingFanSite.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }


        //Navigation Properties//
        public ICollection<Forum> Forums { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public ICollection<Novel> Novels { get; set; }
        public ICollection<Score> Scores { get; set; }
    }
}
