namespace task4;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: створити розширюючий метод для цілого масиву, який сортує елементи масиву за зростанням. 
 */


class Program
{
    static void Main(string[] args)
    {
        int[] arrey = new int[6];
        Random rd = new Random();
        for (int i = 0; i < arrey.Length; i++)
        {
            arrey[i] = rd.Next(1, 100);
            Console.Write($" {arrey[i]}");
        }

        Console.WriteLine();
        arrey.Sort();
        Console.WriteLine(new string('*',40));
        for (int i = 0; i < arrey.Length; i++)
        {
            Console.Write($" {arrey[i]}");
        }
    }

    
}