using Finance.Repositories.FileStorage.StockStorage;

namespace Finance.Services.StockService
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
