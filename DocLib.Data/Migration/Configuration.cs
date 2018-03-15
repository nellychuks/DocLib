using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace DocLib.Data.Migration
{
    public sealed class Configuration : DbMigrationsConfiguration<DocLib.Data.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataContext context)
        {
            base.Seed(context);
            //user
            context.Users.AddOrUpdate(u => u.Email, new[]
            {

                new Entities.User
                {
                    Email = "k@k.com", Password = "password"
                },
                 new Entities.User
                {
                    Email = "v@v.com", Password = "password"
                },
                  new Entities.User
                {
                    Email = "a@a.com", Password = "password"
                },
            });

            //books

            context.Books.AddOrUpdate(o => o.Name, new[]
            {
                new Entities.Book
                    {

                     Author = "Brad Lenon",
                    Price = 1200,
                    Description = "Romance",
                    Bookid = 1,
                    Category = "Emotion",
                    Quantity = 5,
                    Name = "Love Apart",
                    Image = ""
                },
                new Entities.Book
                {
                     Author = "Grace Bowey",
                    Price = 1660,
                    Description = "Scientific Fiction",
                    Bookid = 2,
                    Category = "Sci-Fi",
                    Quantity =7,
                    Name = "Alien Dominion",
                    Image = ""
                },
                new Entities.Book
                {
                     Author = "George Valma",
                    Price = 1340,
                    Description = "Geographical Discovery",
                    Bookid = 3,
                    Category = "Geography",
                    Quantity =4,
                    Name = "Earth from Stone",
                    Image = ""
                },

                new Entities.Book
                {
                     Author = "Francis Kent",
                    Price = 1260,
                    Description = "Historical Thoughts",
                    Bookid = 4,
                    Category = "History",
                    Quantity =8,
                    Name = "Great Philosophy of Plato",
                    Image = ""
                },

                new Entities.Book
                {
                     Author = "Drew Lawrence",
                    Price = 1630,
                    Description = "Blood and Guns",
                    Bookid = 5,
                    Category = "Action",
                    Quantity =4,
                    Name = "Death and Sorrow",
                    Image = ""
                }
        });
        }

    }

}
