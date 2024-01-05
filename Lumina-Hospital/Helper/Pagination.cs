namespace Lumina_Hospital.Helper
{
    public class Pagination<T>
    {
        public List<T> Items { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public Pagination(List<T> items, int pageCount, int pageSize)
        {
            Items = items;
            PageCount = pageCount;
            PageSize = pageSize;
        }

        public static int CalculatePage(int count, int take)
        {
            return (int)Math.Ceiling((decimal)(count) / take);
        }
    }
}
