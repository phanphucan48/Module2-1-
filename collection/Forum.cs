using System;
using System.Collections.Generic;
using System.Text;

namespace collection
{
    public class Forum
    {
        public SortedList<int, Post> post = new SortedList<int, Post>();
        public void Add( Post Post)
        {
            post.Add(Post.Id1, Post);
        }
        public void Update(int id , string content)
        {
            post[id].Content1 = content;
        }
        public void removePosts(int Id)
        {
        
                    post.Remove(Id);
          
        }
        public void ShowPost()
        {
            foreach ( Post post in post.Values)
            {
                post.Display();
            }
        }
        public void FindTitle(string Title1)
        {
            foreach (Post post in post.Values)
            {
                if (post.Title1 == Title1)
                {
                    post.Display();
                }
            }
        }
        public void Ratingid(int id,int rate)
        {
            post[id].Rates.Add(rate);
            
            post[id].CalculatorRate();
            post[id].Display();
        }

    }
}
