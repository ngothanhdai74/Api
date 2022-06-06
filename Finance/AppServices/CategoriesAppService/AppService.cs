using AutoMapper;
using Finance.Models.BizModels.Categories;

namespace Finance.AppServices.CategoriesAppService
{
    public class AppService : IAppService
    {
        private readonly IMapper _mapper;
        private readonly Services.CategoriesService.IService _service;

        public AppService(
            IMapper mapper,
            Services.CategoriesService.IService service
            )
        {
            _mapper = mapper;
            _service = service;
        }
        public async Task<View> Get(string code)
        {
            var result = await _service.Get(code);
            return result;
        }
        public async Task<IList<List>> Filter(Filter model)
        {
            var result = await _service.Filter(model);
            return result;
        }
        public async Task<View> Post(New model)
        {
            var result = await _service.Post(model);
            return result;
        }
        public async Task<View> Put(Edit model)
        {
            var result = await _service.Put(model);
            return result;
        }
        public async Task<View> Delete(string code)
        {
            var result = await _service.Delete(code);
            return result;
        }
    }
}
