namespace Pruebas_CSharp;

public abstract class Protection : Iitem
{
    private string _name;
    private int _armor;

    public Protection(string name, int armor)
    {
        _name = name;
        _armor = armor;
    }

    public int GetArmor(){return _armor;}
    public string GetName(){return _name;}

    public void Apply(Character character)
    {
        Console.WriteLine($"{character._name} equiped {_name}, adding {_armor} points of defense");
    }
}