using System.Runtime.CompilerServices;
namespace Homework_Classes;

public class Unit
{
    private float _health;
    private float _armor;
    public string Name { get; }
    public float Health => _health;
    public int Damage { get; }
    
    //Armor
    public float Armor
    {
        get { return (float)Math.Round(_armor, 2);}
        set
        {
            if (value >= 0 || value <= 1) _armor = value;
            else Console.WriteLine("Armor out of range");
        }
    }
    
    //Name
    public Unit() : this("Unknown Unit")
    {
      
    }

    public Unit(string name)
    {
        Name = name;
    }

    //Get real health
    public float GetRealHealth()
    {
        return Health * (1f + Armor);
    }
    public bool SetDamage(float value)
    {
        if (Health <= 0) return true;
        return false;
        _health = Health - value * Armor;
    }
}
   