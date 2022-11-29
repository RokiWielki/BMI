//Napisz program, który oblicza wskaźnik masy ciała BMI. Program ma prosić
//użytkownika o podanie wagi w kilogramach oraz wzrostu w metrach.
//Wzór: BMI= masa/wzrost^2
//Po obliczeniu wskaźnika BMI program powinien wyświetlać stosowną informację w
//zależności od wartości wskaźnika:
//< 18,5 – niedowaga,
//18,5-24,99 – wartość prawidłowa,
//≥ 25,0 – nadwaga

using System;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your BMI?");
            Console.Write("(Kg) Weight: ");
            double weight=double.Parse(Console.ReadLine());
            Console.Write("(Cm) Height: ");
            double height=double.Parse(Console.ReadLine());
            Console.WriteLine("Your BMI: {0,0:F2}",BMI(weight,height));
            Console.WriteLine("Your weight is "+ Weight(BMI(weight, height)));
        }
        static double BMI(double w, double h)
        {
            h /= 100;
            double result = w / (h * h);
            return result;
        }
        static string Weight(double bmi)
        {
            if (bmi < 18.5) return "underweight";
            else if (bmi < 25) return "correct weight";
            else return "overweight";

        }
    }
}
