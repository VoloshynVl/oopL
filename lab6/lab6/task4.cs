class CollectionHandler<T>
{
    private List<T> collection;

    public CollectionHandler(List<T> initialCollection)
    {
        collection = initialCollection;
    }

    public void PrintCollection()
    {
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }

    public void SearchByValue(T searchValue)
    {
        collection = collection.Where(item => item.Equals(searchValue)).ToList();
    }

    public int CountStringsByLength(int length)
    {
        return collection.Count(item => item.ToString().Length == length);
    }

    public void SortCollectionAscending()
    {
        collection = collection.OrderBy(item => item.ToString()).ToList();
    }

    public void SortCollectionDescending()
    {
        collection = collection.OrderByDescending(item => item.ToString()).ToList();
    }
}