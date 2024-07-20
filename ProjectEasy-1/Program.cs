using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEasy_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kısa Kenar :");
            int kisa = int.Parse(Console.ReadLine());
            Console.WriteLine("Uzun Kenar : ");
            int uzun = int.Parse(Console.ReadLine());

            int alan = kisa * uzun;
            int cevre = (kisa + uzun) * 2;

            Console.WriteLine($"alan: {alan} Çevre: {cevre}");
        }
    }
}
