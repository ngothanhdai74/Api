using Finance.Infrastructure;
using Finance.Models;
using Finance.Models.BizModels.Categories;
using AutoMapper;
using System.Text.Json;
using Finance.Models.Common;

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
            return _mapper.Map<View>(result);
        }
        public async Task<PagedResult<List>> Filter(Filter filter)
        {
            string startFolder = _configuration.GetValue<string>(FileHelper.StartFolderConfig);

            startFolder = Path.Combine(startFolder, BaseFolder);

            DirectoryInfo dir = new DirectoryInfo(startFolder);

            IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);

            var categories =
            from file in fileList
            let category = JsonSerializer.Deserialize<Categories>(File.ReadAllText(file.FullName))
            where 
                (!string.IsNullOrEmpty(filter.Code) && category.Code.Equals(filter.Code)) &&
                (!string.IsNullOrEmpty(filter.ParentCode) && category.ParentCode.Equals(filter.ParentCode)) &&
                (!string.IsNullOrEmpty(filter.Name) && category.Name.ToLower().Contains(filter.Name.ToLower())) &&
                (filter.Type.HasValue && filter.Type.Value == category.Type) &&
                (filter.Status.HasValue && filter.Status.Value == category.Status)
            select category;

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
