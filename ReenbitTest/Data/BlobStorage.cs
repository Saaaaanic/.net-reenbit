using Azure.Storage.Blobs;

namespace ReenbitTest;

public class BlobStorage
{
    private string connectionString =
        "DefaultEndpointsProtocol=https;AccountName=netreenbit;AccountKey=WVk/a6VJhzpjsjvwoffvVtpyOcgrFm2ZQ+sO8Fa/NWN7D8rXar2WdeZBCKQDW4vh2oagn1fCwiem+AStMyPcyQ==;EndpointSuffix=core.windows.net";
    private string containerName = "files";
    public BlobContainerClient container;
    
    public BlobStorage()
    {
        container = new BlobContainerClient(connectionString, containerName);
    }
}