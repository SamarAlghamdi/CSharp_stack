using System;
using System.Collections.Generic;
namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List <object> list = new List<object>();
            list.Add(7);
            list.Add(28);
            list.Add(-1);
            list.Add(true);
            list.Add("chair");
            int sum=0;
            for(int i = 0; i <list.Count; i++)
            {
                Console.WriteLine(list[i]);
                if (list[i] is int){
                    sum=sum+(int)list[i];
                }
            }
            Console.WriteLine("the sum is:"+sum);
        }
    }
}
