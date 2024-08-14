![alt text](image.png)

perfrmance

![alt text](image-1.png)

Redundancy
![alt text](image-2.png)

Locally redundant storage
LRS provides at least 99.999999999% (11 nines) durability of objects over a given year.

![alt text](image-3.png)

Zone-redundant storage
![alt text](image-4.png)
ZRS offers durability for storage resources of at least 99.9999999999% (12 9s) over a given year.


geo redundant storage
![alt text](image-5.png)

data write access is not available secondary region. Mainly focused on disaster recovery.

GRS offers durability for storage resources of at least 99.99999999999999% (16 9s) over a given year.



Geo-zone-redundant storage
![alt text](image-6.png)
GZRS is designed to provide at least 99.99999999999999% (16 9s) durability of objects over a given year.


Advanced:
![alt text](image-7.png)


Access tier 

Data protection
![alt text](image-8.png)

review_create

after creation of storage account


![alt text](image-9.png)

container ==>blob storage ==> binary ,large volume of data like video, image

![alt text](image-10.png)

to Anonymous access level private to public

![alt text](image-11.png)
![alt text](image-12.png)

save

![alt text](image-13.png)

under data storage ==> containers==> create 
![alt text](image-14.png)

choose container anonymous read

![alt text](image-15.png)

![alt text](image-16.png)

 3 types
 - block blobs – store large amount of a data and frequently access data
- Page blobs – store random read and write operation data
- Append blobs – storing blocks type of data
# Different access tire 
- Hot tier - An online tier optimized for storing data that is accessed or modified frequently. The hot tier has the highest storage costs, but the lowest access costs.
- Cool tier - An online tier optimized for storing data that is infrequently accessed or modified. Data in the cool tier should be stored for a minimum of 30 days. The cool tier has lower storage costs and higher access costs compared to the hot tier.
- Cold tier - An online tier optimized for storing data that is rarely accessed or modified, but still requires fast retrieval. Data in the cold tier should be stored for a minimum of 90 days. The cold tier has lower - - storage costs and higher access costs compared to the cool tier.
- Archive tier - An offline tier optimized for storing data that is rarely accessed, and that has flexible latency requirements, on the order of hours. Data in the archive tier should be stored for a minimum of 180 days.


![alt text](image-17.png)

![alt text](image-18.png)

 
 Manual file upload completed.

 another  way : using code 

 to take connecting string
 ![alt text](image-19.png)


 ![alt text](image-20.png)

 ![alt text](image-21.png)


Connection string

![alt text](image-22.png)
# BlobEndpoint=`https://samydemo.blob.core.windows.net/;QueueEndpoint=https://samydemo.queue.core.windows.net/;FileEndpoint=https://samydemo.file.core.windows.net/;TableEndpoint=https://samydemo.table.core.windows.net/;SharedAccessSignature=sv=2022-11-02&ss=bfqt&srt=sco&sp=rwdlacupiytfx&se=2024-08-10T10:20:09Z&st=2024-08-10T02:20:09Z&spr=https&sig=reoAQNQ5jrvoTCX%2BBdRcC%2BTq1FHtJqUMi6HBqwYFC7U%3D`
# SAS token
`sv=2022-11-02&ss=bfqt&srt=sco&sp=rwdlacupiytfx&se=2024-08-10T10:20:09Z&st=2024-08-10T02:20:09Z&spr=https&sig=reoAQNQ5jrvoTCX%2BBdRcC%2BTq1FHtJqUMi6HBqwYFC7U%3D`
# Blob service SAS URL
`https://samydemo.blob.core.windows.net/?sv=2022-11-02&ss=bfqt&srt=sco&sp=rwdlacupiytfx&se=2024-08-10T10:20:09Z&st=2024-08-10T02:20:09Z&spr=https&sig=reoAQNQ5jrvoTCX%2BBdRcC%2BTq1FHtJqUMi6HBqwYFC7U%3D`
# File service SAS URL
`https://samydemo.file.core.windows.net/?sv=2022-11-02&ss=bfqt&srt=sco&sp=rwdlacupiytfx&se=2024-08-10T10:20:09Z&st=2024-08-10T02:20:09Z&spr=https&sig=reoAQNQ5jrvoTCX%2BBdRcC%2BTq1FHtJqUMi6HBqwYFC7U%3D`
# Queue service SAS URL
`https://samydemo.queue.core.windows.net/?sv=2022-11-02&ss=bfqt&srt=sco&sp=rwdlacupiytfx&se=2024-08-10T10:20:09Z&st=2024-08-10T02:20:09Z&spr=https&sig=reoAQNQ5jrvoTCX%2BBdRcC%2BTq1FHtJqUMi6HBqwYFC7U%3D`
# Table service SAS URL
`https://samydemo.table.core.windows.net/?sv=2022-11-02&ss=bfqt&srt=sco&sp=rwdlacupiytfx&se=2024-08-10T10:20:09Z&st=2024-08-10T02:20:09Z&spr=https&sig=reoAQNQ5jrvoTCX%2BBdRcC%2BTq1FHtJqUMi6HBqwYFC7U%3D`


![alt text](image-23.png)

![alt text](image-24.png)


storage browser azure download

Azure file share ==> distributed filse system
queue ==> 64kb storeage ==> messaging service

table ==> unstructured table