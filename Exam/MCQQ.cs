using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    
    internal class MCQQ : Question
    {
        #region Attribute
        public List<string> Options { get; set; }
        #endregion

        #region Constructor
        public MCQQ(string header, string body, double mark,List<string>options) : base(header, body, mark)
        {
            Options = options;
        }
       
        #endregion

        #region Methods
        public override void ShowQuestion()
        {
            Console.WriteLine($"\n{Header}\n{Body}\n ");
           for (int i = 0; i < Options?.Count; i++)
                Console.WriteLine($"{i + 1} - {Options[i]}");
            Console.WriteLine("-------------------------------");
        }
        #endregion

    }
}
