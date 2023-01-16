using IsmaelOrdonez_Hamburguesa.Data;
using IsmaelOrdonez_Hamburguesa.Models;
using IsmaelOrdonez_Hamburguesa.Views;

namespace IsmaelOrdonez_Hamburguesa;

public partial class App : Application
{
	public static JOBurgerDatabase BurgerRepo { get; private set; }

	public App(JOBurgerDatabase repo)
	{
		InitializeComponent();

        MainPage = new AppShell();

		BurgerRepo = repo;
	}
}
