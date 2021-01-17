using AutoPaskaitos.ManoBaigiamasisProjektas.ManoPuslapiai;
using NUnit.Framework;


namespace AutoPaskaitos.ManoBaigiamasisProjektas.ManoTestai
{
    class ManoTestai03 : BazineManoTestu
    {
        private ManoPuslapis03 manoPuslapis03;

        [SetUp]
        public void PriesKiekvienaFolderioTesta()
        {            
            manoPuslapis03 = new ManoPuslapis03(driver);
            manoPuslapis03.PaspauskPrekybosCentras();
            manoPuslapis03.PaspauskSuzinotiDaugiau();
            manoPuslapis03.PasirinkParduotuvePagalRaideV();
            manoPuslapis03.PaspauskVeroKoffeeHouse();
        }      
        
        [Test]
        public void ArEsuTinkamamePuslapyje()
        {          
            manoPuslapis03.PaspauskIvertinimaiIrKomentarai();
            manoPuslapis03.PatikrinkArEsuAtsiliepimuPuslapyje();
        }

        [Test]
        public void ArIdejoPrekeINoruSarasa()
        {          
            manoPuslapis03.PaspauskPerkamiausiosPrekes();
            //manoPuslapis03.IsskleiskMeniu();//nebereikia
            manoPuslapis03.PasirinkGeriausiaiIvertintos();
            manoPuslapis03.PaspauskKavosPupelesBrazil();
            manoPuslapis03.PaspauskItrauktiINoruSarasa();
            manoPuslapis03.PatikrinkArIdejoINoruSarasa();
        }

        [Test]
        public void ArIdejoPrekeIPalyginimoLanga()
        {            
            manoPuslapis03.PaspauskKavosPupelesHola();
            manoPuslapis03.PaspauskItrauktiIPalyginima();
            manoPuslapis03.LygintiPrekes();
            manoPuslapis03.PatikrinkArEsiPalyginimoLange();                                    
        }
    }
}
