using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Mvc;
using System.IO;

//

namespace BlobQuickstartAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class blobController : ControllerBase
    {
        private static string blobconnectionstring = "DefaultEndpointsProtocol=https;AccountName=capegeblobstorage;AccountKey=HdLeGUZG28YHJEITidIK3I2MfDfH/ip+R53xGhKFD9QSAP8K0wqeK2eQf5GSsdD90fasXWPNHMlT+AStWNTMiw==;EndpointSuffix=core.windows.net";
        private static string containername = "democontainer";
        [HttpPost("[action]")]
     
        public async Task<IActionResult> FileUpload(IList<IFormFile> files)
        {
            
            BlobContainerClient blobContainerClient = new BlobContainerClient(blobconnectionstring, containername);
            foreach (IFormFile file in files)
            {
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    stream.Position = 0;
                     await blobContainerClient.UploadBlobAsync($"SQlFile/{file.FileName}", stream);
                }
            }

         return Ok("File uploaded Successfully!!");
        }

    }
}
