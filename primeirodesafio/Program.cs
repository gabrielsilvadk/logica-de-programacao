using System;
using System.Collections.Generic;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> multiplos5 = new List<int>();
            List<int> multiplos7 = new List<int>();
            List<int> multiplos5e7 = new List<int>();
            for(int i=1; i<=200; i++){
                if(i%5==0 && i%7!=0){
                    Console.WriteLine("Foo");
                    multiplos5.Add(i);
                }
                if(i%7==0 && i%5!=0){
                    Console.WriteLine("Bar");
                    multiplos7.Add(i);
                }
                if(i%7==0 && i%5==0){
                    Console.WriteLine("FooBar");
                    multiplos5e7.Add(i);
                    }
                 else{
                    Console.WriteLine(i);

                }
            }
            int[] valores = multiplos5.ToArray();
            int[] valores2 = multiplos7.ToArray();
            int[] valores3 = multiplos5e7.ToArray();
            
            Console.WriteLine("multiplos5: "+string.Join(" ",valores));
            Console.WriteLine("multiplos7: "+string.Join(" ",valores2));
            Console.WriteLine("multiplos5e7: "+string.Join(" ",valores3));
        }
    }
}
