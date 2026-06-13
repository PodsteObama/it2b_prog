class Cichnamon 
{ 
    public string CichnaName; 
    public int Health; 
    public int MaxHealth; 
    public int ExtraAtk; 
    public Attack NormAtk; 
    public Attack SpecAtk; 
    public bool HealUsed = false; 
    public bool SpecialReady = true; 

    //staty
    public Cichnamon(string cichnaname, int maxHealth, int extraAtk, Attack normAttack, Attack specAtk) 
    {
        CichnaName = cichnaname; 
        MaxHealth = maxHealth; 
        Health = maxHealth; 
        ExtraAtk = extraAtk; 
        NormAtk = normAttack; 
        SpecAtk = specAtk; 
    } 

    public void UseNormAtk(Cichnamon enemy) //utok
    { 
        int damage = NormAtk.GetDamage() + ExtraAtk;
        Console.WriteLine(CichnaName + " used " + NormAtk.Name + "!");
        enemy.TakeDamage(damage); 
        SpecialReady = true; 
    } 
    public void UseSpecAtk(Cichnamon enemy) //spec utok
    {
        int damage = SpecAtk.GetDamage() + ExtraAtk; 
        Console.WriteLine(CichnaName + " used " + SpecAtk.Name + "!"); 
        enemy.TakeDamage(damage); 
        SpecialReady = false; 
    } 
    public void TakeDamage(int damage) //udeleni poskozeni + kontrola jestli je nepritel porazen
    { 
        Health -= damage; 
        if (Health <= 0)  
        {
            Health = 0; 
        } 
        Console.WriteLine(CichnaName + " took " + damage + " damage"); 
    } 
    public void Heal(int amount) //heal
    { 
        Health += amount; 
        if (Health > MaxHealth) 
        {
            Health = MaxHealth; 
        } 
        Console.WriteLine(CichnaName + " healed  " + amount + " HP."); 
    } 
    public bool IsAlive() //kontrola jestli je ## nazivu
    { 
        return Health > 0; 
    } 
    public void Info() //vypis infa
    { Console.WriteLine("----------------");
        Console.WriteLine("Name: " + CichnaName); 
        Console.WriteLine("Health: " + Health + "/" + MaxHealth); 
        Console.WriteLine("Attack Bonus: " + ExtraAtk); 
        Console.WriteLine("----------------"); 
    } 
}