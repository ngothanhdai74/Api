namespace Finance.Models.BizModels.StockHistory
{
    public class View
    {
        public long Id { get; set; }
        public string StockCode { get; set; }
        public double Price { get; set; }
        public DateTime TimeStamp { get; set; }
        public long Year { get; set; }
        public long Month { get; set; }
        public long Day { get; set; }
    }
    public class List
    {
        public long Id { get; set; }
        public string StockCode { get; set; }
        public double Price { get; set; }
        public DateTime TimeStamp { get; set; }
        public long Year { get; set; }
        public long Month { get; set; }
        public long Day { get; set; }
    }
}
