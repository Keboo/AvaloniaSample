using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaSample.ViewModels;

public partial class MainViewModel : ObservableObject
{
    public string Greeting => "Hello, World!";


    public CounterViewModel Counter { get; } = new();

    public NameViewModel Name { get; } = new();
}
