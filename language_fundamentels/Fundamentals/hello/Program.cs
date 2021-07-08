using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for( int i = 1; i <=255; i++)
            {
                // Console.WriteLine(i);
            }
            for( int i = 1; i <=100; i++)
            {
                if((i%3==0 || i%5==0) && !(i%3==0 && i%5==0))
                {
                    // Console.WriteLine(i);
                }
                
            }
            for( int i = 1; i <=100; i++)
            {
                if(i%3==0)
                {
                    //Console.WriteLine("Fizz");
                }
                if(i%5 ==0)
                {
                    //Console.WriteLine("Buzz");
                }
                if(i%3==0 && i%5 == 0){
                    //Console.WriteLine("FizzBuzz");
                }
                
            }
            int x = 1;
            while(x<=100)
            {
                if(x%3==0)
                {
                    Console.WriteLine("Fizz");
                }
                if(x%5 ==0)
                {
                    Console.WriteLine("Buzz");
                }
                if(x%3==0 && x%5 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                x++;
            }
        }
    }
}
