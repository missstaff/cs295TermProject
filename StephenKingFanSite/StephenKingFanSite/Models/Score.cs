using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StephenKingFanSite.Models
{
    public class Score
    {
        public int ID { get; set; }
        public int HighScore { get; set; }
        public string Ranking { get; set; }
        public DateTime Date { get; set; }

        //Navigation Properties//
        public ICollection<User> Users { get; set; }
    }
}