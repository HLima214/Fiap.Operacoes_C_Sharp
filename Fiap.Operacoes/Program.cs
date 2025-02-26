using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Operacoes
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite um número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o número 2: ");
                double num2 = double.Parse(Console.ReadLine());

                double soma = num1 + num2;
                double sub = num1 - num2;
                double mult = num1 * num2;
                double div = num1 / num2;
                double modulo = num1 % num2;

                Console.WriteLine("\nResultado das operações");

                Console.WriteLine($"O valor da soma é {soma}");
                Console.WriteLine($"O valor da subtração é {sub}");
                Console.WriteLine($"O valor da multiplicação é {mult}");
                Console.WriteLine($"O valor da divisão é {div}");
                Console.WriteLine($"O valor do módulo é {modulo}");



                //Operações relacionais

                Console.WriteLine("\n  Comparação entre números");
                Console.WriteLine($"Os números são iguais ? {num1 == num2}");

                Console.WriteLine($"Os números são diferentes ? {num1 != num2}");

                Console.WriteLine($"O primeiro é maior que o segundo ? {num1 > num2}");


                //Operadores lógicos
                bool ambosPositivos = num1 >0 && num2 >0;
                bool algumnegativo = (num1 <0 || num2 < 0);

                Console.WriteLine($"Ambos positivos {ambosPositivos}");
                Console.WriteLine($"Algum negativos {algumnegativo}");

                Console.Write("Digite qualquer coisa para sair");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

            
        }
    }
}
