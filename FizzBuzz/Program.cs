/*FizzBuzz
 * A program that writes numbers from 1 to 100. Any number that is a multiple of three is replaced
 * by the word 'Fizz', any number that is a multiple of five is replaced by the word 'Buzz', and any
 * number that is a multiple of both three and five is replaced by the word 'FizzBuzz'.
 */

using System;

namespace FizzBuzz
{
    class Program
    {
            static void Main(string[] args)
            {
                double ii;


                for (ii = 1; ii <= 100; ii += 1)
                {
                    double div1 = (ii / 3);
                    double div2 = (ii / 5);

                    //Console.WriteLine(div1);
                    //Console.WriteLine(div2);

                    if (((div1 % 1) == 0) && ((div2 % 1) == 0))
                    {

                        Console.WriteLine("FizzBuzz");

                    }
                    else if ((div1 % 1) == 0)
                    {

                        Console.WriteLine("Fizz");

                    }
                    else if ((div2 % 1) == 0)
                    {

                        Console.WriteLine("Buzz");

                    }
                    else
                    {

                        Console.WriteLine(ii);

                    }


                }
            }
        }
    }


