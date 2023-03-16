using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.ViewModel.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email không được để trống");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email không đúng định dạng");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Mật khẩu không được để trống")
                .MinimumLength(6).WithMessage("Mật khẩu phải ít nhất 6 ký tự");
        }
    }
}
