using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace LibraryAppInteractive;

public partial class LibraryAdminPage : ContentPage
{
    private Library _library;
    public LibraryAdminPage()
    {        
        InitializeComponent();
        _library = new Library();
    }

    private void OnRegisterBook(object sender, EventArgs e)
    {
        if (_chckBoxDigitalBook.IsChecked == true && _chckBoxPaperBook.IsChecked == true)
        {
            DisplayAlertAsync("Alert!", "Please check only one book type", "OK");
            return;
        }

        if (_chckBoxDigitalBook.IsChecked == true)
        {
            _library.RegisterBookName(
                _entryBookName.Text,
                "123",
                new string[] { "Author" },
                BookType.Digital,
                1
            );
        }
        else if (_chckBoxPaperBook.IsChecked == true)
        {
            _library.RegisterBookName(
                _entryBookName.Text,
                "123",
                new string[] { "Author" },
                BookType.Paper,
                1
            );
        }
    }

    private void OnDisplayBookAssets(object sender, EventArgs e)
    {

    }
}