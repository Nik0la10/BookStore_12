using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository) 
        {
            _authorRepository= authorRepository;
        }

        public void AddAuthor(Author author)
        {
            _authorRepository.AddAuthor(author);
        }

        public IEnumerable<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public Author GetById(int id)
        {
            return _authorRepository.GetById(id);
        }
    }
}
