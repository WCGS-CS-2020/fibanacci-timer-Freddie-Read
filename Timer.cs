using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main()
        {
            Stopwatch sW = new Stopwatch();
            sW.Restart();
            fibRec(1, 1, 1000, 1);
            Console.WriteLine("Recursive: {0}", sW.Elapsed);
            sW.Stop();
            sW.Restart();
            fibIt(1, 1, 1000);
            Console.WriteLine("Iterative: {0}", sW.Elapsed);
            sW.Stop();
            Console.ReadLine();
        }

        static void fibRec(int num1, int num2, int fibMax, int curr)
        {
            int answer = 0;
            if (curr == fibMax)
            {
                answer = num1 + num2;
                return;
            }
            else
            {
                answer = num1 + num2;
                curr++;
                fibRec(num2, answer, fibMax, curr);
            }
            
        }

        static int fibIt(int num1, int num2, int fibMax)
        {
            int ans = 0;
            for (int i = 0; i < fibMax; i++)
            {
                ans = num1 + num2;
                num1 = num2;
                num2 = ans;
            }
            return ans;
        }

    }
}
