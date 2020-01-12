using System;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
            int[,,] mas = new int[4,2,2]
            { 
              { { 1, 2 },{ 3, 4 } }, 
              { { 4, 5 },{ 6, 7 } }, 
              { { 7, 8 },{ 9, 10 } }, 
              { { 10, 11 },{ 12, 13 } } 
            };
            
            int z = mas.GetUpperBound(0) + 1;
            int y = mas.GetUpperBound(1) + 1;
            int x = mas.GetUpperBound(2) + 1;
            
            Console.Write("{");
            
            for(int i=0;i < z; i++)
            {   
            	Console.Write("{");
            	
            	for(int q=0;q < y; q++ )
            	{   
            		Console.Write("{");
            		
            		for(int u=0;u < x; u++)
            		{
            			Console.Write(mas[i,q,u]);
            			if(u < x-1) Console.Write(",");
            		}
            		
            		Console.Write("}");
            		if(q < y-1) Console.Write(",");
            	}
            	
            	Console.Write("}");
            	if(i < z-1) Console.Write(",");
            }
            
            Console.Write("}");
            Console.ReadLine();
        }
    }
}
