class Program
{
    static void Main()
    {
        char[] povoleneBarvy = { 'r', 'g', 'b' };

        List<char> vysluzka = new List<char>();
        //List<char> vysluzka = new List<char>() {'r', 'r'};
        
        bool pokracovat = true;
        int volba;
        char barva;

        while (pokracovat)
        {
            Console.WriteLine("Moznosti:");
            Console.WriteLine("  1) Pridej vajicko");
            Console.WriteLine("  2) Vypis sebrana vajicka");
            Console.WriteLine("  3) Vypis pocet vajec");
            Console.WriteLine("  4) Ukonci aplikaci");
            Console.Write("Vyber akci:");
            volba = int.Parse(Console.ReadLine());

            if (volba < 1 || volba > 4)
            {
                Console.WriteLine("Neplatna operace");
            }
            else if (volba == 1)
            {
                Console.Write("Zadej barvu vajicka [rgb]:");
                barva = Console.ReadLine()[0];
                if (!povoleneBarvy.Contains(barva))
                    Console.WriteLine("Neplatna barva");
                else
                    vysluzka.Add(barva);
            }
            else if (volba == 2)
            {
                for (int i = 0; i < vysluzka.Count; i++)
                {
                    Console.WriteLine($"   {i + 1}. vajicko: {vysluzka[i]}");
                }
            }
            else if (volba == 3)
            {
                Console.WriteLine("Pocet sebranych vajicek: " + vysluzka.Count);
            }
            else
            {
                pokracovat = false;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Aplikace byla ukoncena. Vesele ¨Velikonoce.");
    }
}
