class Autor
{
    public string Jmeno {  get; set; }
    public List<Kniha> Knihy {  get; set; }
    
    public Autor(string jmeno)
    {
        Jmeno = jmeno;
        Knihy = new List<Kniha>();
    }
}