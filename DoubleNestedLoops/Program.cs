using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleNestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Double Nested Loop and 2D arrays");
           // Console.WriteLine();

            


            for (int i = 0; i <=9; i++)
            {
                Console.WriteLine("My misery is immesurable");
               for(int j = 0; j <= 9; j++)
                {
                    Console.WriteLine(i + "," + j);
                }
                
            }
            
            

            Console.ReadKey(true);
        }
    }
}
