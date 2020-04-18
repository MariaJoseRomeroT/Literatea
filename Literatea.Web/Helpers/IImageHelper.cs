using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Literatea.Web.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImagesAsync(
            IFormFile imageFile,
            string nameFile,
            string nameForder);
    }
}
