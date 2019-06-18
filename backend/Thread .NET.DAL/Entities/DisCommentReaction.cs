using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.DAL.Entities
{
    public sealed class DisCommentReaction: DisReaction
    {
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
