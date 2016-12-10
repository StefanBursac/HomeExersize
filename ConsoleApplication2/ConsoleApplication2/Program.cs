using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            lista.Add(11);
            lista.Add(12);
            lista.Add(13);
            lista.Add(14);

            foreach (int l in lista)
            {
                Console.WriteLine(l);
            }
          
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
