﻿namespace Lumina_Hospital.Extension
{
    public static class FileExtension
    {
        public static bool CheckImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }
        public static bool CheckVideo(this IFormFile file)
        {
            return file.ContentType.Contains("video/");
        }
        public static bool CheckImageSize(this IFormFile file, int size)
        {
            return file.Length / 1024 > size;
        }
        public static string SaveImage(this IFormFile file, string folder, IWebHostEnvironment webHostEnvironment)
        {
            string fileName = Guid.NewGuid() + file.FileName;
            string path = Path.Combine(webHostEnvironment.WebRootPath, folder, fileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);

            };
            return fileName;
        }
    }
}
