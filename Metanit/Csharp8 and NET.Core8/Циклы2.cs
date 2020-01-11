using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {   
        	
        	while(true)
        	{
               Console.WriteLine("Введите первое число : \n");
               int num0 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("\nВведите второе число : \n");
               int num1 = Convert.ToInt32(Console.ReadLine());
               
               if(num0 >= 0 && num1 >= 0 && num0 <= 10 && num1 <= 10)
               {
               	 Console.WriteLine($"\n{num0} * {num1} = {num0 * num1}");
               	 break;
              
               }
        	}
        }
    }
}
