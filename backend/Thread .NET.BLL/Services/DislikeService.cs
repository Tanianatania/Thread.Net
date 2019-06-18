using AutoMapper;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.DAL.Context;

namespace Thread_.NET.BLL.Services
{
    public sealed class DisLikeService : BaseService
    {
        public DisLikeService(ThreadContext context, IMapper mapper) : base(context, mapper) { }

        public async Task DisLikePost(NewDisReactionDTO reaction)
        {
            var dislikes = _context.DisPostReactions.Where(x => x.UserId == reaction.UserId && x.PostId == reaction.EntityId);

            if (dislikes.Any())
            {
                _context.DisPostReactions.RemoveRange(dislikes);
                await _context.SaveChangesAsync();

                return;
            }

            _context.DisPostReactions.Add(new DAL.Entities.DisPostReaction
            {
                PostId = reaction.EntityId,
                IsDisLike = reaction.IsDisLike,
                UserId = reaction.UserId
            });

            await _context.SaveChangesAsync();
        }

        public async Task DisLikeComment(NewDisReactionDTO reaction)
        {
            var dislikes = _context.DisCommentReactions.Where(x => x.UserId == reaction.UserId && x.CommentId == reaction.EntityId);

            if (dislikes.Any())
            {
                _context.DisCommentReactions.RemoveRange(dislikes);
                await _context.SaveChangesAsync();

                return;
            }

            _context.DisCommentReactions.Add(new DAL.Entities.DisCommentReaction
            {
                CommentId = reaction.EntityId,
                IsDisLike = reaction.IsDisLike,
                UserId = reaction.UserId
            });

            await _context.SaveChangesAsync();
        }
    }
}

