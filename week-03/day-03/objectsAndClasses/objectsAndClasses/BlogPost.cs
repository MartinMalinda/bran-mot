using System;
namespace objectsAndClasses
{
    public class BlogPost
    {
        //Create a BlogPost class that has
        //an authorName
        //a title
        //a text
        //a publicationDate

        public string authorName { get; set; }
        public string title {get; set;}
        public string publicationDate { get; set; }
        public string text { get; set; }

        public BlogPost()
        {
        }
        public BlogPost(string author, string title, string published, string content)
        {
            this.authorName = author;
            this.title = title;
            this.publicationDate = published;
            this.text = content;
        }
    }
}
