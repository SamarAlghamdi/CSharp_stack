using System;

namespace IronNinja.classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            SpiceHound spiceHound = new SpiceHound();
            SweetTooth sweetTooth = new SweetTooth();
            spiceHound.Consume(buffet.Serve());
            sweetTooth.Consume(buffet.Serve());
            spiceHound.Consume(buffet.Serve());
            sweetTooth.Consume(buffet.Serve());
            spiceHound.Consume(buffet.Serve());
            sweetTooth.Consume(buffet.Serve());
            spiceHound.Consume(buffet.Serve());
            sweetTooth.Consume(buffet.Serve());
            spiceHound.Consume(buffet.Serve());
            sweetTooth.Consume(buffet.Serve());
            if (spiceHound.ConsumptionHistory.Count> sweetTooth.ConsumptionHistory.Count){
                Console.WriteLine("SpiceHound has consumed the most items,");
                Console.WriteLine("Number of items consumed is:"+spiceHound.ConsumptionHistory.Count);
            } else {
                Console.WriteLine("SweetTooth has consumed the most items,");
                Console.WriteLine("Number of items consumed is:"+sweetTooth.ConsumptionHistory.Count);
            }
            
        }
    }
}
