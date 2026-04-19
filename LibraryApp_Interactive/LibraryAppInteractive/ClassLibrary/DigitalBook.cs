using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary;

public class DigitalBook : Book
{
    /// <summary>
    /// Defines the maximum borrow days
    /// </summary>
    private int _maxBorrowDays;
    /// <summary>
    /// Defines Late penalty per day
    /// </summary>
    private float _latePenaltyPerDay;

    public DigitalBook(string bookName, string bookISBN) : base(bookName, bookISBN)
    {
        //_maxBorrowDays = 5;
        //_latePenaltyPerDay = 0;
    }
    /// <summary>
    /// Determines loan license for digital books
    /// </summary>
    private void DetermineLoanLicense()
    {

    }
    /// <summary>
    /// Represents method for borrowing digital books
    /// </summary>
    /// <returns></returns>
    public LibraryAssets BorrowBook()
    {

    }
    /// <summary>
    /// Represents method for returning paper books
    /// </summary>
    /// <param name="libID"></param>
    /// <returns></returns>
    public (TimeSpan, decimal) ReturnBook(int libID)
    {

    }
}
