using IsmaelOrdonez_Hamburguesa.Data;
using IsmaelOrdonez_Hamburguesa.Models;
using IsmaelOrdonez_Hamburguesa.Views;

namespace IsmaelOrdonez_Hamburguesa;

public partial class App : Application
{
	public static BurgerDatabase BurgerRepo { get; private set; }

	public App(BurgerDatabase repo)
	{
		InitializeComponent();

        MainPage = new AppShell();

		BurgerRepo = repo;
	}
}
