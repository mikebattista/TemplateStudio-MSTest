using System.Collections.ObjectModel;

using App5.Contracts.ViewModels;
using App5.Core.Contracts.Services;
using App5.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;

namespace App5.ViewModels;

public class ListDetailsViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;
    private SampleOrder? _selected;

    public SampleOrder? Selected
    {
        get => _selected;
        set => SetProperty(ref _selected, value);
    }

    public ObservableCollection<SampleOrder> SampleItems { get; private set; } = new ObservableCollection<SampleOrder>();

    public ListDetailsViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        SampleItems.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetListDetailsDataAsync();

        foreach (var item in data)
        {
            SampleItems.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }

    public void EnsureItemSelected()
    {
        if (Selected == null)
        {
            Selected = SampleItems.First();
        }
    }
}
