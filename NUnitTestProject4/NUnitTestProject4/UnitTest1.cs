using NUnit.Framework;
using NUnitTestProjectSeleniumWebDriverAdvanced;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
namespace NUnitTestProjectAnya
{
    public class Tests
    {
        private IWebDriver driver;
        private MainPage MainPage;
        private LoginPage LoginPage;
        protected const string name = "user";
        protected const string password = "user";
        internal AddProductPage AddProduct { get; private set; }
        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
        }
        [Test, Order(1)]
        public void Login()
        {
            LoginPage = new LoginPage(driver);

            //Assert.AreEqual("Home page", driver.FindElement(By.XPath("//div[h2= 'Home page']")).Text);
        }
        [Test, Order(2)]
        public void AddNewProduct()
        {
            MainPage = new MainPage(driver);
            AddProduct = new AddProductPage(driver);
            AddProduct.AddNewProduct();
            Assert.AreEqual("Create new", driver.FindElement(By.XPath("//a[@href='/Product/Create']")).Text);
        }
        [Test, Order(3)]
        public void Logout()
        {
            driver.FindElement(By.XPath("//a[@href='/Account/Logout']")).Click();
            Assert.AreEqual("Login", driver.FindElement(By.XPath("//div[h2=\"Login\"]")).Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Close();
            driver.Quit();
        }
    }
}