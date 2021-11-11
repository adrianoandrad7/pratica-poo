using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Video [] videos = new Video[3];

            videos[0] = new Video("Aula 1 de POO");
            videos[1] = new Video("Aula 2 de POO");
            videos[2] = new Video("Aula 3 de POO"); 

            System.Console.WriteLine(videos[0].ToString());
            System.Console.WriteLine();

            Pessoa pessoa = new Pessoa("João", 25, "M");
            Gafanhoto [] gafanhoto = new Gafanhoto[2];
            gafanhoto[0] = new Gafanhoto("Jubileu",22,"M","Jubi");
            gafanhoto[1] = new Gafanhoto("Creuza",18,"F","Creu");

            System.Console.WriteLine(gafanhoto[0].ToString());       

            System.Console.WriteLine();
            videos[1].Play();
            System.Console.WriteLine(videos[1].ToString());

            
        }
    }
}
