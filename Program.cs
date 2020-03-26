using System;

namespace zokirov
{
    class Program
    {
        static void Main(string[] args)
        {
       

        // ДЗ-3 
        // Задача №1 Данны две переменные целого тип: А и В. 
        // int a=44, b=25;
        //   if (a==b)
        // {
        //      a=0;
        //      b=0;
        //      Console.WriteLine("A=" +a);
        //      Console.WriteLine("B="+b);
        // }
        // else if(a>b)
        // {
            
        //     Console.Write("A= "+a);


        // }
        
       
        // else
        // {
            
        //     Console.Write("B= "+b);
        // }
        // Console.ReadKey();


        // }
         
         // Задание 2 
        //  int operand1, operand2;
        //  string sing;
        //  Console.WriteLine("введите число:   ");
        //  operand1=int.Parse(Console.ReadLine());

        //  Console.WriteLine("введите число:   ");

        //  operand2=int.Parse(Console.ReadLine());
        // Console.WriteLine("Выбор +, - , * , /");

        //  sing=Console.ReadLine();
        //  switch(sing)
        //   {
        //      case"+":Console.WriteLine(operand1+operand2);
        //      break;
        //      case "-": Console.WriteLine(operand1-operand2);
        //      break;
        //      case"*": Console.WriteLine(operand1*operand2);
        //      break;
        //      case "/": 
        //      if (operand1==0)
        //      {
        //          Console.WriteLine("ошибка");
        //          break;
        //      }
        //      if (operand2==0)
        //      {
        //          Console.WriteLine("ошибка");
        //          break;

        //      }
             
        
        //      else 
        //      {
        //          Console.WriteLine(operand1/operand2);
        //      }
        //     break;
        //     default: Console.WriteLine("ошибка");
        //     break;
        //  }
             
             
         
        
        Console.WriteLine("Выберите 1 то 100");
          double num = double.Parse(Console.ReadLine());
        
         if (num>=0 && num<=14)
         {
             Console.WriteLine("[0-14]");

         }
         if (num>=15 && num <=35)
         {
             Console.WriteLine("[15-35]");
         }
         if (num>=36 && num<=50)
         {
             Console.WriteLine("[36-50]");

         }
         if (num>=51 && num<=100)
         {
             Console.WriteLine("[51-100]");
         }
         else {
             Console.WriteLine("Нет такого числа");
         }
         Console.ReadLine();



        


        }

         
        
    }
}
