namespace Finance.Models.BizModels.Transaction
{
    public class Edit
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
        public string AssetCodeFrom { get; set; }
        public string AssetCodeTo { get; set; }
        public double AmountFrom { get; set; }
        public double AmountTo { get; set; }
        public double Fee { get; set; }
    }
}
