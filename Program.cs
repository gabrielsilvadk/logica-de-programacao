using System;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=200; i++){
                if(i%5==0){
                    Console.WriteLine("Foo");
                }else if(i%7==0){
                    Console.WriteLine("Bar");
                }else if(i%5==0 && i%7==0){
                    Console.WriteLine("FooBar");
                }else{
                    Console.WriteLine(i);

                }
            }
        }
    }
}
