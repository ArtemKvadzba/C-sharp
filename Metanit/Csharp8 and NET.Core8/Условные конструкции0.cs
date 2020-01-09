using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;



public static class Program 
{

  public static void Main() 
  {
    Console.WriteLine("Введите два числа, "+
    "программа сравнит их и" +
    " выдаст результат сравнения");
    Console.Write("\nПервое число : ");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.Write("\nВторое число : ");
    int second = Convert.ToInt32((Console.ReadLine()));

    if(first > second) Console.WriteLine($"\n{first} больше чем {second}");
    else if (first < second) Console.WriteLine($"\n{second} больше чем {first}");
    else Console.WriteLine($"\n{first} и {second} равные числа");

    Console.ReadKey();

  }


}
