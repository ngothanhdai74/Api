namespace Finance.Models.Common
{
    public class PagedResult<T>
    {
        public IList<T> Results
        {
            get;
            set;
        }

        public int RowCount
        {
            get;
            set;
        }
    }
}
