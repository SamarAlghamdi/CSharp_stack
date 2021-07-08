using System;

namespace IronNinja.classes
{
    class SpiceHound: Ninja
    {
        public SpiceHound()
        {
        }

        public override bool IsFull{get{return calorieIntake >= 1200;}}

        public override void Consume(IConsumable item)
        {
            if (IsFull){
                Console.WriteLine("SpiceHound is full and cannot eat anymore");
            } else {
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                if (item.IsSpicy){
                    calorieIntake -= 5;
                }
                Console.WriteLine(item.GetInfo());
            }
        }
    }
}