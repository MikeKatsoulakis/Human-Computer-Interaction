using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using Wpf.Ui.Common.Interfaces;

namespace HumanComputerInteraction.DesktopUI.ViewModels;
public partial class ShoppingListViewModel : ObservableObject, INavigationAware
{
    public void OnNavigatedFrom()
    {

    }

    public void OnNavigatedTo()
    {

    }
    [ObservableProperty]
    private string _itemName = " ";
    [ObservableProperty]
    private string _itemCount = "1";

    public ObservableCollection<ShoppingList> ShoppingLists { get; set; } = new();

    [RelayCommand]
    private void Key()
    {

    }

    [RelayCommand]
    private void Add()
    {

    }


}

public class ShoppingList
{
    public string ItemName { get; set; }
    public string ItemCount { get; set; } 
}
