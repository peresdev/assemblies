using System;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assembly Privado");
            Console.WriteLine(PeresLib.Math.Sum(10, 10));
            Console.WriteLine(PeresLib.Math.Subtract(20, 10));
        }
    }
}
