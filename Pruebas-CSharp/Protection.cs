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

    //Devuelve el valor de la armadura
    public int GetArmor(){return _armor;}
    
    //Devuelve el nombre del item de protección
    public string GetName(){return _name;}

    //Muestra información sobre el item de protección
    public void Apply(Character character)
    {
        Console.WriteLine($"{character._name} equiped {_name}, adding {_armor} points of defense");
    }
}