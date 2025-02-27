//Written by Grace Ofure Agbenin
// Feb 27, 2025


using System;
namespace HomeWork
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }

        // constructors
        public Book(string title, string author, int yearPublished)
        {
            this.Title = title;
            this.Author = author;
            this.YearPublished = yearPublished;
        }

        // methods
        public override string ToString()
        {
            return $"{Title} by {Author} ({YearPublished})";
        }
    }

    // Subclass EBook
    public class EBook : Book
    {
        public double FileSizeMB { get; set; }

        // constructor
        public EBook(string title, string author, int yearPublished, double fileSizeMB) : base(title, author, yearPublished)
        {
            this.FileSizeMB = fileSizeMB;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} ({YearPublished}), File Size: {FileSizeMB} MB";
        }
    }

    // Subclass PrintedBook
    public class PrintedBook : Book
    {
        public int PageCount { get; set; }

        // constructor
        public PrintedBook(string title, string author, int yearPublished, int pageCount) : base(title, author, yearPublished)
        {
            this.PageCount = pageCount;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} ({YearPublished}), Pages: {PageCount}";
        }
    }

}
