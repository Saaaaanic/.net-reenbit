using Azure.Storage.Blobs;

namespace ReenbitTest;

public class BlobStorage
{
    private string connectionString =
        "DefaultEndpointsProtocol=https;AccountName=reenbitproj;AccountKey=qoKOi0XOtE1iMgQVt4jeQHLD3MVl2HpKrEcLu9NUP3G1T7/3n66pUN2mt6yT93uCUceIRpDbP9MT+AStYEfiPw==;EndpointSuffix=core.windows.net";
        private string containerName = "files";
    public BlobContainerClient container;
    
    public BlobStorage()
    {
        container = new BlobContainerClient(connectionString, containerName);
    }
}
