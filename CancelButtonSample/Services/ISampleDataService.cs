﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using CancelButtonSample.Models;

namespace CancelButtonSample.Services
{
    // This interface specifies methods used by some generated pages to show how they can be used.
    // TODO WTS: Delete this file once your app is using real data.
    public interface ISampleDataService
    {
        ObservableCollection<SampleOrder> GetGridSampleData();

        Task<IEnumerable<SampleOrder>> GetSampleModelDataAsync();
    }
}
