using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*#*# -- R7 Official -- #*#*");
            Console.WriteLine();
            Console.WriteLine();

            //Assign values to an array
            int[] ArrayItems = new int[11];
            int[] Primes = new int[11];
            int[] Composites = new int[11];

            Console.WriteLine("Enter Numbers for Array");
            Console.WriteLine();
            for (int i = 0; i < ArrayItems.Length; i++)
            {
                Console.Write("Array Number {0} --> ", i);
                ArrayItems[i] = Convert.ToInt32(Console.ReadLine()) ;
                
            }
            

            int j;
            //Iterate through the items of array
            for (int i = 0; i < ArrayItems.Length; i++)
            {
                
                // see if num is evenly divisible
                for (j = 2; j < ArrayItems[i]; j++)
                    if ((ArrayItems[i] % j == 0))
                    {
                        // num is evenly divisible -- not prime
                        //Console.WriteLine("{0} : Is NOT a primenumber", + ArrayItems[i]);
                        Composites[i] = ArrayItems[i];
                        break;
                    }
                if (j == ArrayItems[i])
                {
                    //Console.WriteLine("{0} : Is a primenumber", + ArrayItems[i]);
                    Primes[i] = ArrayItems[i];
                }


               


                    
                
            }
            // Printing 
            Console.WriteLine();
            Console.WriteLine("Prime Numbers in Array;");
            for (int p = 0; p < ArrayItems.Length; p++)
            {
                Console.WriteLine(p + " --> " + Primes[p]);
            }
            Console.WriteLine();
            Console.WriteLine("Sum of Primes --> " + Primes.Sum());
          
            



            Console.WriteLine();
            Console.WriteLine("Composite Numbers in Array;");
            for (int o = 0; o < ArrayItems.Length; o++)
            {
                Console.WriteLine(o + " --> " + Composites[o]);
            }
            Console.WriteLine();
            Console.WriteLine("Sum of Composites --> " + Composites.Sum());
          

            Console.ReadLine();

        }
    }
}
