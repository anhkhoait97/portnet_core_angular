using FluentValidation;

namespace Web.BackendServer.UndergroundWorks.ReadRequest.ViewModels
{
    public class TacitReadRequestValidator : AbstractValidator<TacitReadRequest>
    {
        public TacitReadRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Tên không được để trống")
                .MaximumLength(50).WithMessage("Tên chỉ được nhập tối đa 50 ký tự");
        }
    }
}