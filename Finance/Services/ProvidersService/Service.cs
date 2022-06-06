using Finance.Repositories.FileStorage.ProvidersStorage;

namespace Finance.Services.ProvidersService
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
