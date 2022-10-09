namespace Zarlar
{
    public class Para
    {
        private Zar zar;

        public Para()
        {
            zar = new Zar(2);
        }

        public string At()
        {
            return zar.At() == 1 ? "Yazı" : "Tura";
        }
    }
}
