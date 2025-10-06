namespace Week3_Library
{
    class Book
    {
        private string title; //variable
        private string author; //variable
        private string isbn; //variable

        //Title property to allow access to the private Title variable
        public string Title
        {
            get { return title; } //get method
            set { title = value; } //set method
        }
        public string Author
            {
            get { return author; } //get method
            set { author = value; } //set method
        }
        public string Isbn
        {
            get { return isbn; } //get method
            set { isbn = value; } //set method
        }

        //Example of a constructor that allows us to "construct" a new book object
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.title = bookTitle;
            this.author = bookAuthor;
            this.isbn = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"ISBN: {isbn}");
            Console.WriteLine();
        }
    }
}
