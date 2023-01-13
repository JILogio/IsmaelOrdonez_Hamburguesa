using IsmaelOrdonez_Hamburguesa.Views;

namespace IsmaelOrdonez_Hamburguesa;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("Burger", typeof(BurgerItemPage));
        Routing.RegisterRoute("Main", typeof(MainPage));
    }
}
