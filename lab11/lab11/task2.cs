
class DateCalculator
{
    public static TimeSpan CalculateRemainingDays(DateTime targetDate)
    {
        DateTime currentDate = DateTime.Now;
        TimeSpan remainingDays = targetDate - currentDate;

        return remainingDays;
    }
}