namespace Homework_Classes;

public class Weapon
{
    public string Name { get; }
    public int MinDamage { get; private set; }
    public int MaxDamage { get; private set; }
    public float Durability { get;}
    
    //Weapon name
    public Weapon(string name)
    {
        Name = name;
    }

    public Weapon(string name , int minDamage, int maxDamage) : this(name)
    {
        SetDamageParams(minDamage, maxDamage);
    }
    
    //SetDamageParams
    public void SetDamageParams(int minDamage, int maxDamage)
    {
        if (minDamage > maxDamage)
        {
            int tempDamage  = maxDamage;
            maxDamage = minDamage;
            minDamage = tempDamage;
            Console.WriteLine("Not correct weapon damage {name}.");
        }

        if (minDamage < 1)
        {
            minDamage = 1;
            Console.WriteLine("Forced change minDamage to 1");
        }

        if (maxDamage <= 1)
        {
            maxDamage = 10;
        }
    }
    
    //Get damage
    public int GetDamage()
    {
        return (MinDamage + MaxDamage)/2;
    }


}