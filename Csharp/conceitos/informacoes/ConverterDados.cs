using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01conceito
{
    public class ConverterDados
    {
        Console.WriteLine("Informe um número: ")
        int numero1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Informe o segundo número: ")
        int numero2 = Convert.ToInt16(Console.ReadLine());

        int resultado = numero1 + numero2;
        Console.WriteLine("O resultado da soma é: " + resultado);
    }
}