using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace AuthomanizationYandexPageTests
{
    public class Tests
    {
        private IWebDriver driver;

        private readonly By signInButton = By.XPath("//a[@class='control button2 button2_view_classic button2_size_mail-big " +
            "button2_theme_mail-white button2_type_link HeadBanner-Button HeadBanner-Button-Enter with-shadow']");
        private readonly By loginInputButton = By.XPath("//input[@name='login']");
        private readonly By enterButton = By.XPath("//button[@id='passp:sign-in']");
        private readonly By passInputButton = By.XPath("//input[@id='passp-field-passwd']");
        private readonly By inButton = By.XPath("//button[@id='passp:sign-in']");
        private readonly By clickLkButton = By.XPath("//img[@class='user-pic__image']");
        private readonly By controlkButton = By.XPath("//span[text()='Управление аккаунтом']");
        private readonly By writeButton = By.XPath("//span[text()='Написать письмо']");
        private readonly By fromButton = By.XPath("//div[@class='composeYabbles']");
        private readonly By themeButton = By.XPath("//input[@name='subject']");
        private readonly By letterButton = By.XPath("//div[@class='cke_wysiwyg_div cke_reset cke_enable_context_menu " +
            "cke_editable cke_editable_themed cke_contents_ltr cke_htmlplaceholder']");
        private readonly By sendButton = By.XPath("//button[@class='Button2 Button2_pin_circle-circle Button2_view_default Button2_size_l']");

        private const string email = "stringtest0@yandex.ru";
        private const string password = "ckbirjvghjcnjq1";
        private const string contact = "string0@yandex.ru";
        private const string themeLetter = "Тестирование отправки письма";
        private const string textLetter = "Доброго времени суток.";

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://mail.yandex.ru/");
            Thread.Sleep(800);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void SendingLetter()
        {
            var signIn = driver.FindElement(signInButton);
            signIn.Click();            Thread.Sleep(2800);
            var loginInput = driver.FindElement(loginInputButton);
            loginInput.SendKeys(email);            Thread.Sleep(2800);
            var enterB = driver.FindElement(enterButton);
            enterB.Click();            Thread.Sleep(400);
            var passB = driver.FindElement(passInputButton);
            passB.SendKeys(password);            Thread.Sleep(400);
            var inB = driver.FindElement(inButton);
            inB.Click();            Thread.Sleep(2800);
            var clickLk = driver.FindElement(clickLkButton);            Thread.Sleep(1800);
            clickLk.Click();            Thread.Sleep(1800);
            var controlCl = driver.FindElement(controlkButton);
            controlCl.Click();            Thread.Sleep(1800);
            var clickLk1 = driver.FindElement(clickLkButton);            Thread.Sleep(1800);
            clickLk1.Click();            Thread.Sleep(1800);
            var writeB = driver.FindElement(writeButton);            Thread.Sleep(1800);
            writeB.Click();            Thread.Sleep(1800);
            var contactB = driver.FindElement(fromButton);
            contactB.SendKeys(contact);            Thread.Sleep(800);
            var themeLetterB = driver.FindElement(themeButton);
            themeLetterB.SendKeys(themeLetter);            Thread.Sleep(800);
            var letterButtonB = driver.FindElement(letterButton);
            letterButtonB.SendKeys(textLetter);            Thread.Sleep(800);
            var sendB = driver.FindElement(sendButton);
            sendB.Click();            Thread.Sleep(800);
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}