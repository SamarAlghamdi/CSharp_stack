using System;
using System.Linq;

namespace Basic13
{
    class Program
    {
        public static void PrintNumbers()
                {
                    for(int i=1 ; i<=255 ; i++){
                        Console.WriteLine(i);
                    }
                }
        public static void PrintOdds()
            {
                for(int i=1 ; i<=255 ; i+=2){
                        Console.WriteLine(i);
                    }
            }
            public static void PrintSum(){
                int sum = 0;
                for(int i=0 ; i<=255 ; i++){
                    sum+=i;
                        Console.WriteLine($"the number is:{i} sum:{sum}");
                    }
            }
            public static void LoopArray(int[] numbers)
                {
                    for(int i = 0; i < numbers.Length; i++){
                        Console.WriteLine(numbers[i]);
                    }
                }
                public static int FindMax(int[] numbers)
                    {
                        int max=numbers[0];
                        for(int i = 1; i < numbers.Length; i++){
                            if(numbers[i]>max){
                                max = numbers[i];
                            }
                        }
                        return max;
                    }
                    public static void GetAverage(int[] numbers)
                        {
                            double sum = 0;
                            for(int i = 0; i < numbers.Length; i++){
                            sum+=numbers[i];
                            }
                            Console.WriteLine(sum/numbers.Length);
                        }
                        public static int[] OddArray()
                            {
                                int[] numbers=new int [256/2];
                                int i =0;
                                int counter=1;
                                while(i < numbers.Length && counter <=255){
                                    if(counter%2 != 0){
                                        numbers[i]=counter;
                                        i++;
                                    }
                                    
                                    counter++;
                                }
                                return numbers;
                            }
                            public static int GreaterThanY(int[] numbers, int y)
                                {
                                    int counter = 0;
                                    for(int i =0; i < numbers.Length; i++)
                                    {
                                        if(numbers[i]>y){
                                            counter++;
                                        }
                                    }
                                    return counter;
                                }
                            public static void SquareArrayValues(int[] numbers)
                                {
                                    int [] arr=new int [numbers.Length];
                                    for(int i =0;i<numbers.Length;i++){
                                        arr[i]=numbers[i]*numbers[i];
                                    }
                                    foreach( int x in arr){
                                        Console.WriteLine(x);
                                    }
                                }
                                public static void EliminateNegatives(int[] numbers)
                                    {
                                    
                                    for(int i =0;i<numbers.Length;i++){
                                        if(numbers[i]<0){
                                            numbers[i]=0;
                                        }
                                    }
                                    foreach( int x in numbers){
                                        Console.Write(x+" ");
                                    }
                                    }
                                    public static void MinMaxAverage(int[] numbers)
                                        {
                                            int max= numbers.Max();
                                            int min= numbers.Min();
                                            double sum = 0;
                                            for(int i = 0; i < numbers.Length; i++){
                                            sum+=numbers[i];
                                            }
                                            Console.WriteLine($"max: {max} min: {min} average: {sum/numbers.Length}");
                                        }
                                        public static void ShiftValues(int[] numbers)
                                            {
                                                for(int i = 0; i < numbers.Length-1; i++){
                                                    numbers[i]=numbers[i+1];
                                                }
                                                numbers[numbers.Length-1]=0;
                                                foreach( int x in numbers){
                                                    Console.WriteLine(x);
                                                }
                                            }
                                            public static object[] NumToString(int[] numbers)
                                                    {
                                                        object[] arr=new object[numbers.Length];
                                                       for( int i=0; i<numbers.Length; i++){
                                                            if(numbers[i]<0){
                                                                arr[i]="Dojo";
                                                            }
                                                            else{
                                                                arr[i]=numbers[i];
                                                            }
                                                        }
                                                        return arr;
                                                    }
        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            int [] arr = {1,2,3};
            // LoopArray(arr);
            // Console.WriteLine(FindMax(new int []{-3, -5, -7}));
            // GetAverage(new int [] {3, 10, 3});
            int [] arr2 = OddArray();
            foreach( int i in arr2){
                // Console.WriteLine(i);
            }
            // Console.WriteLine(GreaterThanY(new int [] {1, 3, 5, 7}, 3));
            // SquareArrayValues(new int [] {1,5,10,-10});
            // EliminateNegatives(new int [] {1,5,10,-2});
            // MinMaxAverage(new int [] {1,5,10,-2});
            // ShiftValues(new int [] {1, 5, 10, 7, -2});
            // object[] values = NumToString(new int[] {-1,-3,2});
            // foreach(object value in values){
            //     Console.WriteLine(value);
            // }
            
            
        }
    }
}
