namespace Finance.Models
{
    public class Categories
    {
        public string Code { get; set; }
        public string ParentCode { get; set; }
        public string Name { get; set; }
        public long Type { get; set; }
        public string TypeName { get; set; }
        public long Status { get; set; }
        public string StatusName { get; set; }
    }
}
