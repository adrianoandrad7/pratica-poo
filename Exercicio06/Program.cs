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
   
            Gafanhoto [] gafanhoto = new Gafanhoto[2];
            gafanhoto[0] = new Gafanhoto("Jubileu",22,"M","Jubi");
            gafanhoto[1] = new Gafanhoto("Creuza",18,"F","Creu");

            Visualizacao [] visualizacao = new Visualizacao[5];
            visualizacao[0] = new Visualizacao(gafanhoto[0],videos[2]);
            visualizacao[0].avaliar();
            System.Console.WriteLine(visualizacao[0].ToString());
            System.Console.WriteLine();

            visualizacao[1] = new Visualizacao(gafanhoto[0],videos[1]);
            visualizacao[0].avaliar(70.0f);
            System.Console.WriteLine(visualizacao[1].ToString()); 

        }
    }
}
