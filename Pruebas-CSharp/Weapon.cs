namespace Pruebas_CSharp;

public abstract class Weapon : Iitem
{
    private string _name;
    private int _damage;

    public Weapon(string name, int damage)
    {
        _name = name;
        _damage = damage;
    }
    
    //Devuelve el daño del arma
    public int GetDamage(){return _damage;}
    
    //devuelve el nombre del arma
    public string GetName(){return _name;}

    //Muestra un mensaje sobre el arma
    public void Apply(Character character)
    {
        Console.WriteLine($"{character._name} equiped {_name}, adding {_damage} points of damage");
    }

    
}