using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            bool isprime = true;
            for(int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    if (i!=j  && i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }

                if(isprime)
                {
                    Console.WriteLine("\t" +i);
                }
                isprime = true;
            }

        }
    }
}
