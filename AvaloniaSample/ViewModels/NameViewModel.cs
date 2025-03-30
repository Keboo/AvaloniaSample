using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaSample.ViewModels;

public partial class NameViewModel : ObservableObject
{
    [ObservableProperty]
    private string _name = "John Doe";

    [RelayCommand]
    public void ClearName() => Name = "";
}