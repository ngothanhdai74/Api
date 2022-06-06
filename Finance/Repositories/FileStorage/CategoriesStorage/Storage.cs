using Finance.Infrastructure;
using Finance.Models;
using Finance.Models.BizModels.Categories;
using AutoMapper;

namespace Finance.Repositories.FileStorage.CategoriesStorage
{
    public class Storage : IStorage
    {
        private readonly IConfiguration _configuration;
        private const string BaseFolder = "Categories";
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
            var filePath = Path.Combine(BaseFolder, $"{code}.json");
            var result = _configuration.GetFile<Categories>(filePath);
            if(result != null)
            {
            }
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
