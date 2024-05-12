namespace task6;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити статичний клас Calculator, з методами виконання основних
 * арифметичних операцій. Написати програму, яка виводить на екран основні арифметичні операції.
 */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть перше число");
        Double.TryParse(Console.ReadLine(), out double a);
        
        Console.WriteLine("Введіть друге число");
        Double.TryParse(Console.ReadLine(), out double b);
        
        Console.WriteLine($"Сума введених чисел  {Calculator.Plass(a,b)}");
        Console.WriteLine($"Різниця введених чисел {Calculator.Minus(a,b)}");
        Console.WriteLine($"Добуток введених чисел {Calculator.Multiplication(a,b)}");
        Console.WriteLine($"Частка введених чисел {Calculator.Division(a,b)}");
    }
}