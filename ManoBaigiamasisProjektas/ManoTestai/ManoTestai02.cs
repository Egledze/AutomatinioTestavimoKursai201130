using AutoPaskaitos.ManoBaigiamasisProjektas.ManoPuslapiai;
using NUnit.Framework;


namespace AutoPaskaitos.ManoBaigiamasisProjektas.ManoTestai
{
    class ManoTestai02 : BazineManoTestu
    {
        private ManoPuslapis02 manoPuslapis02;

        [SetUp]
        public void PriesKiekvienaFolderioTesta()
        {
            manoPuslapis02 = new ManoPuslapis02(driver);
            manoPuslapis02.PaspauskMygtukaDezinfekcinesPriemones();
            manoPuslapis02.PaspauskLangeliSpecApsaugosPriemones();
        }

        [Test]
        public void SuraskPreke()
        {           
            manoPuslapis02.PaspauskLangeliKaukesRespiratoriai();            
            manoPuslapis02.PatikrinkArSurado(); 
            //https://pigu.lt/lt/apsaugos-dezinfekcines-priemones/specialios-apsaugos-priemones/kaukes-respiratoriai
        }

        [Test]
        public void SudėkIKrepseli()
        {            
            manoPuslapis02.PaspauskLangeliKaukesRespiratoriai();            
            manoPuslapis02.IdekIKrepseliJuodasKaukes();            
            manoPuslapis02.IdekIKrepseliRespiratoriu();         
            manoPuslapis02.PirkPrekes();
            manoPuslapis02.PatikrinkArJauKrepselyje();
        }
        
        [Test]
        public void UzduokKlausimaApiePreke()
        {          
            manoPuslapis02.PaspauskLangeliSkydeliaiIrAkiniai();
            manoPuslapis02.AtverskInfoApieApsauginiSkydeli();
            manoPuslapis02.UzduokKlausima();
            manoPuslapis02.PatikrinkArGaliUzduotiKlausima();                       
        }      
    }
}
