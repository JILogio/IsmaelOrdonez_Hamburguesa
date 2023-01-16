using IsmaelOrdonez_Hamburguesa.Data;
using IsmaelOrdonez_Hamburguesa.Models;
using IsmaelOrdonez_Hamburguesa.Views;
using Microsoft.Maui.ApplicationModel.Communication;
using Microsoft.Maui.Controls;

namespace IsmaelOrdonez_Hamburguesa;

public partial class MainPage : ContentPage
{
    JOBurger selected;
    public MainPage()
    {
        InitializeComponent();
        J_List.ItemsSource = UpdateList();
    }

    private async void JO_Add(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Burger");
    }

    private async void JO_selected(object sender, SelectionChangedEventArgs e)
    {
        selected = e.CurrentSelection[0] as JOBurger;
        await Navigation.PushAsync(new BurgerItemPage
        {
            J_pass = selected,
            BindingContext = selected,
        });
    }

    private static List<JOBurger> UpdateList()
    {
        List<JOBurger> burger = App.BurgerRepo.GetAllBurger();
        return burger;
    }
}
