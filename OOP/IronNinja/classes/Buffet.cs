
using System;
using System.Collections.Generic;

namespace IronNinja.classes
{
    class Buffet
    {
    public List<IConsumable> Menu;
     
    //constructor
    public Buffet()
        {
            Menu = new List<IConsumable>()
            {
            new Food("Nodels", 500, true, false),
            new Food("Dinmate Shrimp", 1000, true, false),
            new Food("Chepotly", 1200, false, false),
            new Food("Broneez", 700, false, true),
            new Food("Coockies", 500, false, true),
            new Food("Lobstare", 1000, false, false),
            new Food("Mash sweet potato", 300, true, true),
            new Drink("Moheto", 200,false),
            new Drink("Coffee", 200,false),
            new Drink("Tea", 200,false),
            new Drink("Latteh", 200,false)
            };
        }
     
    public IConsumable Serve()
    {
        Random rand = new Random();
        return Menu[rand.Next(0, Menu.Count)];

    }
}


}