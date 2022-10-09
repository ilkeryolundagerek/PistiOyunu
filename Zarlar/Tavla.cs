namespace Zarlar
{
    public class Tavla
    {
        private Zar zar;

        public Tavla()
        {
            zar = new Zar(6);
        }

        public int At()
        {
            return zar.At();
        }
    }
}
