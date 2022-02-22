using Microsoft.Maui.Controls.Compatibility;

namespace MauiCustomization;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
// #if __IOS__
//             .ConfigureMauiHandlers(handlers =>
//                 {
//                     handlers.AddCompatibilityRenderer(typeof(Microsoft.Maui.Controls.Entry),
//                         typeof(Microsoft.Maui.Controls.Compatibility.Platform.iOS.EntryRenderer));
//                 })
// #endif   
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});



		return builder.Build();
	}
}
