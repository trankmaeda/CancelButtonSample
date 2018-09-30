using System.Collections.ObjectModel;

using CancelButtonSample.Models;
using CancelButtonSample.Services;

using Prism.Windows.Mvvm;

namespace CancelButtonSample.ViewModels
{
    public class DataGridViewModel : ViewModelBase
    {
        private readonly ISampleDataService _sampleDataService;

        public DataGridViewModel(ISampleDataService sampleDataServiceInstance)
        {
            _sampleDataService = sampleDataServiceInstance;
        }

        public ObservableCollection<SampleOrder> Source => _sampleDataService.GetGridSampleData();
    }
}
