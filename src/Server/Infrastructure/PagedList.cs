namespace Server.Infrastructure;

public class PagedList<T> : object
{
    public PagedList(List<T> items, int page, int pageSize, int totalCount) : base()
    {
        Items = items;
        Page = page;
        PageSize = pageSize;
        TotalCount = totalCount;
    }

    public List<T> Items { get; set; }

    public int Page { get; set; }

    public int PageSize { get; set; }

    public int TotalCount { get; set; }

    public bool HasNextPage => Page * PageSize < TotalCount;

    public bool HasPrevPage => Page > 1;

    public int TotlaPages => (int)Math.Ceiling(TotalCount / (double)PageSize);

    public List<T> Create()
    {
        var result =
            Items
                .Skip((Page - 1) * PageSize)
                .Take(PageSize)
                .ToList();

        return result;
    }
}
