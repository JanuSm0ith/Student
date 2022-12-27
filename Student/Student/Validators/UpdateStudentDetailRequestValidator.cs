using FluentValidation;

namespace Student.Validators
{
    public class UpdateStudentDetailRequestValidator: AbstractValidator<Models.DTO.UpdateStudentDetailRequest>
    {
        public UpdateStudentDetailRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.City).NotEmpty();
        }
    }
}
