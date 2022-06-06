using Finance.Repositories.FileStorage.StockHistoryStorage;

namespace Finance.Services.StockHistoryService
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
