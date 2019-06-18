using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.Common.DTO.Post;
using Thread_.NET.Extensions;

namespace Thread_.NET.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly PostService _postService;
        private readonly LikeService _likeService;
        private readonly DisLikeService _dislikeService;
        private readonly EmailService _emailService;

        public PostsController(PostService postService, LikeService likeService, DisLikeService disLikeService, EmailService emailService)
        {
            _postService = postService;
            _likeService = likeService;
            _dislikeService = disLikeService;
            _emailService = emailService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<PostDTO>>> Get()
        {
            return Ok(await _postService.GetAllPosts());
        }

        [HttpGet("get")]
        [AllowAnonymous]
        public ActionResult<PostDTO> Get(int id)
        {
            id = 14;
            return Ok(_postService.GetPost(id));
        }

        [HttpPost]
        public async Task<ActionResult<PostDTO>> CreatePost([FromBody] PostCreateDTO dto)
        {
            dto.AuthorId = this.GetUserIdFromToken();

            return Ok(await _postService.CreatePost(dto));
        }

        //[HttpPost]
        //public async Task<ActionResult<PostDTO>> Edit(int id, [FromBody] PostDTO dto)
        //{
        //    return Ok(await _postService.EditPost(dto));
        //}

        [HttpDelete]
        public IActionResult DeletePost(int id)
        {
            _postService.DeletePost(id);
            return Ok();
        }

        [HttpPost("like")]
        public async Task<IActionResult> LikePost(NewReactionDTO reaction)
        {
            reaction.UserId = this.GetUserIdFromToken();

            await _likeService.LikePost(reaction);
            PostDTO post = _postService.GetPost(reaction.EntityId);
            string message = "Your post " + post.Id.ToString() + " was liked :)";
            await _emailService.SendEmailAsync(post.Author.Email, "Ваш пост був оцынений", message);
            return Ok();
        }

        [HttpPost("dislike")]
        public async Task<IActionResult> DislikePost(NewDisReactionDTO reaction)
        {
            reaction.UserId = this.GetUserIdFromToken();

            await _dislikeService.DisLikePost(reaction);
            return Ok();
        }
    }
}