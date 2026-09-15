class Program
{
    static double Obsahkruhu(double polomer)
    {
        const double PI = 3.14159;
        return PI * polomer * polomer;
    }

    static int Pokuta(List<int> rychlosti)
    {
        const int MAX_RYCHLOST = 50;
        int pokuta = 0;
        int pocetPokut = 0;

        foreach (int r in rychlosti)
        {
            if (r > MAX_RYCHLOST)
            {
                pokuta += 500;
                pocetPokut++;
            }
        }

        if (pocetPokut > 10)
        {
            pokuta += 1000;
        } 

        if (rychlosti.Count > 6 && rychlosti.Count == pocetPokut)
        {
            pokuta += 6000;
        }

        return pokuta;
    }

    static void Main()
    {
        Console.Write("Zadej polomer kruhu: ");
        double polomer = double.Parse(Console.ReadLine());
        Console.WriteLine($"Obsah kruhu je: {Obsahkruhu(polomer)}");

        List<int> rychlosti = new List<int> { 80, 52, 30, 50, 60, 54, 66, 48, 58, 58};
        Console.WriteLine($"Pokuta: {Pokuta(rychlosti)}");
    }
}
