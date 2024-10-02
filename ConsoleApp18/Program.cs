using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            animal a = new animal("a", 2);
            animal cats = new cats("megatron",2);
            animal dogs = new dogs("optimus prime",3);

            a.SesCikar();
           cats.SesCikar();
           dogs.SesCikar();
        }
    }
}
