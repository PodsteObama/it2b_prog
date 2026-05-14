class Ucitel
{
    public string Jmeno {  get; set; }
    public bool JeTridni { get; set; }
    public Trida Tridnictvi {  get; set; }


    public Ucitel(string jmeno)
    {
        Jmeno = jmeno;
        JeTridni = false;
        Tridnictvi = null;
    }
}