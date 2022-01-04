using System;
using System.Collections.Generic;

namespace AppPost.Entities
{
    class Post
    {
        public DateTime Date { get; private set; }
        public string Title{ get; private set; }
        public int Likes { get; private set; }
        public List<Comment> Comments { get; private set; } = new List<Comment>();

        public Post()
        {
        }
        public Post(DateTime date, string title, int likes)
        {
            Date = date;
            Title = title;
            Likes = likes;
        }
        public void AddComment (Comment comment)
        {
            Comments.Add(comment); 
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
