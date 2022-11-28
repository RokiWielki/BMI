//Napisz program, który oblicza wskaźnik masy ciała BMI. Program ma prosić
//użytkownika o podanie wagi w kilogramach oraz wzrostu w metrach.
//Wzór: BMI= masa/wzrost^2

using System;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your BMI?");
            Console.Write("(KG) Weight: ");
            double weight=double.Parse(Console.ReadLine());
            Console.Write(" (M) Height: ");
            double height=double.Parse(Console.ReadLine());
            Console.WriteLine("Your BMI: {0,0:F2}",BMI(weight,height));
        }
        static double BMI(double w, double h)
        {
            double result = w / (h * h);
            return result;
        }
    }
}
