using Tyuiu.VasilevNV.Sprint6.Task7.V2.Lib;
namespace Tyuiu.VasilevNV.Sprint6.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = @"C:\Users\Nvasiljev\source\repos\Tyuiu.VasilevNV.Sprint6\Tyuiu.VasilevNV.Sprint6.Task7.V2\bin\Debug\InPutFileTask7V2.csv";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}