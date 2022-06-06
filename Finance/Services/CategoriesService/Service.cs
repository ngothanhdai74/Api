using Finance.Repositories.FileStorage.CategoriesStorage;

namespace Finance.Services.CategoriesService
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
