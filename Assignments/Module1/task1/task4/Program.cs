using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Methods
            //1) Length
            string a = "This is .NET";
            Console.WriteLine("<---Length method--->");
            Console.WriteLine("The given string length is :" + a.Length);

            //2)Containes
            string b = "This is String";
            Console.WriteLine();
            Console.WriteLine("<---Containes Method--->");
            Console.WriteLine(b.Contains("is"));

            //3)Trim
            string c = "    This is Trim method";
            Console.WriteLine();
            Console.WriteLine("<---Trim Method--->");
            Console.WriteLine(c.Trim());

            //4)ToLower
            string d = "THIS IS TOLOWER METHOD";

            Console.WriteLine();
            Console.WriteLine("<---ToLower Method--->");
            Console.WriteLine(d.ToLower());

            //5)ToUpper
            string e = "this is toupper method";
            Console.WriteLine();
            Console.WriteLine("<---ToUpper Method--->");
            Console.WriteLine(e.ToUpper());

            //6)EndsWith
            string f = "This is EndsWith method";
            Console.WriteLine();
            Console.WriteLine("<---EndsWith Method--->");
            Console.WriteLine(f.EndsWith("method"));

            //7)StartWith
            string g = "This is StartWith method";
            Console.WriteLine();
            Console.WriteLine("<---StartsWith Method--->");
            Console.WriteLine(g.StartsWith("This"));

            //8)IndexOf
            string h = "This is IndexOf method";

            Console.WriteLine();
            Console.WriteLine("<---IndexOf Method--->");
            Console.WriteLine(h.IndexOf("IndexOf"));
            Console.WriteLine(h.IndexOf('s'));

            //9)LastIndexOf
            string i = "This is lastIndexof method";

            Console.WriteLine();
            Console.WriteLine("<---LastIndexOf Method--->");
            Console.WriteLine(i.LastIndexOf('i'));

            //10)Insert
            string j = "This is insert method";

            Console.WriteLine();
            Console.WriteLine("<---Insert Method--->");
            Console.WriteLine(j.Insert(8, "true "));

            //11)PadLeft
            string k = "This is Padleft method";

            Console.WriteLine();
            Console.WriteLine("<---PadLeft Method--->");
            Console.WriteLine(k.PadLeft(30));
            Console.WriteLine(k.PadLeft(30,'a'));

            //12)PadRight
            string l = "   This is PadRight method";
            string m = "for practice.";
            Console.WriteLine();
            Console.WriteLine("<---PadRight Method--->");
            Console.WriteLine(l.PadRight(30) + m);

            //13)Remove
            string n = "This is Remove method";

            Console.WriteLine();
            Console.WriteLine("<---Remove Method--->");
            Console.WriteLine(n.Remove(2));
            Console.WriteLine(n.Remove(8, 10));

            //14)SubString
            string o = "This is subString method";

            Console.WriteLine();
            Console.WriteLine("<---SubString Method--->");
            Console.WriteLine(o.Substring(4));

            //15)TrimEnd
            string p = "method00***";
            char[] trimChar = { 'd','*','0' };

            Console.WriteLine();
            Console.WriteLine("<---TrimEnd Method--->");
            Console.WriteLine(p.TrimEnd(trimChar));

            //16)TrimStart
            string q = "This is TrimStart method";
            char[] trimStart = { 'T', 'h' };

            Console.WriteLine();
            Console.WriteLine("<---TrimStart Method--->");
            Console.WriteLine(q.TrimStart(trimStart));
            Console.Read();

        }
    }
}
