using System;
using AppPost.Entities;

namespace AppPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Muito bom !");
            Comment c2 = new Comment("Parabéns !!");

            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"),
                "La casa de papel",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);
        }
    }
}
