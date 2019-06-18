using Thread_.NET.Common.DTO.User;

namespace Thread_.NET.Common.DTO.Like
{
    public sealed class DisReactionDTO
    {
        public bool IsDisLike { get; set; }
        public UserDTO User { get; set; }
    }
}
