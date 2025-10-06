using Week3_Library;
class Program
{
    static void Main(string[] args)
    {
        //Create a new instance (object) of the Book class
        //Note how the object name differs from the class name

        Book book = new Book("C# for Beginners", "Bill Gates", "12345678");

        //Output the book information to the console
        book.DisplayInfo();
    }
}