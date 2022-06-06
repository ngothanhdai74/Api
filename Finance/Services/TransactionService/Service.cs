using Finance.Repositories.FileStorage.TransactionStorage;

namespace Finance.Services.TransactionService
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
