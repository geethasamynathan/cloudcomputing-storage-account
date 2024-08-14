using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blobAccountDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlobController : ControllerBase
    {
        public static string connectionString = "DefaultEndpointsProtocol=https;AccountName=blobstoragebatch1;AccountKey=c3mkimSbOIs7pW0RwZSodKuYIKAop/XGhMNTGfm+UpZZhLtHtg0oNv8XRhRAGFgKqw2IRyOVOg8D+AStF8TSPg==;EndpointSuffix=core.windows.net";
        public static string containerName = "democontainer";

        [HttpPost]
        public async Task<IActionResult> FileUpload(IList<IFormFile> files)
        {
            BlobContainerClient blobContainerClient=new BlobContainerClient(connectionString, containerName);
            foreach (IFormFile file in files)
            {
               using (var stream=new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    stream.Position = 0;
                    await blobContainerClient.UploadBlobAsync($"/Myuploads/{file.FileName}",stream);
                }
            }
            return Ok("File Uploaded successfully");
        }


    }
}
