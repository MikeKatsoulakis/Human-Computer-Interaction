using System.Windows.Controls;
using Wpf.Ui.Common.Interfaces;

namespace HumanComputerInteraction.DesktopUI.Views.Pages;

public partial class ShoppingListPage : INavigableView<ViewModels.ShoppingListViewModel>
{
    public ViewModels.ShoppingListViewModel ViewModel
    {
        get;
    }

    public ShoppingListPage(ViewModels.ShoppingListViewModel viewModel)
    {
        ViewModel = viewModel;

        InitializeComponent();
    }
}
