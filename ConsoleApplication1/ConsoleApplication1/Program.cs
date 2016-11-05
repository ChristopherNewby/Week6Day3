using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            //    Console.WriteLine("Please Enter a Number");
            //    int numTimes = Convert.ToInt32(Console.ReadLine());
            //    Recursive(0, 1, 1, numTimes);
            //    Console.ReadLine();


            Console.WriteLine("Please Enter a Number");
            int newNum = Convert.ToInt32(Console.ReadLine());          
            Console.WriteLine(recursiveFac(newNum));
            

            for (int i = newNum; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(j);

                }
                Console.WriteLine(recursiveFac(i));
            }
            Console.ReadLine();
        }

        //static void Recursive(int a, int b, int count, int number)
        //{
        //    Console.WriteLine(a);
        //    if (count < number)
        //    {
        //       Recursive(b, a + b, count + 1, number);      
        //    }
        //}


        static int recursiveFac(int num)
        {            
            if (num > 0)
            {
               return num * recursiveFac(num - 1);
            }
            return 1;
        }
    }
}


