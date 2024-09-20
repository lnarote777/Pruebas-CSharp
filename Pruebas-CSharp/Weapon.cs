namespace Pruebas_CSharp;

abstract class Weapon : Iitem
{
    private string name;
    private int damage;
    
    public int getDamage(){return damage;};
}