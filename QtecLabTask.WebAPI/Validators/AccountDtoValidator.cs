using FluentValidation;
using QtecLabTask.Core.DTOs;

namespace QtecLabTask.WebAPI.Validators
{
    public class AccountDtoValidator : AbstractValidator<AccountDto>
    {
        public AccountDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(100).WithMessage("Name cannot exceed 100 characters");

            RuleFor(x => x.Type)
                .NotEmpty().WithMessage("Type is required")
                .MaximumLength(50).WithMessage("Type cannot exceed 50 characters");
        }
    }
}
