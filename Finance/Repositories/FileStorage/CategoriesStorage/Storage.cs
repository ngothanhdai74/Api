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
            //where 
            //    (!string.IsNullOrEmpty(filter.Code) && category.Code.Equals(filter.Code)) &&
            //    (!string.IsNullOrEmpty(filter.ParentCode) && category.ParentCode.Equals(filter.ParentCode)) &&
            //    (!string.IsNullOrEmpty(filter.Name) && category.Name.ToLower().Contains(filter.Name.ToLower())) &&
            //    (filter.Type.HasValue && filter.Type.Value == category.Type) &&
            //    (filter.Status.HasValue && filter.Status.Value == category.Status)
            select category;

            if(!string.IsNullOrEmpty(filter.Code))
            {
                categories = categories.Where(c => c.Code.ToLower().Equals(filter.Code.ToLower())).ToList();
            }
            if (!string.IsNullOrEmpty(filter.ParentCode))
            {
                categories = categories.Where(c => c.ParentCode.ToLower().Equals(filter.ParentCode.ToLower())).ToList();
            }
            if (!string.IsNullOrEmpty(filter.Name))
            {
                categories = categories.Where(c => c.Name.ToLower().Contains(filter.Name.ToLower())).ToList();
            }
            return categories.GetPageAsync<Categories, List>(_mapper, filter.Page, filter.PageSize);
        }
        public async Task<View> Post(New model)
        {
            if(model == null || string.IsNullOrEmpty(model.Code))
            {
                return default;
            }
            if(FileHelper.IsExistFile(_configuration, $"{model.Code}.json", BaseFolder))
            {
                return default;
            }
            FileHelper.SaveFile(_configuration, $"{model.Code}.json", model, BaseFolder);
            return default;
        }
        public async Task<View> Put(Edit model)
        {
            if (model == null || string.IsNullOrEmpty(model.Code))
            {
                return default;
            }
            FileHelper.SaveFile(_configuration, $"{model.Code}.json", model, BaseFolder);
            return default;
        }
        public async Task<View> Delete(string code)
        {
            FileHelper.DeleteFile(_configuration, $"{code}.json", BaseFolder);
            return default;
        }
    }
}
