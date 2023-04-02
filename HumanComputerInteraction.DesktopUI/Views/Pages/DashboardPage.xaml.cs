using Wpf.Ui.Common.Interfaces;

namespace HumanComputerInteraction.DesktopUI.Views.Pages;

public partial class DashboardPage : INavigableView<ViewModels.DashboardViewModel>
{
    public ViewModels.DashboardViewModel ViewModel
    {
        get;
    }

    public DashboardPage(ViewModels.DashboardViewModel viewModel)
    {
        ViewModel = viewModel;

        InitializeComponent();
    }
}