using Mad.Database;
using Mad.Pages.EditNote;
using Mad.Pages.NotesList;
using Mad.Pages.Settings;
using Mad.Pages.Weather;
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

		var builded = builder.Build();

		//builded.Services.GetRequiredService<DatabaseContext>().Database.Migrate();

		return builded;
	}

    public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddDbContext<DatabaseContext>();
		return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddScoped<EditNoteViewModel>();
        mauiAppBuilder.Services.AddScoped<SettingsViewModel>();
        mauiAppBuilder.Services.AddScoped<WeatherViewModel>();
        mauiAppBuilder.Services.AddScoped<NotesListViewModel>();
        return mauiAppBuilder;
    }
}

