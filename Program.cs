using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lalalaa
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Petya = new Class1();
            Class1 Vasya = new Class1();
            Petya.Birth = new DateTime(2007, 4, 15);
            Vasya.Birth = new DateTime(2008, 1, 1);
            System.TimeSpan daysCount = Vasya.Birth.Subtract(Petya.Birth);

            Console.WriteLine(daysCount.ToString());
        }
    }
}
