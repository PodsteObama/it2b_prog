class Program
{
    static void SmazVyskyty(List<int> list, int smaz)
    {
        while (list.Contains(smaz))
            list.Remove(smaz);
    }

    static void Main()
    {
        List<int> list = new List<int>() { 0, 0, 1, 0, 1, 1, 0};

        SmazVyskyty(list, 0);

        Console.WriteLine("List po smazani 0:");
        foreach (int l in list) { 
            Console.WriteLine("   " + l);
        }
    }
}
