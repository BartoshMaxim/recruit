using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Recruter.Helpers
{
    public static class ImageHelper
    {
        public static async Task<string> UploadLogo(IFormFile file, string userId, IHostingEnvironment hostingEnvironment)
        {
            var uploadpath = $"/Images/Users/{userId}";
            var ext = Path.GetExtension(file.FileName);

            var physicalImagePath = hostingEnvironment.ContentRootPath + uploadpath;

            if (!Directory.Exists(physicalImagePath))
            {
                Directory.CreateDirectory(physicalImagePath);
            }
            
            var imagepath = $"{physicalImagePath}/logo{ext}";

            if (File.Exists(imagepath))
            {
                File.Delete(imagepath);
            }
            
            using (var fileStream = new FileStream(imagepath, FileMode.Create)) {
                await file.CopyToAsync(fileStream);
            }

            return $"{uploadpath}/logo{ext}";
        }
    }
}