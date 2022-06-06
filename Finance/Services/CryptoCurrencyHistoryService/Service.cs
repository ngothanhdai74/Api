using Finance.Repositories.FileStorage.CryptoCurrencyHistoryStorage;

namespace Finance.Services.CryptoCurrencyHistoryService
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
