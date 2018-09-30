using System;

using CancelButtonSample.ViewModels;

using Windows.UI.Xaml.Controls;

namespace CancelButtonSample.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
