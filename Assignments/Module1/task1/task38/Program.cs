using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task38
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> di = new Dictionary<string, object>();

            di.Add("Name", "Raj");
            di.Add("Age", 25);
            di.Add("Location", "Surat");

            foreach(var item in di)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            Console.Read();

        }
    }
}
