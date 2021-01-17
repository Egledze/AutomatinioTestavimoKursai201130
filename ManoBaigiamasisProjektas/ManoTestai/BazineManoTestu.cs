using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace AutoPaskaitos.ManoBaigiamasisProjektas.ManoTestai
{
    class BazineManoTestu
    {
        public IWebDriver driver;

        [SetUp]
        public void PriesKiekvienaTesta()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://pigu.lt/";            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);           
        }
        
        [TearDown]
        public void PoKiekvienoTesto()
        {
            driver.Quit();
        }
        
    }
}
