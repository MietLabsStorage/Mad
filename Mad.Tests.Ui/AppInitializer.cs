using Xamarin.UITest;

namespace Mad.Tests.Ui
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                   .Android
                   .InstalledApp("com.companyname.mad")
                   .PreferIdeSettings()
                   .EnableLocalScreenshots()
                   .StartApp();
            }
            return ConfigureApp
               .iOS
               .StartApp();
        }
    }
}
