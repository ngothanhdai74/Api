using Finance.Repositories.FileStorage.CryptoCurrencyStorage;

namespace Finance.Services.CryptoCurrencyService
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
