using System;

namespace collection
{
    class Program
    {
        public static Forum forumList = new Forum();
        static void Main(string[] args)
        {
            string luachon ="";
            while (luachon != "7")
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Create Post");
                Console.WriteLine("2. Update Post");
                Console.WriteLine("3. Remove Post");
                Console.WriteLine("4. Show Posts");
                Console.WriteLine("5. Search");
                Console.WriteLine("6. Rating");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Enter your choice: ");
                luachon = Console.ReadLine();
                switch (luachon)
                {
                    case "1":
                        Post post = new Post();
                        Console.WriteLine("nhap content: ");
                         post.Content1 = Console.ReadLine();
                        Console.WriteLine("Nhap title: ");
                         post.Title1 = Console.ReadLine();
                        Console.WriteLine("Nhap author: ");
                         post.Author1 = Console.ReadLine();
                        forumList.Add(post);
                        break;
                    case "2":
                        Console.WriteLine("nhap Update post");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("nhap content post");
                        string contentUpdate =Console.ReadLine();
                        forumList.Update(id, contentUpdate);
                        break;
                    case "3":
                        Console.WriteLine("Remove Post");
                        int idDelete = int.Parse(Console.ReadLine());
                        forumList.removePosts(idDelete);
                        break;
                    case "4":
                        Console.WriteLine("Show All Post");
                        forumList.ShowPost();
                        break;
                    case "5":
                        Console.WriteLine("Search:");
                        string titleSearch = Console.ReadLine();
                        forumList.FindTitle(titleSearch);
                        break;
                    case "6":
                        Console.WriteLine("nhap Id :");
                        int idrRating = int.Parse(Console.ReadLine());
                        Console.WriteLine("nhap Rating");
                        int Rating = int.Parse(Console.ReadLine());
                        forumList.Ratingid(idrRating, Rating);
                        break;
                    case "7":
                        Environment.Exit(7);
                        break;
                }
            }
        }
    }
}

