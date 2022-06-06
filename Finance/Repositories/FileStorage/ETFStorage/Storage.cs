using Finance.Models.BizModels.ETF;

namespace Finance.Repositories.FileStorage.ETFStorage
{
    public class Storage : IStorage
    {
        private readonly IConfiguration _configuration;
        private const string BaseFolder = "ETF";
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
