using System;
using System.Collections.Generic;
using System.Text;

namespace AppPost.Entities
{
    class Comment
    {
        public string Text { get; private set; }

        public Comment()
        {

        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
