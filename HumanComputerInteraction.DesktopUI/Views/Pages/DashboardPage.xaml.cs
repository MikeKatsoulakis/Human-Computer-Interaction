using HumanComputerInteraction.DesktopUI.ViewModels;
using System.Windows;
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

    private void TextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
    {
        var key = e.Key;

        if (key == System.Windows.Input.Key.Enter)
        {
            var contact = new Contact { Name = TextBox1.Text, PhoneNo = TextBox2.Text };

            //23153425325sdfsf34

            if (contact.Name != "" &&
                contact.PhoneNo != "" &&
                int.TryParse(contact.PhoneNo, out _))
            {
                ViewModel.TestList.Add(contact);
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Aderfe trollares");
            }
        }
    }
}