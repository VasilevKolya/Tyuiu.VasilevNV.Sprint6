namespace Tyuiu.VasilevNV.Sprint6.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
            [TestMethod]
            public void TestMethod1()
            {
                string resStr = "dsdsbw dsdsdsb";
                string line = "www dsdsbw dsdsdsb ww";
                string[] words = line.Split(' ');
                string res = "";

                foreach (string word in words)
                {
                    if (word.Contains("b"))
                    {
                        res += word + " ";
                    }
                }
                res = res.TrimEnd();
                Assert.AreEqual(resStr, res);
            }
        }
    }