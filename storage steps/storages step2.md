# Storage Account
![alt text](image-45.png)
![alt text](image-46.png)
![alt text](image-47.png)
![alt text](image-27.png)

# structured storage

![alt text](image-28.png)
 # semi structured 

![alt text](image-29.png)

# unstructured  data
![alt text](image-30.png)


# Blob Storage
![alt text](image-31.png)

how it woule be , what kinds of things can store in blob storage
![alt text](image-32.png)

# Queue Storage
![alt text](image-33.png)
![alt text](image-34.png)
![alt text](image-35.png)

# Table Storage (unstructured data Like mongodb,cosmos db)
![alt text](image-36.png)
![alt text](image-38.png)


![alt text](image-39.png)

# File Storage
![alt text](image-40.png)
## comparison of blob and file storage
![alt text](image-41.png)

![alt text](image-42.png)

![alt text](image-43.png)

![alt text](image-44.png)



goto azure portal ==>storage Account ==> create resource group==>

![alt text](image-51.png)

![alt text](image-52.png)


Advance tab

![alt text](image-53.png)

Data protection

![alt text](image-54.png)

review + create
create

![alt text](image-55.png)

goto resource

![alt text](image-56.png)

![alt text](image-58.png)

save 
![alt text](image-59.png)

for blob storage => choose container ==>

![alt text](image-60.png)

![alt text](image-61.png)

![alt text](image-62.png)

![alt text](image-63.png)

![alt text](image-64.png)

![alt text](image-65.png)

![alt text](image-66.png)

![alt text](image-67.png)

![alt text](image-68.png)

this is how we creating blobstroage and uploading the files .for viewing you copy the url paste in browser file will download. we can view from downloads

# blob storage from C#

create storage account in az portal.
![alt text](image-98.png)

create a new project ( .net core web api).

copy the connectionstring from portal paste in notepad

set Environmentvariable using below command

`
setx AZURE_STORAGE_CONNECTION_STRING "<yourconnectionstring>"
`

`
setx AZURE_STORAGE_CONNECTION_STRING "DefaultEndpointsProtocol=https;AccountName=capegeblobstorage;AccountKey=HdLeGUZG28YHJEITidIK3I2MfDfH/ip+R53xGhKFD9QSAP8K0wqeK2eQf5GSsdD90fasXWPNHMlT+AStWNTMiw==;EndpointSuffix=core.windows.net""
`


create api project  ==>Blobquickstartapi

create new controller ==>blob controller==>

needs to install **Azure.Storage.Blobs** from nuget package
``` csharp
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Mvc;
using System.IO;



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
```
run your application
![alt text](image-100.png)

![alt text](image-101.png)

![alt text](image-102.png)

# another way you can set through 
goto environment variables
![alt text](image-99.png)

copy the connectionstring from portal paste in notepad

set Environmentvariable using below command

`
setx AZURE_STORAGE_CONNECTION_STRING "<yourconnectionstring>"
`

`
setx AZURE_STORAGE_CONNECTION_STRING "DefaultEndpointsProtocol=https;AccountName=capegeblobstorage;AccountKey=HdLeGUZG28YHJEITidIK3I2MfDfH/ip+R53xGhKFD9QSAP8K0wqeK2eQf5GSsdD90fasXWPNHMlT+AStWNTMiw==;EndpointSuffix=core.windows.net""
`

# File Storage

creating another storage  as i have delete the previous account.

review + create

Allow Blob anonymous access

![alt text](image-69.png)

![alt text](image-70.png)
choose any one the access tier ==>Hot  , cool, tr..
![alt text](image-71.png)

review + create

goto demofileshare ==> connect ==>

![alt text](image-72.png)

![alt text](image-73.png)

copy the script
open powershell in local machine

paste the script


it will create one drive with name we gave
there we can create folder ,file .That will reflect on azure portal too.

![alt text](image-74.png)

![alt text](image-75.png)

![alt text](image-76.png)

![alt text](image-77.png)
![alt text](image-78.png)
![alt text](image-79.png)



if we  want to look all storage inforamtion in local machine 
download and install ==>storage browser for windows 

![alt text](image-80.png)

![alt text](image-81.png)

![alt text](image-82.png)

![alt text](image-83.png)

![alt text](image-84.png)

![alt text](image-85.png)

![alt text](image-86.png)

# Add Queue

add queue

![alt text](image-91.png)

![alt text](image-92.png)

![alt text](image-93.png)

![alt text](image-94.png)

![alt text](image-95.png)

![alt text](image-96.png)

as we set expiration time for bye message 2mins. it is expired

![alt text](image-97.png)

# Azure Disk storage  ==> Price is high

![alt text](image-87.png)

![alt text](image-88.png)

![alt text](image-89.png)

unmanged disk ==> Blob ==> customer needs to take care responsibility

![alt text](image-90.png)



# CDN in storage account
# How does a CDN work?
CDNs are all about caching content and improving user experience. These tasks may sound rather straightforward, but the processes behind them are complex and full of technical wizardry.

# The CDN server
In order to exist, any such vendor needs content caching servers. These CDN servers are grouped into **point of presence** (PoPs) which are then distributed in various geographic locations. The purpose of the network is to **redirect the user to the closest possible PoP**. In most cases, this is done by utilizing the so-called GeoIP, a technology that allows IP address mapping to specific geographic regions, like countries, cities and largely populated areas. Upon processing a request, the network uses the GeoIP technology as a reference to direct the user to the closest available server.
![alt text](image-116.png)

# The content caching process
Any website user can cache their site’s content on a CDN to deliver it to their end-users in a quick, efficient manner. Thanks to this service, the entire process is much faster than if you had to deliver it straight from the source. In other words, **the user’s request to your content will go straight to the nearest possible PoP and back**, rather than traveling to the origin servers and back.
goto storage 
storagename :capegeblobstorage  ==> overview ==> cdn 
![alt text](image-105.png)

upload image in image container
![alt text](image-108.png)

goto storage ==> seach cdn

![alt text](image-103.png)

![alt text](image-104.png)

![alt text](image-106.png)

![alt text](image-107.png)



![alt text](image-109.png)

![alt text](image-110.png)

configure origin

![alt text](image-111.png)

![alt text](image-112.png)

![alt text](image-113.png)

goto cdn overview
copy the url
![alt text](image-114.png)

paste in another tab

for an example if url **https://imagecdnendpoint.azureedge.net**

**https://imagecdnendpoint.azureedge.net/myimage1.jpg**
![alt text](image-115.png)

| Feature    |	 Azure Front Door	|  Azure CDN |
| ---------- | -------------------- | ------------ |
|Primary Function |	Application acceleration |	Content delivery |
|Content Focus	|All content (static and dynamic)|	Static content (images, videos, large files)|
|Key Features |	Caching, intelligent routing, load balancing, WAF	|Caching, global POP network |
| Security |	Integrated Web Application Firewall (WAF) |	Limited security features|
|Routing	|Intelligent routing based on user location, server health, custom rules |	Simpler routing based on content type and origin server|
|Scalability |	Highly scalable for handling large traffic spikes |	Scalable for efficient content delivery |
| Cost |	Per rule set (potentially higher for complex configurations)|	Per bandwidth usage and storage|
|Ideal Use Case|	Global applications with complex routing and security needs	|Websites and applications requiring fast delivery of static content|