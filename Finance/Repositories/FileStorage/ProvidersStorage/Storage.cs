using Finance.Models.BizModels.Providers;
using AutoMapper;

namespace Finance.Repositories.FileStorage.ProvidersStorage
{
    public class Storage : IStorage
    {
        private readonly IConfiguration _configuration;
        private const string BaseFolder = "Providers";
        private readonly IMapper _mapper;
        public Storage(
            IConfiguration configuration,
            IMapper mapper
            )
        {
            _configuration = configuration;
            _mapper = mapper;
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
