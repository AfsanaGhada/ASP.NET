using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_1
{
  
public class mat
    {
        int i, j, m, n;
        int[,] a = new int[20, 20];
        public void get()
        {
            Console.WriteLine("Enter Row Value");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column Value");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Elements one by one");
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Given Matrix");
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    Console.Write("\t{0}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void diag()
        {
            int d;
            d = 0;
            if (m == n)
            {
                for (i = 1; i <= m; i++)
                {

                    for (j = 1; j <= n; j++)
                    {
                        if (i == j)
                        {
                            d = d + a[i, j];
                        }

                    }
                }
                Console.WriteLine("Diagonal Sum= {0}", d);
            }
            else
            {
                Console.WriteLine("Can't Perform Diagonal Sum");
            }
        }
      
    }
}

