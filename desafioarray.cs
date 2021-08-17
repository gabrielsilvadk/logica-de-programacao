using System;

namespace desafio
{
    class Program2
    {
        static void Main(string[] args)
        {
            ImprimeItensCozinha();
}

public static void ImprimeItem(string item){
Console.WriteLine($"{item}");
}

public static void ImprimeItensCozinha(){
string itemCozinha1 = "Fogão";
string itemCozinha2 = "Pia";
string itemCozinha3 = "Geladeira";

Console.WriteLine("Cozinha");
ImprimeItem($"{itemCozinha1}");
ImprimeItem($"{itemCozinha2}");
ImprimeItem($"{itemCozinha3}");
}
            }
        }
    }
}