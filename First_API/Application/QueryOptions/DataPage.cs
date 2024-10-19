namespace First_API.Application.QueryOptions
{
    public class DataPage
    {
        public int PageSize { get; set; }
        public int PageNum { get; set; }
        public int PageTotal { get; set; }
        public bool NeedTotal { get; set; }=false;
    }
}
