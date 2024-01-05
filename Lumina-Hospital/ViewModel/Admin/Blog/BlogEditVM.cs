using FluentValidation;

namespace Lumina_Hospital.ViewModel.Admin.Blog
{
    public class BlogEditVM
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public IFormFile Photo { get; set; }
        public DateTime UpdateAt { get; set; }
    }

    public class BlogEditVMValidator : AbstractValidator<BlogEditVM>
    {
        public BlogEditVMValidator()
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
