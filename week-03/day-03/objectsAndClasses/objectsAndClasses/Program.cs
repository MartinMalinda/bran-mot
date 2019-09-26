using System;
using System.Collections.Generic;

namespace objectsAndClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            BlogPost Lorem = new BlogPost(
                "John Doe",
                "Lorem Ipsum",
                "2000.05.04",
                "Lorem ipsum dolor sit amet."
                );
            BlogPost WaitButWhy = new BlogPost(
                "Tim Urban",
                "Wait but why",
                "2010.10.10",
                "A popular long-form, stick-figure-illustrated blog about almost everything."
                );
            BlogPost OneEngineer = new BlogPost(
                "William Turton",
                "One Engineer Is Trying to Get IBM to Reckon With Trump",
                "2017.03.28",
                "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention.When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing."
                );

            Blog myBlog = new Blog();

            myBlog.AddBlogPost(Lorem);
            myBlog.AddBlogPost(WaitButWhy);
            myBlog.AddBlogPost(OneEngineer);
            Console.WriteLine();
            Console.WriteLine("My Blog so Far:");
            myBlog.PrintTitles();

            myBlog.Update(1, Lorem);

            Console.WriteLine();
            myBlog.PrintTitles();
        }
    }
}
