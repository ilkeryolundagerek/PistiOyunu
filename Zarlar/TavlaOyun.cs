using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarlar
{
    public class TavlaOyun
    {
        private Tavla[] zarlar;
        public TavlaOyun()
        {
            zarlar = new Tavla[2];
            zarlar[0] = new Tavla();
            zarlar[1] = new Tavla();
        }

        public int[] Oyna()
        {
            int[] sonuc = new int[2];

            sonuc[0] = zarlar[0].At();
            sonuc[1] = zarlar[1].At();

            return sonuc;
        }
    }
}
