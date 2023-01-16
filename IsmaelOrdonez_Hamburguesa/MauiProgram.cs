using IsmaelOrdonez_Hamburguesa.Data;
using IsmaelOrdonez_Hamburguesa.Views;

namespace IsmaelOrdonez_Hamburguesa;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        string dbPath = FileAccessHelper.GetLocalFilePath("burger.db3");
        builder.Services.AddSingleton<JOBurgerDatabase>(s => ActivatorUtilities.CreateInstance<JOBurgerDatabase>(s, dbPath));

        return builder.Build();
    }
}
