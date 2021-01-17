using NUnit.Framework;
using OpenQA.Selenium;


namespace AutoPaskaitos.ManoBaigiamasisProjektas.ManoPuslapiai
{
    class ManoPuslapis01 : BazineManoPuslapiu
    {
        public ManoPuslapis01(IWebDriver driver) : base(driver) { }

        private IWebElement ElAdresoLaukas => driver.FindElement(By.Name("email"));
        private IWebElement SlaptazodzioLaukas => driver.FindElement(By.Name("password"));
        private IWebElement PrisijungimoMygtukas => driver.FindElement(By.Name("login"));
                   
        public void NueikIprisijungimoForma()
        {
            driver.Url = ("https://pigu.lt/lt/u/login");
        }
       
        public void IrasykElAdresaBloga(string IrasomasBlogasElAdresas)
        {
            ElAdresoLaukas.SendKeys(IrasomasBlogasElAdresas);
        }

        public void IrasykElAdresaGera(string IrasomasGerasElAdresas)
        {
            ElAdresoLaukas.SendKeys(IrasomasGerasElAdresas);
        }

        public void IrasykSlaptazodiBloga(string IrasomasBlogasSlaptazodis)
        {
            SlaptazodzioLaukas.SendKeys(IrasomasBlogasSlaptazodis);
        }

        public void IrasykSlaptazodiGera(string IrasomasGerasSlaptazodis)
        {
            SlaptazodzioLaukas.SendKeys(IrasomasGerasSlaptazodis);
        }

        public void PaspauskPrisijungimoMygtuka()
        {
            PrisijungimoMygtukas.Click();
        }

        public void PatikrinkZinutePirma()
        {
            Assert.AreEqual("Klaidingai įvedėte el. pašto adresą", driver.FindElement(By.CssSelector(".has-icon > .error-message")).Text);
        }
  
        public void PatikrinkZinuteAntra()
        {
            Assert.AreEqual("Neteisingas slaptažodis", driver.FindElement(By.CssSelector(".error-message:nth-child(2)")).Text);
        }

        public void PatikrinkArPrisijunge()
        {
            Assert.AreEqual("Eglė", driver.FindElement(By.CssSelector(".visitor-login .inner > .text")).Text); 
        }       
    }
}
