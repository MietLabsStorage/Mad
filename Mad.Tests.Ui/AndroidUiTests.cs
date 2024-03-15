using Xamarin.UITest;

namespace Mad.Tests.Ui
{
    [TestFixture(Platform.Android)]
    public class AndroidUiTests: BaseTest
    {
        public AndroidUiTests(Platform platform): base(platform) { }

        [Test]
        public void WhenCounterClicked_IncrementCount()
        {
            const string countButton = "CounterBtn";
            App.WaitForElement(countButton);
            App.Tap(countButton);

            var newNoteBtn = "Новая заметка";
            var notesBtn = "Заметки";
            var weatherBtn = "Погода";
            var settingsBtn = "Настройки";

            Assert.DoesNotThrow(() => App.WaitForElement(x => x.Marked(newNoteBtn)), $"Button {newNoteBtn} was not clicked");
            Assert.DoesNotThrow(() => App.WaitForElement(x => x.Marked(notesBtn)), $"Button {notesBtn} was not clicked");
            Assert.DoesNotThrow(() => App.WaitForElement(x => x.Marked(weatherBtn)), $"Button {weatherBtn} was not clicked");
            Assert.DoesNotThrow(() => App.WaitForElement(x => x.Marked(settingsBtn)), $"Button {settingsBtn} was not clicked");

            App.Screenshot("Переход в основное меню, все кнопки на месте");
        }
    }
}
