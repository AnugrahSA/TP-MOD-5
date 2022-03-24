using System;
using System.Diagnostics.Contracts;

namespace tpmodul5_1302204047
{
    internal class Program
    {
        static void Main(String[] args)
        {
            SayaTubeVideo x = new SayaTubeVideo("Tutorial Design By Contract - Anugrah Saputra Aras");

            Console.WriteLine(x.playCount);
            x.IncreasePlayCount(10);

            Console.WriteLine(x.playCount);
            x.IncreasePlayCount(150000000);

            Console.WriteLine(x.playCount);
            x.IncreasePlayCount(20);

            Console.WriteLine(x.playCount);
            x.IncreasePlayCount(1200);

            Console.WriteLine(x.playCount);
            x.IncreasePlayCount(150000);

        }
    }
}