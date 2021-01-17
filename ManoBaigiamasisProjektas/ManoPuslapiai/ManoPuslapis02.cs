using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace AutoPaskaitos.ManoBaigiamasisProjektas.ManoPuslapiai
{
    class ManoPuslapis02 : BazineManoPuslapiu
    {
        public ManoPuslapis02(IWebDriver driver) : base(driver) { }

        private IWebElement DezinfekciniuPriemoniuMygtukas => driver.FindElement(By.CssSelector("#department-11345 .text"));
        private IWebElement SpecApsaugosPriemoniuLangelis => driver.FindElement(By.CssSelector(".category-list-item-wrap:nth-child(2) img"));
        private IWebElement KaukiuRespiratoriuLangelis => driver.FindElement(By.CssSelector(".category-list-item-wrap:nth-child(1) img"));
        
        
        private IWebElement MygtukasSurastiJuodasKaukes => driver.FindElement(By.CssSelector("[title='Vienkartinės veido kaukės 3-jų sluoksnių juodos spalvos (50 vnt.)']"));
        private IWebElement MygtukasDetiIKrepseliJuodasKaukes => driver.FindElement(By.XPath("(//a[contains(text(),'Į krepšelį')])[4]"));
        private IWebElement MygtukasUzdarytiJuodasKaukes => driver.FindElement(By.CssSelector("#modal .close-modal"));
         
        private IWebElement MygtukasSurastiRespiratoriu => driver.FindElement(By.CssSelector("[title='Veido kaukė 4-ių sluoksnių, 2vnt']"));
        private IWebElement MygtukasDetiIKrepseliRespiratoriu => driver.FindElement(By.CssSelector("[widget-attachpoint='addToCart']")); //(By.XPath("//*[@id='productBlock31166886']/div/div/a[2]"));
        private IWebElement MygtukasUzdarytiRespiratoriu => driver.FindElement(By.Id("close"));
        
        private IWebElement MygtukasPrekiuKrepselis => driver.FindElement(By.CssSelector("#cartWidget > a > div > div > span.text"));

        
        private IWebElement LangelisSkydeliaiIrAkiniai => driver.FindElement(By.CssSelector(".category-list-item-wrap:nth-child(5) img"));
        private IWebElement LangelisApsauginisSkydelisVeidui => driver.FindElement(By.CssSelector("#productBlock30883851 > .heightResponse a > img"));
        
        private IWebElement MygtukasKlausimaiIrAtsakymai => driver.FindElement(By.Id("question_answerTab")); 
        private IWebElement MygtukasUzduotiKlausima => driver.FindElement(By.CssSelector("[widget-id='question_answer']"));
        

        private readonly string TekstasApieKlausimus = "Užduoti klausimus gali tik registruoti Pigu.lt nariai. Prašome prisijungti arba registruotis";


        //Pirmas testas:

        public void PaspauskMygtukaDezinfekcinesPriemones()
        {
            DezinfekciniuPriemoniuMygtukas.Click();
        }

        public void PaspauskLangeliSpecApsaugosPriemones()
        {
            SpecApsaugosPriemoniuLangelis.Click();
        }

        public void PaspauskLangeliKaukesRespiratoriai()
        {
            KaukiuRespiratoriuLangelis.Click();
            Thread.Sleep(5000);
        }

        public void PatikrinkArSurado()
        {
            Assert.AreEqual("Kaukės, respiratoriai", driver.FindElement(By.XPath("//h1[contains(.,'Kaukės, respiratoriai')]")).Text);
        }

        //Antras testas:

        public void IdekIKrepseliJuodasKaukes()
        {                         
            Actions builder = new Actions(driver);
            builder.MoveToElement(MygtukasSurastiJuodasKaukes).Build().Perform();
            MygtukasDetiIKrepseliJuodasKaukes.Click();
            Thread.Sleep(3000);
            MygtukasUzdarytiJuodasKaukes.Click();
            Thread.Sleep(3000);
        }      

        public void IdekIKrepseliRespiratoriu()
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(MygtukasSurastiRespiratoriu).Build().Perform();
            MygtukasSurastiRespiratoriu.Click();
            Thread.Sleep(3000);
            MygtukasDetiIKrepseliRespiratoriu.Click();
            Thread.Sleep(3000);
            MygtukasUzdarytiRespiratoriu.Click();
        }

        public void PirkPrekes()
        {
            MygtukasPrekiuKrepselis.Click();
            //driver.Url = ("https://pigu.lt/lt/cart");
        }

        public void PatikrinkArJauKrepselyje()
        {
            Thread.Sleep(4000);                      
            Assert.AreEqual("Prekių krepšelis", driver.FindElement(By.CssSelector(".current > .title")).Text);
            // Assert.AreEqual("https://pigu.lt/lt/cart", driver.Url);
        }


        //Trecias testas:
        
        public void PaspauskLangeliSkydeliaiIrAkiniai()
        {
            LangelisSkydeliaiIrAkiniai.Click();
            Thread.Sleep(3000);
        }

        public void AtverskInfoApieApsauginiSkydeli()
        {
            Thread.Sleep(2000);
            LangelisApsauginisSkydelisVeidui.Click();
                        
        }
        public void UzduokKlausima()
        {                        
            Thread.Sleep(2000);
            MygtukasKlausimaiIrAtsakymai.Click();
            Thread.Sleep(2000);
            MygtukasUzduotiKlausima.Click();
        }
        
        public void PatikrinkArGaliUzduotiKlausima()
        {
            Thread.Sleep(3000);
            Assert.AreEqual(TekstasApieKlausimus, driver.FindElement(By.CssSelector("h2:nth-child(2)")).Text);
            //Assert.AreEqual("https://pigu.lt/lt/namu-remontas/darbo-apranga/galvos-pasauga/apsauginis-skydelis-veidui?id=30883851", driver.Url);            
        }
    }
}




