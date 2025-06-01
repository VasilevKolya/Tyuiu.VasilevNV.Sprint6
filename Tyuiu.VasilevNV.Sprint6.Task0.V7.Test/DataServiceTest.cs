using Tyuiu.VasilevNV.Sprint6.Task0.V7.Lib;
namespace Tyuiu.VasilevNV.Sprint6.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1);
            double wait = 0.014;
            Assert.AreEqual(wait, res);
        }
    }
}