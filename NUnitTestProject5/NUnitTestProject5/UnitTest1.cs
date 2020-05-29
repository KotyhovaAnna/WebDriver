using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;


namespace NUnitTestProjectSeleniumWebDriverAdvanced
{

    class AddProductPage
    {
        private readonly IWebElement ProductName;
        private readonly IWebElement clickProduct;
        private IWebDriver driver;
        private readonly string element;
        private IWebElement UnitPrice;
        private IWebElement CategoryId;
        private IWebElement SupplierId;
        private IWebElement QuantityPerUnit;
        private IWebElement UnitsOnOrder;
        private IWebElement ReorderLevel;
        private IWebElement clickCreateNew;
        private IWebElement Product;
        private IWebElement ClickAll_Products;
        private IWebElement ClickProducts;
        private IWebElement ClickHome_page;

        public AddProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement Home_page { get; private set; }
        public IWebElement CreateNew { get; private set; }



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

        public IWebElement ClickProduct => clickProduct;

        public string Element => element;

        public string Element1 => element;

        //public void AddNewProducts(string productProductName)
        //{
        //    searchHome_page.Click();
        //    searchCreateNew.Click();
        //    searchProductName.SendKeys(productProductName);

        //}

        public void AddNewProduct()
        {
            new Actions(driver).Click(ClickProducts).Build().Perform();
            new Actions(driver).Click(clickCreateNew).Build().Perform();
            new Actions(driver).SendKeys(ProductName, "морс").Build().Perform();
            new Actions(driver).Click(CategoryId).SendKeys("7").Build().Perform();
            new Actions(driver).Click(SupplierId).SendKeys("10").Build().Perform();
            new Actions(driver).Click(UnitPrice).SendKeys("30,0000").Build().Perform();
            new Actions(driver).Click(QuantityPerUnit).SendKeys("95").Build().Perform();
            new Actions(driver).Click(UnitsOnOrder).SendKeys("74").Build().Perform();
            new Actions(driver).Click(ReorderLevel).SendKeys("8").Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
        }
        internal void AddNewProducts()
        {
            throw new NotImplementedException();
        }

    }
}