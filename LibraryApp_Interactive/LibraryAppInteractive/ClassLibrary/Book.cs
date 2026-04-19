using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary;

public class Book
{
    /// <summary>
    /// Defines book name
    /// </summary>
    private string _bookName;
    /// <summary>
    /// Defines book ISBN
    /// </summary>
    private string _bookISBN;
    /// <summary>
    /// Defines a list of book authors
    /// </summary>
    private List<string> _bookAuthorList;
    /// <summary>
    /// represents a list of library assets
    /// </summary>
    private List<LibraryAssets> _libAssetList;

    public string Name {  get { return _bookName; } set { _bookName = value; } }
    public string ISBN { get { return _bookISBN; } set { _bookISBN = value; } }
    public List<string> Authors { get { return _bookAuthorList; } set { _bookAuthorList = value; }  }

    public IEnumerable<LibraryAssets> Assets { get { return _libAssetList; } }
    public Book(string bookName, string bookISBN)
    {
        _bookName = bookName;
        _bookISBN=bookISBN;

        _bookAuthorList=new List<string>();
        _libAssetList=new List<LibraryAssets>();
    }
    /// <summary>
    /// Checks if book is currently available
    /// </summary>
    /// <param name="LibraryAsset"></param>
    public void CheckAvailabilty(bool LibraryAsset)
    {

    }
   
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    //public LibraryAssets BorrowBook()
    //{
        
    //}

    //public (TimeSpan, int, decimal) ReturnBook (int libID)
    //{

    //}
    /// <summary>
    /// Reserves
    /// </summary>
    /// <returns></returns>
    //public LibraryAssets ReserveBook()
    //{

    //}
    /// <summary>
    /// Locates Library Asset utilizing libID
    /// </summary>
    /// <param name="libID"></param>
    /// <returns></returns>
    //private LibraryAssets findLibraryAsset(int libID)
    //{
    
    //}
    /// <summary>
    /// Finds next available asset
    /// </summary>
    /// <returns></returns>
    //private LibraryAssets findNextAvailableAsset()
    //{

    //}
}
