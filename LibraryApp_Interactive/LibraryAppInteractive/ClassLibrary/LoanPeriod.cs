using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary;

public struct LoanPeriod
{
    /// <summary>
    /// Represents date book was borrowed on
    /// </summary>
    private DateTime _borrowedOn;
    /// <summary>
    /// Represents date book was returned on
    /// </summary>
    private DateTime _returnedOn;
    /// <summary>
    /// Represents date book is due
    /// </summary>
    private DateTime _dueDate;

    public DateTime BorrowedOn {  get { return _borrowedOn; }  set { _borrowedOn = value; }}
    public DateTime ReturnedOn { get { return _returnedOn;  } set { _returnedOn = value; }}
    public DateTime DueDate {  get { return _dueDate; } set {_dueDate = value; }}

    public TimeSpan LoanDuration { get; }
    public TimeSpan LatePeriod { get; }

    public LoanPeriod(DateTime borrowedOn, DateTime returnedOn)
    {
        _borrowedOn = borrowedOn;
        _returnedOn = returnedOn;

        //_dueDate
    }
}
