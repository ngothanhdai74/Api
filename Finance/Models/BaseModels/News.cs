namespace Finance.Models.BaseModels
{
    public class News
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string KeyWord { get; set; }
        public DateTime TimeStamp { get; set; }
        public long Type { get; set; }
        public string TypeName { get; set; }
        public long Status { get; set; }
        public string StatusName { get; set; }
    }
}
