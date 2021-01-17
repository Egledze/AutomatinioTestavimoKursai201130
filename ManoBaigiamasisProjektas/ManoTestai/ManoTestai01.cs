using System.Threading;
using AutoPaskaitos.ManoBaigiamasisProjektas.ManoPuslapiai;
using NUnit.Framework;


namespace AutoPaskaitos.ManoBaigiamasisProjektas.ManoTestai
{
    class ManoTestai01 : BazineManoTestu
    {
        private ManoPuslapis01 manoPuslapis01;

        [SetUp]
        public void PriesKiekvienaKlasesTesta()
        {
            manoPuslapis01 = new ManoPuslapis01(driver);
            manoPuslapis01.NueikIprisijungimoForma();
        }
        [Test]
        public void BlogasElAdresas()
        {
            manoPuslapis01.IrasykElAdresaBloga("egle");
            manoPuslapis01.IrasykSlaptazodiBloga("Pigu");
            manoPuslapis01.PaspauskPrisijungimoMygtuka();
            manoPuslapis01.PatikrinkZinutePirma();
        }

        [Test]
        public void BlogasSlaptazodis()
        {
            manoPuslapis01.IrasykElAdresaGera("egledze@gmail.com");
            manoPuslapis01.IrasykSlaptazodiBloga("Pigu");
            manoPuslapis01.PaspauskPrisijungimoMygtuka();
            manoPuslapis01.PatikrinkZinuteAntra();
        }

        [Test]
        public void Prisijungti()
        {
            manoPuslapis01.IrasykElAdresaGera("egledze@gmail.com");
            manoPuslapis01.IrasykSlaptazodiGera("Pigult2020");
            Thread.Sleep(5000);
            manoPuslapis01.PaspauskPrisijungimoMygtuka();
            Thread.Sleep(5000);
            manoPuslapis01.PatikrinkArPrisijunge();   
        }
    }
}