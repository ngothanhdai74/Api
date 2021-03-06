using AutoMapper;
using Finance.Models.Common;
namespace Finance.Infrastructure
{
    public static class Extensions
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            // Sql
            // Cache
            // Storage
            services.AddTransient<Repositories.FileStorage.AssetsHistoryStorage.IStorage, Repositories.FileStorage.AssetsHistoryStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.AssetStorage.IStorage, Repositories.FileStorage.AssetStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CategoriesStorage.IStorage, Repositories.FileStorage.CategoriesStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CryptoCurrencyHistoryStorage.IStorage, Repositories.FileStorage.CryptoCurrencyHistoryStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.CryptoCurrencyStorage.IStorage, Repositories.FileStorage.CryptoCurrencyStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.ProvidersStorage.IStorage, Repositories.FileStorage.ProvidersStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.StockHistoryStorage.IStorage, Repositories.FileStorage.StockHistoryStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.StockStorage.IStorage, Repositories.FileStorage.StockStorage.Storage>();
            services.AddTransient<Repositories.FileStorage.TransactionStorage.IStorage, Repositories.FileStorage.TransactionStorage.Storage>();
            // Service
            services.AddTransient<Services.AssetService.IService, Services.AssetService.Service>();
            services.AddTransient<Services.AssetsHistoryService.IService, Services.AssetsHistoryService.Service>();
            services.AddTransient<Services.CategoriesService.IService, Services.CategoriesService.Service>();
            services.AddTransient<Services.CryptoCurrencyHistoryService.IService, Services.CryptoCurrencyHistoryService.Service>();
            services.AddTransient<Services.CryptoCurrencyService.IService, Services.CryptoCurrencyService.Service>();
            services.AddTransient<Services.ProvidersService.IService, Services.ProvidersService.Service>();
            services.AddTransient<Services.StockHistoryService.IService, Services.StockHistoryService.Service>();
            services.AddTransient<Services.StockService.IService, Services.StockService.Service>();
            services.AddTransient<Services.TransactionService.IService, Services.TransactionService.Service>();
            // AppService
            services.AddTransient<AppServices.AssetAppService.IAppService, AppServices.AssetAppService.AppService>();
            services.AddTransient<AppServices.AssetsHistoryAppService.IAppService, AppServices.AssetsHistoryAppService.AppService>();
            services.AddTransient<AppServices.CategoriesAppService.IAppService, AppServices.CategoriesAppService.AppService>();
            services.AddTransient<AppServices.CryptoCurrencyAppService.IAppService, AppServices.CryptoCurrencyAppService.AppService>();
            services.AddTransient<AppServices.CryptoCurrencyHistoryAppService.IAppService, AppServices.CryptoCurrencyHistoryAppService.AppService>();
            services.AddTransient<AppServices.ProvidersAppService.IAppService, AppServices.ProvidersAppService.AppService>();
            services.AddTransient<AppServices.StockAppService.IAppService, AppServices.StockAppService.AppService>();
            services.AddTransient<AppServices.StockHistoryAppService.IAppService, AppServices.StockHistoryAppService.AppService>();
            services.AddTransient<AppServices.TransactionAppService.IAppService, AppServices.TransactionAppService.AppService>();
        }

        public static PagedResult<TDestination> GetPageAsync<TSource, TDestination>(
            this IEnumerable<TSource> dataSource,
            IMapper mapper,
            int? page, 
            int? pageSize
            )
        {
            var result = new PagedResult<TDestination>();
            result.RowCount = dataSource.Count();
            if (page.HasValue && pageSize.HasValue)
            {
                dataSource = dataSource.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value);

            }
            result.Results = mapper.Map<IList<TDestination>>(dataSource);
            return result;
        }
    }
}
