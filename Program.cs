namespace monCompteur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour!");
            DateTime date = DateTime.Now;
            Thread.Sleep(1000);

            Random r = new Random();
            Console.WriteLine($"Nous sommes le {date}");
            Thread.Sleep(1000);
            string etoile = " ";
            for (int i = 0; i < 100; i++)
            {
                
                Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
                if(Console.ForegroundColor == ConsoleColor.Black)
                {
                    Console.ForegroundColor= (ConsoleColor)r.Next(5, 10);
                }

                etoile += "*";
                Console.WriteLine("\t"+
                i+"\t"+etoile);
                Thread.Sleep(300);
            }
        }
    }
}