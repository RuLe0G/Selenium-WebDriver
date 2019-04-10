using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Selenium_WebDriver
{
    [TestFixture]
    public class Class1
    {
        IWebDriver webDriver = new ChromeDriver();

        [TestCase]
        public void Title()
        {
            webDriver.Url = "http://express-prigorod.ru/";
            Assert.AreEqual("АО «Экспресс-пригород» — Главная", webDriver.Title);
           // webDriver.Close();
        }

    
        [TestCase]
        public void SEnabled()
        {
            webDriver.Url = "http://express-prigorod.ru/";
            IWebElement element = webDriver.FindElement(By.XPath("/html/body/div[2]/div[1]"));
            bool status = element.Enabled;
            Assert.True(status);
        }

        [TestCase]
        public void Cli()
        {
            webDriver.Url = "http://express-prigorod.ru/";
            IWebElement element = webDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[2]/div[2]/div[1]/p[1]/a"));
            element.Click();



            IWebElement element2 = webDriver.FindElement(By.XPath("/ html / body / div[2] / div[2] / div[2]"));
            bool status = element2.Displayed;

            Assert.True(status);

        }

        [TestCase]
        public void sea()
        {
            webDriver.Url = "http://express-prigorod.ru/";

              IWebElement search = webDriver.FindElement(By.XPath("//*[@id=\"dispatch\"]"));
            //IWebElement search = webDriver.FindElement(By.XPath("/ html / body / div[2] / div[2] / div[3] / div[1] / div / div[2] / form / div[1] / input[1]"));
            search.SendKeys("mail@mail.com");
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[3]/div[1]/div/div[2]/form/div[2]/input"));
            button.Click();

            IWebElement element = webDriver.FindElement(By.XPath("/ html / body / div[2] / div[2] / div[2] / div / div[2] / form / div / div[1]"));
            string text = element.Text;

            Assert.AreEqual("Не правильный e-mail или пароль", text);

        }



        [TearDown]
        public void TestEnd()
        {
          // webDriver.Quit();

        }
    }
}
