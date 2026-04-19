using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary;

public class PaperBook : Book
{
    /// <summary>
    /// Represent maximum borrow days
    /// </summary>
    private const int MAX_BORROW_DAYS = 30;
    /// <summary>
    /// Represents late penalty per day
    /// </summary>
    private const float LATE_PENALTY_PER_DAY = 0.25f;
    public PaperBook(string name, string bookISBN) : base(name, bookISBN)
    {

    }
    /// <summary>
    /// Represents method for borrowing paper books
    /// </summary>
    /// <returns></returns>
    //public LibraryAssets BorrowBook()
    //{

    //}
    /// <summary>
    /// Represents method for returning paper books
    /// </summary>
    /// <param name="libID"></param>
    /// <returns></returns>
    //public (TimeSpan, decimal) ReturnBook(int libID)
    //{

    //}

}
