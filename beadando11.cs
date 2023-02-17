using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ELTE.Basics.PrintNumbers
{
    class Program
    {

        static Int32 Read()
        {
            Console.WriteLine("Kérek egy számot: ");

            Int32 h = Convert.ToInt32(Console.ReadLine());

            return h;

        }



        static void Output()
        {
            try
            {
                Int32 r = Read();
                if (r < 0)
                    
                    Console.WriteLine("Nem természetes szám!");
                
                else
                {

                    Console.WriteLine("A végeredmény:");

                    List<Int32> ListOfPowers = new List<Int32>(0);

                    
                    for (Int32 t = 0; t < r + 1; t++)
                    {
                        ListOfPowers.Add(1 << t);
                    }
                    
                    
                    for (Int32 j = 0; j < r; j++)
                    {

                        for (Int32 i = 0; i < ListOfPowers[j]; i++)
                            
                            Console.Write(j);
                            Console.WriteLine();
                    }
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Nem számot adtál be!");
            }

            catch (OverflowException)
            {
                Console.WriteLine("Túl sok a számjegy!");
            }


        }


        static void Main(string[] args)
        {
            Output();

            Console.ReadKey();
        }
    }
}
