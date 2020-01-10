using System;

namespace CSharp_Shell
{

    public static class Program 
    {
    	
        public static void Main() 
        {
             Console.WriteLine("\nВведите сумму: ");
             double money = Convert.ToDouble(Console.ReadLine());
             double percent;
             
             if(money < 100) percent = 0.05;
             else if(money >= 100 && money <= 200) percent = 0.07;
             else percent = 0.1;
             money += money * percent + 15;
             
             Console.WriteLine($"\nСумма вклада с процентами :\n{money}");
             
             Console.ReadKey();
             
        }
       
        
    }
}
