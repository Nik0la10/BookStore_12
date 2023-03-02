using BookStore.BL.Interfaces;
using BookStore.BL.Services;
using BookStore.Models.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [ApiController]
    [Route(template: "[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet(template: "GetAll")]
        public IEnumerable<Author> GetAll()
        {
            return _authorService.GetAll();
        }
    }
}