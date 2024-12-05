using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        private WebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public void TestDangki()
        {
            driver.Navigate().GoToUrl("https://vitimex.com.vn/");
            driver.FindElement(By.CssSelector(".active .img-pc")).Click();
            driver.FindElement(By.CssSelector("a:nth-child(1) > svg:nth-child(1) > path")).Click();
            driver.FindElement(By.CssSelector(".regis-forgot > a:nth-child(1)")).Click();
            driver.FindElement(By.Id("name")).SendKeys("haha");
            driver.FindElement(By.Id("phone")).SendKeys("7896543678");
            driver.FindElement(By.Id("email")).SendKeys("ha@gmail.com");
            driver.FindElement(By.Id("pass-regis")).SendKeys("haha123");
            driver.FindElement(By.Id("pass-confirm")).SendKeys("haha123");
            driver.FindElement(By.CssSelector("register-btn")).Click();
            driver.Quit();



        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}