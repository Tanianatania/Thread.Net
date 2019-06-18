using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.DAL.Entities
{
    public sealed class DisPostReaction: DisReaction
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
