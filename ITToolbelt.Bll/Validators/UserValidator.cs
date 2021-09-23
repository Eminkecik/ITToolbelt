using FluentValidation;
using ITToolbelt.Entity.Db;

namespace ITToolbelt.Bll.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Firstname).NotEmpty().WithMessage("Name field cannot be empty");
        }
    }
}