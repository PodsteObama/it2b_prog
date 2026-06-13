class Attack
{
    public string Name;
    public int Damage;

    public Attack(string name, int damage)
    { 
        Name = name; Damage = damage; 
    }
    public int GetDamage()
    { //vraci damage hodnotu u urceneho cichnamona
        return Damage;
    }
}