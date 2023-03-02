using BookStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.InMemoryDB
{
    public class DataStore
    {
        public static List<Author> Authors
            = new List<Author>()
            {
                new Author()
                {
                    Id = 1,
                    Name= "Gosho",
                    Bio= "Goso bio"
                },
                new Author()
                {
                    Id = 2,
                    Name= "Ginka",
                    Bio= "Ginka bio"
                }
            };
    }
}
