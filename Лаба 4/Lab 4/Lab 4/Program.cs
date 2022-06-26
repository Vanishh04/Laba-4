using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Впишите цену сноуборда:");
            int price1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            var snowboard = new Snowboard(price1);
            snowboard.GetInfo();

            Console.WriteLine("Впишите цену беговых коньков:");
            int price2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            var runningSkis = new RunningSkis(price2);
            runningSkis.GetInfo();

            Console.WriteLine("Впишите цену горных коньков:");
            int price3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            var mountainSkis = new MountainSkis(price3);
            mountainSkis.GetInfo();
        }
    }
}
