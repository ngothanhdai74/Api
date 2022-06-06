using AutoMapper;

namespace Finance.AppServices.StockAppService
{
    public class AppService : IAppService
    {
        private readonly IMapper _mapper;
        public AppService(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
