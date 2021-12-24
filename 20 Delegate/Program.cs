using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Delegate
{
    class Program
    {
        delegate double AllAboutCircle(double r);
        static void Main(string[] args)
        {
            AllAboutCircle allAboutCircle = Lenght;
            Console.WriteLine(allAboutCircle(5));
            allAboutCircle = Area;
            Console.WriteLine(allAboutCircle(5));
            allAboutCircle = Volume;
            Console.WriteLine(allAboutCircle(5));
            Console.ReadKey();
        }
        static double Lenght(double r)
        {
            return (2 * Math.PI * r);
        }
        static double Area(double r)
        {
            return (Math.PI * r * r);
        }
        static double Volume(double r)
        {
            return (4 / 3 * (Math.PI * Math.Pow(r, 3)));
        }
    }
}
