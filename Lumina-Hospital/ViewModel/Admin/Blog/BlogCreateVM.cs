using FluentValidation;

namespace Lumina_Hospital.ViewModel.Admin.Blog
{
    public class BlogCreateVM
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile ImagePath { get; set; }
        public DateTime CreateAt { get; set; }

    }
    public class BlogCreateVMValidator : AbstractValidator<BlogCreateVM>
    {
        public BlogCreateVMValidator()
        {
            RuleFor(a => a.Author)
                .NotEmpty()
                .MaximumLength(30);
            RuleFor(a => a.Title)
                .NotEmpty()
                .MaximumLength(60);
            RuleFor(a => a.Description)
                .NotEmpty()
                .MaximumLength(4000);
        }
    }
}
