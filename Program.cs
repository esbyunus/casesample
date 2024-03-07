namespace Course_8
{
    internal class Program
    {
        public enum Renkler { Kirmizi, Yesil, Mavi }
        static void Main(string[] args)
        {
            Renkler r = (Renkler)(new Random()).Next(0, 10);

            switch (r)
            {
                case Renkler.Kirmizi:
                    Console.WriteLine("Renk kirmizidir.");
                    break;
                case Renkler.Yesil:
                    Console.WriteLine("Renk yesildir.");
                    break;
                case Renkler.Mavi:
                    Console.WriteLine("Renk mavidir.");
                    break;
                default:
                    Console.WriteLine("Renk bilinmiyor.");
                    break;

            }
        }
    }
}