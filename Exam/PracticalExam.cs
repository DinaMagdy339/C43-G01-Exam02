using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class PracticalExam : Exam
    {
        #region Attributes
        public List<MCQQ> MCQ { get; set; } = new List<MCQQ>();
        #endregion

        #region Methods
        public override void ShowExam()
        {
            NumberOfQuestions = MCQ.Count;
            foreach (var item in MCQ)
            {
                item.ShowQuestion();
                item.Answers.GetAnswers();
            }
            Console.WriteLine("-------------------------");
            ShowRightAnswers();
        }

        public override void ShowRightAnswers()
        {
            for (var i = 0; i < MCQ.Count; i++)
            {
                Console.WriteLine($"Question {i + 1} : {MCQ[i].Body}");
                Console.WriteLine($"Right Answer : {MCQ[i].RightAnswer}");
            }
        }
        #endregion
    }
}

