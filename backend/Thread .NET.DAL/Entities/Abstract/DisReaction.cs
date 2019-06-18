namespace Thread_.NET.DAL.Entities.Abstract
{
    public abstract class DisReaction : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public bool IsDisLike { get; set; }
    }
}
