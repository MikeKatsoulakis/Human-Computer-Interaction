using System.Windows.Controls;
using Wpf.Ui.Common.Interfaces;

namespace HumanComputerInteraction.DesktopUI.Views.Pages;

public partial class ContactsPage : INavigableView<ViewModels.ContactsViewModel>
{
    public ViewModels.ContactsViewModel ViewModel
    {
        get;
    }

    public ContactsPage(ViewModels.ContactsViewModel viewModel)
    {
        ViewModel = viewModel;

        InitializeComponent();
    }
}
