using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Question 
    {
        #region Attributes
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }

        internal string RightAnswer;
        public Answer Answers { get; set; } = new Answer();
        #endregion

        #region Constructor
        public Question(string header, string body, double mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }
        #endregion

        #region Methods
        public static void CreateQuestion(string header, out string? question, out List<string> options, out double mark)
        {
            Console.WriteLine("Please Enter The Body Of Question .");
            question = Console.ReadLine();
            while (question == null)
            {
                Console.WriteLine("please enter the question .");
                question = Console.ReadLine();
            }
            bool isparsed;
            int size;
            do 
            {
                Console.WriteLine("Enter num of options for your question");
                isparsed = int.TryParse(Console.ReadLine(), out size);
            } while (!isparsed || size <= 0 );
            options = new List<string>();
            Console.WriteLine("The Choices of question : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter option {i + 1} :");
                string option = Console.ReadLine() ?? "0";
                options.Add(option);
            }
            Console.WriteLine("Enter the mark for this question .");
            do
            {
                isparsed = double.TryParse(Console.ReadLine(), out mark);
            } while (!isparsed);
        }

        public virtual void GetRightAnswer()
        {
            do
            {
                Console.WriteLine("Enter the right answer for this question .");
                RightAnswer = Console.ReadLine();
            } while (RightAnswer == null );
        }

        public virtual void ShowQuestion() { }       

        #endregion
    }
}
