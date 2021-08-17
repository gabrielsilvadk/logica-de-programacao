using System;

public class Program
{
    public static void Main()
    {
        ImprimeItensCozinha();
    }

    public static void ImprimeItem(string item)
    {
        Console.WriteLine($"{item}");
    }

    public static void ImprimeItensCozinha()
    {
        string[] itens = {"Fogão", "Pia", "Geladeira"};
        
       
        for(int i=0; i<3; i++){
            Console.WriteLine(itens[i]);
        }
    }
}