﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.ObjectModel;
using Wpf.Ui.Common;
using Wpf.Ui.Controls;
using Wpf.Ui.Controls.Interfaces;
using Wpf.Ui.Mvvm.Contracts;

namespace HumanComputerInteraction.DesktopUI.ViewModels;
public partial class MainWindowViewModel : ObservableObject
{
    private bool _isInitialized = false;

    [ObservableProperty]
    private string _applicationTitle = String.Empty;

    [ObservableProperty]
    private ObservableCollection<INavigationControl> _navigationItems = new();

    [ObservableProperty]
    private ObservableCollection<INavigationControl> _navigationFooter = new();

    [ObservableProperty]
    private ObservableCollection<MenuItem> _trayMenuItems = new();

    public MainWindowViewModel(INavigationService navigationService)
    {
        if (!_isInitialized)
            InitializeViewModel();
    }

    private void InitializeViewModel()
    {
        ApplicationTitle = "Human-Computer Interaction";

        NavigationItems = new ObservableCollection<INavigationControl>
        {
            new NavigationItem()
            {
                Content = "Home",
                PageTag = "dashboard",
                Icon = SymbolRegular.Home24,
                PageType = typeof(Views.Pages.DashboardPage)
            },
            new NavigationItem()
            {
                Content = "Shopping List",
                PageTag = "shoppingList",
                Icon = SymbolRegular.Cart24,
                PageType = typeof(Views.Pages.ShoppingListPage)
            },
            new NavigationItem()
            {
                Content = "Contacts List",
                PageTag = "contacts",
                Icon = SymbolRegular.ContactCard24,
                PageType = typeof(Views.Pages.ContactsPage)
            },
            new NavigationItem()
            {
                Content = "ToDo List",
                PageTag = "todoList",
                Icon = SymbolRegular.TaskListLtr24,
                PageType = typeof(Views.Pages.ToDoListPage)
            }
        };

        NavigationFooter = new ObservableCollection<INavigationControl>
        {
            new NavigationItem()
            {
                Content = "Settings",
                PageTag = "settings",
                Icon = SymbolRegular.Settings24,
                PageType = typeof(Views.Pages.SettingsPage)
            }
        };

        TrayMenuItems = new ObservableCollection<MenuItem>
        {
            new MenuItem
            {
                Header = "Home",
                Tag = "tray_home"
            }
        };

        _isInitialized = true;
    }
}
