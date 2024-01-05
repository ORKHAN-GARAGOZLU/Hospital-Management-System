using AutoMapper;
using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Blog;
using Lumina_Hospital.Extension;
using Lumina_Hospital.ViewModel.Admin.Blog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class BlogController : Controller
    {
        private readonly LuminaHospitalDbContex _contex;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;

        public BlogController(LuminaHospitalDbContex contex, IWebHostEnvironment webHostEnvironment, IMapper mapper)
        {
            _webHostEnvironment = webHostEnvironment;
            _contex = contex;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var blog = _contex.Blogs.Where(b => !b.IsDelete).ToList();
            return View(blog);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(BlogCreateVM blogVM)
        {
            Blog blog = _mapper.Map<Blog>(blogVM);

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("ImagePath", "Add photo");
                return View();
            }
            if (!blogVM.ImagePath.CheckImage())
            {
                ModelState.AddModelError("ImagePath", "Add only photo");
                return View();
            }
            if (blogVM.ImagePath.CheckImageSize(1000))
            {
                ModelState.AddModelError("ImagePath", "Size is high, maximum size will be 1mb");
                return View();
            }
            blog.ImagePath = blogVM.ImagePath.SaveImage("./assets/images/blog/", _webHostEnvironment);
            _contex.Blogs.Add(blog);
            _contex.SaveChanges();

            //Send Email

            var createdBlogUrl = Url.Action(nameof(Detail), "Blog", new { id = blog.Id });

            var subscriber = _contex.Subsicribers.ToList();
            foreach (var user in subscriber)
            {
                if (!string.IsNullOrEmpty(user.Email))
                {
                    var subject = "New Blog";

                    SendEmail(user.Email, subject, createdBlogUrl);
                }
            }

            return RedirectToAction("Index");

        }

        public void SendEmail(string email, string subject, string blogUrl)
        {

            MailMessage mailMessage = new();
            mailMessage.From = new MailAddress("orkhanqaragozov@gmail.com", "Lumina Hospital");
            mailMessage.To.Add(new MailAddress(email));
            mailMessage.Subject = subject;

            string body = string.Empty;
            using (StreamReader streamReader = new StreamReader("wwwroot/templates/blog/index.html"))
            {
                body = streamReader.ReadToEnd();
            }

            mailMessage.Body = body.Replace("{{link}}", blogUrl);
            mailMessage.IsBodyHtml = true;



            SmtpClient smtpClient = new();
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("orkhanqaragozov@gmail.com", "wrhi dcnt iiwo belq");
            smtpClient.Send(mailMessage);

        }

        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var blog = _contex.Blogs.FirstOrDefault(v => v.Id == id);
            if (blog == null) return NotFound();
            var blogVM = _mapper.Map<BlogEditVM>(blog);
            return View(blogVM);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(BlogEditVM blogVM)
        {
            var blog = _contex.Blogs.FirstOrDefault(v => v.Id == blogVM.Id);
            if (blog == null) return NotFound();
            blog.Author = blogVM.Author;
            blog.Description = blogVM.Description;
            blog.Title = blogVM.Title;

            var photo = blogVM.Photo;

            if (photo != null)
            {
                if (!photo.CheckImage())
                {
                    ModelState.AddModelError("Photo", "Only Photo.");
                }

                if (photo.CheckImageSize(1000))
                {
                    ModelState.AddModelError("Photo", "Size is high.");
                }

                var imagePathToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "./assets/images/blog/", blog.ImagePath);
                if (System.IO.File.Exists(imagePathToDelete))
                {
                    System.IO.File.Delete(imagePathToDelete);
                }
                blog.ImagePath = photo.SaveImage("./assets/images/blog/", _webHostEnvironment);
            }

            _contex.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var blog = _contex.Blogs
                .Where(d => !d.IsDelete)
                .FirstOrDefault(d => d.Id == id);
            if (blog == null) return NotFound();
            blog.IsDelete = true;
            blog.DeleteAt = DateTime.Now;
            _contex.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Blog? blog = _contex.Blogs.FirstOrDefault(s => s.Id == id);
            return blog is null ? BadRequest() : View(blog);
        }




    }
}
