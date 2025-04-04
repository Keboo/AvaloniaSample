using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaSample.ViewModels;

public partial class CounterViewModel : ObservableObject
{
    [ObservableProperty]
    private decimal _counter;

    partial void OnCounterChanged(decimal value)
    {
        IsCloseToFour = true;
    }

    [ObservableProperty]
    private bool _isCloseToFour;

    [RelayCommand]
    public void Increment() => Counter++;
}
