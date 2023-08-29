using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringbuildpro
{
    internal class stringbuilderPro
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());
            str1 = str1 + "Good Morning";
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());



            Console.WriteLine("string bulider ");
            StringBuilder str2 = new StringBuilder("hello");

            Console.WriteLine(str2);
            Console.WriteLine(str2.GetHashCode());
            /* strbuilder.Append("Good Morning");
             Console.WriteLine(strbuilder);
             Console.WriteLine(strbuilder.GetHashCode());*/
            str2.Append("good afternoon");
            Console.WriteLine(str2);
            Console.WriteLine(str2.GetHashCode());



        }
    }
}
