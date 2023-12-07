// Делегат для представлення функцій одного змінного, який повертає значення типу double
public delegate double FunctionDelegate(double x);

// Клас для обчислення визначеного інтегралу методом правих прямокутників
public class RightRectangleIntegralCalculator
{
    // Подія, яка викликається після успішного обчислення інтегралу
    public event EventHandler<string> CalculationCompleted;

    // Метод для обчислення визначеного інтегралу методом правих прямокутників
    public double CalculateIntegral(FunctionDelegate function, double a, double b, int n)
    {
        // Визначення ширини кожного прямокутника
        double h = (b - a) / n;
        double result = 0.0;

        // Цикл для сумування значень функції на правих границях прямокутників
        for (int i = 1; i <= n; i++)
        {
            double x = a + i * h;
            result += function(x);
        }

        // Помноження суми на ширину прямокутника
        result *= h;

        // Виклик події для повідомлення про успішне обчислення
        OnCalculationCompleted($"Integral calculated successfully: {result}");

        return result;
    }

    // Віртуальний метод для виклику події при завершенні обчислення інтегралу
    protected virtual void OnCalculationCompleted(string message)
    {
        CalculationCompleted?.Invoke(this, message);
    }
}

class Program
{
    static void Main()
    {
        // Приклад використання класу RightRectangleIntegralCalculator

        // Функція, яку будемо інтегрувати
        FunctionDelegate function = x => x * x;

        // Визначення меж інтегрування та кількості прямокутників
        double a = 0.0;
        double b = 1.0;
        int n = 100;

        // Створення об'єкта класу RightRectangleIntegralCalculator
        RightRectangleIntegralCalculator calculator = new RightRectangleIntegralCalculator();

        // Підписка на подію CalculationCompleted
        calculator.CalculationCompleted += (sender, message) =>
        {
            Console.WriteLine(message);
        };

        // Виклик методу для обчислення інтегралу
        double result = calculator.CalculateIntegral(function, a, b, n);

        Console.WriteLine($"Result: {result}");
    }
}