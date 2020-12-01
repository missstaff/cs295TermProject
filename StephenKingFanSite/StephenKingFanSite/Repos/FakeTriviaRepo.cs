/*using StephenKingFanSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StephenKingFanSite.Repos
{
    public class FakeTriviaRepo : ITrivia
    {
        private List<TriviaMV> answers = new List<TriviaMV>();
        public IQueryable<TriviaMV> Trivias { get { return answers.AsQueryable<TriviaMV>(); } }

        public void CheckAnswers()
        {
            bool correct = false;
            var quiz = new TriviaMV()
            {
                UserAnswer1 = "1947", // What year was Stephen King Born
                UserAnswer2 = "Carrie", // What was King's first novel?
                UserAnswer3 = "86" // How many novels has King written?
            };
            if (quiz.UserAnswer1 == quiz.RightOrWrong1 && quiz.UserAnswer2 == quiz.RightOrWrong2 && quiz.UserAnswer3 == quiz.RightOrWrong3)

                correct = true;
        }
    }
}*/
