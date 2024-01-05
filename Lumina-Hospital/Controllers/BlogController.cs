using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.AppUser;
using Lumina_Hospital.Entities.Blog;
using Lumina_Hospital.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.Controllers
{
    public class BlogController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly LuminaHospitalDbContex _contex;

        public BlogController(LuminaHospitalDbContex contex, UserManager<User> userManager)
        {
            _contex = contex;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var blog = _contex.Blogs.Where(b => !b.IsDelete).ToList();
            return View(blog);
        }

        public async Task<IActionResult> Detail(int id)
        {
            if (id == 0) return NotFound();

            User user = null;

            if (User.Identity.IsAuthenticated)
            {
                user = await _userManager.FindByNameAsync(User.Identity.Name);
            }

            BlogVM vm = new()
            {
                Blogs = _contex.Blogs.Include(c => c.Comments).FirstOrDefault(b => b.Id == id),
                BlogComments = _contex.BlogComments.ToList(),
                Blogss = _contex.Blogs.Where(b => !b.IsDelete).ToList(),
                User = user,
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(BlogComment comment, int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                Blog? blog = await _contex.Blogs.Include(p => p.Comments).FirstOrDefaultAsync(p => p.Id == id);
                User user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user == null) return NotFound();
                

                BlogComment newComment = new()
                {
                    Message = comment.Message,
                    User = user,
                    CreationTime = DateTime.Now,
                    Blog = blog

                };
                user.Comments.Add(newComment);
                blog.Comments.Add(newComment);
                await _contex.BlogComments.AddAsync(newComment);
                await _contex.SaveChangesAsync();
                return RedirectToAction(nameof(Detail), new { id });
            }
        }

        public async Task<IActionResult> DeleteComment(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            User currentUser = await _userManager.FindByNameAsync(User.Identity.Name);

            BlogComment comment = await _contex.BlogComments
                .Include(c => c.User)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (comment == null)
            {
                return NotFound();
            }

            if (currentUser.Id != comment.User.Id)
            {
                return Forbid();
            }

            _contex.Remove(comment);
            await _contex.SaveChangesAsync();

            return RedirectToAction(nameof(Detail), new { id = comment.BlogId });
        }

    }
}
