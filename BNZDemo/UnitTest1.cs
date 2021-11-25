using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Assert = NUnit.Framework.Assert;

namespace BNZDemo
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver Driver = new ChromeDriver();
        [TestMethod]
        public void ClickMenu()
        {

            Driver.Navigate().GoToUrl("https://www.demo.bnz.co.nz/client/");
            Thread.Sleep(5000);
            string linkMenu = "//button[contains(@class,'Button Button--transparent js-main-menu-btn MenuButton')]";
            string linkPayee = "//span[text()='Payees']//ancestor::a[contains(@class,'Button')]";
            Driver.FindElement(By.XPath(linkMenu)).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath(linkPayee)).Click();

        }
        [TestMethod]
        public void ClickPayee()
        {
            ClickMenu();
            Thread.Sleep(2000);
            string addPayee = "//span[text()='Add']//ancestor::button[contains(@class,'Button')]";
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath(addPayee)).Click();
            Thread.Sleep(2000);
            string txtboxName = "//input[@name='apm-name']";
            Driver.FindElement(By.XPath(txtboxName)).Click();
            Driver.FindElement(By.XPath(txtboxName)).SendKeys("Upinder");
            Thread.Sleep(2000);
            string newPayee = "(//span[text()='Someone new: Upinder']/ancestor::span)[1]";
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath(newPayee)).Click();
            Thread.Sleep(2000);
            string bank = "//input[@name='apm-bank']";
            Driver.FindElement(By.XPath(bank)).Click();
            Driver.FindElement(By.XPath(bank)).SendKeys("01");

            string branch = "//input[@name='apm-branch']";
            Driver.FindElement(By.XPath(branch)).Click();
            Driver.FindElement(By.XPath(branch)).SendKeys("0423");

            string account = "//input[@name='apm-account']";
            Driver.FindElement(By.XPath(account)).Click();
            Driver.FindElement(By.XPath(account)).SendKeys("1234567");

            string suffix = "//input[@name='apm-suffix']";
            Driver.FindElement(By.XPath(suffix)).Click();
            Driver.FindElement(By.XPath(suffix)).SendKeys("00");

            string statement = "//h2[text()='Statement Details']";
            Driver.FindElement(By.XPath(statement)).Click();
            Thread.Sleep(1000);
            string add = "//button[contains(@class,'js-submit Button Button--primary')]";
            Driver.FindElement(By.XPath(add)).Click();
            Thread.Sleep(4000);
            Driver.Quit();

            /*try {
                Driver.FindElement(By.XPath(" "))

            {

                Console.WriteLine("Message dislayed ");
            }

            Thread.Sleep(1000);
            Driver.Quit();
        }*/
        }

        [TestMethod]
        public void ValidateErrors()
        {
            ClickMenu();
            Thread.Sleep(2000);
            string addPayee = "//span[text()='Add']//ancestor::button[contains(@class,'Button')]";
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath(addPayee)).Click();
            Thread.Sleep(2000);

            string add = "//button[contains(@class,'js-submit Button Button--primary')]";
            Driver.FindElement(By.XPath(add)).Click();
            Thread.Sleep(2000);
            string actualerrormsg;
            string expectederrormsg = "A problem was found.Please correct the field highlighted below.";
            actualerrormsg = Driver.FindElement(By.XPath("//div[contains(@class,'error-header')]")).Text;
            Assert.AreEqual(expectederrormsg, actualerrormsg);
            Console.WriteLine("Test Passed");
            Thread.Sleep(1000);
            string txtboxName = "//input[@name='apm-name']";
            Driver.FindElement(By.XPath(txtboxName)).Click();
            Driver.FindElement(By.XPath(txtboxName)).SendKeys("Upinder");
            Thread.Sleep(2000);
            string newPayee = "(//span[text()='Someone new: Upinder']/ancestor::span)[1]";
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath(newPayee)).Click();
            Thread.Sleep(2000);
            string bank = "//input[@name='apm-bank']";
            Driver.FindElement(By.XPath(bank)).Click();
            Driver.FindElement(By.XPath(bank)).SendKeys("01");

            string branch = "//input[@name='apm-branch']";
            Driver.FindElement(By.XPath(branch)).Click();
            Driver.FindElement(By.XPath(branch)).SendKeys("0423");

            string account = "//input[@name='apm-account']";
            Driver.FindElement(By.XPath(account)).Click();
            Driver.FindElement(By.XPath(account)).SendKeys("1234567");

            string suffix = "//input[@name='apm-suffix']";
            Driver.FindElement(By.XPath(suffix)).Click();
            Driver.FindElement(By.XPath(suffix)).SendKeys("00");
            Thread.Sleep(2000);


            Driver.Quit();







        }

        [TestMethod]
        public void sort()
        {
            ClickPayee();

        }
        [TestMethod]
        public void PaymentsPage()
        {
            Driver.Navigate().GoToUrl("https://www.demo.bnz.co.nz/client/");
            Thread.Sleep(5000);
            string linkMenu = "//button[contains(@class,'Button Button--transparent js-main-menu-btn MenuButton')]";
            Driver.FindElement(By.XPath(linkMenu)).Click();
            Thread.Sleep(2000);
            string payortransfer = "//span[text()='Pay or transfer']/ancestor::button";
            Driver.FindElement(By.XPath(payortransfer)).Click();
            Thread.Sleep(1000);
            string chooseaccountfrom = "//span[text()='Choose account']/ancestor::button";
            string chooseaccountto = "//span[text()='Choose account, payee, or someone new']";
            string amount = "//input[@name='amount']";
            Driver.FindElement(By.XPath(chooseaccountfrom)).Click();
            Driver.FindElement(By.XPath(chooseaccountto)).Click();
            Driver.FindElement(By.XPath(amount)).Click();
            Driver.FindElement(By.XPath(chooseaccountto)).SendKeys("500");

            Driver.Quit();
        }       
        }

    }






     