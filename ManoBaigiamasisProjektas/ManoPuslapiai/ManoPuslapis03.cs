using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;


namespace AutoPaskaitos.ManoBaigiamasisProjektas.ManoPuslapiai
{
    class ManoPuslapis03 : BazineManoPuslapiu
    {
        public ManoPuslapis03(IWebDriver driver) : base(driver) { }

        private IWebElement MygtukasPrekybosCentras => driver.FindElement(By.CssSelector("li:nth-child(2) > .grey-ab-main-menu"));
        private IWebElement MygtukasSuzinotiDaugiau => driver.FindElement(By.XPath("//div[@id='731block']/div/div/a/div/div/div"));
        private IWebElement VeroKoffeeHouseLangelis => driver.FindElement(By.CssSelector(".category-list-item-wrap:nth-child(4) img"));
      
        private IWebElement IvertinimaiIrKomentarai => driver.FindElement(By.CssSelector(".nav > li:nth-child(2) > a"));

        private readonly String Tekstas = "Klientų atsiliepimai apie pardavėjo VERO COFFEE HOUSE prekes";

        private IWebElement LangelisPerkamiausiosPrekes => driver.FindElement(By.CssSelector(".select-target > b"));
        private IWebElement PaskrolinkZemyn => driver.FindElement(By.CssSelector(""));
        

        private IWebElement MygtukasGeriausiaiIvertintos => driver.FindElement(By.CssSelector("[data-value='rs']"));
        private IWebElement PaveiksliukasKavosPupelesBrazil => driver.FindElement(By.CssSelector("#productBlock29554500 > div > div > div:nth-child(3) > a > img"));
        private IWebElement MygtukasItrauktiINoruSarasa => driver.FindElement(By.CssSelector("#productPage > section:nth-child(3) > div.site-block > div.clearfix.detailed-product-top > div.product-info-options > div.add-product-box.sticked > div.mt10 > div.more-btns.fl.one-row-buttons > div:nth-child(1) > div > a > span"));
       
      
        private IWebElement PaveiksliukasKavosPupelesHola => driver.FindElement(By.CssSelector("#productBlock32731201 > .heightResponse a > img"));
        private IWebElement MygtukasItrauktiIPalyginima => driver.FindElement(By.CssSelector(".col-1-of-2 > .btn > span"));
        private IWebElement LangelisLygintiPrekes => driver.FindElement(By.CssSelector("#compare > i:nth-child(2)")); 

        //Pirmas testas:

        public void PaspauskPrekybosCentras()
        {
            MygtukasPrekybosCentras.Click();
        }

        public void PaspauskSuzinotiDaugiau()
        {
            MygtukasSuzinotiDaugiau.Click();
        }

        public void PasirinkParduotuvePagalRaideV()
        {
            driver.Url = ("https://pigu.lt/lt/parduotuves/v");
        }

        public void PaspauskVeroKoffeeHouse()
        {
            VeroKoffeeHouseLangelis.Click();
        }

        public void PaspauskIvertinimaiIrKomentarai()
        {
            IvertinimaiIrKomentarai.Click();
        }

        public void PatikrinkArEsuAtsiliepimuPuslapyje()
        {
             Assert.AreEqual(Tekstas, driver.FindElement(By.XPath("//div[@id='ratingJump']/h1")).Text);
            // Assert.AreEqual("https://pigu.lt/lt/parduotuve/vero-coffee-house/atsiliepimai", driver.Url);
        }


        //Antras testas:

        public void PaspauskPerkamiausiosPrekes()
        {
            LangelisPerkamiausiosPrekes.Click();
        }
        
        public void IsskleiskMeniu() 
        {
            Thread.Sleep(3000); 
            PaskrolinkZemyn.Click();
        } 

        public void PasirinkGeriausiaiIvertintos()
        {
            //Thread.Sleep(1000); 
            MygtukasGeriausiaiIvertintos.Click();
        }
        public void PaspauskKavosPupelesBrazil()
        {
            Thread.Sleep(2000); 
            PaveiksliukasKavosPupelesBrazil.Click();
        }
        public void PaspauskItrauktiINoruSarasa()
        {
            Thread.Sleep(3000); 
            MygtukasItrauktiINoruSarasa.Click();
        }

        public void PatikrinkArIdejoINoruSarasa()
        {
            Thread.Sleep(3000);
            Assert.AreEqual("https://pigu.lt/lt/u/login", driver.Url);
            //Assert.AreEqual("Prisijungti", driver.FindElement(By.Name("login")).Text);
        }

        //Trecias testas:

        public void PaspauskKavosPupelesHola()
        {
            Thread.Sleep(2000);
            PaveiksliukasKavosPupelesHola.Click();
        }
        public void PaspauskItrauktiIPalyginima()
        {
            MygtukasItrauktiIPalyginima.Click();
        }
        public void LygintiPrekes()
        {
            LangelisLygintiPrekes.Click();
        }
        public void PatikrinkArEsiPalyginimoLange()
        {
            Thread.Sleep(3000);
            Assert.AreEqual("https://pigu.lt/lt/products/compare/index/2831", driver.Url);
            //Assert.AreEqual("Palyginkite prekes", driver.FindElement(By.CssSelector(".page-title")).Text);
        }





        /*
        public void IrasykElAdresaGera("egledze@gmail.com")
        {

        }
        public void IrasykSlaptazodiGera("Pigult2020")
        {
            Thread.Sleep(5000);
        }
            
        public void PaspauskPrisijungimoMygtuka()
        {
            Thread.Sleep(5000);
        }
            

            public void PatikrinkArPrisijunge()
        {

        }
        */


    }

}

