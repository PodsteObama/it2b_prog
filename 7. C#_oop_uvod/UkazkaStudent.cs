public class Student
{
    // Atributy:
    public string Jmeno { get; set; }
    public int Vek { get; set; }
    public string Trida { get; set; }
    public List<int> Znamky;

    // Konstruktor:
    public Student(string jmeno, int vek, string trida)
    {
        // Studenta vytvořím pomocí: Student pepa = new Student(“Pepa”, 17, “IT2B”);
        Jmeno = jmeno;
        Vek = vek;
        Trida = trida;
        Znamky = new List<int>();
    }

    // Metody
    public void PridejZnamku(int znamka)
    {
      Znamky.Add(znamka);
    }

    public void ZmenTridu(string novaTrida)
    {
      Trida = novaTrida;
    }
}
