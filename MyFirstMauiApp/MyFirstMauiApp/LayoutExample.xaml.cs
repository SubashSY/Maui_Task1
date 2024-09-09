namespace MyFirstMauiApp;

public partial class LayoutExample : ContentPage
{
    public const double FontSize =18;
    public LayoutExample()
	{
		InitializeComponent();
        VStackLayout.Padding = DeviceInfo.Platform == DevicePlatform.iOS
            ? new Thickness(30, 10, 30, 10) : new Thickness(25);

    }

}
public class GlobalFontSizeExtension : IMarkupExtension
{
    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return LayoutExample.FontSize;
    }
}