
namespace VIN_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckVIN()
        {
            String actual = "";
            String expected = "";
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void ChechJAJTisJapan()
        {
            String actual = "";
            String expected = "Japan";
            actual = VIN_LIB.Class1.GetVINCountry("JA");
            Assert.AreEqual(actual, expected);
        }
    }
}