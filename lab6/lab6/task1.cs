class CollectionType<T>
{
    private List<T> items;

    public CollectionType()
    {
        items = new List<T>();
    }

    public CollectionType(IEnumerable<T> initialItems)
    {
        items = new List<T>(initialItems);
    }

    // Додавання елемента
    public void AddItem(T item)
    {
        items.Add(item);
    }

    // Видалення елемента
    public void RemoveItem(T item)
    {
        items.Remove(item);
    }

    // Отримання елемента за індексом
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= items.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            return items[index];
        }
        set
        {
            if (index < 0 || index >= items.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            items[index] = value;
        }
    }

    // Кількість елементів у колекції
    public int Count
    {
        get { return items.Count; }
    }

    // Індексатор для доступу за значенням елемента
    public int IndexOf(T item)
    {
        return items.IndexOf(item);
    }

    // Вивід всіх елементів на екран
    public void DisplayItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
