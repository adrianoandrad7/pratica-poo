using System;

namespace Exercicio06
{
    class Visualizacao 
    {
        private Gafanhoto Espectador;
        private Video Filme;

        public Video Getfilme()
        {
            return Filme;
        }

        public void Setfilme(Video value)
        {
            Filme = value;
        }
        public Gafanhoto Getespectador()
        {
            return Espectador;
        }
        public void Setespectador(Gafanhoto value)
        {
            Espectador = value;
        }
        public Visualizacao(Gafanhoto espectador, Video filme)
        {
          Espectador = espectador;
          Filme = filme;
          Espectador.SetTotAssistido(Espectador.GetTotAssistido() + 1);
          Filme.SetViews(Filme.GetViews() + 1);
        } 
        
        public void avaliar(){
            Filme.SetAvalicao(5);
        }

        public void  avaliar(int nota){
            Filme.SetAvalicao(nota);
        }

        public void avaliar(float porcentagem){
           int tot = 0;
           if(porcentagem <= 20){
               tot =3;
           }else if(porcentagem <= 50){     
               tot = 5;
           }else if(porcentagem <= 90){
               tot = 8;
           }else{
               tot = 10;
           }

           Filme.SetAvalicao(tot);  
        }   
        
        public override string ToString()
        {
            return "O espectador " + Espectador + " assistiu o filme " + Filme;
        }
        
    }
}
