using System;
using System.Collections.Generic;
using System.Linq;

namespace SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                var author1 = new Author()
                {
                    Name = "Leonardo da Vinci"
                };

                var author2 = new Author()
                {
                    Name = "Claude Mone"
                };

                context.Authors.Add(author1);
                context.Authors.Add(author2);
                context.SaveChanges();


                var pictures = new List<Picture>
                {
                    new Picture() {Name = "Mona Lisa", Year = 1503, AuthorId = author1.Id},
                    new Picture() {Name = "Water Lilies", Year = 1916, AuthorId = author2.Id}
                };

                context.Pictures.AddRange(pictures);

                context.SaveChanges();

                foreach (var currentPicture in context.Pictures.ToList())
                {
                    Console.WriteLine($"Picture name: {currentPicture.Name}, Author name: {currentPicture.Author.Name}");
                }
                Console.ReadKey();
            }
        }
    }
}
