using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutoPaskaitos.ManoBaigiamasisProjektas.ManoPuslapiai
{
    public class BazineManoPuslapiu
    {
        protected IWebDriver driver;
        public BazineManoPuslapiu(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
