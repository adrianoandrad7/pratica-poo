using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] Pessoa = new Pessoa[2];
            Livro[] Livro = new Livro[3];

            Pessoa[0] = new Pessoa("Pedro", 22, "M");
            Pessoa[1] = new Pessoa("Maria", 20, "F");

            Livro[0] = new Livro("C#", "João da silva", 100, Pessoa[0]);
            Livro[1] = new Livro(".Net", "Pedro Paulo", 200, Pessoa[1]);
            Livro[2] = new Livro("Java", "Maria Candido", 300, Pessoa[0]);

            Livro[0].abrir();
            Livro[0].folhear(100);
            Livro[0].avancarPag();
            System.Console.WriteLine(Livro[0].detalhes());
            System.Console.WriteLine(Livro[1].detalhes());

        }
    }
}
