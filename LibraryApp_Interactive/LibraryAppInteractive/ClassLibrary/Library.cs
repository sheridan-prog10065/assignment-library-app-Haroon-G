using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary;

public class Library
{
    /// <summary>
    /// Describes a List of Books
    /// </summary>
    private List<Book> _bookList;
    /// <summary>
    /// Describes varaible for Id generation
    /// </summary>
    private int _libIDGeneratorSeed;
    /// <summary>
    /// Describess the starting int for id's
    /// </summary>
    private const int DEFAULT_LIBD_START = 100;
    
    public Library()
    {
        _bookList = new List<Book>();
        _libIDGeneratorSeed = DEFAULT_LIBD_START;
    }
    /// <summary>
    /// Creates a set of default books for the library
    /// </summary>
    private void CreateDefaultBooks()
    {

    }
    /// <summary>
    /// Determines ID for a book
    /// </summary>
    /// <returns></returns>
    private int DetermineLibID()
    {
        int libId = DEFAULT_LIBD_START + 1;
        return libId;
    }
    /// <summary>
    /// Registers a new book
    /// </summary>
    /// <param name="bookName"></param>
    /// <param name="bookISBN"></param>
    /// <param name="authors"></param>
    /// <param name="booktype"></param>
    /// <param name="nCopies"></param>
    /// <returns></returns>
    public Book RegisterBookName(string bookName, string bookISBN, string[] authors, BookType booktype, int nCopies)
    {
        Book book = new Book(bookName, bookISBN);
        _bookList.Add(book);

        return book;
    }
    /// <summary>
    /// Finds a book by searching with bookname
    /// </summary>
    /// <param name="bookName"></param>
    /// <returns></returns>
    public Book FindBookByName(string bookName)
    {
        foreach (Book book  in _bookList)
        {
            if (book.Name == bookName)
            {
                return book;
            }
        }
        return null;
    }
    /// <summary>
    /// Finds a book by searching with bookISBN
    /// </summary>
    /// <param name="bookISBN"></param>
    /// <returns></returns>
    public Book FindBookByISBN(string bookISBN)
    {
        foreach (Book book in _bookList)
        {
            if (book.ISBN == bookISBN)
            {
                return book;
            }
        }
        return null;
    }
}
