using Wpf.Ui.Common.Interfaces;

namespace HumanComputerInteraction.DesktopUI.Views.Pages;

public partial class ToDoListPage : INavigableView<ViewModels.ToDoListViewModel>
{
    public ViewModels.ToDoListViewModel ViewModel
    {
        get;
    }
    public ToDoListPage(ViewModels.ToDoListViewModel viewModel)
    {
        ViewModel = viewModel;

        InitializeComponent();
    }
}
