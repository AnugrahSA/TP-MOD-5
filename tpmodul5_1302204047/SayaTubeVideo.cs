using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204047
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            Random random = new Random();
            id = random.Next(0, 99999);
            playCount = 0;
        }

        public void IncreasePlayCount(int PlayCount)
        {
            playCount++;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID VIDEO : " + id);
            Console.WriteLine("JUDUL : " + title);
            Console.WriteLine("JUMLAHDIMAINKAN : " + playCount);
        }
    }
}