using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using PocketDecisionMaker.App.Models.HomePage;

namespace PocketDecisionMaker.App.ViewModels;

// MainViewModel with ObservableObject
public partial class MainViewModel : ObservableObject
{
    // Observable collection for options
    public ObservableCollection<Option> Options { get; } = new ObservableCollection<Option>
    {
        new Option { Name = "Toss", Value1 = "Head", Value2 = "Tail" },
        new Option { Name = "Food", Value1 = "Burger", Value2 = "Pizza" }
    };

    // Selected option
    [ObservableProperty]
    private Option? selectedOption;
}