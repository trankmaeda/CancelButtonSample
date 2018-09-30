using System;

using CancelButtonSample.ViewModels;

using Windows.UI.Xaml.Controls;

namespace CancelButtonSample.Views
{
    public sealed partial class DataGridPage : Page
    {
        private DataGridViewModel ViewModel => DataContext as DataGridViewModel;

        // TODO WTS: Change the grid as appropriate to your app, adjust the column definitions on DataGridPage.xaml.
        // For more details see the documentation at https://github.com/Microsoft/WindowsCommunityToolkit/blob/master/docs/controls/DataGrid.md
        public DataGridPage()
        {
            InitializeComponent();
        }
    }
}
