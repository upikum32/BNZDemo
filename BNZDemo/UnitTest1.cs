using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
namespace BNZDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ClickMenu()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.demo.bnz.co.nz/client/");
            string linkMenu = "//button[contains(@class,'Button Button--transparent js-main-menu-btn MenuButton')]//button[contains(@class,'Button Button--transparent js-main-menu-btn MenuButton')]";
            Driver.FindElement(By.XPath(linkMenu)).Click();
        }
        [TestMethod]
        public void ClickPayee()
        {
            IWebDriver Driver = new ChromeDriver();
            string linkPayee = "//span[contains(@class,'Language__container') and text()='Payees']/ancestor::a";
          
            Driver.FindElement(By.XPath(linkPayee)).Click();
            Driver.Quit();
        }
    }
}




     