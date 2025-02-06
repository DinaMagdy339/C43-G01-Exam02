using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Subject
    {
        #region Attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam? Exam { get; set; }

        #endregion

        #region Constructor
        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #endregion

        #region Methods
        public void CreateExam()
        {
            Console.Write("Do you want to create exam ? ");
            string answer;
            do
            {
                Console.Write("(Yes or No) ");
                answer = Console.ReadLine().ToLower();
            } while (answer != "yes" && answer != "no" );

            if (answer == "yes")
            {
                do
                {
                    Console.Write("please choise exam type 1 for Final 2 for Practical :  ");
                    answer = Console.ReadLine();
                } while (answer != "1" && answer != "2");
                if (answer == "1")
                {
                    Console.Write("Please Enter The Time of Exam in Minutes : ");
                    double time = double.Parse(Console.ReadLine());
                    List<TrueOrFalseQ> trueOrFalseQ = new List<TrueOrFalseQ>();
                    List<MCQQ> mcq = new List<MCQQ>();
                    do {
                        do
                        {
                            Console.Write("please choise this question True Or False(1) or MCQ(2) : ");
                            answer = Console.ReadLine();
                        } while (answer != "1" && answer != "2");
                        Console.Clear();
                        if (answer == "1")
                        {
                            Console.WriteLine("True Or False Question");
                            TrueOrFalseQ.CreateQuestion("True Or False Question", out string? question, out List<string> options, out double mark);
                            TrueOrFalseQ trueOrFalseQuestion = new TrueOrFalseQ("True Or False Question", question, mark, options);
                            trueOrFalseQ.Add(trueOrFalseQuestion);
                            trueOrFalseQuestion.GetRightAnswer();
                            Console.Clear();
                        }

                        else
                        {
                            Console.WriteLine("MCQ Question");
                            MCQQ.CreateQuestion(answer, out string? question, out List<string> options, out double mark);
                            MCQQ mcqQuestion = new MCQQ("MCQ Question", question, mark, options);
                            mcq.Add(mcqQuestion);
                            mcqQuestion.GetRightAnswer();
                            Console.Clear();
                        }
                        Console.WriteLine("Do you want to add another question ? (answer Yes or No)");
                        answer = Console.ReadLine();
                    } while (answer.ToLower() == "yes");
                    Exam = new FinalExam { MCQ = mcq, TrueOrFalse = trueOrFalseQ ,Time= time };
                }
                else
                {
                    Console.Write("Please Enter The Time of Exam in Minutes : ");
                    double time = double.Parse(Console.ReadLine());
                    Console.Clear();
                    List<MCQQ> mcq = new List<MCQQ>();
                    do {
                        Console.WriteLine("MCQ Question");
                        MCQQ.CreateQuestion(answer, out string? question, out List<string> options, out double mark);
                        MCQQ mCQQ = new MCQQ("MCQ Question", question, mark, options);
                        mcq.Add(mCQQ);
                        mCQQ.GetRightAnswer();
                        Console.WriteLine("Do you want to add another question ? Yes or No");
                        answer = Console.ReadLine();
                    } while (answer.ToLower() == "yes");
                   Exam = new PracticalExam { MCQ = mcq , Time = time };
                }
            }
            else Console.WriteLine("Good By");
        }
        #endregion
    }
}
