using Finance.Repositories.FileStorage.BondStorage;

namespace Finance.Services.BondService
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
