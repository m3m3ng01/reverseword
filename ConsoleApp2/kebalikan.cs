using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan kata yang akan dibalik: ");
            string kata = Console.ReadLine();
            string dibalik = string.Empty;

             for (int i = kata.Length - 1;
                i >= 0;
                i--)
            {
                dibalik += kata[i];
            }
             Console.WriteLine($"kebalikan dari kata yang anda input adalah: " + dibalik);
            Console.ReadKey();
        }
    }
}
