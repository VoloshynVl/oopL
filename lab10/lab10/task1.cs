using System;
using System.Collections.Generic;

class CharSet
{
    private HashSet<char> set;

    public CharSet()
    {
        set = new HashSet<char>();
    }

    // Додавання елементу до множини
    public void Add(char element)
    {
        set.Add(element);
    }

    // Видалення елементу з множини
    public void Remove(char element)
    {
        set.Remove(element);
    }

    // Перевірка належності до множини
    public bool Contains(char element)
    {
        return set.Contains(element);
    }

    // Перевірка на підмножину
    public bool IsSubsetOf(CharSet other)
    {
        return set.IsSubsetOf(other.set);
    }

    // Перевантаження оператору "-"
    public static CharSet operator -(CharSet set1, char element)
    {
        set1.Remove(element);
        return set1;
    }

    // Перевантаження оператору ">"
    public static bool operator >(CharSet set1, CharSet set2)
    {
        return set1.set.IsProperSupersetOf(set2.set);
    }

    // Перевантаження оператору "<"
    public static bool operator <(CharSet set1, CharSet set2)
    {
        return set1.set.IsProperSubsetOf(set2.set);
    }

    // Перевантаження оператору "=="
    public static bool operator ==(CharSet set1, CharSet set2)
    {
        return set1.set.SetEquals(set2.set);
    }

    // Перевантаження оператору "!="
    public static bool operator !=(CharSet set1, CharSet set2)
    {
        return !set1.set.SetEquals(set2.set);
    }

    // Виведення множини на консоль
    public void Print()
    {
        Console.Write("{ ");
        Console.Write(string.Join(", ", set));
        Console.WriteLine(" }");
    }
}
