using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary;
public class LibraryAssets
{
    /// <summary>
    /// Defined book object
    /// </summary>
    private Book _book;
    /// <summary>
    /// Represents library id
    /// </summary>
    private int _libID;
    /// <summary>
    /// Represents current asset status
    /// </summary>
    private AssetStatus _status;
    /// <summary>
    /// Represents loan period object
    /// </summary>
    private LoanPeriod _loanPeriod;

    public int LibId {  get { return _libID; } set { _libID = value; } }
    public AssetStatus Status { get { return _status; } set { _status = value; } }
    public LoanPeriod LoanPeriod { get { return _loanPeriod; } set { _loanPeriod = value; } }
    public bool IsAvailable { get; set; }

    public LibraryAssets(int libID, Book book)
    {
        _book = book;
        _libID = libID;

        _status = AssetStatus.Available;
        _loanPeriod = new LoanPeriod();
    }
}
