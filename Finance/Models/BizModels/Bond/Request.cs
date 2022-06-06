namespace Finance.Models.BizModels.Bond
{
    public class Filter
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public long Type { get; set; }
        public string TypeName { get; set; }
        public long Status { get; set; }
        public string StatusName { get; set; }
    }
}
