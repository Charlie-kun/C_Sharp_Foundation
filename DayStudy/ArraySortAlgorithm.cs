using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[5] {51,43,35,72,11};
            string[] alpha = { "a", "b", "c", "d", "e" };
            int index, temp;
            string tempAL;

            for (int i = 0; i < 5-1; i++)
            {
                index = i;
                for (int k = i + 1; k < 5; k++)
                {                    
                    if (test[k] < test[index])
                        index = k;
                }

                if (i != index)
                {                    
                    temp = test[i];
                    tempAL = alpha[i];
                    test[i] = test[index];
                    alpha[i] = alpha[index];
                    test[index] = temp;
                    alpha[index] = tempAL;
                }
            }
            for (int k=0;k<5;k++)
            {
                Console.Write(test[k]);
                Console.Write(alpha[k] + "\t");
            }
        }
    }
}
