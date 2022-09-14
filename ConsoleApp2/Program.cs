using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 12;
            int n2 = ++n1;
            int n3 = n2++;
            Console.WriteLine($"n1 is{n1}, n2 is{n2},n3 is{n3}");


        }
    }
}
