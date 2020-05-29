using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
namespace NUnitTestProjectSeleniumWebDriverAdvanced
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement searchInputName => driver.FindElement(By.XPath("//input[@id='Name']"));
        private IWebElement searchInputPassword => driver.FindElement(By.XPath("//input[@id='Password']"));
        private IWebElement searchClick => driver.FindElement(By.XPath("//input[@class='btn btn-default']"));

        public void LoginMetod(string Name, string Password)
        {
            new Actions(driver).SendKeys(Name).Build().Perform();
            new Actions(driver).SendKeys(Password).Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
        }

        private IWebElement searchHome_page => driver.FindElement(By.XPath("//div[h2='Home page']//preceding::a[@href ='/Product']"));
        private IWebElement searchCreateNew => driver.FindElement(By.XPath("//a[@class = 'btn btn-default']"));
        private IWebElement searchProductName => driver.FindElement(By.XPath("//a[@class = 'btn btn-default']"));
        private IWebElement searchCategoryId => driver.FindElement(By.XPath("//select[@id= 'CategoryId']/child::option[@value = '7']"));
        private IWebElement searchSupplierId => driver.FindElement(By.XPath("//select[@id= 'SupplierId']/child::option[@value = '5']"));
        private IWebElement searchUnitPrice => driver.FindElement(By.XPath("//input[@id = 'UnitPrice']"));
        private IWebElement searchQuantityPerUnit => driver.FindElement(By.XPath("//input[@id = 'QuantityPerUnit']"));
        private IWebElement searchUnitsInStock => driver.FindElement(By.XPath("//input[@id = 'UnitsInStock']"));
        private IWebElement searchUnitsOnOrder => driver.FindElement(By.XPath("//input[@id = 'UnitsOnOrder']"));
        private IWebElement searchReorderLevel => driver.FindElement(By.XPath("//input[@id = 'ReorderLevel']"));
        private IWebElement searchsubmit => driver.FindElement(By.XPath("//input[@type = 'submit']"));
    }
}
