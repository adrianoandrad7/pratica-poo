using System;
using System.Collections.Generic;

namespace Exercicio03
{
    class Livro : Publicacao
    {

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public int ToPaginas { get; set; }

        public int PagAtual { get; set; }

        public bool Aberto { get; set; }

        public Pessoa Leitor { get; set; }

         public Livro(string titulo, string autor, int toPaginas, int pagAtual, bool aberto, Pessoa leitor)
        {
            Titulo = titulo;
            Autor = autor;
            ToPaginas = toPaginas;
            Aberto = false;
            PagAtual = 0;
            Leitor = leitor;
        }
  
        public Livro(string titulo, string autor, int toPaginas, Pessoa leitor)
        {
            Titulo = titulo;
            Autor = autor;
            ToPaginas = toPaginas;
            Leitor = leitor;
        }
        
        public string detalhes(){
            return $" Titulo: {Titulo},\n Autor: {Autor},\n Total de Paginas: {ToPaginas},\n Página Atual: {PagAtual},\n Aberto: {Aberto},\n Leitor: {Leitor.Nome},\n Sexo: {Leitor.Sexo}";
        }
        
        public void abrir()
        {
            Aberto = true;
        }
               

        public void fechar()
        {
            Aberto = false;
        }

        public void folhear(int p)
        {
            if (p > ToPaginas)
                Console.WriteLine("Página inválida");
            else
                PagAtual = p;
        }

        public void avancarPag()
        {
            if(PagAtual < ToPaginas)
                PagAtual++;
            else
                Console.WriteLine("Não há mais páginas");
        }

        public void voltarPag()
        {
           PagAtual--;
        }
    }

}