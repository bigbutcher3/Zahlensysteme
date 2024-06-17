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
                switch (wahl)
                {
                    case "A":
                        //Berechnur dzb
                        Console.Write("Bitte geben Sie eine ganze positive Zahl ein: ");
                        Int32.TryParse(Console.ReadLine(), out int dezimal);
                        Console.WriteLine("Das Ergebnis lautet: {0}", DecToBin(dezimal));
                        Console.WriteLine("weiter mit beliebiger Taste ....");
                        Console.ReadKey();
                        break;
                    case "B":
                        //Berechnung bzd
                        Console.Write("Bitte geben Sie die binäre Zahl ein: ");
                        binaer = Console.ReadLine();
                        Console.WriteLine("Das Ergebnis lautet: {0}", BinToDec(binaer));
                        Console.WriteLine("weiter mit beliebiger Taste ....");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (wahl != "Q");

            string DecToBin(int input)
            {
                string binaer = "";
                while (input > 0)
                {
                    binaer = input % 2 + binaer;
                    input = input / 2;
                }
                return binaer;
            }

            decimal BinToDec(string input)
            {
                int stellenwert = 1;
                decimal sum = 0;
                for (int i = input.Length - 1; i > -1; i--)
                {
                    sum += (input[i] - 48) * stellenwert;
                    stellenwert *= 2;
                }
                return sum;
            }
        }
    }
}