using System;
using Jogo_RPG.src.Entities;

namespace Jogo_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
        Knight arus = new Knight("Arus", 23, "Knight");
        Wizard wizard = new Wizard("Jennica", 23, "Wizard");

        Console.WriteLine(wizard.Attack(1));
        Console.WriteLine(wizard.Attack(7));
        }
    }
}
