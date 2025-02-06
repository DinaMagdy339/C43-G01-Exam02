using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class TrueOrFalseQ : Question
    {
        #region Attributes
        public List<string> Options { get; set; }
        #endregion

        #region Constructor
        public TrueOrFalseQ(string header, string body, double mark, List<string> options) : base(header, body, mark)
        {
            Options = options;
        }
        #endregion

        #region Methods
        new public static void CreateQuestion(string header, out string? question, out List<string> options, out double mark)
        {
            Console.WriteLine("Enter the question .");
            question = Console.ReadLine();
            while (question == null)
            {
                Console.WriteLine("please enter the question .");
                question = Console.ReadLine();
            }
            options = new List<string>() { "True", "False" };
            bool isparsed;
            Console.WriteLine("Enter the mark for this question .");
            do
            {
                isparsed = double.TryParse(Console.ReadLine(), out mark);
            } while (!isparsed);
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"\n{Header}\n{Body}\n ");
            foreach (var option in Options)
            {
                Console.WriteLine(option);
            }
            Console.WriteLine("-------------------------------");
        }
        public override void GetRightAnswer()
        {
            do
            {
                Console.WriteLine("Enter the right answer for this question True or false .");
                RightAnswer = Console.ReadLine();
            } while (RightAnswer == null);
        }
        #endregion
    }
}