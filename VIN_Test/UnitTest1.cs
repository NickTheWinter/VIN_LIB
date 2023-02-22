namespace VIN_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckJHMCM56557C404453isCorrectVIN()
        {
            Boolean actual;
            Boolean expected = true;
            actual = VIN_LIB.Class1.CheckVIN("JHMCM56557C404453");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckJH5CD515574404453isIncorrectVIN()
        {
            Boolean actual;
            Boolean expected = false;
            actual = VIN_LIB.Class1.CheckVIN("JH5CD515574404453");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ChechJHMCM56557C404453isAsia()
        {
            String actual = "";
            String expected = "Азия";
            actual = VIN_LIB.Class1.GetVINCountry("JHMCM56557C404453");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ChechJHMCM56557C404453isCorrectAndITsAsia()
        {
            Boolean expected = true;
            Boolean actual;
            Boolean first;
            String second;
            String expectedReg = "Азия";
            Boolean answer = false;
            first = VIN_LIB.Class1.CheckVIN("JHMCM56557C404453");
            second = VIN_LIB.Class1.GetVINCountry("JHMCM56557C404453");
            if(second.Equals(expectedReg) && first)
            {
                answer = true;
            }
            Assert.AreEqual(expected, answer);
        }
    }
}