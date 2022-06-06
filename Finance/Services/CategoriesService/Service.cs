using Finance.Repositories.FileStorage.CategoriesStorage;
using Finance.Models.BizModels.Categories;

namespace Finance.Services.CategoriesService
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
            var result = await _storage.Get(code);
            return result;
        }
        public async Task<IList<List>> Filter(Filter model)
        {
            var result = await _storage.Filter(model);
            return result;
        }
        public async Task<View> Post(New model)
        {
            var result = await _storage.Post(model);
            return result;
        }
        public async Task<View> Put(Edit model)
        {
            var result = await _storage.Put(model);
            return result;
        }
        public async Task<View> Delete(string code)
        {
            var result = await _storage.Delete(code);
            return result;
        }
    }
}
