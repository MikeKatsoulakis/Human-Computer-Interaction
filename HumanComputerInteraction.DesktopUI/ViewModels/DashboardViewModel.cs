using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Wpf.Ui.Common.Interfaces;

namespace HumanComputerInteraction.DesktopUI.ViewModels;
public partial class DashboardViewModel : ObservableObject, INavigationAware
{
    [ObservableProperty]
    private string _testString = "Starting Value";

    [ObservableProperty]
    private string _testString2 = "Starting Value";

    [ObservableProperty]
    private string _phoneString = "";


    public ObservableCollection<Contact> TestList { get; set; } = new();


    [RelayCommand]
    private void Test()
    {

    }

    [RelayCommand]
    private void Key()
    {

    }








    public void OnNavigatedTo()
    {
    }

    public void OnNavigatedFrom()
    {
    }
}

public class Contact
{
    public string Name { get; set; }
    public string PhoneNo { get; set; }
}
