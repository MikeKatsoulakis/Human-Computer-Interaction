using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
    private string _shoppingName = "Poutses";

    [RelayCommand]
    public void UpdateShoppingList()
    {
        ShoppingName = "Traveli";
    }
}
