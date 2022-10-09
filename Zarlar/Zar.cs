using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarlar
{
    public class Zar
    {
        private int yuzler;
        private static readonly Random random = new Random();
        public Zar(int yuz_sayisi)
        {
            this.yuzler = yuz_sayisi;
        }

        public int At()
        {
            return random.Next(yuzler) + 1;
        }
    }
}
