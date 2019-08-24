using System;

namespace MeuPrimeiroTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o Seu peso: ");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            float altura = float.Parse(Console.ReadLine());

           float imc = CalcularIMC (peso, altura);
            ExibirIMC(imc);

            Console.WriteLine("Seu IMC é: " + imc);

            Console.ReadLine();            
        }

        private static float CalcularIMC (float altura, float peso) =>
            peso / (altura * altura);
        

        private static void ExibirIMC (float imc)
        {
            if (imc <= 18.5)
                Console.Write("Peso Abaixo do Normal");
            else if (imc <= 25)
                Console.WriteLine("Peso Normal");
            else if (imc <= 30)
                Console.WriteLine("Sobrepeso.");
            else if (imc <= 35)
                Console.WriteLine("Obesidade Grau 1");
            else if (imc <= 40)
                Console.WriteLine("Obesidade Grau 2");
            else
                Console.WriteLine("Obesidade Grau 3");
        }

        
    }
}
