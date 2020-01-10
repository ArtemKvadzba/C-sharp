using System;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {  
           Console.WriteLine("Введите первый операнд:\n");
           int number0 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("\nВведите второй операнд:\n");
           int number1 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("\nВведите номер операции:\n\n 1.Сложение\n\n 2.Вычитание\n\n 3.Умножение\n");
           int operation = Convert.ToInt32(Console.ReadLine());
           
           switch(operation)
           {
           	 case 1:
           	   Console.WriteLine($"\n {number0 + number1}");
           	   break;
           	 case 2:
           	   Console.WriteLine($"\n {number0 - number1}");
           	   break;
           	 case 3:
           	   Console.WriteLine($"\n {number0 * number1}");
           	   break;
           	 default:
           	   Console.WriteLine("\n Неопределено");
           	   break;
           	
           }
           
        }
    }
}
