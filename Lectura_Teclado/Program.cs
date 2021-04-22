using System;

namespace Lectura_Teclado
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            Console.WriteLine("Digite el primer numero:  ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero:  ");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado de {numero1} + {numero2} es igual a: {numero1+numero2}");
        }
    }
}
