using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja ninja = new Ninja("Norah");
            Wizard wizard = new Wizard("Samar");
            Samurai samurai = new Samurai("Faisal");
            Console.WriteLine($"Ninja health is: {ninja.healthProp}");
            Console.WriteLine($"Wizard health is: {wizard.healthProp}");
            Console.WriteLine($"Samurai health is: {samurai.healthProp}");
            wizard.Attack(samurai);
            Console.WriteLine($"Ninja health is: {ninja.healthProp}");
            Console.WriteLine($"Wizard health is: {wizard.healthProp}");
            Console.WriteLine($"Samurai health is: {samurai.healthProp}");
            wizard.Heal(ninja);
            Console.WriteLine($"Ninja health is: {ninja.healthProp}");
            Console.WriteLine($"Wizard health is: {wizard.healthProp}");
            Console.WriteLine($"Samurai health is: {samurai.healthProp}");
            samurai.Meditate();
            Console.WriteLine($"Samurai health is: {samurai.healthProp}");
            ninja.Steal(wizard);
            Console.WriteLine($"Wizard health is: {wizard.healthProp}");
            Console.WriteLine($"Ninja health is: {ninja.healthProp}");
            ninja.Attack(samurai);
            Console.WriteLine($"Ninja health is: {ninja.healthProp}");
            Console.WriteLine($"Samurai health is: {samurai.healthProp}");

        }
    }
}
