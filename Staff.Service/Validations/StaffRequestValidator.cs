using FluentValidation;
using Staff.Service.Schemas;

namespace Staff.Service.Validations
{
    public class StaffRequestValidator : AbstractValidator<StaffRequest>
    {
        public StaffRequestValidator()
        {
            RuleFor(x => x.CreatedBy).NotNull().NotEmpty();
            RuleFor(x => x.FirstName).NotNull().NotEmpty().MinimumLength(3).MaximumLength(20);
            RuleFor(x => x.LastName).NotNull().NotEmpty().MinimumLength(3).MaximumLength(20);
            RuleFor(x => x.Email).NotNull().NotEmpty().EmailAddress();
            RuleFor(x => x.Phone).NotNull().NotEmpty().MinimumLength(10).MaximumLength(11);
            RuleFor(x => x.DateOfBirth).NotNull().NotEmpty();
            RuleFor(x => x.AddressLine1).NotNull().NotEmpty().MinimumLength(3).MaximumLength(500);
            RuleFor(x => x.City).NotNull().NotEmpty().MinimumLength(3).MaximumLength(100);
            RuleFor(x => x.Country).NotNull().NotEmpty().MinimumLength(3).MaximumLength(250);
            RuleFor(x => x.Province).NotNull().NotEmpty().MinimumLength(3).MaximumLength(500);
            RuleFor(x => x.FullName).NotNull().NotEmpty().MinimumLength(3).MaximumLength(20);
        }
    }
}