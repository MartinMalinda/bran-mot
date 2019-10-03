using System;
using System.Collections.Generic;
namespace objectsAndClasses
{
    public class Blog
    {
        //Reuse your BlogPost class
        //Create a Blog class which can
        //store a list of BlogPosts
        //add BlogPosts to the list
        //Delete(int) one item at given index
        //Update(int, BlogPost) one item at the given index and update it with another BlogPost

        public List<BlogPost> BlogPosts { get; set; }

        public Blog()
        {
            BlogPosts = new List<BlogPost>();
        }

        public void AddBlogPost(BlogPost post)
        {
            BlogPosts.Add(post);
            Console.WriteLine($"{post.title} was added to the blog");
        }

        public void DeletePost(int postID)
        {
            string postToDelete = BlogPosts[postID].title;
            BlogPosts.RemoveAt(postID);
            Console.WriteLine($"{postToDelete} was removed from the blog");
        }

        public void Update(int index, BlogPost post)
        {
            string removedTitle = BlogPosts[index].title;
            string addedTitle = post.title;
            BlogPosts.RemoveAt(index);
            BlogPosts.Insert(index, post);
            Console.WriteLine($"{removedTitle} was replaced with {addedTitle}");

        }

        public void PrintTitles()
        {
            foreach (BlogPost post in BlogPosts)
            {
                Console.WriteLine(post.title);
            }
        }

    }
}
