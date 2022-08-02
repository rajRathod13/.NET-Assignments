using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task24
{
    class cricketer
    {
        internal int[] runs = new int[4];
        internal int[] index = { 1, 2, 3, 4 };

        internal void getData()
        {
            for(int a = 0; a<runs.Length; a++)
            {
                Console.Write("Enter runs of match"+index[a]+": ");
                runs[a] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    class batsmen : cricketer
    {
        int totalRuns, avgRuns, bestPerfomance;

        internal void calculate()
        {
            totalRuns = 0;
            avgRuns = 0;
            getData();
            for (int b = 0; b < runs.Length; b++)
            {
                totalRuns = totalRuns + runs[b];
            }
            Console.WriteLine("Total runs are: " + totalRuns);

            avgRuns = totalRuns / 4;
            Console.WriteLine("Average runs are: " + avgRuns);

            bestPerfomance = runs.Max();
            Console.WriteLine("Best performance is: " + bestPerfomance);

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            batsmen obj = new batsmen();
            obj.calculate();
            Console.Read();
        }
    }
}
