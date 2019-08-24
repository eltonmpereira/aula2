using System;
using System.Collections.Generic;

namespace ContadorDecrescente
{
    class Program
    {
        private static Dictionary<int, string> _operacoes = new Dictionary<int, string>
        {
            { 0, "Soma" },
            { 1, "Subtração" },
            { 2, "Multiplicacao"},
            { 3, "Divisao"},
            { 4, "Sair"}
        };

        static void Main(string[] args)
        {
            Menu();

            bool aberto = true;
            while(aberto)
            {
                Console.WriteLine("Digite uma operacao: ");
                decimal operacao = LeiaNumero();

                switch (operacao)
                {
                    case 0:
                        Soma();                        
                        break;
                    case 1:
                        Subtracao();
                        break;
                    case 2:
                        Multiplicacao();
                        break;
                    case 3:
                        Divisao();
                        break;
                    case 4:
                        aberto = false;
                        break;
                    default:
                        Console.WriteLine("Este Numero nao esta no menu");
                        break;
                }
                
            }
        }

        private static decimal PedeNumero()
        {
            Console.WriteLine("Digite um numero:  ");
            return LeiaNumero();
        }

        private static void Divisao()
        {
            decimal num1 = PedeNumero();
            decimal num2 = PedeNumero();
            Console.WriteLine($"O Resultado da divisao é: {num1 / num2}");
        }

        private static void Multiplicacao()
        {
            decimal num1 = PedeNumero();
            decimal num2 = PedeNumero();
            Console.WriteLine($"O Resultado da multiplicacao é: {num1 * num2}");
        }

        private static void Subtracao()
        {
            decimal num1 = PedeNumero();
            decimal num2 = PedeNumero();
            Console.WriteLine($"O Resultado da subtracao é: {num1 - num2}");
        }

        private static void Soma()
        {
            decimal num1 = PedeNumero();
            decimal num2 = PedeNumero();
            Console.WriteLine ($"O Resultado é: {num1 + num2}");
        }

        private static void Menu()
        {
            foreach (var operacao in _operacoes)
            {
                Console.WriteLine($"{operacao.Key} - {operacao.Value}");
            }
        }

    private static decimal LeiaNumero()
        {
            string txt = Console.ReadLine();
            return Convert.ToDecimal(txt);
        }
    }
}