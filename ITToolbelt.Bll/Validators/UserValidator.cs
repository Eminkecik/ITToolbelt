using FluentValidation;
using ITToolbelt.Entity.Db;

namespace ITToolbelt.Bll.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Firstname).NotEmpty().WithMessage("Name field cannot be empty");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname field cannot be empty");            
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail field cannot be empty");
        }
    }
}
