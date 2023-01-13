using IsmaelOrdonez_Hamburguesa.Models;

namespace IsmaelOrdonez_Hamburguesa;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

        List<Burger> burger = App.BurgerRepo.GetAllBurger();
        J_List.ItemsSource = burger;
    }

	private void Button_Clicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("Burger");
    }
}
