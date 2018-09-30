using System;

using CancelButtonSample.ViewModels;

using Windows.UI.Xaml.Controls;

namespace CancelButtonSample.Views
{
    public sealed partial class TabbedPage : Page
    {
        private TabbedViewModel ViewModel => DataContext as TabbedViewModel;

        public TabbedPage()
        {
            InitializeComponent();
        }
    }
}
