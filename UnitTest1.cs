using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestAutomation
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/Account/Login");
            driver.Manage().Window.Maximize();

            var txtUserName = driver.FindElement(By.Name("UserName"));

            txtUserName.SendKeys("admin");

            var txtPassWord = driver.FindElement(By.Name("Password"));

            txtPassWord.SendKeys("password");

            IWebElement loginBtn = driver.FindElement(By.ClassName("btn"));

            loginBtn.Submit();
        }
    }
}