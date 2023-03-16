using FluentValidation;

namespace GDStore.ViewModel.Products
{
    public class ProductRequestValidator : AbstractValidator<ProductUpdateRequest>
    {
        public ProductRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Tên sản phẩm không được để trống")
                .MinimumLength(5).WithMessage("Tên sản phẩm ít nhất 5 ký tự")
                .MaximumLength(50).WithMessage("Tên sản phẩm không quá 50 ký tự");

            RuleFor(x => x.OriginalPrice).NotEmpty().WithMessage("Giá gốc không được để trống");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Giá gốc không được để trống");

        }
    }
}
