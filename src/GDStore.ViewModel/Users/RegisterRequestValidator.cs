using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.ViewModel.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Họ không được để trống");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Tên không được để trống");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email không được để trống");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email không đúng định dạng");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Số điện thoại không được để trống");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Tên đăng nhập không được để trống");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Mật khẩu không được để trống")
                .MinimumLength(6).WithMessage("Mật khẩu phải ít nhất 6 ký tự");
            RuleFor(x => x.ConfirmPassword).NotEmpty().Equal(x => x.Password).WithMessage("Mật khẩu không khớp");
        }
    }
}
