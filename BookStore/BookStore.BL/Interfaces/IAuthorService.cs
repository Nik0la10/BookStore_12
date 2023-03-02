using BookStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Interfaces
{
    public interface IAuthorService
    {
        IEnumerable<Author> GetAll();

        Author GetById(int id);

        void AddAuthor(Author author);
    }
}
