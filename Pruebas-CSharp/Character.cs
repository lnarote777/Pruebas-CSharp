using System.Runtime.CompilerServices;

namespace Pruebas_CSharp;

public class Character
{
    private string _name;
    private int maxHitPoints;
    private int baseAttack;
    private int baseDefense;
    private List<Iitem> inventory;
    private int actualHitPoints;

    public Character(string name)
    {
        _name = name;
        maxHitPoints = 100;
        baseAttack = 20;
        baseDefense = 40; 
    }
    
    static void int Attack()
    {
        int totalAttack = baseAttack;
        
        foreach (var item in inventory) 
        {
            if (item is Weapon)
            {
                totalAttack += (item as Weapon).getDamage();

            }
            
        }
        return totalAttack;
    }
   
    static void int Defense()
    {

        int totalDefense = baseDefense;
        
        foreach (var item in inventory) 
        {
            if (item is Protection)
            {
                totaldefense += (item as Protection).getArmor();

            }
        }
        return totalDefense;
    }

    static void Heal(int points)
    {
        if (points >= maxHitPoints)
        {
            actualHitPoints = maxHitPoints;
            Console.WriteLine($"{_name} has healed $maxHitPoints life points - Actual life points: $actualHitPoints");
            
        }
    }

    static void ReceiveDamage(int damage)
    {
        
    }

    static void AddItem(Iitem item)
    {
        inventory.Add(item);
        item.apply();
    }
}