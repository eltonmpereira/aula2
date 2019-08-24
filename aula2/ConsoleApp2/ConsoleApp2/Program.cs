using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> carros = new List<Carro>
            {
                new Carro ("aaa-0000") { Cor ="Laranja", NumeroDePortas = 2},
                new Carro("aaa-1111") { Cor = "Preto", NumeroDePortas = 4 },
                new Carro("aaa-2222") { Cor = "Branco" , NumeroDePortas = 2 },
            };

            var placas = carros
                .Where(carro => carro.NumeroDePortas == 2)
                .Select(carro => carro.Placa)
                .ToList();

            carros
                .Where(carro=> carro.NumeroDePortas==2)
                .ToList()
                .ForEach(carro => carro.Ligar());

            //var carrosParaLigar = carros
            //    .Where(carro => carro.NumeroDePortas == 2);

            //foreach (var carro in carrosParaLigar)
            //{
            //    carro.Ligar();
            //}
        }
    }
}
