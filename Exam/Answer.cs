using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Answer
    {
        #region Attributes
        public int Id { get; set; }
        public string? Answers { get; set; }
        #endregion

        #region Methods
        public void GetAnswers()
        {
            Console.WriteLine("Enter the answer for this question .");
            Answers = Console.ReadLine();
        }
        #endregion

    }
}
