using System;
using Task10Subtask2;

namespace Task10Subtask2
{
    public interface ICalculator
    {
        void Sum(int a, int b);
    }

    public class MyCalc : ICalculator
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("Ответ: {0} ", a + b);
        }
    }
    public interface ILogger
    {
        void Event(string message);
        void Erorr(string message);
    }

    public class Logger : ILogger
    {
        public void Erorr(string message)
        {
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine(message);
        }

    }
    public interface IWorker
    {

        void Work();
    }

    class Program
    {
        static ILogger Logger { get; set; }
        static void Main()
        {
            Logger = new Logger();

            var worker1 = new Worker1(Logger);

            worker1.Work();

            ICalculator mycalc;
            try
            {
                Console.WriteLine("Ввидите значение 1: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ввидите значение 2: ");
                int b = Convert.ToInt32(Console.ReadLine());

                mycalc = new MyCalc();
                mycalc.Sum(a, b);
            }
            catch (FormatException)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Введенное значение не коректно!");
            }
            finally
            {
                Console.WriteLine("Калькулятор окончил работу");
            }
        }
    }
}


