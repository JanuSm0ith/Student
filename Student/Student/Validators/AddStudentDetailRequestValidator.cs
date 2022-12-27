using FluentValidation;

namespace Student.Validators
{
    public class AddStudentDetailRequestValidator: AbstractValidator<Models.DTO.AddStudentDetailRequest>
    {
       public AddStudentDetailRequestValidator()
        {
            RuleFor(x=>x.Name).NotEmpty();
            RuleFor(x => x.City).NotEmpty();
        }

    }
    
}
