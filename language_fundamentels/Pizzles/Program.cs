using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizzles
{
    class Program
    {
        public static int [] RandomArray(){
            int [] array = new int[10];
            Random rand = new Random();
            for(int i = 0; i <array.Length; i++){
                array[i] = rand.Next(5,25);
            }
            return array;
        }
        public static string  TossCoin(){
            Random rand = new Random();
            int x= rand.Next(0,2);
            if(x==0){
                return "Tails";
            }
            else{
                return "Heads";
            }
        }
        public static double TossMultipleCoins(int num){
            double couter=0;
            for(int i=0; i<num; i++){
                if(TossCoin()=="Heads"){
                    couter++;
                }
            }
            return couter/num;
        }
        public static List<string> Names(){
            List <string> names = new List<string>();
            List <string> names2 = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            Random rand = new Random();
             int n = names.Count;  
                while (n > 1) {  
                    n--;  
                    int k = rand.Next(n + 1);  
                    string value = names[k];  
                    names[k] = names[n];  
                    names[n] = value;  
                }
            foreach(string name in names){
                Console.WriteLine(name);
                if (name.Length>5){
                    names2.Add(name);
                }
            }
            return names2;
        }
        static void Main(string[] args)
        {
            int [] arr=RandomArray();
            int sum=0;
            foreach(int i in arr){
                sum+=i;
            }
            // Console.WriteLine($"min={arr.Min()} max={arr.Max()} average={sum/arr.Length}");
            // Console.WriteLine(TossCoin());
            // Console.WriteLine(TossMultipleCoins(4)); 
            foreach(string name in Names()){
                Console.WriteLine("*"+name);
            }
            
        }
    }
}
