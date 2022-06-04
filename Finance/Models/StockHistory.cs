namespace Finance.Models
{
    public class CryptoCurrencyHistory
    {
        public string Code { get; set; }
        public double Price { get; set; }
        public DateTime TimeStamp { get; set; }
        public long Year { get; set; }
        public long Month { get; set; }
        public long Day { get; set; }
    }
}
