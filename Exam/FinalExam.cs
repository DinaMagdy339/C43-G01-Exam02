using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class FinalExam : Exam
    {
        #region Attributes
        public List<TrueOrFalseQ>? TrueOrFalse { get; set; } = new List<TrueOrFalseQ>();
        public List<MCQQ>? MCQ { get; set; } = new List<MCQQ>();
        #endregion

        #region Methods
        public override void ShowExam()
        {
            NumberOfQuestions = TrueOrFalse.Count + MCQ.Count;
            Console.WriteLine("-------------------------------");

            if (TrueOrFalse.Count >0)
            {
                foreach (var item in TrueOrFalse)
                {
                    item.ShowQuestion();
                    item.Answers.GetAnswers();
                }
            }
            if (MCQ.Count >0)
            {
                foreach (var item in MCQ)
                {
                    item.ShowQuestion();
                    item.Answers.GetAnswers();
                }
            }
            Console.WriteLine("-------------------------");
            ShowRightAnswers();
            Console.WriteLine("-------------------------");
            ShowGrades();
        }

        public override void ShowRightAnswers()
        {
            if (TrueOrFalse.Count >0)
            {
                for (var i = 0; i < TrueOrFalse.Count; i++)
                {
                    Console.WriteLine($"Question {i + 1} : {TrueOrFalse[i].Body}");
                    Console.WriteLine($"Right Answer : {TrueOrFalse[i].RightAnswer}");
                }
            }
            if (MCQ.Count >0)
            {
                for (var i = 0; i < MCQ.Count; i++)
                {
                    Console.WriteLine($"Question {i + 1} : {MCQ[i].Body}");
                    Console.WriteLine($"Right Answer : {MCQ[i].RightAnswer}");
                }
            }
        }

        public void ShowGrades()
        {
            double grade = 0, totalmark = 0;

            if (TrueOrFalse?.Count >0)
            {
                foreach (var item in TrueOrFalse)
                {
                    if (item.Answers.Answers?.ToLower() == item.RightAnswer.ToLower())
                    {
                        grade += item.Mark;
                    }
                    totalmark += item.Mark;
                }
            }
            if (MCQ.Count >0)
            {
                foreach (var item in MCQ)
                {
                    if (item.Answers.Answers?.ToLower() == item.RightAnswer.ToLower())
                    {
                        grade += item.Mark;
                    }
                    totalmark += item.Mark;
                }
            }
            Console.WriteLine($"Grade = {grade} from {totalmark} ");
        }
        #endregion
    }
}
