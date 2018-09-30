using System;

using CancelButtonSample.ViewModels;

using Windows.UI.Xaml.Controls;

namespace CancelButtonSample.Views
{
    public sealed partial class MasterDetailPage : Page
    {
        private MasterDetailViewModel ViewModel => DataContext as MasterDetailViewModel;

        public MasterDetailPage()
        {
            InitializeComponent();
        }
    }
}
