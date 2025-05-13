using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace EventEasep2.Services
{
    public interface IBlobService
    {
        Task<string> UploadFileAsync(IFormFile file);
    }
}
