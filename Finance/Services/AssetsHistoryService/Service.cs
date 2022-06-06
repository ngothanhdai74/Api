using Finance.Repositories.FileStorage.AssetsHistoryStorage;

namespace Finance.Services.AssetsHistoryService
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
