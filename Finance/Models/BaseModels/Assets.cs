    namespace Finance.Models
{
    public class Assets
    {
        public long Id { get; set; }
        public long Type { get; set; }
        public string AssetCode { get; set; }
        public string ProviderCode { get; set; }
        public double Amount { get; set; }
    }
}
