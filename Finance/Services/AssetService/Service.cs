using Finance.Repositories.FileStorage.AssetStorage;
using Finance.Models.BizModels.Assets;

namespace Finance.Services.AssetService
{
    public class Service : IService
    {
        private readonly IStorage _storage;
        public Service(IStorage storage)
        {
            _storage = storage;
        }
        public async Task<View> Get(string code)
        {
            return default;
        }
        public async Task<IList<List>> Filter(Filter model)
        {
            return default;
        }
        public async Task<View> Post(New model)
        {
            return default;
        }
        public async Task<View> Put(Edit model)
        {
            return default;
        }
        public async Task<View> Delete(string code)
        {
            return default;
        }
    }
}
