using System;

namespace human
{
    public class Ninja : Human
    {
        public Ninja(string name):base(name) { 
            dexterity=175;
        }

        public override int Attack(Human target){
            int dmg =(dexterity * 5);
            target.healthProp= target.healthProp - dmg;
            Random rand = new Random();
            int chanc = rand.Next(1,100);
            if (chanc<20){
                dmg+=10;
            }
            
            Console.WriteLine($"Ninja {name} attacked {target.name} for {dmg} damage!");

            return target.healthProp;
        }

        public int Steal(Human target){
            int dmg =5;
            target.healthProp= target.healthProp - dmg;
            healthProp = healthProp+ dmg;
            
            Console.WriteLine($"Ninja {name} steal from {target.name} {dmg} damage and giand them!");
            return target.healthProp;
        }
    }
}