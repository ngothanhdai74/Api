namespace Finance.Models
{
    public class AssetsHistory
    {
        public long Id { get; set; }
        public long Type { get; set; }
        public string AssetCode { get; set; }
        public string ProviderCode { get; set; }
        public double Amount { get; set; }
        public long Year { get; set; }
        public long Month { get; set; }
        public long Day { get; set; }
    }
}
