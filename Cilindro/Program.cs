using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            const float pi = 3.1415926f;
            string height, rad;
            float v, sArea, h, r;
            Console.WriteLine("Insert height");
            height = Console.ReadLine();
            h = Convert.ToSingle(height);
            Console.WriteLine("Insert radius");
            rad = Console.ReadLine();
            r = Convert.ToSingle(rad);
            v = pi * r * r * h;
            sArea = 2 * pi * r * (r + h);
            Console.WriteLine("Cilinder's Volume: " + v);
            Console.WriteLine("Cilinder's Surface Area: " + sArea);
            Console.ReadKey();
        }
    }
}
