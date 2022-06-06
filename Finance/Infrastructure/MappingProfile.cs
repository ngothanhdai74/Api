using AutoMapper;

namespace Finance.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Assets
            CreateMap<Models.BizModels.Assets.Edit, Models.Assets>();
            CreateMap<Models.BizModels.Assets.New, Models.Assets>();
            CreateMap< Models.Assets, Models.BizModels.Assets.View>();
            // AssetsHistory
            CreateMap<Models.BizModels.AssetsHistory.Edit, Models.AssetsHistory>();
            CreateMap<Models.BizModels.AssetsHistory.New, Models.AssetsHistory>();
            CreateMap<Models.AssetsHistory, Models.BizModels.AssetsHistory.View>();
            // Bond
            CreateMap<Models.BizModels.Bond.Edit, Models.Bond>();
            CreateMap<Models.BizModels.Bond.New, Models.Bond>();
            CreateMap<Models.Bond, Models.BizModels.Bond.View>();
            // Categories
            CreateMap<Models.BizModels.Categories.Edit, Models.Categories>();
            CreateMap<Models.BizModels.Categories.New, Models.Categories>();
            CreateMap<Models.Categories, Models.BizModels.Categories.View>();
            // CryptoCurrency
            CreateMap<Models.BizModels.CryptoCurrency.Edit, Models.CryptoCurrency>();
            CreateMap<Models.BizModels.CryptoCurrency.New, Models.CryptoCurrency>();
            CreateMap<Models.CryptoCurrency, Models.BizModels.CryptoCurrency.View>();
            // CryptoCurrencyHistory
            CreateMap<Models.BizModels.CryptoCurrencyHistory.Edit, Models.CryptoCurrencyHistory>();
            CreateMap<Models.BizModels.CryptoCurrencyHistory.New, Models.CryptoCurrencyHistory>();
            CreateMap<Models.CryptoCurrencyHistory, Models.BizModels.CryptoCurrencyHistory.View>();
            // ETF
            CreateMap<Models.BizModels.ETF.Edit, Models.ETF>();
            CreateMap<Models.BizModels.ETF.New, Models.ETF>();
            CreateMap<Models.ETF, Models.BizModels.ETF.View>();
            // Providers
            CreateMap<Models.BizModels.Providers.Edit, Models.Providers>();
            CreateMap<Models.BizModels.Providers.New, Models.Providers>();
            CreateMap<Models.Providers, Models.BizModels.Providers.View>();
            // Stock
            CreateMap<Models.BizModels.Stock.Edit, Models.Stock>();
            CreateMap<Models.BizModels.Stock.New, Models.Stock>();
            CreateMap<Models.Stock, Models.BizModels.Stock.View>();
            // StockHistory
            CreateMap<Models.BizModels.StockHistory.Edit, Models.StockHistory>();
            CreateMap<Models.BizModels.StockHistory.New, Models.StockHistory>();
            CreateMap<Models.StockHistory, Models.BizModels.StockHistory.View>();
            // Transaction
            CreateMap<Models.BizModels.Transaction.Edit, Models.Transaction>();
            CreateMap<Models.BizModels.Transaction.New, Models.Transaction>();
            CreateMap<Models.Transaction, Models.BizModels.Transaction.View>();
        }
    }
}
