using System;
namespace human
{
    public class Samurai : Human
    {
        public Samurai(string name):base(name) {
            healthProp = 200;
        }

        public override int Attack(Human target){
            int targetHealth = base.Attack(target);
            if (targetHealth<50){
                target.healthProp= 0;
            }

            return target.healthProp;
        }

        public int Meditate(){
            healthProp = 1000;
            return healthProp;
        }
    }
}