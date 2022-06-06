using AutoMapper;

namespace Finance.AppServices.TransactionAppService
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
