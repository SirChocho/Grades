using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class grades
    {
        static void Main(string[] args)
        {
            var count = double.Parse(Console.ReadLine());

            var between2And3 = 0.00;
            var between3And4 = 0.00;
            var between4And5 = 0.00;
            var between5And6 = 0.00;

            var people2and3 = 0.00;
            var people3and4 = 0.00;
            var people4and5 = 0.00;
            var people5and6 = 0.00;

            var sum = 0.00;

            for (int i = 0; i < count; i++)
            {
                var n = double.Parse(Console.ReadLine());
                sum += n;
                if (n >=2 && n <3)
                {
                    between2And3 += n;
                    people2and3 += 1;
                }
                else if (n >=3 && n <4)
                {
                    between3And4 += n;
                    people3and4 += 1;
                }
                else if (n>=4 && n<5)
                {
                    between4And5 += n;
                    people4and5 += 1;
                }
                else if (n>=5 && n<=6)
                {
                    between5And6 += n;
                    people5and6 += 1;
                }
            }
            var average = (between2And3 + between3And4 + between4And5 + between5And6) / count;

            Console.WriteLine("Top students: {0:f2}%", people5and6 / count * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", people4and5 / count * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", people3and4 / count * 100);
            Console.WriteLine("Fail: {0:f2}%", people2and3 / count * 100);

            Console.WriteLine("Average: {0:f2}", average);




            
        }
    }
}
