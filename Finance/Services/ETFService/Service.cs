using Finance.Repositories.FileStorage.ETFStorage;

namespace Finance.Services.ETFService
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
