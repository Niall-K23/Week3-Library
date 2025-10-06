class Book
{
    string Title;
    string Author;
    string ISBN;

    //Example of a constructor that allows us to "construct" a new book object
    public Book(string bookTitle, string bookAuthor, string bookISBN)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
    }

    void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //Create a new instance (object) of the Book class
        //Note how the object name differs from the class name

        Book book = new Book("C# for Beginners", "Bill Gates", "12345678");

        //Output the book information to the console
        book.DisplayInfo();
    }
}