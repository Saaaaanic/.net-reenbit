using Azure.Storage.Blobs;

namespace ReenbitTest;

public class BlobStorage
{
    private string connectionString;
    private string containerName = "files";
    public BlobContainerClient container;
    
    public BlobStorage()
    {
        // Get connection string from appsettings.connection.json
        IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
        string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "ReenbitTest");
        path = Path.Combine(path, "appsettings.connection.json");
        configurationBuilder.AddJsonFile(path, false);
        IConfigurationRoot root = configurationBuilder.Build();
        IConfigurationSection appSettings = root.GetSection("ConnectionStrings:BlobStorageString");
        connectionString = appSettings.Value;
        container = new BlobContainerClient(connectionString, containerName);
    }
}
