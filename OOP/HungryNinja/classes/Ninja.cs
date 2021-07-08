using System.Collections.Generic;
using System;

namespace HungryNinja
{
    class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;
     
    // add a constructor
    public Ninja(){
        calorieIntake =0;
        FoodHistory = new List<Food>();

    }
     
    // add a public "getter" property called "IsFull"
    public bool IsFull { 
        get{return calorieIntake > 1200;}
        
    }
     
    // build out the Eat method
    public void Eat(Food item)
    {
        if (!IsFull){
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
            Console.WriteLine($"Eating, Food name: {item.Name}, is't spicy: {item.IsSpicy}, is Sweet: {item.IsSweet}");
        } else {
            Console.WriteLine("The ninja is full and cannot eat anymore");
        }
    }
}


}