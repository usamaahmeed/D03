namespace Task3
{
    class Book
    {
        public string title;
        public string author;
        public string isbn;
        public bool isAvailable;

        public Book(string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.isAvailable = true;
        }
        public string Gettitle()
        {
            return title;
        }
        public string Getauthor()
        {
            return author;
        }
        public string Getisbn()
        {
            return isbn;
        }
        public bool GetisAvailable()
        {
            return isAvailable;
        }
        public void Settitle(string title)
        {
            this.title = title;
        }
        public void Setauthor(string author)
        {
            this.author = author;
        }
        public void Setisbn(string isbn)
        {
            this.isbn = isbn;
        }
        public void SetisAvailable(bool isAvailable)
        {
            this.isAvailable = isAvailable;
        }

    }
    class Library
    {
        public List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void SearchBook(string title)
        {
            for(int i = 0; i < books.Count; i++)
            {
                if (books[i].title.Contains(title))
                {
                    Console.WriteLine("Book found!");
                    return ;
                }
            }
            Console.WriteLine("Book not found!");
        }

        public void BorrowBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title.Contains(title))
                {
                    if (books[i].isAvailable == true)
                    {
                        books[i].isAvailable = false;
                        Console.WriteLine("Book borrowed!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Book not available!");
                        return;
                    }
                }
               
            }
            Console.WriteLine("Book not found!");
        }
        public void ReturnBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title.Contains(title))
                {
                    if (books[i].isAvailable == false)
                    {
                        books[i].isAvailable = true;
                        Console.WriteLine("Book returned!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Book already available!");
                        return;
                    }
                }
                
            }
            Console.WriteLine("Book not found!");
        }
        public void DisplayBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine("Title: " + book.Gettitle());
                Console.WriteLine("Author: " + book.Getauthor());
                Console.WriteLine("ISBN: " + book.Getisbn());
                Console.WriteLine("Available: " + book.GetisAvailable());
                Console.WriteLine();
            }
        }
    }

    internal class Program
        {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books to the library
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            // Searching and borrowing books
            Console.WriteLine("Searching and borrowing books...");
            library.SearchBook("1984");
            library.SearchBook("Harry Potter"); // This book is not in the library
            library.BorrowBook("Gatsby");
            library.BorrowBook("1984");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter"); // This book is not in the library

            // Returning books
            Console.WriteLine("\nReturning books...");
            library.ReturnBook("1984");
            library.ReturnBook("1984");
            library.ReturnBook("Harry Potter"); // This book is not borrowed
            //display books

            Console.ReadLine();
        }
    }
   }
