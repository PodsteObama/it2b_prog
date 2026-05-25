class Program
{
    static void Main()
    {
        Autor bozena = new Autor("Božena Němcová");

        Kniha babicka = new Kniha("Babička", bozena);

        Console.WriteLine($"Autorkou knihy {babicka.Nazev} " +
            $"je {babicka.AutorObj.Jmeno}.");
    }
}
