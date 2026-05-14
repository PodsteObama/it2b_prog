class Program
{
    static void Main()
    {
        Trida it2b = new Trida("IT2B");

        Ucitel drimal = new Ucitel("Dřímal");

        it2b.PriradTridniho(drimal);

        Console.WriteLine(drimal.Tridnictvi.Nazev);
    }
}