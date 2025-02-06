using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class Exam
    {
        #region Attributes
        public double Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>();
        #endregion

        #region Methods
        public abstract void ShowExam();
        public abstract void ShowRightAnswers();
        #endregion
    }
}
