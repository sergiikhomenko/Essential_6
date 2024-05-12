namespace task6;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити статичний клас Calculator, з методами виконання основних
 * арифметичних операцій. Написати програму, яка виводить на екран основні арифметичні операції.
 */
public static class Calculator
{
    public static double Plass(double a, double b)
    {
        return a + b;
    }

    public static double Minus(double a, double b)
    {
        return a - b;
    }

    public static double Multiplication(double a, double b)
    {
        return a * b;
    }

    public static double Division(double a, double b)
    {
        double devision = 0;
        if (b!=0)
        {
            devision = a / b;
        }
        else
        {
            Console.WriteLine("Ділення на 0 неможливе");
        }
        return devision;
    }
}