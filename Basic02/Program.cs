using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Basic02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Class1 cls01 = new Class1();
            // Console.WriteLine("print: " + cls01);
            //

            Console.WriteLine("print: " + cls01.i);
            Console.WriteLine("print: " + cls01.str);
            Console.WriteLine("print: " + cls01.chk);
            Console.WriteLine("print: " + cls01.f);
            //
            Console.WriteLine("print plus: " + cls01.func_plus());
            Console.WriteLine("print minus: " + cls01.func_minus());
            Console.WriteLine("print multiply: " + cls01.func_multiply());
            Console.WriteLine("print divide: " + cls01.func_divide());
            //
            // Console.WriteLine("print: " + cls01.func_print()); ติดตัวแดงเพราะค่า void(ไม่มีค่า)
            cls01.str = "5555";
            cls01.func_print();
            //
            Console.WriteLine("print: " + cls01.str);
            //
            string str = "6666";
            Console.WriteLine("print(37): " + str);
            Console.WriteLine("print(38): " + cls01.str);

            Class2.func_print(cls01.str);

            Class2.func_print(cls01.i);

            Class2.func_print(cls01.f);
            cls01.f = 2.1f;
            Class2.func_print(cls01.f);
            cls01.f = 3.21f;
            Class2.func_print(cls01.f);

            cls01.f = 1234.11f;
            string f = "1234.1.1";
            Class2.func_print(f);

        }

    }
}
