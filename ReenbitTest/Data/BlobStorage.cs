using Azure.Storage.Blobs;

namespace ReenbitTest;

public class BlobStorage
{
    private string connectionString =
        *connection string from Azure*;
    private string containerName = "files";
    public BlobContainerClient container;
    
    public BlobStorage()
    {
        container = new BlobContainerClient(connectionString, containerName);
    }
}
