class Kniha
{
    public string Nazev {  get; set; }
    public Autor AutorObj {  get; set; }
    public bool Pujceno { get; set; }

    public Kniha(string nazev, Autor autorObj = null)
    {
        Nazev = nazev;
        Pujceno = false;
        AutorObj = autorObj;

        if (autorObj != null)
            autorObj.Knihy.Add(this);
    }
}
