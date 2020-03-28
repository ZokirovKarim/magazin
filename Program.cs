using System;

namespace zokirov
{
    class Program
    {
        static void Main(string[] args)
        {
            // double percent, summa;
            // summa=Convert.ToDouble(Console.ReadLine());
            // if (summa>=500&&summa<1000)
            // {

            //     percent=97*summa/100;
            //     Console.WriteLine($"покупка с %^{percent}");
            // }
            // if (summa>=1000)
            // {
            //     percent=95*summa/100;
            //     Console.WriteLine($"покупка с %^{percent}");


            // }
            // if(summa<500)
            // {
            //     Console.WriteLine(summa);
            // }

            // }

            // int a = 11, b = 66, c = 7, d = 9;

            // if(a < b && b < c && c < d){
            //     Console.WriteLine("Числа расположены по возрастанию");
            // }
            // else if(a == b && b == c && c == d){
            //     Console.WriteLine("Произведение значении = " + (a * b * c * d));
            // }
            // else if(a <= b && a <= c && a <= d)   
            // {
            //     Console.WriteLine($"Min:{a}");
            // }
            // else if(b <= a && b <= c && b <= d){

            //     Console.WriteLine($"Min:{b}");
            // }
            // else if(c <= a && c <= b && c <= d){
            //     Console.WriteLine($"Min:{c}");
            // }
            // else if(d <= a && d <= b && d <= c){
            //     Console.WriteLine($"Min:{d}");
            // }

            int a = 2, b = 4, c = 2, d = a, e = a, f = a;
            d = a > b && a > c ? a : d;
            d = b > a && b > c ? b : d;
            d = c > b && a < c ? c : d;
            e = a > b && a < c || a < c && a > b ? a : e;
            e = a < b && b < c || b > c && a > b ? b : e;
            e = c > b && a < c || a > c && c > b ? a : e;
            f = a < b && a < c ? a : f;
            f = a > b && b < c ? b : f;
            f = c < b && a > c ? c : f;
            a = d;
            b = e;
            c = f;
            System.Console.WriteLine($"a = {a} b = {b} c = {c}");
            Console.ReadKey();

        }

    }
}
