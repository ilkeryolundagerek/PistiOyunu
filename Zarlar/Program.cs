using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Zar z10 = new Zar(10);
            Para para = new Para();
            Tavla tavla = new Tavla();

            Console.WriteLine(z10.At());
            Console.WriteLine(para.At());
            Console.WriteLine(tavla.At());
            Console.WriteLine(z10.At());
            Console.WriteLine(para.At());
            Console.WriteLine(tavla.At());
            Console.WriteLine(z10.At());
            Console.WriteLine(para.At());
            Console.WriteLine(tavla.At());
            Console.WriteLine(z10.At());
            Console.WriteLine(para.At());
            Console.WriteLine(tavla.At());

            TavlaOyun oyun = new TavlaOyun();
            Console.WriteLine(string.Join(",",oyun.Oyna()));
        }
    }
}
