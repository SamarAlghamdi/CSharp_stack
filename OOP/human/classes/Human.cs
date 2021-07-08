using System;
namespace human
{
    public class Human
    {
        public string name;
        public int intelligence;
        public int strength;
        public int dexterity;
        private int health;
        public int healthProp {get{return health;} set{health = value;} }

        public Human(string name){
            this.name = name;
            intelligence = 3;
            strength = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string name, int intelligence, int strength, int dexterity , int health){
            this.name = name;
            this.intelligence = intelligence;
            this.strength = strength;
            this.dexterity = dexterity;
            this.health = health;
        }

        public virtual int Attack(Human target){
            int dmg =(strength * 5);
            target.health= target.health - dmg;
            Console.WriteLine($"{name} attacked {target.name} for {dmg} damage!");

            return target.health;
        }

        
    }
}