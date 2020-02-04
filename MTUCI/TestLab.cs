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
           Console.WriteLine("Введите размерность одномерного массива:\n");
           int array_size = Int32.Parse(Console.ReadLine());
           int[] array = new int[array_size];
           for(int counter = 0; counter < array_size; counter++) 
           {
           	 Console.WriteLine($"\nВведите {counter + 1} элемент массива:\n ");
           	 int number = Int32.Parse(Console.ReadLine());
           	 array[counter] += number;
           	 
           	 
           	
           }
           
           Console.WriteLine();
           
           for(int counter= array_size - 1; counter >= 0 ; counter--) 
           {
           	 Console.Write($"{array[counter]} ");
           }
        }
    }
}
