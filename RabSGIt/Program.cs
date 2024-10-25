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
            int a, b, c, resultSab, resultmul, resultDiv;

            double resultSin, resultCos, RPow;

            double  resultSQ;


            a = Convert.ToInt32( Console.ReadLine());
            b = Convert.ToInt32( Console.ReadLine());
            c = a + b;
            resultSab = a - b;
            resultmul = a * b;
            resultDiv = a / b;
            resultSQ = Math.Sqrt(a);
            resultSin = Math.Sin( a );
            resultCos = Math.Cos( a );
            RPow = Math.Pow( a, 2 );

            Console.WriteLine(c);
            Console.WriteLine(resultSab);
            Console.WriteLine(resultmul);
            Console.WriteLine(resultDiv);
            Console.WriteLine(resultSin);
            Console.WriteLine($" Cos({a}) = {resultCos}");

            Console.WriteLine(RPow);

            Console.WriteLine($" Sqrt({a}) = {resultSQ}");

                
            Console.ReadKey();

        }
    }
}
