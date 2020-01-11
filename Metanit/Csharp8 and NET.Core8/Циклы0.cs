using System;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
           Console.WriteLine("Введите сумму: \n");
           decimal money = Convert.ToDecimal(Console.ReadLine());
           Console.WriteLine("\nВведите количество месяцев : \n");
           int mouth = Convert.ToInt32(Console.ReadLine());
           int number_mouths = 0;
           
           while(number_mouths < mouth)
           {
           	 money += money * 0.07m;
           	 number_mouths++;
           }
           
           Console.WriteLine($"\n{money}");
           Console.ReadLine();
        }
    }
}
