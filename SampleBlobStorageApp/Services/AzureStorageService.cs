using Microsoft.WindowsAzure.Storage;
using SampleBlobStorageApp.Interfaces;
using System;

namespace SampleBlobStorageApp.Services
{
    public class AzureStorageService : IStorage
    {
        public AzureStorageService() { }

        public string GetToken(string connectionString)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);

            SharedAccessAccountPolicy policy = new SharedAccessAccountPolicy()
            {
                Permissions = SharedAccessAccountPermissions.Write | SharedAccessAccountPermissions.Update,
                Services = SharedAccessAccountServices.Blob,
                ResourceTypes = SharedAccessAccountResourceTypes.Object,
                SharedAccessExpiryTime = DateTime.UtcNow.AddMinutes(5),
                Protocols = SharedAccessProtocol.HttpsOnly
            };

            return storageAccount.GetSharedAccessSignature(policy);
        }
    }
}
