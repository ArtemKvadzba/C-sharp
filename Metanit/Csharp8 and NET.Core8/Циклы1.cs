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
           Console.WriteLine("Таблица умножения : \n");
           
           for(int q = 1; q <= 9; q++)
           {
           	 for(int w = 1; w <= 9; w++)
           	 {
           	 	Console.WriteLine($"   {q} * {w} = {q*w};\n");
           	 }
           	
           }
        }
    }
}
