using System;
namespace IronNinja.classes
{
    class SweetTooth : Ninja
    {
        public SweetTooth()
        {
        }

        public override bool IsFull{get{return calorieIntake >= 1500;}}

        public override void Consume(IConsumable item)
        {
            if (IsFull){
                Console.WriteLine("SweetTooth is full and cannot eat anymore");
            } else {
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                if (item.IsSweet){
                    calorieIntake += 10;
                }
                Console.WriteLine(item.GetInfo());
            }
        }
    }
}