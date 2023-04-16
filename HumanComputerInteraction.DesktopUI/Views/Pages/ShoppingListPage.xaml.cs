using HumanComputerInteraction.DesktopUI.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
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

    private void TextBox_KeyUp(object render, System.Windows.Input.KeyEventArgs e)
    {
        var key = e.Key;

        if (key == System.Windows.Input.Key.Enter)
        {
            var shoppingList = new ShoppingList { ItemName = ItemName.Text, ItemCount = ItemCount.Text };
            if (!String.IsNullOrWhiteSpace(shoppingList.ItemName))
            {
                ViewModel.ShoppingLists.Add(shoppingList);
                ItemName.Text = "";
                ItemCount.Text = "1";
            }
            else
            {
                MessageBox.Show("Should Add an Item");
            }
        }
        
    }


    private void Save_Item(object sender, RoutedEventArgs e)
    {
        var shoppingList = new ShoppingList { ItemName = ItemName.Text, ItemCount = ItemCount.Text };
        if (!String.IsNullOrWhiteSpace(shoppingList.ItemName))
        {
            ViewModel.ShoppingLists.Add(shoppingList);
            ItemName.Text = "";
            ItemCount.Text = "1";
        }
        else
        {
            MessageBox.Show("Should Add an Item");
        }

    }

    private void DeleteButton_Click(object sender, RoutedEventArgs e)
    {
        ViewModel.ShoppingLists.RemoveAt(ViewModel.ItemName.IndexOf(ViewModel.ItemName));

    }

    private void btnEdit_Click(object sender, RoutedEventArgs e)
    {
    }
}
