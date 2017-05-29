using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{


    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;

            

            for (int j = 0; j < n; j++)
            {
                StringBuilder sb = new StringBuilder();
                int k = n - j;
                for (int i = 0; i < k; i++)
                {
                    if (i == k - 1)
                    {
                        sb.Append("#");
                        Console.WriteLine(sb.ToString());
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        sb.Append(" ");
                        
                    }

                }
            }

            Console.ReadLine();
        }
    }
}
