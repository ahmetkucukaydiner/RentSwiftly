using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentSwiftly.Application.Features.RepositoryPattern;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _commentRepository;

        public CommentsController(IGenericRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }

        [HttpGet]
        public IActionResult GetCommentList() 
        {
            var values = _commentRepository.GetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            _commentRepository.Create(comment);
            return Ok("Yorum başarıyla eklendi.");
        }

        [HttpDelete]
        public IActionResult DeleteComment(int id)
        {
            var value = _commentRepository.GetById(id);
            _commentRepository.Delete(value);
            return Ok("Yorum başarıyla silindi.");
        }

        [HttpPut]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentRepository.Update(comment);
            return Ok("Yorum başarıyla güncellendi.");
        }

        [HttpGet("{id}")]
        public IActionResult GetCommentById(int id)
        {
            var value = _commentRepository.GetById(id);
            return Ok(value);
        }
    }
}
