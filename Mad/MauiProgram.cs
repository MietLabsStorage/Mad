using Mad.Database;
using Mad.Pages.EditNote;
using Mad.Services;
using Mad.Shared;
using Microsoft.Extensions.Logging;

namespace Mad;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		Paths.Init();

		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<SettingsService>();
        builder.RegisterAppServices();
		builder.RegisterViewModels();

		return builder.Build();
	}

    public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddDbContext<DatabaseContext>();
		return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddScoped<EditNoteViewModel>();
        return mauiAppBuilder;
    }
}

