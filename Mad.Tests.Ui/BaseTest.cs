using Xamarin.UITest;

namespace Mad.Tests.Ui
{
    [TestFixture(Platform.Android)]
    public class BaseTest
    {
        IApp _app;
        protected readonly Platform Platform;

        public BaseTest(Platform platform) => Platform = platform;

        protected IApp App => _app ?? throw new NullReferenceException();

        [SetUp]
        public virtual void BeforeEachTest()
        {
            _app = AppInitializer.StartApp(Platform);

            App.Screenshot("App Initialized");
        }
    }
}
