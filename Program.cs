namespace Zahlensysteme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Zahlensysteme umrechnen";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            string wahl = "";

            do
            {
                string binaer = "";

                Console.Clear();
                Console.WriteLine("Welche Art Umrechnung möchten Sie?\nBitte wählen\nA = dezimal zu binär\nB = binär zu dezimal\n\nq = Ende");
                wahl = Console.ReadLine();
                wahl = wahl.ToUpper();
                switch(wahl)
                {
                    case "A":
                        //Berechnur dzb
                        Console.Write("Bitte geben Sie eine ganze positive Zahl ein: ");
                        Int32.TryParse(Console.ReadLine(), out int dezimal);
                        while (dezimal > 0)
                        {
                            binaer = dezimal % 2 + binaer;
                            dezimal = dezimal / 2;
                        }
                        Console.WriteLine("Das Ergebnis lautet: {0}", binaer);
                        Console.WriteLine("weiter mit beliebiger Taste ....");
                        Console.ReadKey();
                        break;
                    case "B":
                        //Berechnung bzd
                        Console.Write("Bitte geben Sie die binäre Zahl ein: ");
                        binaer = Console.ReadLine();
                        int stellenwert = 1;
                        int sum = 0;
                        for (int i = binaer.Length -1; i > -1; i--)
                        {
                            sum += (binaer[i] - 48) * stellenwert;
                            stellenwert *= 2;
                        }
                        Console.WriteLine("Das Ergebnis lautet: {0}", sum);
                        Console.WriteLine("weiter mit beliebiger Taste ....");
                        Console.ReadKey();
                        break;
                    case "Q":
                        break;
                    default:
                        break;
                }
            } while (wahl != "Q");
        }
    }
}