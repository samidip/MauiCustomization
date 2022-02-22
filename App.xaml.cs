namespace MauiCustomization;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Microsoft.Maui.Handlers.EntryHandler.EntryMapper.AppendToMapping(nameof(IView.Background), (handler, view) =>
        {   
#if __IOS__
                handler.NativeView.BackgroundColor = UIKit.UIColor.Green;
				handler.NativeView.BorderStyle = UIKit.UITextBorderStyle.Line;
#endif   
        });

		MainPage = new MainPage();
	}
}
