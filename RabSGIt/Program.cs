using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabSGIt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, resultSab, resultmul;


            a = Convert.ToInt32( Console.ReadLine());
            b = Convert.ToInt32( Console.ReadLine());
            c = a + b;
            resultSab = a - b;
            resultmul = a * b;


            Console.WriteLine(c);
            Console.WriteLine(resultSab);
            Console.WriteLine(resultmul);

            Console.ReadKey();

        }
    }
}
