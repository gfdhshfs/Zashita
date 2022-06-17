using System.Windows;
using Library.Service;
using Library.UI.LibrarianWindows;
using Library.UI.ReaderWindows;

namespace Library.UI
{
    public partial class MainWindow : Window
    {
        private IsbnService _isbnService = new IsbnService();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoToLibrarianSignInWindow_OnClick(object sender, RoutedEventArgs e)
        {
            var librarianSignInWindow = new LibrarianSignInWindow();
            librarianSignInWindow.ShowDialog();
            if (librarianSignInWindow.DialogResult == true)
            {
                new LibrariansOffice().ShowDialog();
            }
        }

        private void GoToReaderSignInWindow_OnClick(object sender, RoutedEventArgs e)
        {
            var readerSignInWindow = new ReaderSignInWindow();
            readerSignInWindow.ShowDialog();
            if (readerSignInWindow.DialogResult == true)
            {
                new ReadersOfficeWindow().ShowDialog();
            }

        }

        private void GoToLibrariansOfficeWindow_OnClick(object sender, RoutedEventArgs e)
        {
            new LibrariansOffice().ShowDialog();
        }

        private void GoToReaderOfficeWindow_OnClick(object sender, RoutedEventArgs e)
        {
            new ReadersOfficeWindow().ShowDialog();
        }
    }
}