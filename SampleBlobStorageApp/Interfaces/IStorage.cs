using System;

namespace SampleBlobStorageApp.Interfaces
{
    public interface IStorage
    {
        string GetToken(string connectionString);
    }
}
