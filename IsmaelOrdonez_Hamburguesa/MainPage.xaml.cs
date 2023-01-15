using IsmaelOrdonez_Hamburguesa.Data;
using IsmaelOrdonez_Hamburguesa.Models;
using IsmaelOrdonez_Hamburguesa.Views;
using Microsoft.Maui.ApplicationModel.Communication;
using Microsoft.Maui.Controls;

namespace IsmaelOrdonez_Hamburguesa;

public partial class MainPage : ContentPage
{
    Burger selected;
    public MainPage()
	{
		InitializeComponent();
        J_List.ItemsSource = UpdateList();
    }

	private async void J_Add(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("Burger");
    }

    private void J_selected(object sender, SelectionChangedEventArgs e)
    {
        selected = e.CurrentSelection[0] as Burger;
        var navigation = new Dictionary<string,object>
        {
            {"pass",selected}
        };
        Shell.Current.GoToAsync("Burger",navigation);
    }

    private static List<Burger> UpdateList()
    {
        List<Burger> burger = App.BurgerRepo.GetAllBurger();
        return burger;
    }
}
