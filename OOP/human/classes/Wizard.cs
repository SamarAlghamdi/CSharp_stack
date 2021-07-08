using System;

namespace human
{
    public class Wizard : Human
    {
        public Wizard(string name):base(name){
            healthProp = 50;
            intelligence = 25;
        }

        public override int Attack(Human target){
            int dmg =(intelligence * 5);
            target.healthProp= target.healthProp - dmg;
            healthProp = healthProp + dmg;
            Console.WriteLine($"Wizarde {name} attacked {target.name} for {dmg} damage!");

            return target.healthProp;
        }

        public int Heal(Human target){
            target.healthProp = target.healthProp + (intelligence*10);
            Console.WriteLine($"Wizarde {name} heals {target.name} for {intelligence*10}");
            return target.healthProp;
        }
    }
}