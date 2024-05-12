namespace task2;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити статичний клас FindAndReplaceManager з методом void FindNext(string str)
 * для пошуку за книгою з прикладу уроку 005_Book. При виклику цього методу проводиться
 * послідовний пошук рядка в книзі.
 */
public static class FindAndReplaceManager
{
    private static string bookPath = "text.txt";

    public static void FindNext(string str)
    {
        try
        {
            StreamReader file = new StreamReader(bookPath);
            int lineNumber = 0;
            string line;
            bool serch = false;
            
            while ((line = file.ReadLine()) != null)
            {
                lineNumber++;
                if (line.Contains(str))
                {
                    Console.WriteLine($"Знайдено {str}  на рядку  {lineNumber}: {line}");
                    serch = false;
                }
            }
            if (serch!)
            {
                Console.WriteLine("Нічого незнайдено...");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }   
    }
    
}