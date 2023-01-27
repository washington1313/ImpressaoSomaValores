using System;

namespace ImprimirSomaValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero, segundoNumero, terceiroNumero, soma;

            Console.WriteLine("Digite o primeiro número da soma: ");
            primeiroNumero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número da soma: ");
            segundoNumero= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número da soma: ");
            terceiroNumero= int.Parse(Console.ReadLine());
            Console.Clear();

            soma = somaValores(primeiroNumero, segundoNumero, terceiroNumero);
            Console.WriteLine("A soma dos números foi: " + soma);

            Console.ReadKey();
        }

        static int somaValores (int primeiroValor, int segundoValor, int terceiroValor)
        {
            int resultado = primeiroValor + segundoValor + terceiroValor;

            return resultado;
        }

    }
}
