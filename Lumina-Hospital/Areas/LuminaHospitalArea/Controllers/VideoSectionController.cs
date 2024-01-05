using AutoMapper;
using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Blog;
using Lumina_Hospital.Entities.Product;
using Lumina_Hospital.Entities.VideoSection;
using Lumina_Hospital.Extension;
using Lumina_Hospital.ViewModel.Admin;
using Lumina_Hospital.ViewModel.Admin.Video;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class VideoSectionController : Controller
    {
        private readonly LuminaHospitalDbContex _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;

        public VideoSectionController(LuminaHospitalDbContex context, IWebHostEnvironment webHostEnvironment, IMapper mapper)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var videoData = _context.Videos
                .Where(v => !v.IsDelete)
                .Include(v => v.VideoTitles)
                .FirstOrDefault();
            return View(videoData);
        }

        public IActionResult EditVideo(int? id)
        {
            if (id == null) return NotFound();
            var video = _context.Videos.FirstOrDefault(v => v.Id == id);
            if (video == null) return NotFound();
            return View(new VideoSectionEditVM
            {
                Id = video.Id,
                VideoPath = video.VideoPath,
            });
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult EditVideo(VideoSectionEditVM videoVM)
        {
            var videoData = _context.Videos.FirstOrDefault(v => v.Id == videoVM.Id);
            if (videoData == null) return NotFound();

            var video = videoVM.Video;

            if (video != null)
            {
                if (!video.CheckVideo())
                {
                    ModelState.AddModelError("Video", "Only video!");
                }

                if (video.CheckImageSize(8 * 1000))
                {
                    ModelState.AddModelError("Video", "Size is high!");
                }

                var imagePathToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "./assets/images/video/", videoData.VideoPath);
                if (System.IO.File.Exists(imagePathToDelete))
                {
                    System.IO.File.Delete(imagePathToDelete);
                }
                videoData.VideoPath = video.SaveImage("./assets/images/video/", _webHostEnvironment);
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            ViewBag.Video = new SelectList(_context.Videos.ToList(), "Id", "VideoPath");
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(VideoTitleCreateVM titleVM)
        {
            ViewBag.Video = new SelectList(_context.Videos.ToList(), "Id", "VideoPath");

            VideoTitle title = new()
            {
                Title = titleVM.Title,
                VideoId = titleVM.VideoId,
            };
            _context.VideoTitles.Add(title);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult EditTitle(int? id)
        {
            if (id == null) return NotFound();
            var videoTitle = _context.VideoTitles.Where(v => !v.IsDelete).FirstOrDefault(v => v.Id == id);
            if (videoTitle == null) return NotFound();
            return View(new VideoTitleEditVM
            {
                Id = videoTitle.Id,
                Title = videoTitle.Title,
            });
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult EditTitle(VideoTitleEditVM titleVM)
        {
            var title = _context.VideoTitles.Where(v => !v.IsDelete).FirstOrDefault(v => v.Id == titleVM.Id);
            if (title == null) return NotFound();
            titleVM.Title = title.Title;
            title.UpdateAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var title = _context.VideoTitles
                .Where(c => !c.IsDelete)
                .FirstOrDefault(c => c.Id == id);
            if (title == null) return NotFound();
            title.IsDelete = true;
            title.DeleteAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}
