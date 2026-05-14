class Trida
{
    public string Nazev {  get; set; }
    public Ucitel Tridni { get; set; }
    
    public Trida(string nazev)
    {
        Nazev = nazev;
        Tridni = null; 
    }

    public void PriradTridniho(Ucitel tridni)
    {
        if (Tridni != null)
        {
            // Pokud už mám třídního odpoj ho
            Tridni.Tridnictvi = null;
            Tridni.JeTridni = false;
        }

        Tridni = tridni;
        tridni.JeTridni = true;
        tridni.Tridnictvi = this;
    }
}