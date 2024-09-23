using System.Runtime.CompilerServices;

namespace Pruebas_CSharp;

public class Character
{
    public string _name;
    private int maxHitPoints;
    private int baseAttack;
    private int baseDefense;
    private List<Iitem> inventory = new List<Iitem>();
    private int actualHitPoints;

    public Character(string name)
    {
        _name = name;
        maxHitPoints = 100;
        baseAttack = 20;
        baseDefense = 40; 
        actualHitPoints = maxHitPoints;
    }
    
    //Devuelve el ataque total
    public int Attack()
    {
        int totalAttack = baseAttack;
        if (inventory.Count != 0)
        {
            foreach (var item in inventory) 
            {
                if (item is Weapon) { totalAttack += (item as Weapon).GetDamage(); }
            }        
        }
        
        return totalAttack;
    }
   
    //Devuelve la defensa total
    public int Defense()
    {

        int totalDefense = baseDefense;

        if (inventory.Count != 0)
        {
             foreach (var item in inventory) 
             {
                 if (item is Protection) { totalDefense += (item as Protection).GetArmor(); }
             }
        }
       
        return totalDefense;
    }

    //Incrementa los puntos actuales del personaje sin pasarse del máximo
    public void Heal(int points)
    {
        if (points >= maxHitPoints)
        {
            actualHitPoints = maxHitPoints;
            Console.WriteLine($"{_name} has healed {maxHitPoints} life points - Actual life points: {actualHitPoints}");  
        }
        else
        {
            actualHitPoints += points;
            Console.WriteLine($"{_name} has healed {points} life points - Actual life points: {actualHitPoints}");
        }          
    }

    //Quita puntos de vida dependiendo del daño
    public void ReceiveDamage(int damage)
    {
        actualHitPoints -= damage;
        Console.WriteLine($"{_name} received damage {damage} - Actual life points: {actualHitPoints}");
    }

    //Añade un Item al inventario y muestra el mensaje de lo que se ha añadido
    public void AddItem(Iitem item)
    {
        inventory.Add(item);
        item.Apply(this);
    }

    //Devuelve la informacion del personaje 
    public override string ToString()
    {
        string inventoryItems = "";
        foreach (var item in inventory)
        {
            if (item is Weapon weapon)
            {
                inventoryItems += weapon.GetName() + ", ";
            }else if (item is Protection protection)
            {
                inventoryItems += protection.GetName() + ", ";
            }
        }
        
        return $"{_name} - Total life: {maxHitPoints}, Attack: {Attack()}, Defense: {Defense()}, Inventory: [{inventoryItems}]";
    }

}