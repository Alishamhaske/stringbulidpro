using oopfirstclass_program.arraylistcollection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringbulidpro
{
    internal class stringbulid1
    {
        static void Main(string[] args)
        {
            StringBuilder str2 = new StringBuilder("Hello to all");
            Console.WriteLine(str2);

            str2.Append("Good Morning");
            Console.WriteLine(str2);

            str2.Remove(4, 5);
            Console.WriteLine(str2);

            //str2.Replace('l', 'L');
            //Console.WriteLine(str2);

            str2.Replace("all", "everyone");
            Console.WriteLine(str2);

            Console.WriteLine("Capacity =" + str2.Capacity);

            str2.Clear();// remove all the letters / strbuilder will be empty

            Console.WriteLine(str2);

         
            

        }
    }
}
