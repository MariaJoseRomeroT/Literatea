namespace Literatea.Web.Helpers
{
    using Microsoft.AspNetCore.Http;
using System;
    using System.IO;
    using System.Threading.Tasks;
    public class ImageHelper : IImageHelper
    {
        public async Task<string> UploadImagesAsync(
            IFormFile imageFile,
            string nameFile,
            string nameFolder)
        {
            var grid = Guid.NewGuid().ToString();
            var file = $"{nameFile}{grid}.png";
            var path = Path.Combine(
                Directory.GetCurrentDirectory(),
                $"wwwroot\\image\\{nameFolder}",
                file);
                
         using (var stream= new FileStream(path, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }
            return $"~/images/{nameFolder}/{file}";
        }
    }
}
