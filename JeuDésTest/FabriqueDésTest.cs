using JeuDés.Dés;
using JeuDés.Dés.Concrets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JeuDésTest
{
    [TestClass]
    public class FabriqueDésTest
    {
        [TestMethod]
        public void Derait_retourner_2dés_6face_appel_fabrique()
        {
            //Given
            var fabrique = new FabriqueDés();

            //When
            var retour = fabrique.Fabrique(2, 6);

            //Then
            Assert.IsNotNull(retour);
            Assert.IsTrue(retour.Count() == 2);
            Assert.IsInstanceOfType(retour, typeof(List<Dé>));
        }
    }
}
