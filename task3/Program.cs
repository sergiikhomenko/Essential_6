namespace task3;


class Book
{
    public void FindNext(string str)
    {
        Console.WriteLine("Пошук рядка : " + str);
    }

   public class Notes
    {
        private string _notes;

        public void AddNotes(string textNotes)
        {
            _notes = textNotes;
        }

        public void OutNotes()
        {
            Console.WriteLine($"Нотаток користувача: {_notes}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book.Notes notes = new Book.Notes();
        
        Console.WriteLine("Введіть текст для нотатку");
        notes.AddNotes(Console.ReadLine());
        Console.WriteLine(new string('*',30));
        notes.OutNotes();
    }
}