using System;
using AppCalculoArea.Entidades;
using System.Collections.Generic;
using AppCalculoArea.Entidades.Enums;
using System.Globalization;

namespace AppCalculoArea
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> list = new List<Figura>();

            Console.Write("Entre com o numero de figuras: ");
            int nFiguras = int.Parse(Console.ReadLine());

            for( int i = 1; i <= nFiguras; i++)
            {
                Console.WriteLine($"Figura #{i}");

                Console.Write("Retangulo ou Circulo (r/c)? ");
                string resposta = Console.ReadLine();

                Console.Write("Cor: Black/Blue/Red : ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                if(resposta == "r")
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                   
                    list.Add(new Retangulo(altura, largura, cor));
                }
                else
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circulo(raio, cor));
                }
            }

            foreach(Figura figura in list)
            {
                Console.WriteLine(figura.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
