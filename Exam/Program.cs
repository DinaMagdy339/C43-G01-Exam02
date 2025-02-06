using System.Diagnostics;

namespace Exam 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject Sub1 = new Subject(10, "C#");
            Sub1.CreateExam();
            Console.Clear();
            Console.WriteLine("Do you want to start the Exam (y | n)?");
            if (char.Parse(Console.ReadLine().ToLower()) == 'y')
            {

                if (Sub1.Exam is FinalExam finalExam)
                {
                    Stopwatch SW = new Stopwatch();
                    SW.Start();
                    Sub1.Exam.ShowExam();
                    Console.WriteLine($"The Elapsed Time = {SW.Elapsed}");

                }
                else if (Sub1.Exam is PracticalExam practicalExam)
                {
                    Stopwatch SW = new Stopwatch();
                    SW.Start();
                    Sub1.Exam.ShowExam();
                    Console.WriteLine($"The Elapsed Time = {SW.Elapsed}");
                }
            }

        }
    }
}
