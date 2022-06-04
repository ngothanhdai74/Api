namespace FinanceService.Models
{
    public class Stock
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public long CurrentPrice { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public long Type { get; set; }
        public string TypeName { get; set; }
    }
}
