using FluentValidation;
using Thread_.NET.Common.DTO.Comment;

namespace Thread_.NET.Validators
{
    public sealed class CommentDTOValidation : AbstractValidator<CommentDTO>
    {
        public CommentDTOValidation()
        {
            RuleFor(u => u.Body)
                .NotNull()
                .Length(10, 50);
        }
    }
}
