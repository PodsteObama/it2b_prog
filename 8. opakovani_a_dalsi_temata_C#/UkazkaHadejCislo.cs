class Program
{
    static void Main()
    {
        // Hodnota konstanty se během programu nemění.
        const int TAJNE_CISLO = 7;
        const int MAX_POKUSU = 5;

        int pocetPokusu = 0;
        bool uhodnuto = false;

        Console.WriteLine("Hádej číslo od 1 do 10.");

        while (pocetPokusu < MAX_POKUSU)
        {
            try
            {
                Console.Write("Zadej číslo: ");

                // int.Parse může vyvolat výjimku,
                // pokud uživatel nezadá číslo.
                int tip = int.Parse(Console.ReadLine());

                // Čísla mimo povolený rozsah ignorujeme.
                if (tip < 1 || tip > 10)
                {
                    Console.WriteLine("Číslo musí být od 1 do 10.");

                    // Přeskočíme zbytek této iterace cyklu.
                    continue;
                }

                pocetPokusu++;

                if (tip == TAJNE_CISLO)
                {
                    Console.WriteLine("Správně!");
                    uhodnuto = true;

                    // Číslo jsme našli, takže už nemusíme pokračovat.
                    break;
                }

                Console.WriteLine("Špatně.");
            }
            catch (FormatException)
            {
                // Sem se program dostane například při zadání "ahoj".
                Console.WriteLine("Musíš zadat celé číslo.");
            }
            catch (OverflowException)
            {
                // Číslo je sice zapsané jako číslo,
                // ale je příliš velké pro datový typ int.
                Console.WriteLine("Zadané číslo je příliš velké.");
            }
        }

        if (!uhodnuto)
        {
            Console.WriteLine(
                $"Došly ti pokusy. Správné číslo bylo {TAJNE_CISLO}."
            );
        }
    }
}
