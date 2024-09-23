using System;
using Pruebas_CSharp;

Character j1 = new Character("J1");

Axe axe = new Axe("Axe", 30);
Shield shield = new Shield("Shield", 20);

Console.WriteLine(j1);

j1.AddItem(shield);
j1.AddItem(axe);

Console.WriteLine(j1);

j1.ReceiveDamage(50);
j1.Heal(32);

