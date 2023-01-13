using IsmaelOrdonez_Hamburguesa.Data;

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
