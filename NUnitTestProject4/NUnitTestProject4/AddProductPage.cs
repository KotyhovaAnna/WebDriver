using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
namespace NUnitTestProjectSeleniumWebDriverAdvanced
{
    class AddProductPage
    {
        private IWebDriver driver;
        public AddProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement Home_page { get; private set; }
        public IWebElement CreateNew { get; private set; }
        public string CategoryId { get; private set; }
        public string SupplierId { get; private set; }
        public string UnitPrice { get; private set; }
        public string QuantityPerUnit { get; private set; }
        public string ReorderLevel { get; private set; }
        public string UnitsOnOrder { get; private set; }
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
        //public void AddNewProducts(string productProductName)
        //{
        //    searchHome_page.Click();
        //    searchCreateNew.Click();
        //    searchProductName.SendKeys(productProductName);
        //}
        public void AddNewProduct()
        {
            new Actions(driver).Click(Home_page).Build().Perform();
            new Actions(driver).Click(CreateNew).Build().Perform();
            new Actions(driver).SendKeys("морс").Build().Perform();
            new Actions(driver).SendKeys(CategoryId).Build().Perform();
            new Actions(driver).SendKeys(SupplierId).Build().Perform();
            new Actions(driver).SendKeys(UnitPrice).Build().Perform();
            new Actions(driver).SendKeys(QuantityPerUnit).Build().Perform();
            new Actions(driver).SendKeys(UnitsOnOrder).Build().Perform();
            new Actions(driver).SendKeys(ReorderLevel).Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
        }
        internal void AddNewProducts()
        {
            throw new NotImplementedException();
        }
    }
}
