using AutoMapper;

namespace Finance.AppServices.CryptoCurrencyAppService
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
