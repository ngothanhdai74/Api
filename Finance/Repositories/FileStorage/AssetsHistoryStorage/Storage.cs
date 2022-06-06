using Finance.Models.BizModels.AssetsHistory;

namespace Finance.Repositories.FileStorage.AssetsHistoryStorage
{
    public class Storage : IStorage
    {
        private readonly IConfiguration _configuration;
        private const string BaseFolder = "AssetsHistory";
        public Storage(IConfiguration configuration)
        {
            _configuration = configuration;
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
