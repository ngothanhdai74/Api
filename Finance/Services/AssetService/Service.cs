using Finance.Repositories.FileStorage.AssetStorage;

namespace Finance.Services.AssetService
{
    public class Service : IService
    {
        private readonly IStorage _storage;
        public Service(IStorage storage)
        {
            _storage = storage;
        }
    }
}
