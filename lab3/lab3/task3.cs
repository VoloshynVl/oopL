// Клас-батько "Дата"
class Date
{
    // Змінив рівень захисту полів на protected для забезпечення доступу в класі-нащадку
    public int day;
    public int month;
    public int year;

    // Конструктор для ініціалізації дати
    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    // Функція-метод 1 обробки даних: визначити, чи збігаються номер місяця і число дня
    public bool IsMonthDayMatch()
    {
        return day == month;
    }

    // Функція-метод 2 обробки даних: збільшити дату на один місяць
    public void IncreaseByOneMonth()
    {
        month++;
        if (month > 12)
        {
            month = 1;
            year++;
        }
    }

    // Геттери для полів day, month і year, щоб мати можливість отримати їх значення в класі-нащадку
    public int GetDay()
    {
        return day;
    }

    public int GetMonth()
    {
        return month;
    }

    public int GetYear()
    {
        return year;
    }
}

// Клас-нащадок "Ліки"
class Medicine : Date
{
    private string name;
    private string manufacturer;

    // Конструктор для ініціалізації ліків
    public Medicine(string name, int day, int month, int year, string manufacturer)
        : base(day, month, year)
    {
        this.name = name;
        this.manufacturer = manufacturer;
    }

    // Функція-метод 3 обробки даних: скільки пройшло днів від виготовлення ліків
    public int DaysSinceManufacture()
    {
        DateTime today = DateTime.Now;
        DateTime manufactureDate = new DateTime(GetYear(), GetMonth(), GetDay());
        TimeSpan duration = today - manufactureDate;
        return duration.Days;
    }
}