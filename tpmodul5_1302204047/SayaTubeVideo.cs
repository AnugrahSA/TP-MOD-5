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
        public int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            Random random = new Random();
            id = random.Next(0, 99999);
            playCount = 0;

            Contract.Requires(title != null);
            Contract.Requires(title.Length < 100);
        }

        public void IncreasePlayCount(int Count)
        {
            try
            {
                if (Count >= 10000000) throw new Exception("Input kelebihan");
                playCount++;
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID VIDEO : " + id);
            Console.WriteLine("JUDUL : " + title);
            Console.WriteLine("JUMLAHDIMAINKAN : " + playCount);
        }
    }
}