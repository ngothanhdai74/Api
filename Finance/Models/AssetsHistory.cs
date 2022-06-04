namespace Finance.Models
{
    public class AssetsHistory
    {
        public long Id { get; set; }
        public string AssetCode { get; set; }
        public string ProviderCode { get; set; }
        public double Amount { get; set; }
    }
}
