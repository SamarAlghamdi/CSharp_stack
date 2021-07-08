using System;
using System.Collections.Generic;
namespace Fundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = {0,1,2,3,4,5,6,7,8,9};
            string [] arr2= {"Tim", "Martin", "Nikki", "Sara"};
            bool [] arr3=new bool[10];
            for (int i=0; i<arr3.Length-1; i+=2)
            {
                arr3[0]=true;
                arr3[i]=true;
            }
            for (int i=0; i<arr3.Length; i++)
            {
                // Console.WriteLine(arr3[i]);
            }

            List <string> list = new List<string>();
            list.Add("chocoleate");
            list.Add("vanila");
            list.Add("strowbirry");
            list.Add("oreo");
            list.Add("blue birry");
            // Console.WriteLine(list.Count);
            // Console.WriteLine(list[2]);
            list.RemoveAt(2);
            // Console.WriteLine(list.Count);

            Dictionary <string,string> dict = new Dictionary<string,string>();

            Random rand = new Random();

            for(int i = 0; i < arr2.Length; i++)
            {
                dict.Add(arr2[i],list[rand.Next(list.Count)]);
            }
            foreach( KeyValuePair<string,string> entry in dict)
            {
                Console.WriteLine(entry.Key +","+ entry.Value);
            }
        }
    }
}
